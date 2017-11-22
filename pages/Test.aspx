<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="pages_Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="demo">

        <!-- panel -->
        <div class="jplist-panel">

            <!-- filter by title -->
            <div class="text-filter-box">
                <i class="fa fa-search  jplist-icon"></i>
                <input
                    data-path=".title"
                    type="text"
                    value=""
                    placeholder="Filter by Title"
                    data-control-type="textbox"
                    data-control-name="title-filter"
                    data-control-action="filter" />
            </div>

        </div>

        <!-- HTML data -->
        <div class="list">

            <!-- item 1 -->
            <div class="list-item">
                <p class="title">Architecture</p>
            </div>

            <!-- item 2 -->
            <div class="list-item">
                <p class="title">Autumn</p>
            </div>

            <!-- item 3 -->
            <div class="list-item">
                <p class="title">Boats</p>
            </div>

            <!-- item 4 -->
            <div class="list-item">
                <p class="title">Arch</p>
            </div>

            <!-- item 5 -->
            <div class="list-item">
                <p class="title">Books</p>
            </div>

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
    <link href="../js/jplist-master/dist/css/jplist.core.min.css" rel="stylesheet" type="text/css" />

    <!-- jPList Sort Bundle -->
    <script src="../js/jplist-master/dist/js/jplist.sort-bundle.min.js"></script>

    <!-- jPList Pagination Bundle -->
    <script src="../js/jplist-master/dist/js/jplist.pagination-bundle.min.js"></script>

    <!-- Textbox Filter Control -->
    <script src="../js/jplist-master/dist/js/jplist.textbox-filter.min.js"></script>
    <link href="../js/jplist-master/dist/css/jplist.textbox-filter.min.css" rel="stylesheet" type="text/css" />

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

