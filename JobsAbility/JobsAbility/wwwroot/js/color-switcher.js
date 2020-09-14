window.console = window.console || (function() {
    var a = {};
    a.log = a.warn = a.debug = a.info = a.error = a.time = a.dir = a.profile = a.clear = a.exception = a.trace = a.assert = function() {};
    return a
})();
jQuery(document).ready(function(a) {
    a("ul.colors .color1").click(function() { a("#colors").attr("href", "assets/css/colors/cyan.css"); return false });
    a("ul.colors .color2").click(function() { a("#colors").attr("href", "assets/css/colors/green.css"); return false });
    a("ul.colors .color3").click(function() { a("#colors").attr("href", "assets/css/colors/pink.css"); return false });
    a("ul.colors .color4").click(function() { a("#colors").attr("href", "assets/css/colors/purple.css"); return false });
    a("ul.colors .color5").click(function() { a("#colors").attr("href", "assets/css/colors/blue.css"); return false });
    a("ul.colors .color6").click(function() { a("#colors").attr("href", "assets/css/colors/yellow.css"); return false });
    a("#color-style-switcher .bottom a.settings").click(function(c) { c.preventDefault(); var b = a("#color-style-switcher"); if (b.css("left") === "-145px") { a("#color-style-switcher").animate({ left: "0px" }) } else { a("#color-style-switcher").animate({ left: "-145px" }) } });
    a("ul.colors li a").click(function(b) {
        b.preventDefault();
        a(this).parent().parent().find("a").removeClass("active");
        a(this).addClass("active")
    })
});
jQuery("head").append('<link rel="stylesheet" id="colors" href="assets/css/colors/cyan.css" type="text/css" />');
jQuery("head").append('<link rel="stylesheet" href="assets/css/color-switcher.css" type="text/css" />');
jQuery("body").append('<div id="color-style-switcher"><div><h3>Color Palette</h3><ul class="colors"><li><a class="color1 active" href="#"></a></li><li><a class="color2" href="#"></a></li><li><a class="color3" href="#"></a></li><li><a class="color4" href="#"></a></li><li><a class="color5" href="#"></a></li><li><a class="color6" href="#"></a></li></ul></div><div class="bottom"> <a href="#" class="settings"><i class="lni-cog"></i></a> </div></div>');