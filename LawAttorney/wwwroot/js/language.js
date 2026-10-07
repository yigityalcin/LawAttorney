// Preserve the matching page and current origin when switching languages.
function navigateLink(targetLanguage) {
    const pages = {
        tr: ['Anasayfa', 'CalismaAlanlarimiz', 'Ekibimiz', 'iletisim', 'Kurumsal', 'Makale1', 'Makale5', 'Makale6', 'Makale7', 'Makale8', 'Makale9', 'Makaleler'],
        en: ['HomePage', 'PracticeAreas', 'OurTeam', 'Contact', 'Corporate', 'Article1', 'Article5', 'Article6', 'Article7', 'Article8', 'Article9', 'Articles']
    };
    if (!Object.prototype.hasOwnProperty.call(pages, targetLanguage)) return;
    const segments = window.location.pathname.split('/').filter(Boolean);
    const currentPage = (segments[segments.length - 1] || 'Anasayfa').toLowerCase();
    let index = pages.tr.findIndex(page => page.toLowerCase() === currentPage);
    if (index < 0) index = pages.en.findIndex(page => page.toLowerCase() === currentPage);
    if (index < 0) index = 0;
    const prefix = targetLanguage === 'en' ? '/en/' : '/';
    window.location.href = prefix + pages[targetLanguage][index] + window.location.search + window.location.hash;
}
