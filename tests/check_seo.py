from urllib.request import urlopen
from urllib.parse import urlsplit
from html.parser import HTMLParser
import xml.etree.ElementTree as ET
import sys
base = sys.argv[1].rstrip('/') if len(sys.argv) > 1 else 'http://localhost:5081'
class Head(HTMLParser):
 def __init__(self): super().__init__(); self.links=[]; self.meta=[]
 def handle_starttag(self,tag,attrs):
  if tag=='link': self.links.append(dict(attrs))
  if tag=='meta': self.meta.append(dict(attrs))
def get(path):
 with urlopen(base+path) as r: return r.read().decode('utf-8-sig'),r.headers.get_content_type()
origin='https://ozpartnershukuk.com'
xml,kind=get('/sitemap.xml'); assert kind=='application/xml'
root=ET.fromstring(xml); ns={'s':'http://www.sitemaps.org/schemas/sitemap/0.9'}
urls=[x.text for x in root.findall('s:url/s:loc',ns)]
assert len(urls)==24 and len(set(urls))==24
pages={}
for url in urls:
 assert url.startswith(origin+'/') and '/ru/' not in url
 html,_=get(urlsplit(url).path); h=Head();h.feed(html)
 canonical=[x['href'] for x in h.links if x.get('rel')=='canonical']; assert canonical==[url],url
 alternate={x['hreflang']:x['href'] for x in h.links if x.get('rel')=='alternate' and 'hreflang' in x}
 assert set(alternate)=={'tr','en','x-default'},url
 assert all(x in urls for x in alternate.values()),url
 assert alternate['x-default']==alternate['tr']
 assert alternate['en' if '/en/' in url else 'tr']==url
 assert [x['content'] for x in h.meta if x.get('property')=='og:url']==[url]
 assert [x['content'] for x in h.meta if x.get('name')=='robots']==['index, follow']
 pages[url]=alternate
for url,alt in pages.items():
 assert pages[alt['tr']]==alt and pages[alt['en']]==alt,url
for path,expected in [('/', '/Anasayfa'),('/Home/Anasayfa?utm_source=test','/Anasayfa'),('/tr/Ekibimiz','/Ekibimiz'),('/Home/Article7?ref=test','/en/Article7'),('/en/Article7/','/en/Article7')]:
 html,_=get(path);h=Head();h.feed(html);assert [x['href'] for x in h.links if x.get('rel')=='canonical']==[origin+expected],path
robots,kind=get('/robots.txt');assert kind=='text/plain' and 'Sitemap: '+origin+'/sitemap.xml' in robots
assert 'Disallow: /' not in robots
print('PASS: 24 sitemap URLs, self-canonicals, reciprocal language tags, Open Graph URLs, 5 URL aliases and robots.txt.')

