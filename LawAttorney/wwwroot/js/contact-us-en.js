document.getElementById('contactForm').addEventListener('submit', function (event) {
    var recaptchaResponse = grecaptcha.getResponse();

    if (!recaptchaResponse) {
        event.preventDefault();
        alert('Please complete the reCAPTCHA.');
    } else {
        // Show success message
        alert('Success! Form submitted.');

        document.getElementById('contactForm').reset();
    }
});
