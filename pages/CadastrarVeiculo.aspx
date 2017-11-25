<%@ Page Title="Cadastrar Veículo" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="CadastrarVeiculo.aspx.cs" Inherits="pages_CadastrarVeiculo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">
        <span class="text-left glyphicon glyphicon-chevron-left leftButton"><a href="TodosVeiculos.aspx">&nbsp;Voltar</a></span>
        Cadastrar Veículo
    </div>
    <br />
    <br />
    <br />
    <div class="signupBox" style="padding-right: 50px;">
        <div class="row">
            <div class="col-lg-12">
                <br />
                <br />
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="lblVeiculo" runat="server" Text="Tipo De Veiculo" CssClass="margem"></asp:Label>
                        <asp:DropDownList ID="ddlVeiculo" runat="server" CssClass="form-control controle dropdown">
                        </asp:DropDownList>
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="lblModelo" runat="server" Text="Modelo" CssClass="margem"></asp:Label>
                        <asp:TextBox ID="txtModelo" runat="server" CssClass="form-control controle"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <asp:HiddenField ID="hdf" runat="server" />
                        <asp:Label ID="lblLugar" runat="server" Text="Lugares" CssClass="margem"></asp:Label>
                        <asp:TextBox ID="txtLugar" runat="server" CssClass="form-control controle"></asp:TextBox>
                        <br />
                        <asp:Label ID="lblRecursos" runat="server" Text="Recursos" CssClass="margem"></asp:Label>
                        <asp:CheckBoxList ID="cblRecursos" runat="server" CssClass="checkbox box">
                            
                        </asp:CheckBoxList>
                        <br />
                        <asp:Label ID="lblFoto" runat="server" Text="Upload de Fotos: " CssClass="up"></asp:Label>
                        <asp:FileUpload ID="fup" runat="server" CssClass="up" />
                        <br />
                        <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-default margem" OnClick="btnCadastrar_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

