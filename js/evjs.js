﻿function mudaTamanhoFonte() {
    document.getElementById("teste").style.fontSize = "40px";
}

function mudaBackground() {
    document.getElementById("bgChange").style.backgroundColor = "#f9b946";
    document.getElementsById("undo").style.visibility = true;
}

function undoBg() {
    document.getElementById("bgChange").style.backgroundColor = "#009ffb";
}

$(document).ready(function () {
    $("#ajuda").mouseenter(function () {
        $("#ajudaSenha").show(500);
    });

    $("#ajuda").mouseleave(function () {
        $("#ajudaSenha").hide(500);
    });
});