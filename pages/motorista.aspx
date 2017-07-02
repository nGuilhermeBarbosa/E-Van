<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="motorista.aspx.cs" Inherits="pages_motorista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Dados Pessoais</div>
    <div class="row">
        <div class="col-lg-6">
            <br />
            <br />
            <asp:HiddenField ID="hdf1" runat="server" />
            <asp:HiddenField ID="hdfID" runat="server" />
            <asp:Label ID="lblNome" runat="server" Text="Nome" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server" ReadOnly="true" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <div class="row">
                <div class="col-lg-6">
                    <asp:Label ID="lblCnpj" runat="server" Text="CNPJ" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtCNPJ" runat="server" ReadOnly="true" CssClass="form-control controle"></asp:TextBox>
                </div>
                <div class="col-lg-6">
                    <asp:Label ID="lblSexo" runat="server" Text="Sexo" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtSexo" runat="server" ReadOnly="true" CssClass="form-control controle"></asp:TextBox>
                </div>
            </div>
            <br />
            <br />
            <div class="row">
                <div class="col-lg-6">
                    <asp:Label ID="lblCidade" runat="server" Text="Cidade" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtCidade" runat="server" ReadOnly="true" CssClass="form-control controle"></asp:TextBox>
                </div>
                <div class="col-lg-6">
                    <asp:Label ID="lblEstado" runat="server" Text="Estado" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtEstado" runat="server" ReadOnly="true" CssClass="form-control controle"></asp:TextBox>
                </div>
            </div>
            <br />
            <br />
            <asp:Label ID="lblDataNascimento" runat="server" Text="Data de Nascimento" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtDataNascimento" runat="server" ReadOnly="true" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <%--<asp:Label ID="lblTelefone" runat="server" Text="Telefone" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtTelefone" runat="server" ReadOnly="true" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblCelular" runat="server" Text="Celular" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtCelular" runat="server" ReadOnly="true" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />--%>
            <asp:Label ID="lblEmail" runat="server" Text="E-mail" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" ReadOnly="true" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAlterar" value="0" runat="server" Text="Alterar" CssClass="btn btn-default margem" OnClick="btnAlterar_Click"/>
        </div>

        <div class="col-lg-2 qualquer">
            <div class="foto"></div>
            <fieldset class="rating">
                <input type="radio" id="star5" name="rating" value="5"  /><label for="star5" title="Excelente">5 stars</label>
                <input type="radio" id="star4" name="rating" value="4" /><label for="star4" title="Muito Bom">4 stars</label>
                <input type="radio" id="star3" name="rating" value="3" /><label for="star3" title="Regular">3 stars</label>
                <input type="radio" id="star2" name="rating" value="2" /><label for="star2" title="Ruim">2 stars</label>
                <input type="radio" id="star1" name="rating" value="1" /><label for="star1" title="Muito Ruim">1 star</label>
            </fieldset>
            <asp:Button ID="btnUpload" runat="server" Text="Upload" CssClass="doc"/>
            <asp:Label ID="lblDoc" runat="server" Text="Documento:" CssClass="doc"></asp:Label>


        </div>
    </div>
</asp:Content>

