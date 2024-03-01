// Dil seçildiğinde çağrılacak fonksiyon
function changeLanguage(lang, text) {
    // languageText elementini güncelle
    document.getElementById('languageText').innerText = text;

    // Her bir linkin href özelliğini güncelle
    var links = document.querySelectorAll('.lang-select .dropdown-item');
    links.forEach(function (link) {
        var dataLang = link.getAttribute('data-lang');
        if (dataLang === lang) {
            link.classList.add('selected'); // Opsiyonel: Seçilen dili vurgulamak için bir class ekleyebilirsiniz.
        } else {
            link.classList.remove('selected');
        }
    });
}