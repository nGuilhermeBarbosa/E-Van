<%@ Page Title="Adicionar Administrador" Language="C#" MasterPageFile="~/pages/Admin.master" AutoEventWireup="true" CodeFile="addAdmin.aspx.cs" Inherits="pages_addAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Novo Administrador</div>
    <div class="row margem">

        <div class="col-lg-6 margin-left">
            <br />
            <div class="row">
                <div class="col-lg-6">
                    <br />
                    <asp:TextBox ID="txtNomeA" runat="server" placeholder="Nome Completo" CssClass="form-control" required="required"></asp:TextBox><br />
                </div>
                <div class="col-lg-6">
                    Sexo
                    <asp:DropDownList ID="ddlSexoA" runat="server" CssClass="form-control">
                        <asp:ListItem Selected="True" Value="M">Masculino</asp:ListItem>
                        <asp:ListItem Value="F">Feminino</asp:ListItem>
                    </asp:DropDownList><br />
                </div>
                <div class="col-lg-12">
                    <asp:TextBox ID="txtEmailA" runat="server" placeholder="E-mail" CssClass="form-control" TextMode="Email" required="required"></asp:TextBox><br />
                </div>
            </div>

            <div class="row">
                <div class="col-lg-6">
                    <asp:TextBox ID="txtSenhaA" runat="server" placeholder="Senha" CssClass="form-control" TextMode="Password" required="required"></asp:TextBox><br />
                    <asp:Label ID="lblCS" runat="server" Text="---" Visible="false" CssClass="alert-danger"></asp:Label><br />
                </div>
                <div class="col-lg-6">
                    <asp:TextBox ID="txtConfirmarSenha" runat="server" placeholder="Confirme a Senha" CssClass="form-control" TextMode="Password" required="required"></asp:TextBox><br />
                </div>
            </div>
            Data de Nascimento
            <asp:TextBox ID="txtDataNasc" runat="server" type="date" placeholder="Data de Nascimento" CssClass="form-control" required="required"></asp:TextBox><br />

            <div class="row">
                <div class="col-lg-6">
                    Estado
                    <asp:DropDownList ID="ddlEstadoA" runat="server" CssClass="form-control dropdown">
                        <asp:ListItem Selected="True">SP</asp:ListItem>
                    </asp:DropDownList><br />
                </div>
                <div class="col-lg-6">
                    Cidade
                    <asp:DropDownList ID="ddlCidadeA" runat="server" CssClass="form-control dropdown">
                        <asp:ListItem>Aparecida</asp:ListItem>
                        <asp:ListItem Selected="True">Guaratinguet&#225;</asp:ListItem>
                        <asp:ListItem>Lorena</asp:ListItem>
                        <asp:ListItem>S&#227;o Jos&#233; dos Campos</asp:ListItem>
                        <asp:ListItem>Taubat&#233;</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="center">
                    <asp:Button ID="Button2" runat="server" Text="Cadastrar" CssClass="btn btn-success" OnClick="btnConfirmaCadastro_Click" />
                    <a href="allAdmin.aspx" class="btn btn-danger">Voltar</a>
                    <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
                </div>
            </div>

        </div>
    </div>
</asp:Content>

