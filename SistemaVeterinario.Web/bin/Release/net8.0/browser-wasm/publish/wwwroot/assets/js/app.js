
try {
    // Dropdown stop
    var dropdownMenus = document.querySelectorAll('.dropdown-menu.stop');
    dropdownMenus.forEach(function (dropdownMenu) {
        dropdownMenu.addEventListener('click', function (event) {
            event.stopPropagation();
        });
    });
} catch (err) {
}

try {
    // Icon
    lucide.createIcons();
} catch (err) { }


try {
    // TopBar Light Dark
    var themeColorToggle = document.getElementById('light-dark-mode');
    if (themeColorToggle) {
        themeColorToggle.addEventListener('click', function (e) {
            var currentTheme = document.documentElement.getAttribute('data-bs-theme');
            if (currentTheme === 'light') {
                document.documentElement.setAttribute('data-bs-theme', 'dark');
            } else {
                document.documentElement.setAttribute('data-bs-theme', 'light');
            }
        });
    }
} catch (err) { }

try {

    //collapsed
    var collapsedToggle = document.querySelector(".mobile-menu-btn");
    const sidebarOverlay = document.querySelector('.startbar-overlay');
    collapsedToggle?.addEventListener('click', function () {

        var sidebarSize = document.body.getAttribute("data-sidebar-size");

        if (sidebarSize == "collapsed") {
            document.body.setAttribute("data-sidebar-size", "default")

        } else {
            document.body.setAttribute("data-sidebar-size", "collapsed")
        }

    });

    if (sidebarOverlay) {
        sidebarOverlay.addEventListener('click', () => {
            document.body.setAttribute("data-sidebar-size", "collapsed")
        })
    }

    const changeSidebarSize = () => {
        if (window.innerWidth >= 310 && window.innerWidth <= 1440) {
            document.body.setAttribute("data-sidebar-size", "collapsed")
        } else {
            document.body.setAttribute("data-sidebar-size", "default")
        }
    }

    window.addEventListener('resize', () => {
        changeSidebarSize()
    })

    changeSidebarSize();

} catch (err) {
}

try {
    const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]')
    const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl))

    var popoverTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="popover"]'))
    var popoverList = popoverTriggerList.map(function (popoverTriggerEl) {
        return new bootstrap.Popover(popoverTriggerEl)
    });
} catch (err) {
}


try {


    changeSidebarSize();

    // Add event listener for window resize
    window.addEventListener('resize', changeSidebarSize);

    window.addEventListener('resize', () => {
        changeSidebarSize()
    })

    changeSidebarSize();

} catch (err) {
}


/*********************/
/*   Menu Sticky     */

/*********************/
function windowScroll() {
    const navbar = document.getElementById("topbar-custom");
    if (navbar != null) {
        if (
            document.body.scrollTop >= 50 ||
            document.documentElement.scrollTop >= 50
        ) {
            navbar.classList.add("nav-sticky");
        } else {
            navbar.classList.remove("nav-sticky");
        }
    }
}

window.addEventListener('scroll', (ev) => {
    ev.preventDefault();
    windowScroll();
})


function initVerticalMenu ()  {
    const navCollapse = document.querySelectorAll('.navbar-nav li .collapse');
    const navToggle = document.querySelectorAll(".navbar-nav li [data-bs-toggle='collapse']");

    console.log("nav colapse: ");
    console.log(navCollapse);

    console.log("nav toggle: ");
    console.log(navToggle);
    navToggle.forEach(toggle => {
        toggle.addEventListener('click', function (e) {
            e.preventDefault();
            console.log(navCollapse);
        });
    });

    // open one menu at a time only (Auto Close Menu)
    navCollapse.forEach(collapse => {
        collapse.addEventListener('show.bs.collapse', function (event) {
            const parent = event.target.closest('.collapse.show');
            console.log(parent);
            document.querySelectorAll('.navbar-nav .collapse.show').forEach(element => {
                if (element !== event.target && element !== parent) {
                    const collapseInstance = new bootstrap.Collapse(element);
                    collapseInstance.hide();
                }
            });
        });
    });

    if (document.querySelector(".navbar-nav")) {
        // Activate the menu in left side bar based on url
        document.querySelectorAll(".navbar-nav a").forEach(function (link) {
            var pageUrl = window.location.href.split(/[?#]/)[0];

            if (link.href === pageUrl) {
                link.classList.add("active");
                link.parentNode.classList.add("active");

                let parentCollapseDiv = link.closest(".collapse");
                console.log("-->"+parentparentCollapseDiv)
                while (parentCollapseDiv) {
                    parentCollapseDiv.classList.add("show");
                    parentCollapseDiv.parentElement.children[0].classList.add("active");
                    parentCollapseDiv.parentElement.children[0].setAttribute("aria-expanded", "true");
                    parentCollapseDiv = parentCollapseDiv.parentElement.closest(".collapse");
                }
            }
        });

        setTimeout(function () {
            var activatedItem = document.querySelector('.nav-item li a.active');

            if (activatedItem != null) {
                var simplebarContent = document.querySelector('.main-nav .simplebar-content-wrapper');
                var offset = activatedItem.offsetTop - 300;
                if (simplebarContent && offset > 100) {
                    scrollTo(simplebarContent, offset, 600);
                }
            }
        }, 200);

        // scrollTo (Left Side Bar Active Menu)
        function easeInOutQuad(t, b, c, d) {
            t /= d / 2;
            if (t < 1) return c / 2 * t * t + b;
            t--;
            return -c / 2 * (t * (t - 2) - 1) + b;
        }

        function scrollTo(element, to, duration) {
            var start = element.scrollTop, change = to - start, currentTime = 0, increment = 20;
            var animateScroll = function () {
                currentTime += increment;
                var val = easeInOutQuad(currentTime, start, change, duration);
                element.scrollTop = val;
                if (currentTime < duration) {
                    setTimeout(animateScroll, increment);
                }
            };
            animateScroll();
        }

        console.log("pasa por la funcion");
    }
}

window.initVerticalMenu = initVerticalMenu;

function prueba() {
    console.log("Inicializando menú vertical...");
    document.querySelectorAll(".navbar-nav a").forEach(function (link) {
        var pageUrl = window.location.href.split(/[?#]/)[0];
        console.log(pageUrl);
        if (link.href === pageUrl) {
            link.classList.add("active");
            link.parentNode.classList.add("active");

            let parentCollapseDiv = link.closest(".collapse");
            while (parentCollapseDiv) {
                parentCollapseDiv.classList.add("show");
                parentCollapseDiv.parentElement.children[0].classList.add("active");
                parentCollapseDiv.parentElement.children[0].setAttribute("aria-expanded", "true");
                parentCollapseDiv = parentCollapseDiv.parentElement.closest(".collapse");
            }
        }
    });

    setTimeout(function () {
        var activatedItem = document.querySelector('.nav-item li a.active');

        if (activatedItem != null) {
            var simplebarContent = document.querySelector('.main-nav .simplebar-content-wrapper');
            var offset = activatedItem.offsetTop - 300;
            if (simplebarContent && offset > 100) {
                scrollTo(simplebarContent, offset, 600);
            }
        }
    }, 200);

    // scrollTo (Left Side Bar Active Menu)
    function easeInOutQuad(t, b, c, d) {
        t /= d / 2;
        if (t < 1) return c / 2 * t * t + b;
        t--;
        return -c / 2 * (t * (t - 2) - 1) + b;
    }

    function scrollTo(element, to, duration) {
        var start = element.scrollTop, change = to - start, currentTime = 0, increment = 20;
        var animateScroll = function () {
            currentTime += increment;
            var val = easeInOutQuad(currentTime, start, change, duration);
            element.scrollTop = val;
            if (currentTime < duration) {
                setTimeout(animateScroll, increment);
            }
        };
        animateScroll();
    }
}

// Registrar la función en el objeto global
window.prueba = prueba;


function CambiarAtributoBody() {
    console.log("cambiar atributo body");
    var sidebarSize = document.body.getAttribute("data-sidebar-size");

    if (sidebarSize == "collapsed") {
        document.body.setAttribute("data-sidebar-size", "default")

    } else {
        document.body.setAttribute("data-sidebar-size", "collapsed")
    }
}

window.CambiarAtributoBody = CambiarAtributoBody;

function CambiarModoPantalla() {
    console.log("cambiar modo pantalla");
    var themeColorToggle = document.getElementById('light-dark-mode');
    if (themeColorToggle) {
       
        var currentTheme = document.documentElement.getAttribute('data-bs-theme');
        if (currentTheme === 'light') {
            document.documentElement.setAttribute('data-bs-theme', 'dark');
        } else {
            document.documentElement.setAttribute('data-bs-theme', 'light');
        }
        
    }
}
window.CambiarModoPantalla = CambiarModoPantalla;
// Validar que está registrada correctamente
console.log("prueba disponible en window:", typeof window.prueba);

function showAlertSuccessLogin() {
    Swal.fire({
        title: 'Bienvenido',
        text: 'Inicio de sesion exitoso',
        icon: 'success'
    });
}
window.showAlertSuccessLogin = showAlertSuccessLogin;
console.log(" showAlertSuccessLogin disponible en window:", typeof window.showAlertSuccessLogin);

function showAlertErrorLogin() {
    Swal.fire({
        title: 'Error',
        text: 'Usuario y Contraseña Invalido',
        icon: 'error'
    });
}
window.showAlertErrorLogin = showAlertErrorLogin;

function showAlertErrorRut() {
    Swal.fire({
        title: 'Error',
        text: 'Rut erroneo',
        icon: 'error'
    });
}
window.showAlertErrorRut = showAlertErrorRut;

function showMessageOk() {
    Swal.fire({
        title: 'Success',
        text: "Registrado Correctamente",
        icon: 'success'
    });
}
window.showMessageOk = showMessageOk;


window.mostrarAlertaError = function (mensaje) {
    Swal.fire({
        title: 'Error',
        text: mensaje,
        icon: 'error'
    });
}

window.mostrarAlerta = function (mensaje, tipo, icono) {
    Swal.fire({
        title: tipo,
        text: mensaje,
        icon: icono
    });
}

function seleccionarTabMascota() {
    // 1. Obtener todos los nav-links
    tabId = "paciente";
    const links = document.querySelectorAll('.nav-link');
    const panes = document.querySelectorAll('.tab-pane');

    links.forEach(link => {
        link.classList.remove('active');
        link.setAttribute('aria-selected', 'false');
    });

    panes.forEach(pane => {
        pane.classList.remove('active');
        pane.classList.remove('show'); // Opcional: si estás usando fade
    });

    // 2. Activar el nav-link
    const link = document.querySelector(`.nav-link[href="#${tabId}"]`);
    if (link) {
        link.classList.add('active');
        link.setAttribute('aria-selected', 'true');
        link.click(); // Esto ejecuta @onclick de Blazor
    }

    // 3. Activar el tab-pane
    const pane = document.getElementById(tabId);
    if (pane) {
        pane.classList.add('active');
        pane.classList.add('show'); // Opcional si usas fade/tab transitions
    }
    const triggerEl = document.querySelector(`a[href="#consultas"]`);
    if (triggerEl) {
        const tab = new bootstrap.Tab(triggerEl);
        tab.show();
    }
    var pane1 = document.getElementById("consultas");
    if (pane1) {
        pane1.classList.add('active');
        pane1.setAttribute('aria-selected', 'true');
        pane1.click(); 
    }
}


window.seleccionarTabMascota = seleccionarTabMascota;

function printHtmlComponent(elementId) {
    var element = document.getElementById(elementId);
    console.log(elementId);
    if (!element) return;

    var opt = {
        margin: 0,
        filename: 'ticket.pdf',
        image: { type: 'jpeg', quality: 1 },   // calidad máxima
        html2canvas: { scale: 2, useCORS: true },
        jsPDF: { unit: 'mm', format: 'a4', orientation: 'portrait' }
    };

    html2pdf()
    .set(opt)
        .from(element)
        .toPdf()
        .get('pdf')
        .then(function (pdf) {
            var blob = pdf.output('blob');
            var blobUrl = URL.createObjectURL(blob);
            var ventana = window.open(blobUrl);
            ventana.focus();
            ventana.print();
        });
}
window.printHtmlComponent = printHtmlComponent;

window.generarTicketPDF = (idElemento) => {
    var element = document.getElementById(idElemento);

    var opt = {
        margin: 0,
        filename: 'ticket.pdf',
        image: { type: 'jpeg', quality: 1 },
        html2canvas: { scale: 4, useCORS: true },
        jsPDF: {
            unit: 'mm',
            format: [80, element.scrollHeight * 0.2645], // ancho fijo 80mm, alto dinámico
            orientation: 'portrait'
        }
    };

    html2pdf().set(opt).from(element).toPdf()
        .get('pdf').then(function (pdf) {
        var blob = pdf.output('blob');
        var blobUrl = URL.createObjectURL(blob);
        var ventana = window.open(blobUrl);
        ventana.focus();
        ventana.print();
    });
}