function mudaTamanhoFonte() {
    document.getElementById("teste").style.fontSize = "40px";
}

function mudaBackground() {
    document.getElementById("bgChange").style.backgroundColor = "#f9b946";
    document.getElementsById("undo").style.visibility = true;
}

function undoBg() {
    document.getElementById("bgChange").style.backgroundColor = "#009ffb";
}

function mudaItalico() {
    document.getElementById("teste").style.fontStyle = "italic";
}

function escondeDiv() {
    document.getElementById("teste").style.display = "none";
}

function reapareceDiv() {
    document.getElementById("teste").style.display = "block";
}