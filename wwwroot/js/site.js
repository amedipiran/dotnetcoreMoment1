// Hitta den aktiva länken baserat på sidans URL
var currentPage = window.location.pathname;
var navLinks = document.querySelectorAll('.nav-link');

// Loopa genom navigationslänkarna och kontrollera om de matchar den aktiva sidan
navLinks.forEach(function(link) {
    if (link.getAttribute('href') === currentPage) {
        // Ändra dekoration för aktiva länken
        link.style.textDecoration = 'underline';
    }
});
