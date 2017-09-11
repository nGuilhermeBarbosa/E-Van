<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="pages_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Body -->
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
        </ol>

        <!-- Wrapper for slides -->
        <div class="carousel-inner" role="listbox">
            <div class="item active backgroundC">
                <img src="../images/banner.png" alt="Divulgue seu serviço" />
                <div class="carousel-caption">
                    <h3>Motorista</h3>
                    <p>Divulgue seu serviço de forma simples e rápida</p>
                </div>
            </div>

            <div class="item backgroundC">
                <img src="../images/banner2.png" alt="Busque por transporte" />
                <div class="carousel-caption">
                    <h3>Procurando por transporte coletivo?</h3>
                    <p>Encontre ou solicite transporte para o evento que desejar</p>
                </div>
            </div>
        </div>

        <!-- Left and right controls -->
        <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>

    <div class="container text-center">
        <div class="row">
            <div class="col-lg-6">
                <h3 class="text-left">Encontre o transporte ideal para você agora mesmo!</h3>
                <br />
            </div>
            <br />
            <div class="col-lg-6">
                <div class="col-lg-12">
                    <asp:Label ID="Label1" runat="server" Text="Você deve concordar com os termos de uso para prosseguir com o cadastro" CssClass="alert-danger" Visible="false"></asp:Label>
                </div>
                <div class="col-lg-6">
                    <asp:Label ID="Label2" runat="server" Text="---" Visible="false" CssClass="alert-danger"></asp:Label>
                    <asp:DropDownList ID="ddlPM" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlPM_SelectedIndexChanged">
                        <asp:ListItem Selected="True" Value="0">Selecione o tipo de conta</asp:ListItem>
                        <asp:ListItem Value="1">Passageiro</asp:ListItem>
                        <asp:ListItem Value="2">Motorista</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                </div>
                <br />
                
                <asp:Panel ID="pPassageiro" runat="server" Visible="true">
                    <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" CssClass="form-control" required="required"></asp:TextBox><br />
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="E-Mail" CssClass="form-control" TextMode="Email" required="required"></asp:TextBox><br />
                    <asp:TextBox ID="txtSenha" runat="server" placeholder="Senha" CssClass="form-control" TextMode="Password" required="required" onkeyup="CheckPasswordStrength(this.value)"></asp:TextBox><br />

                    <span id="password_strength"></span>

                    <asp:TextBox ID="txtSenha2" runat="server" placeholder="Confirmação de Senha" CssClass="form-control" TextMode="Password" required="required"></asp:TextBox><br />
                    <asp:TextBox ID="txtCpf" runat="server" placeholder="CPF" CssClass="form-control" required="required"></asp:TextBox><br />
                    Data de Nascimento
                    <asp:TextBox ID="txtData" runat="server" type="date" CssClass="form-control" required="required"></asp:TextBox>
                    Sexo
                    <asp:DropDownList ID="ddlSexo" runat="server" CssClass="dropdown form-control">
                        <asp:ListItem Selected="True" Value="M">Masculino</asp:ListItem>
                        <asp:ListItem Value="F">Feminino</asp:ListItem>
                    </asp:DropDownList><br />
                    <div class="row">
                        <div class="col-lg-8">
                            Cidade
                            <asp:DropDownList ID="ddlCidade" runat="server" CssClass="form-control dropdown">
                                <asp:ListItem>Lorena</asp:ListItem>
                                <asp:ListItem Selected="True">Guaratinguet&#225;</asp:ListItem>
                                <asp:ListItem>Taubat&#233;</asp:ListItem>
                                <asp:ListItem>Aparecida</asp:ListItem>
                                <asp:ListItem>Canas</asp:ListItem>
                                <asp:ListItem>Pindamonhangaba</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-4">
                            Estado
                            <asp:DropDownList ID="ddlEstado" runat="server" CssClass="form-control dropdown">
                                <asp:ListItem Selected="true">SP</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="getDown"></div>
                        <asp:Button ID="btnCadastrarPassageiro" ClientIDMode="Static" runat="server" Text="Cadastrar" CssClass="btn btn-info" OnClick="btnCadastrarPassageiro_Click" />

                    </div>
                </asp:Panel>

                <asp:Panel ID="pMotorista" runat="server" Visible="false">
                    <asp:TextBox ID="txtNomeM" runat="server" placeholder="Nome Completo" CssClass="form-control" required="required"></asp:TextBox><br />
                    <asp:TextBox ID="txtEmailM" runat="server" placeholder="E-Mail" CssClass="form-control" TextMode="Email" required="required"></asp:TextBox><br />
                    <asp:TextBox ID="txtSenhaM" runat="server" placeholder="Senha" CssClass="form-control" TextMode="Password" required="required" onkeyup="CheckPasswordStrength2(this.value)"></asp:TextBox><br />

                    <span id="password_strength2"></span>

                    <asp:TextBox ID="txtSenhaCM" runat="server" placeholder="Confirmação de Senha" CssClass="form-control" TextMode="Password" required="required"></asp:TextBox><br />
                    <asp:TextBox ID="txtCnpj" runat="server" placeholder="CNPJ" CssClass="form-control" required="required"></asp:TextBox><br />
                    Data de Nascimento
                    <asp:TextBox ID="txtDataM" runat="server" type="date" CssClass="form-control" required="required"></asp:TextBox>

                    Sexo
                    <asp:DropDownList ID="ddlSexoM" runat="server" CssClass="dropdown form-control">
                        <asp:ListItem Selected="True" Value="M">Masculino</asp:ListItem>
                        <asp:ListItem Value="F">Feminino</asp:ListItem>
                    </asp:DropDownList><br />
                    <div class="row">
                        <div class="col-sm-8">
                            Cidade
                            <asp:DropDownList ID="ddlCidadeM" runat="server" CssClass="form-control dropdown">
                                <asp:ListItem>Lorena</asp:ListItem>
                                <asp:ListItem Selected="True">Guaratinguet&#225;</asp:ListItem>
                                <asp:ListItem>Taubat&#233;</asp:ListItem>
                                <asp:ListItem>Aparecida</asp:ListItem>
                                <asp:ListItem>Canas</asp:ListItem>
                                <asp:ListItem>Pindamonhangaba</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            Estado
                            <asp:DropDownList ID="ddlEstadoM" runat="server" CssClass="form-control dropdown">
                                <asp:ListItem Selected="true">SP</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="getDown"></div>
                        <asp:Button ID="btnCadastrarMotorista" ClientIDMode="Static" runat="server" Text="Cadastrar" CssClass="btn btn-info" OnClick="btnCadastrarMotorista_Click" />
                    </div>
                </asp:Panel>

                <br />
                <div class="row">
                    <div class="col-lg-9">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Li e concordo com os Termos de Uso." CssClass="checkbox" /><br />

                    </div>
                    <div class="col-sm-2">
                    </div>
                </div>

                <br />
                <br />
                <asp:GridView ID="gridUsuario" runat="server" CssClass="table" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                    <Columns>
                        <asp:BoundField DataField="mot_nome" HeaderText="Nome" />
                        <%--<asp:BoundField DataField="usu_email" HeaderText="Email" />
                        <asp:BoundField DataField="usu_senha" HeaderText="Senha" />--%>
                        <asp:BoundField DataField="mot_sexo" HeaderText="Sexo" />
                        <asp:BoundField DataField="mot_cidade" HeaderText="Cidade" />
                        <asp:BoundField DataField="mot_estado" HeaderText="Estado" />
                        <%--<asp:BoundField DataField="mot_cnpj" HeaderText="Cnpj" />--%>
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
        </div>
    </div>
</asp:Content>

