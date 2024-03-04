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

function navigateLink(targetLangValue) {
    const pathName = window.location.pathname;
    var currentLang = "";
    var targetPath = "";
    const langMatrix = {
        'tr': ['Anasayfa', 'CalismaAlanlarimiz', 'Ekibimiz', 'iletisim', 'Kurumsal', 'Makale1', 'Makale5', 'Makale6', 'Makale7', 'Makale8', 'Makale9', 'Makaleler'],
        'en': ['HomePage', 'PracticeAreas', 'OurTeam', 'Contact', 'Corporate', 'Article1', 'Article5', 'Article6', 'Article7', 'Article8', 'Article9', 'Articles'],
        'ru': ['HomePageRu', 'PracticeAreasRu', 'OurTeamRu', 'ContactRu', 'CorporateRu', 'Article1Ru', 'Article5Ru', 'Article6Ru', 'Article7Ru', 'Article8Ru', 'Article9Ru', 'ArticlesRu'],
    };
    if (pathName.includes("/")) {
        targetPath = pathName.replace("/", "");
        currentLang = "tr";
    };
    if (pathName.includes("/en/")) {
        targetPath = pathName.replace("/en/", "");
        currentLang = "en";
    }
    if (pathName.includes("/ru/")) {
        targetPath = pathName.replace("/ru/", "");
        currentLang = "ru";
    }
    

    var index = langMatrix[currentLang].indexOf(targetPath);

    
    var targetPage = langMatrix[targetLangValue][index];

    if (targetLangValue == "tr") {
        if (index == -1) {
            window.location.href = "https://localhost:44332/" + targetLangValue + "/Anasayfa";
            return;
        }
        window.location.href = "https://localhost:44332/" + targetPage;
    }
    if (targetLangValue == "en") {
        if (index == -1) {
            window.location.href = "https://localhost:44332/" + targetLangValue + "/HomePage";
        }
        window.location.href = "https://localhost:44332/" + "en/" + targetPage;
    }
    if (targetLangValue == "ru") {
        if (index == -1) {
            window.location.href = "https://localhost:44332/" + targetLangValue + "/HomePageRu";
        }
        window.location.href = "https://localhost:44332/"+"ru/" + targetPage;
    }

    
}