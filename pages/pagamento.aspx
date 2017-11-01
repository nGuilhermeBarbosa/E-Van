<%@ Page Title="" Language="C#" MasterPageFile="Public.master" AutoEventWireup="true" CodeFile="pagamento.aspx.cs" Inherits="pages_Selecionar_forma_de_pagamento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function openModalL() {
            $('#fbLoading').modal('show');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="fbLoading" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content" style="background:#fff;">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Aguardando pagamento</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <img src="../images/Loading_icon.gif" style="width: 200px;" />
                            <br />
                            <p class="text-center">O pagamento está em estado pendente</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
    <div class="row">
        <div class="col-lg-8">
            <div class="signupBox" style="margin-top: 10px;">
                Selecione a forma de pagamento<br />
                <asp:RadioButton ID="rbCartao" runat="server" Text="Cartão de Crédito" OnCheckedChanged="rbCartao_CheckedChanged" AutoPostBack="true" CssClass="radio-inline" /><br />
                <asp:RadioButton ID="rbBoleto" runat="server" Text="Boleto Bancário" OnCheckedChanged="rbBoleto_CheckedChanged" AutoPostBack="true" CssClass="radio-inline" /><br />
                <asp:RadioButton ID="rbPaypal" runat="server" Text="PayPal" OnCheckedChanged="rbPaypal_CheckedChanged" AutoPostBack="true" CssClass="radio-inline" />
            </div>
            <asp:Panel ID="PanelCartao" runat="server" Visible="false">
                <div class="signupBox" style="border-top: 1px dashed #fff;">
                    Selecione seu cartão de crédito:<br />
                    <asp:RadioButton ID="bVisa" runat="server" CssClass="radio-inline" OnCheckedChanged="bVisa_CheckedChanged" AutoPostBack="true" />
                    <img src="../images/Visa-icon.png" width="50px" /><br />
                    <asp:RadioButton ID="bMaster" runat="server" CssClass="radio-inline" OnCheckedChanged="bMaster_CheckedChanged" AutoPostBack="true" />
                    <img src="../images/Master-Card-icon.png" width="50px" />
                    <br />
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="col-lg-6">
                                <br />
                                Banco
                            <asp:DropDownList ID="ddlBanco" runat="server" CssClass="form-control">
                                <asp:ListItem>Todos os Bancos</asp:ListItem>
                                <asp:ListItem>Banco do Brasil</asp:ListItem>
                            </asp:DropDownList>
                                <br />
                                Parcelas
                            <asp:DropDownList ID="ddlParcela" runat="server" CssClass="form-control">
                                <asp:ListItem>1x</asp:ListItem>
                                <asp:ListItem>2x</asp:ListItem>
                                <asp:ListItem>3x</asp:ListItem>
                            </asp:DropDownList>
                                <br />
                            </div>
                        </div>
                        <div class="col-lg-12">
                            <div class="col-lg-6">
                                Número do Cartão<br />
                                <asp:TextBox ID="txtCartao" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                            </div>
                            <div class="col-lg-2">
                                Validade<br />
                                <asp:DropDownList ID="ddlVCM" runat="server" CssClass="form-control">
                                    <asp:ListItem Value="null">M&#234;s</asp:ListItem>
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                    <asp:ListItem>6</asp:ListItem>
                                    <asp:ListItem>7</asp:ListItem>
                                    <asp:ListItem>8</asp:ListItem>
                                    <asp:ListItem>9</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                                    <asp:ListItem>11</asp:ListItem>
                                    <asp:ListItem>12</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-lg-2">
                                &nbsp;<br />
                                <asp:DropDownList ID="ddlVCA" runat="server" CssClass="form-control">
                                    <asp:ListItem>Ano</asp:ListItem>
                                    <asp:ListItem>2017</asp:ListItem>
                                    <asp:ListItem>2018</asp:ListItem>
                                    <asp:ListItem>2019</asp:ListItem>
                                    <asp:ListItem>2020</asp:ListItem>
                                    <asp:ListItem>2021</asp:ListItem>
                                    <asp:ListItem>2022</asp:ListItem>
                                    <asp:ListItem>2023</asp:ListItem>
                                    <asp:ListItem>2024</asp:ListItem>
                                    <asp:ListItem>2025</asp:ListItem>
                                    <asp:ListItem>2026</asp:ListItem>
                                    <asp:ListItem>2027</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-lg-2">
                                Código
                                <br />
                                <asp:TextBox ID="txtCS" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-lg-12" style="margin-top: 15px;">
                            <div class="col-lg-6">
                                Nome e sobrenome do cartão<br />
                                <asp:TextBox ID="txtNomeC" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-lg-6">
                                CPF do titular do cartão
                                    <asp:TextBox ID="txtCpfC" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel ID="PanelBoleto" runat="server" Visible="false">
                <div class="signupBox" style="border-top: 1px dashed #fff;">
                    A compra apenas será efetuada após o boleto ser dado como pago, o que pode levar dias para ocorrer.<br />
                    <asp:Button ID="btnBoleto" runat="server" Text="Gerar Boleto" CssClass="btn btn-info" />
                </div>
            </asp:Panel>
            <asp:Panel ID="PanelPayPal" runat="server" Visible="false">
                <div class="signupBox" style="border-top: 1px dashed #fff;">
                    Você será redirecionado para a página de pagamento do PayPal<br />
                    <button type="button" class="btn btn-info" onclick="openModalL();">Continuar</button>
                </div>
            </asp:Panel>
        </div>
        <div class="col-lg-4">
            <div class="serviceBox padding shadow" style="background: #ffd800;">
                <span>Aqui entra detalhes da "compra" (somando o valor a ser pago para a plataforma)</span><br />
                <asp:Button ID="btnComprar" runat="server" Text="Comprar" CssClass="btn btn-info" Style="float: right;" />
            </div>
        </div>
    </div>
</asp:Content>

