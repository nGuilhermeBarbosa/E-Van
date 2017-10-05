function excluir(par, nome) {
    $("#par").text("Tem certeza que deseja excluir o servico do motorista: " + nome);
    $("#par").attr('rel', par);
    $("#meuModal").modal('show');
}

function exc() {

    var par = $("#par").attr("rel");
    $("#par").removeAttr("rel");

    $.ajax({
        dataType: "json",
        type: "POST",
        url: "TodosServicosMotorista.aspx/Excluir",
        data: { par: JSON.stringify(par) },
        success: function (retorno) {
            alert(retorno.d);
        }
    });

}