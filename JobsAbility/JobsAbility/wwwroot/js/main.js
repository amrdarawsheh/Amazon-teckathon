(function(a) {
    var b = a(window);
    b.on("load", function() { a("#preloader").fadeOut("slow") });
    b.on("scroll", function() { if (a(this).scrollTop() > 250) { a(".back-to-top").fadeIn(200) } else { a(".back-to-top").fadeOut(200) } });
    a(".back-to-top").on("click", function() { a("html, body").animate({ scrollTop: 0 }, "slow"); return false });
    var c = a(".mobile-menu").data("logo");
    a("#main-navbar").slicknav({ appendTo: ".mobile-menu", removeClasses: false, label: "", closedSymbol: '<i class="lni-chevron-right"><i/>', openedSymbol: '<i class="lni-chevron-down"><i/>', brand: '<a href="index.html"><img src="' + c + '" class="img-responsive" alt="logo"></a>' });
    b.on("scroll", function() { var f = a(window).scrollTop(); if (f >= 100) { a(".scrolling-navbar").addClass("top-nav-collapse") } else { a(".scrolling-navbar").removeClass("top-nav-collapse") } });
    if (a(".fact-count").length > 0) { a(".counter").counterUp({ delay: 10, time: 500 }) }
    var e = a("#testimonials");
    e.owlCarousel({ autoplay: true, margin: 30, dots: true, autoplayHoverPause: true, nav: false, loop: true, responsiveClass: true, responsive: { 0: { items: 1, }, 991: { items: 1 } } });
    var d = a("#new-products");
    d.owlCarousel({ autoplay: true, nav: true, autoplayHoverPause: true, smartSpeed: 350, dots: false, margin: 30, loop: true, navText: ['<i class="lni-chevron-left"></i>', '<i class="lni-chevron-right"></i>'], responsiveClass: true, responsive: { 0: { items: 1, }, 575: { items: 2, }, 991: { items: 3, } } })
})(jQuery);