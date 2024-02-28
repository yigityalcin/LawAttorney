document.addEventListener('DOMContentLoaded', function () {
    const form = document.getElementById('contactForm');
    const result = document.getElementById('form-result');

    // on submit, POST to web3Forms and get response
    form.addEventListener('submit', function (e) {
        e.preventDefault();

        const formData = new FormData(form);
        const object = {};

        formData.forEach(function (value, key) {
            object[key] = value;
        });

        const json = JSON.stringify(object);

        result.innerHTML = "Please wait...";

        // fetch result
        fetch('https://api.web3forms.com/submit', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json'
            },
            body: json
        })
            .then(async (response) => { // show response
                let jsonResponse = await response.json();
                console.log(jsonResponse);

                if (response.status == 200) {
                    result.innerHTML = jsonResponse.message;
                    result.classList.add("notice--success");
                } else {
                    console.log(response);
                    result.innerHTML = jsonResponse.message;
                    result.classList.add("notice--warning");
                }
            })
            .catch(error => { // show error
                console.log(error);
                result.innerHTML = "Something went wrong!";
                result.classList.add("notice--danger");
            })
        then(function () { // reset form
            form.reset();
            // make response disappear after 6 seconds if you wish
            setTimeout(() => {
                result.style.display = "none";
            }, 6000);
        });
    });
    
});