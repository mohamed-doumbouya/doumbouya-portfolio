// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener('DOMContentLoaded', function () {
    const sections = document.querySelectorAll('section[id]');
    const navLinks = document.querySelectorAll('.navmenu a[href^="#"]:not([href="#"])');

    // Fonction pour mettre à jour l'URL avec l'ancre (pour le Tag Helper)
    function updateUrlWithAnchor(anchorId) {
        const url = new URL(window.location);
        if (anchorId) {
            url.searchParams.set('anchor', anchorId);
        } else {
            url.searchParams.delete('anchor');
        }
        window.history.replaceState({}, '', url);
    }

    function updateActiveSection() {
        let currentSection = '';

        sections.forEach(section => {
            const sectionTop = section.offsetTop;
            const sectionHeight = section.clientHeight;

            if (window.scrollY >= (sectionTop - 300)) {
                currentSection = section.getAttribute('id');
            }
        });

        if (currentSection) {
            updateUrlWithAnchor(currentSection);

            // Mettre à jour les classes actives via le Tag Helper
            navLinks.forEach(link => {
                const href = link.getAttribute('href');
                if (href === `#${currentSection}`) {
                    link.classList.add('active');
                } else {
                    link.classList.remove('active');
                }
            });
        }
    }

    if (window.location.hash) {
        const targetSection = document.querySelector(window.location.hash);
        if (targetSection) {
            setTimeout(() => {
                targetSection.scrollIntoView({ behavior: 'smooth' });
            }, 100);
        }
    }

    window.addEventListener('scroll', updateActiveSection);
    updateActiveSection();
});
