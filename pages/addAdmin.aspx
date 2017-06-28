<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Admin.master" AutoEventWireup="true" CodeFile="addAdmin.aspx.cs" Inherits="pages_addAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Novo Administrador</div>
    <div class="row margem">

        <div class="col-lg-6 margin-left">
            <br />
            <div class="row">
                <div class="col-lg-7">
                    <asp:DropDownList ID="ddlAddAdmin" runat="server" CssClass="dropdown form-control">
                        <asp:ListItem Selected="True" Value="null">Sexo</asp:ListItem>
                        <asp:ListItem Value="M">Masculino</asp:ListItem>
                        <asp:ListItem Value="F">Feminino</asp:ListItem>
                    </asp:DropDownList><br />
                </div>
                <div class="col-lg-7">
                    <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" CssClass="form-control" required="required"></asp:TextBox><br />
                </div>
                <div class="col-lg-5">
                    <asp:TextBox ID="txtNomeUsuario" runat="server" placeholder="Nome de Usuário" CssClass="form-control" required="required"></asp:TextBox><br />
                </div>
                <div class="col-lg-5">
                    <asp:TextBox ID="txtTelAdm" runat="server" placeholder="Telefone" CssClass="form-control" TextMode="Phone" required="required"></asp:TextBox><br />
                </div>
                <div class="col-lg-7">
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="E-mail" CssClass="form-control" TextMode="Email" required="required"></asp:TextBox><br />
                </div>
            </div>

            <div class="row">
                <div class="col-lg-6">
                    <asp:TextBox ID="txtSenha" runat="server" placeholder="Senha" CssClass="form-control" TextMode="Password" required="required"></asp:TextBox><br />
                </div>
                <div class="col-lg-6">
                    <asp:TextBox ID="txtConfirmarSenha" runat="server" placeholder="Confirme a Senha" CssClass="form-control" TextMode="Password" required="required"></asp:TextBox><br />
                </div>
            </div>
            <div class="row">
                <div class="col-lg-6">
                    <asp:TextBox ID="txtCpf" runat="server" placeholder="CPF" CssClass="form-control" required="required"></asp:TextBox><br />
                </div>
                <div class="col-lg-6">
                    <asp:TextBox ID="dataNasc" runat="server" placeholder="Data de Nascimento" CssClass="form-control" TextMode="Date" required="required"></asp:TextBox><br />
                </div>
            </div>
            <div class="row">

                <div class="col-lg-6">
                    <asp:TextBox ID="txtEnd" runat="server" placeholder="Endereço" CssClass="form-control" required="required"></asp:TextBox>
                    <br />
                </div>
                <div class="col-lg-6">
                    <asp:DropDownList ID="ddlEstado" runat="server" CssClass="form-control dropdown">
                        <asp:ListItem Selected="True" Value="null">Estado...</asp:ListItem>
                        <asp:ListItem>ES</asp:ListItem>
                        <asp:ListItem>MG</asp:ListItem>
                        <asp:ListItem>RJ</asp:ListItem>
                        <asp:ListItem>SP</asp:ListItem>
                    </asp:DropDownList><br />
                </div>
                <div class="col-lg-6">
                    <asp:DropDownList ID="ddlCidade" runat="server" CssClass="form-control dropdown">
                        <asp:ListItem Selected="True" Value="null">Cidade...</asp:ListItem>
                        <asp:ListItem>Aparecida</asp:ListItem>
                        <asp:ListItem>Guaratinguetá</asp:ListItem>
                        <asp:ListItem>Lorena</asp:ListItem>
                        <asp:ListItem>São José dos Campos</asp:ListItem>
                        <asp:ListItem>Taubaté</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="center">
                    <asp:Button ID="Button1" runat="server" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelaCadastro_Click" />
                    <asp:Button ID="Button2" runat="server" Text="Cadastrar" CssClass="btn btn-success" OnClick="btnConfirmaCadastro_Click" />
                </div>
            </div>
            <br />

            <asp:GridView ID="gridAdmin" runat="server" CssClass="table" AutoGenerateColumns="false" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField DataField="adm_nome" HeaderText="Nome" />
                    <asp:BoundField DataField="adm_telefone" HeaderText="Telefone" />
                    <asp:BoundField DataField="adm_sexo" HeaderText="Sexo" />
                    <asp:BoundField DataField="adm_datanascimento" HeaderText="Data de Nascimento" />
                    <asp:BoundField DataField="adm_cidade" HeaderText="Cidade" />
                    <asp:BoundField DataField="adm_estado" HeaderText="Estado" />
                    <asp:BoundField DataField="adm_endereco" HeaderText="Endereço" />
                    <asp:BoundField DataField="adm_cpf" HeaderText="CPF" />
                    <asp:BoundField DataField="adm_idade" HeaderText="Idade" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />

            </asp:GridView>

            <asp:Label ID="lblCofirma" runat="server" Text="Cadastro Efetuado"></asp:Label>
            <asp:Label ID="lblCancela" runat="server" Text="Cadastro Cancelado"></asp:Label>

        </div>
    </div>
</asp:Content>

