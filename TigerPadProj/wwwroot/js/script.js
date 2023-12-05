document.addEventListener("DOMContentLoaded", function () {
    var profileModal = document.getElementById('profileModal');
    var leftProfile = document.querySelector('.left-profile');
    var closeModalButton = document.getElementsByClassName('cancel-btn')[0];

    leftProfile.addEventListener('click', function () {
        profileModal.style.display = 'block';
    });

    closeModalButton.addEventListener('click', function () {
        profileModal.style.display = 'none';
    });

    window.addEventListener('click', function (event) {
        if (event.target === profileModal) {
            profileModal.style.display = 'none';
        }
    });
});

document.addEventListener("DOMContentLoaded", function () {
    var createModal = document.getElementById('createModal');
    var leftButton = document.querySelector('.left-button');
    var closeModalButton = document.getElementById('closeModalButton');

    leftButton.addEventListener('click', function () {
        createModal.style.display = 'block';
    });

    closeModalButton.addEventListener('click', function () {
        createModal.style.display = 'none';
    });

    window.addEventListener('click', function (event) {
        if (event.target === createModal) {
            createModal.style.display = 'none';
        }
    });
});



