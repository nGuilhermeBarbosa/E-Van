<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Admin.master" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="pages_Report" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
        <div class="title text-center">Denúncias</div>  
        <div class="col-lg-12">
            <div class=" serviceBox">
                <!-- --><div class="padding">
                    <h4>Denúncia A</h4>
                    <hr />
                    <p>Anúncio impróprio  para esta plataforma.</p>
                    <asp:Button ID="btnAprovar1" runat="server" Text="Aprovar" CssClass="btn-success btn cor" OnClick="btnAprovar1_Click"  />
                    <asp:Button ID="btnReprovar2" runat="server" Text="Reprovar" CssClass="btn-danger btn" OnClick="btnReprovar2_Click"  />
                </div>
            </div>
            <div class=" serviceBox">
                <div class="padding">
                    <h4>Denúncia B</h4>
                    <hr />
                    <p>Anúncio impróprio  para esta plataforma.</p>
                    <asp:Button ID="btnAprovar3"  runat="server" Text="Aprovar" CssClass="btn-success btn cor" OnClick="btnAprovar3_Click" />
                    <asp:Button ID="btnReprovar4" runat="server" Text="Reprovar" CssClass="btn-danger btn cor" OnClick="btnReprovar4_Click"  />
                </div>
            </div>

            <div class="serviceBox">
                <div class="padding">
                    <h4>Denúncia C</h4>
                    <hr />
                    <p>Anúncio impróprio  para esta plataforma.</p>
                    <asp:Button ID="btnAprovar5"  runat="server" Text="Aprovar" CssClass="btn-success btn cor" OnClick="btnAprovar5_Click"  />
                    <asp:Button ID="btnReprovar6" runat="server" Text="Reprovar" CssClass="btn-danger btn cor" OnClick="btnReprovar6_Click" />
                </div>
            </div>

            <div class="serviceBox">
                <div class="padding">
                    <h4>Denúncia D</h4>
                    <hr />
                    <p>Anúncio impróprio  para esta plataforma.</p>
                    <asp:Button ID="btnAprovar7"  runat="server" Text="Aprovar" CssClass="btn-success btn cor" OnClick="btnAprovar7_Click" />
                    <asp:Button ID="btnReprovar8" runat="server" Text="Reprovar" CssClass="btn-danger btn cor" OnClick="btnReprovar8_Click" />
                </div>
            </div>
            <div class="serviceBox">
                <div class="padding">
                    <h4>Denúncia E</h4>
                    <hr />
                    <p>Anúncio impróprio  para esta plataforma.</p>
                    <asp:Button ID="btnAprovar9"  runat="server" Text="Aprovar" CssClass="btn-success btn cor" OnClick="btnAprovar9_Click" />
                    <asp:Button ID="btnReprovar10" runat="server" Text="Reprovar" CssClass="btn-danger btn" OnClick="btnReprovar10_Click" />
                </div>
            </div>
            <div class="serviceBox">
                <div class="padding">
                    <h4>Denúncia F</h4>
                    <hr />
                    <p>Anúncio impróprio  para esta plataforma.</p>
                    <asp:Button ID="btnAprovar11" runat="server" Text="Aprovar" CssClass="btn-success btn cor" OnClick="btnAprovar11_Click"  />
                    <asp:Button ID="btnReprovar12" runat="server" Text="Reprovar" CssClass="btn-danger btn cor" OnClick="btnReprovar12_Click"/>
                </div>
            </div>

            <div class="serviceBox">
                <div class="padding">
                    <h4>Denúncia G</h4>
                    <hr />
                    <p>Anúncio impróprio  para esta plataforma.</p>
                    <asp:Button ID="btnAprovar13"  runat="server" Text="Aprovar" CssClass="btn-success btn cor" OnClick="btnAprovar13_Click" />
                    <asp:Button ID="btnReprovar14" runat="server" Text="Reprovar" CssClass="btn-danger btn cor" OnClick="btnReprovar14_Click" />
                </div>
            </div>

            <div class="serviceBox">
                <div class="padding">
                    <h4>Denúncia H</h4>
                    <hr />
                    <p>Anúncio impróprio  para esta plataforma.</p>
                    <asp:Button ID="btnAprovar15" runat="server" Text="Aprovar" CssClass="btn-success btn cor" OnClick="btnAprovar15_Click" />
                    <asp:Button ID="btnReprovar16" runat="server" Text="Reprovar" CssClass="btn-danger btn cor" OnClick="btnReprovar16_Click" />
                </div>
            </div>
        </div>        
    </div>
    
</asp:Content>

