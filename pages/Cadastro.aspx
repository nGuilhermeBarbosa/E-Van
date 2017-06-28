<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="Cadastro.aspx.cs" Inherits="pages_Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title">
        Seleção de Plano
    </div>
    <br />
    <br />
    <br />
    <div class="signupBox">
        <h5>Selecione o tipo de conta</h5>
        <asp:DropDownList ID="ddlTipoConta" runat="server" OnSelectedIndexChanged="ddlTipoConta_SelectedIndexChanged" AutoPostBack="True" CssClass="form-control">
            <asp:ListItem Selected="True" Value="1">Comum</asp:ListItem>
            <asp:ListItem Value="2">Premium</asp:ListItem>
        </asp:DropDownList>
        <hr />
        <asp:Panel ID="Free" runat="server" Visible="true">
            A conta comum é totalmente gratuita, e não requer nenhum tipo de transação financeira para ser utilizada.
            <br /><br />
            <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success" />
        </asp:Panel>
        <asp:Panel ID="Premium" runat="server" Visible="false">
            A contra premium oferece prioridade na divulgação do seu serviço.
            <div class="plano">
                
                <div class="title">
                    Mensal
                    <asp:RadioButton ID="rbM" runat="server" value="1"  OnCheckedChanged="rbM_CheckedChanged" AutoPostBack="true" CssClass="radio"/>
                </div><br />
                Com o plano mensal você paga o valor de R$ 14,90 e pode usufruir de uma maior
                divulgação do seu serviço dentro da nossa plataforma pelo período de um mês.
            </div><br />
            <div class="plano">
                <div class="title">
                    Anual
                    <asp:RadioButton ID="rbA" runat="server" value="2" OnCheckedChanged="rbA_CheckedChanged" AutoPostBack="true" CssClass="radio"/>
                </div><br />
                Considerado como o melhor plano, com o plano anual você paga o valor de R$ 139,90
                e pode usufruir de uma maior divulgação do seu serviço dentro da nossa plataforma
                pelo período de um ano.
            </div>
            <br />
            <asp:Button ID="btnNext" runat="server" Text="Próximo" CssClass="btn btn-info" />
        </asp:Panel>
    </div>
    <div class="getDown"></div>
</asp:Content>

