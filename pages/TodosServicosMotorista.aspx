<%@ Page Title="Serviços" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="TodosServicosMotorista.aspx.cs" Inherits="pages_Default" %>

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

    <div id="meuModal" class="modal fade" role="dialog">
        <div class="modal-a">
            <asp:HiddenField ID="hdf" runat="server" />
            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">

                            <p id="par"></p>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <a href="#" class="btn btn-default" onclick="exc();">Simm</a>
                    <asp:Button ID="btnExcluir" class="btn btn-default" runat="server" Text="Sim" OnClick="btnExcluir_Click" />
                    <asp:Button ID="btnCancelar" class="btn btn-default" runat="server" Text="Cancelar" />
                </div>
            </div>

        </div>
    </div>

    <div id="modalLimite" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Atenção</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-alert col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Lamentamos informar que você atingiu seu limite mensal de divulgação de serviço, aguarde a virada do mês para divulgar novamente.</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>


    <div class="row">
        <%--<asp:Label ID="Label1" runat="server" Text="can you see this?" style="visibility:hidden"></asp:Label>--%>
        <div class="title text-center col-lg-12">
            Meus Serviços
        <asp:LinkButton ID="csm" runat="server" CssClass="glyphicon glyphicon-plus glyphiconBar" OnClick="csm_Click" Text=" Cadastrar novo serviço" Style="float: right; margin: 0 5px 5px 5px; cursor: pointer; color: inherit !important; text-decoration: none !important;" />
            <asp:Label ID="fbse" runat="server" Text="Nada de viajar no tempo" Visible="false" Style="background: #ff6a00; height: 38px; margin-top: -8px; line-height: 20px; padding: 10px;"></asp:Label>
            <asp:Label ID="fbLimite" runat="server" Text="" Visible="false" Style="background: #ff6a00; height: 38px; margin-top: -8px; line-height: 20px; padding: 10px; cursor: default;"></asp:Label>
            <asp:Label ID="fbUnlimited" runat="server" Text="Publicações Ilimitadas" Visible="true" Style="background: #00e888; height: 38px; margin-top: -8px; line-height: 20px; padding: 10px; cursor: default;"></asp:Label>
        </div>



        <div id="demo" style="padding-left: 50px !important">

            <!-- panel -->
            <div class="row">
                <div class="jplist-panel">

                    <div class="jplist-drop-down" data-control-type="items-per-page-drop-down" data-control-name="paging" data-control-action="paging">
                        <div class="jplist-dd-panel">10 por página </div>
                        <ul style="display: none;">
                            <li class=""><span data-number="3">3 per page </span></li>
                            <li class=""><span data-number="5">5 per page </span></li>
                            <li class="active"><span data-number="10" data-default="true">10 per page </span></li>
                            <li><span data-number="15">15 per page </span></li>
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

                    <div class="jplist-label" data-type="Page {current} of {pages}" data-control-type="pagination-info" data-control-name="paging" data-control-action="paging"></div>

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
                <asp:Literal ID="Literal1" runat="server">
                </asp:Literal>


            </div>

            <!-- no results found -->
            <div class="jplist-no-results">
                <p>No results found</p>
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
        <div class="col-lg-12">
        </div>
        <!-- <div class="col-lg-3">
            <b class="glyphicon glyphicon-edit">Editar</b><br />
            <asp:DropDownList ID="ddlEdit" runat="server" CssClass="form-horizontal" OnSelectedIndexChanged="ddlEdit_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList><br />
            <br />
            <b class="glyphicon glyphicon-trash">Excluir</b><br />
            <asp:DropDownList ID="ddlDelete" runat="server" CssClass="form-horizontal" OnSelectedIndexChanged="ddlDelete_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        </div> -->
    </div>



    <!-- jquery library -->
    <script src="../js/jquery-3.1.1.min.js"></script>

    <!-- jPList Core -->
    <script src="../js/jplist-master/dist/js/jplist.core.min.js"></script>

    <!-- jPList Sort Bundle -->
    <script src="../js/jplist-master/dist/js/jplist.sort-bundle.min.js"></script>

    <!-- jPList Pagination Bundle -->
    <script src="../js/jplist-master/dist/js/jplist.pagination-bundle.min.js"></script>

    <!-- Textbox Filter Control -->
    <script src="../js/jplist-master/dist/js/jplist.textbox-filter.min.js"></script>

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

    <script src="jsExcluir.js">
    </script>

    <script type="text/javascript">
        function openModal() {
            $('#meuModal').modal('show');
        }
        function openModalLimite() {
            $('#modalLimite').modal('show');
        }
    </script>
</asp:Content>

