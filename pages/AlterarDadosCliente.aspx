<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="AlterarDadosCliente.aspx.cs" Inherits="pages_AlterarDadosCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Alterar Dados Pessoais</div>
    <div class="row">
        <div class="col-lg-6">
            <br />
            <br />
            <asp:HiddenField ID="hdf" runat="server" />
            <asp:HiddenField ID="hdfID" runat="server" />
            <asp:Label ID="lblNome" runat="server" Text="Nome" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <div class="row">
                <div class="col-lg-6">
                    <asp:Label ID="lblCPF" runat="server" Text="CNPJ" CssClass="margem" readonly="true"></asp:Label>
                    <asp:TextBox ID="txtCPF" runat="server" CssClass="form-control controle"></asp:TextBox>
                </div>
                <div class="col-lg-6">
                    <asp:Label ID="lblSexo" runat="server" Text="Sexo" CssClass="margem"></asp:Label>
                    <asp:DropDownList ID="ddlSexo" runat="server">
                        <asp:ListItem Value="M">Masculino</asp:ListItem>
                        <asp:ListItem Value="F">Feminino</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <br />
            <br />
            <div class="row">
                <div class="col-lg-6">
                    <asp:Label ID="lblCidade" runat="server" Text="Cidade" CssClass="margem"></asp:Label>
                    <asp:DropDownList ID="ddlCidade" runat="server">
                        <asp:ListItem>Lorena</asp:ListItem>
                        <asp:ListItem Selected="True">Guaratinguet&#225;</asp:ListItem>
                        <asp:ListItem>Taubat&#233;</asp:ListItem>
                        <asp:ListItem>Aparecida</asp:ListItem>
                        <asp:ListItem>Canas</asp:ListItem>
                        <asp:ListItem>Pindamonhangaba</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-lg-6">
                    <asp:Label ID="lblEstado" runat="server" Text="Estado" CssClass="margem"></asp:Label>
                    <asp:DropDownList ID="ddlEstado" runat="server">
                        <asp:ListItem Selected="true">SP</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <br />
            <br />
            <asp:Label ID="lblData" runat="server" Text="Data de Nascimento" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtData" runat="server" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="E-mail" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btn btn-default margem" OnClick="btnSalvar_Click" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-default margem" />
        </div>
        <div class="col-lg-2 qualquer">
            <div class="foto"></div>
        </div>

    </div>
</asp:Content>

