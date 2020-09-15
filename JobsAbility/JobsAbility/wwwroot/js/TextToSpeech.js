var elements = [];
var audioIndex = -1;
$(document).ready(function () {
    var index = 0;
    var x = $('body *:not([audio-id],style,script)').contents().filter(function () {
        return (this.nodeType == 3) && this.nodeValue.length > 0;
    }).wrap("<span />").each(function (i, j) {
        var str = j.data;
        str = str.replace("\n", "").replace("\r", "").replace(" ", "");
        if (str.trim() != "") {
            elements.push({ element: j.parentElement, text: str });
            j.parentElement.setAttribute("text-index", index++);
        }
    });
    $("#pollyPlaying").click(function () {
        $("#pollyStop").show();
        $(this).hide();
        StartReading();
    });
    $("#pollyStop").click(function () {
        $("#pollyPlaying").show();
        $(this).hide();
        StopReading();
    });
})
function StopReading() {
    if ($("#audioPlaying").length != 0) {
        $("#audioPlaying")[0].pause();
    }
    $("#audioDiv").empty();
}
function StartReading() {
    PlayIntro();
    document.onkeydown = keydown;

    function keydown(evt) {
        if (!evt) evt = event;
        else if (evt.shiftKey && evt.keyCode == 70) { //Shif+f
            Play(1);//next
        }
        else if (evt.shiftKey && evt.keyCode == 74) {//shift + j
            Play(2);//previous
        }
        else if (evt.shiftKey && evt.keyCode == 71) {//shift + g 
            Play(3);//go
        } else if (evt.shiftKey && evt.keyCode == 72) {//shift + g 
            Play(4);//repeat
        }
    }
}
function GetToTranslate() {
    return elements[audioIndex];
}
var testElm;
function Play(mode) {
    //1 next 2 back 3 go 
    if (mode == 1) {
        audioIndex++;
        TranslateCurrentElem();
    }
    else if (mode == 2) {
        audioIndex--;
        TranslateCurrentElem();
    }
    else if (mode == 3) {
        elements[audioIndex].element.click();
    }
    else if (mode == 4) {
        audioIndex--;
        TranslateCurrentElem();
        audioIndex++;
    }
}
function TranslateCurrentElem() {
    var elemTextObj = GetToTranslate();
    $.get("api/polly", { text: elemTextObj.text }, function (res) {
        PlayAudio(res.mp3Link);
    });
}
function PlayIntro() {
    PlayAudio("MediaFiles/AudioFiles/intro.mp3");
}
function PlayAudio(srcLink) {
    if ($("#audioPlaying").length != 0) {
        $("#audioPlaying")[0].pause();
    }
    var audioEl = document.createElement("audio");
    audioEl.src = srcLink;
    audioEl.id = "audioPlaying";
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