$(document).ready(function () {
    var index = 0;
    var x = $('body *:not([audio-id])').contents().filter(function () {
        return (this.nodeType == 3) && this.nodeValue.length > 0;
    }).wrap("<span />").each(function (i, j) {
        var str = j.data;
        str = str.replace("\n", "").replace("\r", "").replace(" ", "");
        if (str.trim() != "") {
            j.parentElement.setAttribute("text-index", index++);
            console.log(str);
        }
    })
   
})

function StartReading() {
    PlayIntro();
}
function PlayIntro() {
    var audioEl = document.createElement("audio");
    audioEl.src = "MediaFiles/AudioFiles/intro.mp3";
    audioEl.onloadeddata = function () {
        audioEl.play();
    }
    $("#audioDiv").empty();
    $("#audioDiv").append(audioEl);
}
/*
     <audio controls="controls">
        <source src="~/MediaFiles/AudioFiles/intro.mp3" type="audio/mpeg" />
    </audio>
 */ 