using System.Xml.Linq;

namespace LawAttorney.Models;

public sealed record SeoPagePair(string TurkishPath, string EnglishPath);
public sealed record SeoPageMetadata(string CanonicalUrl, string TurkishUrl, string EnglishUrl);

public static class SeoPages
{
    // The live www host redirects to this origin. Never derive SEO URLs from request headers.
    public const string Origin = "https://ozpartnershukuk.com";
    public static IReadOnlyList<SeoPagePair> Pages { get; } = Array.AsReadOnly(new[]
    {
        new SeoPagePair("/Anasayfa", "/en/HomePage"),
        new SeoPagePair("/Kurumsal", "/en/Corporate"),
        new SeoPagePair("/Ekibimiz", "/en/OurTeam"),
        new SeoPagePair("/CalismaAlanlarimiz", "/en/PracticeAreas"),
        new SeoPagePair("/Makaleler", "/en/Articles"),
        new SeoPagePair("/iletisim", "/en/Contact"),
        new SeoPagePair("/Makale1", "/en/Article1"),
        new SeoPagePair("/Makale5", "/en/Article5"),
        new SeoPagePair("/Makale6", "/en/Article6"),
        new SeoPagePair("/Makale7", "/en/Article7"),
        new SeoPagePair("/Makale8", "/en/Article8"),
        new SeoPagePair("/Makale9", "/en/Article9")
    });

    public static SeoPageMetadata? Resolve(string? action)
    {
        foreach (var page in Pages)
        {
            var turkish = page.TurkishPath.TrimStart('/');
            var english = page.EnglishPath.Split('/').Last();
            if (string.Equals(action, turkish, StringComparison.OrdinalIgnoreCase))
                return new(Origin + page.TurkishPath, Origin + page.TurkishPath, Origin + page.EnglishPath);
            if (string.Equals(action, english, StringComparison.OrdinalIgnoreCase))
                return new(Origin + page.EnglishPath, Origin + page.TurkishPath, Origin + page.EnglishPath);
        }
        return null;
    }

    public static string Sitemap()
    {
        XNamespace ns = "http://www.sitemaps.org/schemas/sitemap/0.9";
        var urls = Pages.SelectMany(page => new[] { page.TurkishPath, page.EnglishPath });
        return "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n" +
            new XElement(ns + "urlset", urls.Select(path => new XElement(ns + "url", new XElement(ns + "loc", Origin + path))));
    }
}
