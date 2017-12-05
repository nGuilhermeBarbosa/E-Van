<%@ Page Title="Serviços" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="servicesMotoristas.aspx.cs" Inherits="pages_servicesMotoristas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../js/jplist-master/dist/css/jplist.core.min.css" rel="stylesheet" type="text/css" />
    <link href="../js/jplist-master/dist/css/jplist.textbox-filter.min.css" rel="stylesheet" type="text/css" />
    <link href="../js/jplist-master/dist/css/jplist.pagination-bundle.min.css" rel="stylesheet" type="text/css" />
    <link href="../js/jplist-master/dist/css/jplist.history-bundle.min.css" rel="stylesheet" type="text/css" />
    <link href="../js/jplist-master/dist/css/jplist.list-grid-view.min.css" rel="stylesheet" type="text/css" />
    <link href="../js/jplist-master/dist/css/jplist.demo-pages.min.css" rel="stylesheet" type="text/css" />
    <link href="https://jplist.com/content/css/styles.min.css?v=15" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Serviços</div>
    <div id="demo" style="padding-left: 50px !important">

            <!-- panel -->
            <div class="row">
                <div class="jplist-panel">

                    <div class="jplist-drop-down" data-control-type="items-per-page-drop-down" data-control-name="paging" data-control-action="paging">
                        <div class="jplist-dd-panel">10 per page </div>
                        <ul style="display: none;">
                            <li class=""><span data-number="3">3 por pagina </span></li>
                            <li class=""><span data-number="5">5 por pagina </span></li>
                            <li class="active"><span data-number="10" data-default="true">10 por pagina </span></li>
                            <li><span data-number="15">15 por pagina </span></li>
                            <li><span data-number="all">View All </span></li>
                        </ul>
                    </div>

                    <%--     <div class="text-filter-box">
                        <i class="fa fa-search  jplist-icon"></i>
                        <input
                            data-path=".title"
                            type="text"
                            value=""
                            placeholder="Filter by Title"
                            data-control-type="textbox"
                            data-control-name="title-filter"
                            data-control-action="filter" />
                    </div>--%>

                    <div class="text-filter-box">
                        <i class="fa fa-search  jplist-icon"></i>
                        <input
                            data-path=".destino"
                            type="text"
                            value=""
                            placeholder="Filtrar destino"
                            data-control-type="textbox"
                            data-control-name="destino-filter"
                            data-control-action="filter" />
                    </div>

                    <div class="text-filter-box">
                        <i class="fa fa-search  jplist-icon"></i>
                        <input
                            data-path=".origem"
                            type="text"
                            value=""
                            placeholder="Filtrar origem"
                            data-control-type="textbox"
                            data-control-name="origem-filter"
                            data-control-action="filter" />
                    </div>

                    <div class="jplist-drop-down" data-control-type="sort-drop-down" data-control-name="sort" data-control-action="sort">
                      <%--  <div class="jplist-dd-panel">Ordenar</div>--%>
                        <ul style="display: none;">
                            <li class=""><span data-path="default" data-default="true">Padrão</span></li>
                            <li><span data-path=".destino" data-order="asc" data-type="text">Destino A-Z</span></li>
                            <li><span data-path=".destino" data-order="desc" data-type="text">Destino Z-A</span></li>
                            <li><span data-path=".origem" data-order="asc" data-type="text">Origem A-Z</span></li>
                            <li><span data-path=".origem" data-order="desc" data-type="text">Origem Z-A</span></li>
                            <li><span data-path=".saida" data-order="asc" data-type="datetime">Data saida asc</span></li>
                            <li><span data-path=".saida" data-order="desc" data-type="datetime">Data saida desc</span></li>
                            <li><span data-path=".chegada" data-order="asc" data-type="datetime">Data chegada asc</span></li>
                            <li><span data-path=".chegada" data-order="desc" data-type="datetime">Data chegada desc</span></li>
                        </ul>
                    </div>

                    <div class="jplist-label" data-type="Pagina {current} de {pages}" data-control-type="pagination-info" data-control-name="paging" data-control-action="paging"></div>

                    <div class="jplist-pagination" data-control-type="pagination" data-control-name="paging" data-control-action="paging">
                        <div class="jplist-pagingprev jplist-hidden" data-type="pagingprev">
                            <button type="button" class="jplist-first" data-number="0" data-type="first">«</button>
                            <button type="button" class="jplist-prev" data-type="prev" data-number="0">‹</button>
                        </div>
                        <div class="jplist-pagingmid" data-type="pagingmid">
                            <div class="jplist-pagesbox" data-type="pagesbox">
                                <button type="button" data-type="page" class="jplist-current" data-active="true" data-number="0">1</button>
                                <button type="button" data-type="page" data-number="1">2</button>
                                <button type="button" data-type="page" data-number="2">3</button>
                                <button type="button" data-type="page" data-number="3">4</button>
                            </div>
                        </div>
                        <div class="jplist-pagingnext" data-type="pagingnext">
                            <button type="button" class="jplist-next" data-type="next" data-number="1">›</button>
                            <button type="button" class="jplist-last" data-type="last" data-number="3">»</button>
                        </div>
                    </div>
                </div>
            </div>
            <!-- HTML data -->
            <div class="list">
                <asp:Literal ID="LiteralServices" runat="server">
                </asp:Literal>


            </div>

            <!-- no results found -->
            <div class="jplist-no-results">
                <br />
                <p>Nenhum resultado encontrado</p>
            </div>

        </div>

        <!-- jquery library -->
        <script src="../js/jquery-3.1.1.min.js"></script>

        <!-- jPList Core -->
        <script src="../js/jplist-master/dist/js/jplist.core.min.js"></script>
        <%--<link href="../js/jplist-master/dist/css/jplist.core.min.css" rel="stylesheet" type="text/css" />--%>

        <!-- jPList Sort Bundle -->
        <script src="../js/jplist-master/dist/js/jplist.sort-bundle.min.js"></script>

        <!-- jPList Pagination Bundle -->
        <script src="../js/jplist-master/dist/js/jplist.pagination-bundle.min.js"></script>

        <!-- Textbox Filter Control -->
        <script src="../js/jplist-master/dist/js/jplist.textbox-filter.min.js"></script>
        <%--<link href="../js/jplist-master/dist/css/jplist.textbox-filter.min.css" rel="stylesheet" type="text/css" />--%>

        <!-- Other bundles or controls... -->

        <!-- Initialization -->
        <script>
            $('document').ready(function () {

                //check all jPList javascript options here
                $('#demo').jplist({
                    itemsBox: '.list',
                    itemPath: '.list-item',
                    panelPath: '.jplist-panel'
                });

            });
        </script>
</asp:Content>

