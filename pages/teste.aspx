<%@ Page Language="C#" AutoEventWireup="true" CodeFile="teste.aspx.cs" Inherits="pages_teste" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../js/jplist-master/dist/css/jplist.demo-pages.min.css" rel="stylesheet" />
    <link href="../js/jplist-master/dist/css/jplist.core.min.css" rel="stylesheet" />
    <link href="../js/jplist-master/dist/css/jplist.filter-toggle-bundle.min.css" rel="stylesheet" />
    <link href="../js/jplist-master/dist/css/jplist.pagination-bundle.min.css" rel="stylesheet" />
    <link href="../js/jplist-master/dist/css/jplist.history-bundle.min.css" rel="stylesheet" />
    <link href="../js/jplist-master/dist/css/jplist.jquery-ui-bundle.min.css" rel="stylesheet" />
    <link href="../js/jplist-master/dist/css/jplist.textbox-filter.min.css" rel="stylesheet" />
    <link href="../js/jplist-master/dist/css/jquery-ui.css" rel="stylesheet" />
    <script src="../js/jquery-2.1.1.js"></script>
    <script src="../js/jplist-master/dist/js/jplist.core.min.js"></script>
    <script src="../js/jplist-master/dist/js/jplist.filter-dropdown-bundle.min.js"></script>
    <script src="../js/jplist-master/dist/js/jplist.filter-toggle-bundle.min.js"></script>
    <script src="../js/jplist-master/dist/js/jplist.history-bundle.min.js"></script>
    <script src="../js/jplist-master/dist/js/jplist.jquery-ui-bundle.min.js"></script>
    <script src="../js/jplist-master/dist/js/jplist.pagination-bundle.min.js"></script>
    <script src="../js/jplist-master/dist/js/jplist.sort-bundle.min.js"></script>
    <script src="../js/jplist-master/dist/js/jplist.textbox-filter.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
        <div id="demo" class="box jplist jplist-grid-view">

            <!-- ios button: show/hide panel -->

            <div class="jplist-ios-button">
                <i class="fa fa-sort"></i>
                jPList Actions
            </div>

            <!-- panel -->
            <div class="jplist-panel box panel-top">

                <!-- reset button -->
                <button type="button" class="jplist-reset-btn" data-control-type="reset" data-control-name="reset" data-control-action="reset">
                    Reset &nbsp;<i class="fa fa-share"></i>
                </button>

                <div class="jplist-drop-down" data-control-type="items-per-page-drop-down" data-control-name="paging" data-control-action="paging">
                    <div class="jplist-dd-panel">10 per page </div>
                    <ul style="display: none;">
                        <li class=""><span data-number="5">5 per page </span></li>
                        <li class="active"><span data-number="10" data-default="true">10 per page </span></li>
                        <li><span data-number="15">15 per page </span></li>
                        <li><span data-number="all">View All </span></li>
                    </ul>
                </div>

                <div class="jplist-drop-down" data-control-type="sort-drop-down" data-control-name="sort" data-control-action="sort">
                    <div class="jplist-dd-panel">Likes asc</div>
                    <ul style="display: none;">
                        <li class=""><span data-path="default">Sort by</span></li>
                        <li><span data-path=".title" data-order="asc" data-type="text">Title A-Z</span></li>
                        <li><span data-path=".title" data-order="desc" data-type="text">Title Z-A</span></li>
                        <li><span data-path=".desc" data-order="asc" data-type="text">Description A-Z</span></li>
                        <li><span data-path=".desc" data-order="desc" data-type="text">Description Z-A</span></li>
                        <li class="active"><span data-path=".like" data-order="asc" data-type="number" data-default="true">Likes asc</span></li>
                        <li><span data-path=".like" data-order="desc" data-type="number">Likes desc</span></li>
                        <li><span data-path=".date" data-order="asc" data-type="datetime">Date asc</span></li>
                        <li><span data-path=".date" data-order="desc" data-type="datetime">Date desc</span></li>
                    </ul>
                </div>

                <!-- filter by title -->
                <div class="text-filter-box">

                    <i class="fa fa-search  jplist-icon"></i>

                    <!--[if lt IE 10]>
			<div class="jplist-label">Filter by Title:</div>
			<![endif]-->

                    <input data-path=".title" type="text" value="" placeholder="Filter by Title" data-control-type="textbox" data-control-name="title-filter" data-control-action="filter">
                </div>


                <!-- filter by description -->
                <div class="text-filter-box">

                    <i class="fa fa-search  jplist-icon"></i>

                    <!--[if lt IE 10]>
			<div class="jplist-label">Filter by Description:</div>
			<![endif]-->

                    <input data-path=".desc" type="text" value="" placeholder="Filter by Description" data-control-type="textbox" data-control-name="desc-filter" data-control-action="filter">
                </div>

                <!-- views -->
                <div class="jplist-views" data-control-type="views" data-control-name="views" data-control-action="views" data-default="jplist-grid-view">

                    <button type="button" class="jplist-view jplist-list-view" data-type="jplist-list-view"></button>
                    <button type="button" class="jplist-view jplist-grid-view" data-type="jplist-grid-view"></button>
                    <button type="button" class="jplist-view jplist-thumbs-view" data-type="jplist-thumbs-view"></button>
                </div>

                <!-- pagination results -->
                <div class="jplist-label" data-type="Page {current} of {pages}" data-control-type="pagination-info" data-control-name="paging" data-control-action="paging">Page 1 of 4</div>

                <!-- pagination -->
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

            <!-- data -->
            <div class="list box text-shadow">
                <asp:Literal ID="LiteralServices" runat="server" Text=""></asp:Literal>
            </div>

            <div class="box jplist-no-results text-shadow align-center jplist-hidden">
                <p>No results found</p>
            </div>

            <!-- ios button: show/hide panel -->
            <div class="jplist-ios-button">
                <i class="fa fa-sort"></i>
                jPList Actions
            </div>

            <!-- panel -->
            <div class="jplist-panel box panel-bottom">

                <div class="jplist-drop-down" data-control-type="items-per-page-drop-down" data-control-name="paging" data-control-action="paging" data-control-animate-to-top="true">
                    <div class="jplist-dd-panel">10 per page </div>
                    <ul style="display: none;">
                        <li class=""><span data-number="5">5 per page </span></li>
                        <li class="active"><span data-number="10" data-default="true">10 per page </span></li>
                        <li><span data-number="15">15 per page </span></li>
                        <li><span data-number="all">View All </span></li>
                    </ul>
                </div>
                <div class="jplist-drop-down" data-control-type="sort-drop-down" data-control-name="sort" data-control-action="sort" data-control-animate-to-top="true">
                    <div class="jplist-dd-panel">Likes asc</div>
                    <ul style="display: none;">
                        <li class=""><span data-path="default">Sort by</span></li>
                        <li><span data-path=".title" data-order="asc" data-type="text">Title A-Z</span></li>
                        <li><span data-path=".title" data-order="desc" data-type="text">Title Z-A</span></li>
                        <li><span data-path=".desc" data-order="asc" data-type="text">Description A-Z</span></li>
                        <li><span data-path=".desc" data-order="desc" data-type="text">Description Z-A</span></li>
                        <li><span data-path=".date" data-order="asc" data-type="datetime">Date asc</span></li>
                        <li><span data-path=".date" data-order="desc" data-type="datetime">Date desc</span></li>
                    </ul>
                </div>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
</asp:Content>

                <!-- pagination -->
                <div class="jplist-pagination" data-control-type="pagination" data-control-name="paging" data-control-action="paging" data-control-animate-to-top="true">
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
    </div>
    </form>
    <script>
        $(document).ready(function () {
            $('#demo').jplist({
                itemsBox: '.list'
               , itemPath: '.list-item'
               , panelPath: '.jplist-panel'
            });
        })
    </script>
</body>
</html>
