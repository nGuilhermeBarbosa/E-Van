<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Admin.master" AutoEventWireup="true" CodeFile="allAdmin.aspx.cs" Inherits="pages_allAdmin" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="title text-center">
            Todos Administradores
            <span class="glyphicon glyphicon-plus glyphiconBar">&nbsp;<a href="addAdmin.aspx">Adicionar Administrador</a></span>
        </div>

        <div class="col-lg-10">
            <asp:GridView ID="gridAdmin" runat="server" CssClass="table" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField DataField="adm_nome" HeaderText="Nome" />
                    <asp:BoundField DataField="adm_sexo" HeaderText="Sexo" />
                    <asp:BoundField DataField="adm_estado" HeaderText="Estado" />
                    <asp:BoundField DataField="adm_cidade" HeaderText="Cidade" />
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
            <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
        </div>
        <div class="col-lg-2">
            <asp:DropDownList ID="ddlAdmin" runat="server" OnSelectedIndexChanged="ddlAmdmin_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        </div>
        <asp:Label ID="lbl2" runat="server" Text=""></asp:Label>

    </div>
    <div class="getDown"></div><br />
    <div class="getDown"></div>
</asp:Content>

