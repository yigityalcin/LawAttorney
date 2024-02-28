document.getElementById('contactFormRu').addEventListener('submit', function (event) {
    var recaptchaResponse = grecaptcha.getResponse();

    if (!recaptchaResponse) {
        event.preventDefault();
        alert('Пожалуйста, завершите проверку reCAPTCHA.');
    } else {
        // Показать сообщение об успешной отправке
        alert('Ваше сообщение успешно отправлено.');

        // Опционально, можно сбросить форму после отправки
        document.getElementById('contactFormRu').reset();
    }
});
