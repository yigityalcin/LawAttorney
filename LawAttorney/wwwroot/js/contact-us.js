document.addEventListener('DOMContentLoaded', function () {
    const form = document.getElementById('contactForm');
    const result = document.getElementById('form-result');
    if (!form || !result) return;
    const tr = document.documentElement.lang === 'tr';
    const messages = tr ? {
        captcha: 'Lütfen güvenlik doğrulamasını tamamlayın. Doğrulama görünmüyorsa sayfayı yenileyin.',
        pending: 'Mesajınız gönderiliyor…', success: 'Mesajınız başarıyla gönderildi.',
        error: 'Mesaj gönderilemedi. Lütfen yeniden deneyin veya e-posta ile bize ulaşın.'
    } : {
        captcha: 'Please complete the security check. If it is unavailable, reload the page.',
        pending: 'Sending your message…', success: 'Your message has been sent successfully.',
        error: 'Your message could not be sent. Please try again or contact us by email.'
    };
    let sending = false;
    const button = form.querySelector('[type="submit"]');
    function show(message, kind) {
        result.textContent = message;
        result.classList.remove('notice--success', 'notice--warning', 'notice--danger');
        if (kind) result.classList.add('notice--' + kind);
    }
    form.addEventListener('submit', async function (event) {
        event.preventDefault();
        if (sending) return;
        const captcha = form.querySelector('[name="h-captcha-response"]');
        if (!captcha || !captcha.value.trim()) {
            show(messages.captcha, 'warning');
            return;
        }
        sending = true;
        button.disabled = true;
        form.setAttribute('aria-busy', 'true');
        show(messages.pending);
        try {
            const response = await fetch('https://api.web3forms.com/submit', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json', 'Accept': 'application/json' },
                body: JSON.stringify(Object.fromEntries(new FormData(form)))
            });
            const payload = await response.json();
            if (!response.ok || payload.success !== true) throw new Error('Submission failed');
            form.reset();
            show(messages.success, 'success');
        } catch {
            show(messages.error, 'danger');
        } finally {
            sending = false;
            button.disabled = false;
            form.removeAttribute('aria-busy');
            if (window.hcaptcha && typeof window.hcaptcha.reset === 'function') window.hcaptcha.reset();
        }
    });
});
