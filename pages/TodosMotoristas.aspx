﻿<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="TodosMotoristas.aspx.cs" Inherits="pages_TodosMotoristas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <div class="title">Principais Serviços</div>

            <a href="serviceInfo.aspx" class="dblock">
                <div class="serviceBox">
                    <div class="title">João</div>
                    <div class="padding">
                        <table border="0">
                            <tr>
                                <td>
                                    <b>Cidade:&nbsp</b>Guaratingueta<br />
                                    <b>Tipo de Veiculo:&nbsp</b>Van<br />
                                    <br />
                                    
                                    <span class="glyphicon glyphicon-star"></span>
                                    <span class="glyphicon glyphicon-star"></span>
                                    <span class="glyphicon glyphicon-star"></span>
                                    <span class="glyphicon glyphicon-star-empty"></span>
                                    <span class="glyphicon glyphicon-star-empty"></span>
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
    </div>
    <div class="getDown"></div>
</asp:Content>

