document.addEventListener('DOMContentLoaded', function () {
    const path = window.location.pathname.replace(/\/$/, '').toLowerCase();
    const action = path.split('/').pop();
    const section = /^makale\d+$/.test(action) ? '/makaleler'
        : /^article\d+$/.test(action) ? '/en/articles'
        : (!path || action === 'index') ? '/anasayfa' : path;
    document.querySelectorAll('.navbar-nav .nav-item > a.nav-link').forEach(function (link) {
        const target = new URL(link.href, window.location.origin).pathname.toLowerCase();
        if (section === target || section.endsWith('/home' + target)) {
            link.setAttribute('aria-current', section === path || !path ? 'page' : 'true');
        }
    });
});
