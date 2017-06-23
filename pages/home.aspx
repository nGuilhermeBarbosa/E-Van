<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="pages_home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-9">

            <div class="title">Busca</div>
            <div class="filtro">
                <br />
                <br />
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="Label1" runat="server" CssClass="texthome" Text="Origem: "></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control caixatexto"></asp:TextBox><br />
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="Label2" runat="server" CssClass="texthome" Text="Destino: "></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control caixatexto" ></asp:TextBox><br />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="lbl" runat="server" CssClass="texthome" Text="Data de saída: "></asp:Label>
                        <asp:TextBox ID="TextBox3" runat="server" type="date" CssClass="form-control caixatexto"></asp:TextBox><br />
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="lbl2" runat="server" CssClass="texthome" Text="Data de retorno: "></asp:Label>
                        <asp:TextBox ID="TextBox4" runat="server" type="date" CssClass="form-control caixatexto"></asp:TextBox><br />
                    </div>
                </div>
                <asp:Label ID="Label3" runat="server" CssClass="texthome" Text="Avaliação: "></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control caixatexto">
                    <asp:ListItem Value="null">Estrelas</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem Value="6">Exibir todas as op&#231;&#245;es</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info" />
            </div>
            <br />
            <div class="title">Principais Motoristas</div>
            <a href="serviceInfo.aspx" class="dblock">
                <div class="serviceBox">
                    <div class="title">João</div>
                    <div class="padding">
                        <table border="0">
                            <tr>
                                <td>
                                    <b>Destino:&nbsp</b>Praia Grande<br />
                                    <b>Cidade:&nbsp</b>Ubatuba<br />
                                    <b>Saída:&nbsp</b>Guaratinguetá<br />
                                </td>
                                <td>
                                    <div class="photoDriver border"></div>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <p>9/5/2017</p>
                </div>
            </a>

        </div>
        <div class="col-lg-3">
            <div class="title">Ranking</div>
            <div class="col-lg-12">
                <div class="serviceBox userAvaliate padding">
                    Nome: Claudemir<br />
                    Cidade: Guaratinguetá<br />
                    Avaliação: 5<br />
                    <div class="glyphicon glyphicon-star"></div>
                    <div class="glyphicon glyphicon-star"></div>
                    <div class="glyphicon glyphicon-star"></div>
                    <div class="glyphicon glyphicon-star"></div>
                    <div class="glyphicon glyphicon-star-empty"></div>
                </div>
                <div class="serviceBox userAvaliate padding">
                    Nome: Claudemir<br />
                    Cidade: Guaratinguetá<br />
                    Avaliação: 5<br />
                    <div class="glyphicon glyphicon-star"></div>
                    <div class="glyphicon glyphicon-star"></div>
                    <div class="glyphicon glyphicon-star"></div>
                    <div class="glyphicon glyphicon-star"></div>
                    <div class="glyphicon glyphicon-star-empty"></div>
                </div>
                <asp:Button ID="btnShowAll" runat="server" Text="Ver todas as avaliações" CssClass="btn btn-default buttonShowAll" OnClick="btnShowAll_Click" />
            </div>
        </div>
    </div>
</asp:Content>

