$("#contactForm").validator().on("submit", function(a) {
    if (a.isDefaultPrevented()) {
        formError();
        submitMSG(false, "Did you fill in the form properly?")
    } else {
        a.preventDefault();
        submitForm()
    }
});

function submitForm() {
    var d = $("#name").val();
    var a = $("#email").val();
    var c = $("#msg_subject").val();
    var b = $("#message").val();
    $.ajax({
        type: "POST",
        url: "php/form-process.php",
        data: "name=" + d + "&email=" + a + "&msg_subject=" + c + "&message=" + b,
        success: function(e) {
            if (e == "success") { formSuccess() } else {
                formError();
                submitMSG(false, e)
            }
        }
    })
}

function formSuccess() {
    $("#contactForm")[0].reset();
    submitMSG(true, "Message Submitted!")
}

function formError() { $("#contactForm").removeClass().addClass("shake animated").one("webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend", function() { $(this).removeClass() }) }

function submitMSG(c, a) {
    if (c) { var b = "h3 text-center tada animated text-success" } else { var b = "h3 text-center text-danger" }
    $("#msgSubmit").removeClass().addClass(b).text(a)
};