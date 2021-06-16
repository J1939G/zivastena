

function IsWider(figure){
    let image = figure.querySelector('img')
    return image.offsetHeight/image.offsetWidth < window.innerHeight/window.innerWidth ? true : false
}
function formFactor(figure) {
    let image = figure.querySelector('img')
    return image.offsetHeight/image.offsetWidth
}

function Position(container){
    let image = container.querySelector('img')
    let zoomedImg = document.querySelector('#lightbox img')
    zoomedImg.style.left = image.getBoundingClientRect().x + 'px'
    zoomedImg.style.top = image.getBoundingClientRect().y + 'px'
    zoomedImg.width = image.offsetWidth
    zoomedImg.height = image.offsetHeight
    zoomedImg.src = image.src
    return image.offsetHeight/image.offsetWidth
}

function Px(pixels){
    return Math.round(pixels,0) + 'px'
}

function BringForward(figureIsWider, formFactor){
    document.querySelector('#content').style.filter = 'blur(0.75rem)';
    let lightboxImg = document.querySelector('#lightbox img')
    lightboxImg.classList.add("focus")
    
    if( figureIsWider){
        var leftMargin = Px(window.innerWidth*0.025)
        var topMargin = Px( (window.innerHeight - (window.innerWidth*0.95*formFactor) ) / 2 )
        lightboxImg.style.height = 'auto'
        lightboxImg.style.width = Px(window.innerWidth*0.95)
    } else {
        var topMargin = Px(window.innerHeight*0.025)
        var leftMargin = Px( (window.innerWidth - (window.innerHeight*0.95/formFactor) ) / 2 )
        lightboxImg.style.height = Px(window.innerHeight*0.95)
        lightboxImg.style.width = 'auto'
    }
    lightboxImg.style.left = leftMargin
    lightboxImg.style.top = topMargin
    document.querySelector('#lightbox').style.pointerEvents = 'all';
}


function CleanUp(){
    let zoomedImg = document.querySelector('#lightbox img')
    document.querySelector('#content').style.filter = 'none'
    zoomedImg.removeAttribute("style");
    zoomedImg.style.opacity = '0'
    zoomedImg.classList.remove("focus")
    document.querySelector('#lightbox').style.pointerEvents = 'none'
}

function Resize(container){
    let formFactor = Position(container)
    BringForward(IsWider(container), formFactor);
}


function Listen(){
    let figures = document.getElementsByClassName('protection');
    for( var i = 0; i < figures.length; i++){
        let currentFigure = figures[i];
        currentFigure.addEventListener('click', function(){ Resize( currentFigure ) } );
    }
    document.querySelector('#lightbox').addEventListener('click', function(){ CleanUp()});
}
