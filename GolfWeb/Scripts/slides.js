var slides = (function (slides) {
    var pics = [];
    pics.push("../../Content/images/slides/slide1.png");
    pics.push("../../Content/images/slides/slide2.png");
    pics.push("../../Content/images/slides/slide3.png");

    var pos = pics.length - 1;
    slides.next = function (dir) {
        if (dir == "left") {
            pos = pos - 1;
            if (pos < 0) pos = pics.length - 1;
        }
        else {
            pos = pos + 1;
            if (pos >= pics.length) pos = 0;
        }

        return pics[pos];
    }

    return slides;
})(window.slides || {})