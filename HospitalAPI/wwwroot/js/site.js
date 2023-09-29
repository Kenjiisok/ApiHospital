// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// feedback.js

var stars = document.querySelectorAll('.star');
stars.forEach(function (star) {
    star.addEventListener('mouseover', function () {
        var rating = star.getAttribute('data-rating');
        highlightStars(rating);
    });

    star.addEventListener('mouseout', function () {
        var currentRating = document.getElementById('avaliacao').value;
        highlightStars(currentRating);
    });

    star.addEventListener('click', function () {
        var rating = star.getAttribute('data-rating');
        document.getElementById('avaliacao').value = rating;
    });
});

function highlightStars(rating) {
    stars.forEach(function (star) {
        var starRating = star.getAttribute('data-rating');
        if (starRating <= rating) {
            star.classList.add('highlighted'); // Adicione a classe 'highlighted'
        } else {
            star.classList.remove('highlighted'); // Remova a classe 'highlighted'
        }
    });
}
