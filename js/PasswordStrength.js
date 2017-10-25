function CheckPasswordStrength(password) {
    var password_strength = document.getElementById("password_strength");

    //TextBox left blank.
    if (password.length == 0) {
        password_strength.innerHTML = "";
        return;
    }

    //Regular Expressions.
    var regex = new Array();
    regex.push("[A-Z]"); //Uppercase Alphabet.
    regex.push("[a-z]"); //Lowercase Alphabet.
    regex.push("[0-9]"); //Digit.
    regex.push("[$@$!%*#?&]"); //Special Character.

    var passed = 0;

    //Validate for each Regular Expression.
    for (var i = 0; i < regex.length; i++) {
        if (new RegExp(regex[i]).test(password)) {
            passed++;
        }
    }

    //Validate for length of Password.
    if (passed > 2 && password.length > 8) {
        passed++;
    }

    //Display status.
    var color = "";
    var strength = "";
    switch (passed) {
        case 0:
        case 1:
            strength = "A sua senha está fraca, recomendamos melhora-la";
            color = "red";
            $("#btnCadastrar").prop('disabled', true);
            break;
        case 2:
            strength = "Senha Boa";
            color = "darkorange";
            $("#btnCadastrar").prop('disabled', false);
            break;
        case 3:
        case 4:
            strength = "Senha Forte";
            color = "green";
            $("#btnCadastrar").prop('disabled', false);
            break;
        case 5:
            strength = "Senha Muito Forte";
            color = "darkgreen";
            $("#btnCadastrar").prop('disabled', false);
            break;
    }
    password_strength.innerHTML = strength;
    password_strength.style.color = color;
    password_strength.style.fontWeight = "bold";
}

function CheckPasswordStrength2(password) {
    var password_strength = document.getElementById("password_strength2");

    //TextBox left blank.
    if (password.length == 0) {
        password_strength.innerHTML = "";
        return;
    }

    //Regular Expressions.
    var regex = new Array();
    regex.push("[A-Z]"); //Uppercase Alphabet.
    regex.push("[a-z]"); //Lowercase Alphabet.
    regex.push("[0-9]"); //Digit.
    regex.push("[$@$!%*#?&]"); //Special Character.

    var passed = 0;

    //Validate for each Regular Expression.
    for (var i = 0; i < regex.length; i++) {
        if (new RegExp(regex[i]).test(password)) {
            passed++;
        }
    }

    //Validate for length of Password.
    if (passed > 2 && password.length > 8) {
        passed++;
    }

    //Display status.
    var color = "";
    var strength = "";
    switch (passed) {
        case 0:
        case 1:
            strength = "A sua senha está fraca, recomendamos melhora-la";
            color = "red";
            $("#btnCadastrar").prop('disabled', true);
            break;
        case 2:
            strength = "Senha Boa";
            color = "darkorange";
            $("#btnCadastrar").prop('disabled', false);
            break;
        case 3:
        case 4:
            strength = "Senha Forte";
            color = "green";
            $("#btnCadastrar").prop('disabled', false);
            break;
        case 5:
            strength = "Senha Muito Forte";
            color = "darkgreen";
            $("#btnCadastrar").prop('disabled', false);
            break;
    }
    password_strength.innerHTML = strength;
    password_strength.style.color = color;
    password_strength.style.fontWeight = "bold";
}