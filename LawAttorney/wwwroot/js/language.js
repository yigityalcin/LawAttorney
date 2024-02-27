//document.addEventListener('DOMContentLoaded', function () {
//    var languageDropdown = document.getElementById('languageDropdown');

//    // Önceki dil seçeneğini al
//    var selectedLanguage = localStorage.getItem('selectedLanguage');

//    // Eğer önceki bir dil seçilmişse, onu aktif hale getir
//    if (selectedLanguage) {
//        var activeLanguageElement = languageDropdown.querySelector('.dropdown-toggle');
//        if (activeLanguageElement) {
//            activeLanguageElement.innerHTML = selectedLanguage;
//        }
//    }

//    // Dil seçeneği tıklandığında
//    languageDropdown.addEventListener('click', function (event) {
//        if (event.target.classList.contains('dropdown-item')) {
//            // Seçilen dilin önceki aktif durumunu kaldır
//            var previousActiveLanguage = this.querySelector('.dropdown-toggle');
//            if (previousActiveLanguage) {
//                previousActiveLanguage.innerHTML = event.target.textContent;
//            }

//            // Seçilen dil öğesine aktif durumu ekle
//            var selectedLanguageElement = event.target;
//            // Seçilen dil değerini al
//            var selectedLanguage = selectedLanguageElement.getAttribute('data-lang');
//            // Set the selected language in the dropdown toggle
//            this.querySelector('.dropdown-toggle').innerHTML = selectedLanguage;
//            // Set the selected language in localStorage
//            localStorage.setItem('selectedLanguage', selectedLanguage);
//        }
//    });
//});