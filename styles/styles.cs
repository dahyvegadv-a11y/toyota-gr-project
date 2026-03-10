
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

/*  BODY  */
body {
    font-family: 'Arial', sans-serif;
    background-color: #000; 
    color: #080808;
    line-height: 1.6;
}

/*  HEADER BANNER NEGRO  */
header.header {
    background-color: #000; 
    transition: all 0.3s;
    position: relative;
    z-index: 10;
}

header.header:hover {
    box-shadow: 0 5px 15px rgba(255,0,0,0.5);
}


header img.header-logo {
    max-height: 120px; /* no borrar, mismo tamaño para todas las pag. */
    transition: transform 0.3s;
}

header img.header-logo:hover {
    transform: scale(1.05);
}

/*  MENU NAVEGACION */
.nav-link {
    font-weight: bold;
    color: #fff; 
    transition: color 0.3s;
}

.nav-link:hover {
    color: #f00; 
}

/*  TITULOS  */
h1 {
    font-family: 'Merriweather', serif; 
    font-size: 2.5rem;
    color: #f00;
    text-align: center;
}

h2 {
    font-family: 'Arial', sans-serif;
    font-size: 2rem;
    color: #fff;
    text-align: center;
}

/*  PARRAFOS  */
p, .lead {
    font-size: 1rem;
    color: #ddd;
}

/*  FOOTER  */
footer.footer {
    background-color: #000; 
    color: #fff;
}

footer a {
    text-decoration: none;
    transition: color 0.3s;
}

footer a:hover {
    color: #f00;
}

/*  BOTONES  */
button, .btn {
    background-color: #f00;
    border: none;
    color: #fff;
    padding: 0.6rem 1rem;
    font-weight: bold;
    border-radius: 5px;
    cursor: pointer;
    transition: background 0.3s;
}

button:hover, .btn:hover {
    background-color: #c00;
}

/*  IMAGENES  */
img {
    display: block;
    max-width: 100%;
    height: auto;
    border-radius: 8px;
}

/*  STORE PRODUCTOS  */
.row.g-3 .col-6 img {
    max-height: 200px; 
    object-fit: cover; 
}


.row.g-3 .col-6:nth-child(3),
.row.g-3 .col-6:nth-child(4) img {
    max-height: 180px;
}

/*  CONTACTO  */
form label {
    font-weight: bold;
}

form input, form textarea {
    padding: 0.5rem;
    border-radius: 5px;
    border: 1px solid #ccc;
}

form input:focus, form textarea:focus {
    outline: none;
    border-color: #f00;
    box-shadow: 0 0 5px rgba(255,0,0,0.5);
}

/*  EFECTOS Y ANIMACIONES TIKTOK */
.fade-in {
    opacity: 0;
    animation: fadeInAnim 1s forwards;
}

@keyframes fadeInAnim {
    from { opacity: 0; transform: translateY(20px); }
    to { opacity: 1; transform: translateY(0); }
}

.bubble {
    position: absolute;
    width: 20px;
    height: 20px;
    background-color: rgba(255,0,0,0.7);
    border-radius: 50%;
    animation: floatBubble 6s infinite;
}

@keyframes floatBubble {
    0% { transform: translateY(0) scale(1); }
    50% { transform: translateY(-80px) scale(1.3); }
    100% { transform: translateY(0) scale(1); }
}

/*  SECCIONES  */
.tip-card {
    background: linear-gradient(45deg, #111, #222);
    border: 1px solid #f00;
    border-radius: 15px;
    padding: 1rem;
    margin: 1rem 0;
    transition: transform 0.3s, box-shadow 0.3s;
}

.tip-card:hover {
    transform: scale(1.03);
    box-shadow: 0 0 20px #f00;
}

/*  GALERÍA EFECTOS  */
.gallery-container {
    display: flex;
    width: 95%;
    max-width: 1300px;
    height: 650px;
    gap: 12px;
    margin: 40px auto;
}

.gallery-item {
    position: relative;
    flex: 1;
    overflow: hidden;
    border-radius: 20px;
    cursor: pointer;
    transition: all 0.7s cubic-bezier(0.25, 1, 0.5, 1);
    border: 1px solid rgba(255, 255, 255, 0.1);
}

.gallery-item img {
    width: 100%;
    height: 100%;
    object-fit: cover;
    transition: all 0.7s ease;
    filter: brightness(0.5) grayscale(0.3);
}

.gallery-item:hover {
    flex: 6;
    box-shadow: 0 20px 50px rgba(0, 0, 0, 0.5);
}

.gallery-item:hover img {
    filter: brightness(1) grayscale(0);
    transform: scale(1.05);
}

.gallery-caption {
    position: absolute;
    bottom: 30px;
    left: 30px;
    color: white;
    font-weight: 900;
    font-size: 1.8rem;
    text-transform: uppercase;
    letter-spacing: 2px;
    white-space: nowrap;
    opacity: 0;
    z-index: 2;
    transition: all 0.4s ease;
    transform: translateY(20px);
}

.gallery-item:hover .gallery-caption {
    opacity: 1;
    transform: translateY(0);
    transition-delay: 0.4s;
}

/*  RESPONSIVE -para adaptar a pantallas mas chicas- */
@media (max-width: 768px) {
    h1 { font-size: 2rem; }
    h2 { font-size: 1.5rem; }
    .row.g-3 .col-6 img,
    .gallery-container .gallery-item {
        max-height: 150px;
    }
}
