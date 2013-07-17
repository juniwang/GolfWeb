var slides = (function (slides) {
    var config = { "container": "" };
    var pics = [];
    pics.push({ "img": "../../Content/images/slides/slide1.jpg" });
    pics.push({ "img": "../../Content/images/slides/slide2.jpg" });
    pics.push({ "img": "../../Content/images/slides/slide3.jpg" });
    pics.push({ "img": "../../Content/images/slides/slide4.jpg", "href": "/home/bamboo" });

    var pos = pics.length - 1;
    var next = function (dir) {
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

    slides.showNext = function (dir) {
        var pic = next(dir);
        $(config.container).empty();
        var img = $("<img/>").attr({ "alt": "", "src": pic.img });
        if (pic.href) {
            var a = $("<a />").attr({ "href": pic.href });
            a.append(img).appendTo($(config.container));
        }
        else {
            $(config.container).append(img);
        }
    }

    slides.init = function (args) {
        $.extend(config, args);
    }

    return slides;
})(window.slides || {})