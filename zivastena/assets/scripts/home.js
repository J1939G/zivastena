function scroller(){
    let height = Math.max(
        document.body.scrollHeight, document.documentElement.scrollHeight,
        document.body.offsetHeight, document.documentElement.offsetHeight,
        document.body.clientHeight, document.documentElement.clientHeight
    );
    let width = Math.max(
        document.body.scrollWidth, document.documentElement.scrollWidth,
        document.body.offsetWidth, document.documentElement.offsetWidth,
        document.body.clientWidth, document.documentElement.clientWidth
    );
    var factor = 0.25;
    document.getElementById('subTitle').style.marginTop =  (window.pageYOffset*factor)+'px';
    document.getElementById('header').style.marginTop =  (-window.pageYOffset*factor*0.2)+'px';
    document.getElementById('footer').style.marginTop =  (-window.pageYOffset*factor*0.2)+'px';
}