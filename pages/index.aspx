<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="pages_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function openModalS() {
            $('#fbSuccess').modal('show');
        }
        function openModalE() {
            $('#fbError').modal('show');
        }
        function openModalCb() {
            $('#fbCb').modal('show');
        }
        function openModalP() {
            $('#fbPass').modal('show');
            $("#txtSenha").css("border", "1px solid #ff0000");
        }
        function openModalToU() {
            $('#termsOfUseModal').modal('show');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="fbSuccess" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Cadastro E-Van</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-ok col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Cadastrado com Sucesso</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div id="termsOfUseModal" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 800px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Termos de Uso</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-file col-xs-12 text-center" style="font-size: 40px;"></p>
                            <br />
                            <p class="text-justify">
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce ultrices nisi neque, posuere facilisis justo elementum quis. Fusce neque tortor, vehicula a tempus eget, hendrerit a dui. Aenean et sollicitudin magna, nec consectetur mauris. Suspendisse eget felis iaculis, commodo neque a, finibus risus. Donec egestas risus pellentesque elit vestibulum, id pellentesque urna bibendum. Praesent feugiat nunc nec orci congue consectetur. Quisque porttitor cursus mi, ac tristique purus tristique sit amet. Suspendisse pulvinar, nunc sagittis pellentesque porttitor, ante erat placerat libero, vel convallis massa est sit amet augue. Praesent a elit vel est laoreet suscipit. In eleifend mi ut elit gravida pharetra. In laoreet metus ac dui blandit, ut bibendum sapien lobortis. Vestibulum ac pretium arcu.

Nullam tincidunt rutrum arcu rhoncus commodo. Vestibulum sit amet velit lobortis, fermentum lectus nec, pretium sem. Donec ac nunc vitae tortor convallis lobortis. Nulla eleifend aliquam aliquam. In eget eros non mauris gravida dictum. Nunc aliquet dolor gravida magna finibus, ac eleifend mauris commodo. In varius, turpis quis luctus tristique, odio lacus venenatis leo, sed condimentum ligula arcu ut arcu. Proin consectetur justo tortor, a finibus lacus egestas vel. Praesent ultricies placerat eros, a facilisis velit efficitur eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nullam iaculis nibh at malesuada mattis. Quisque sed ultricies orci. Morbi hendrerit ultricies libero, vitae sollicitudin nulla luctus vel. Etiam auctor, nibh id consectetur imperdiet, quam ante congue diam, eget vestibulum mi ipsum a tortor.

Nunc tempus fringilla lectus, eu aliquam magna tincidunt vel. Nulla quis libero ut orci vehicula tincidunt. Phasellus vel pellentesque lorem, vel sagittis est. In porta non nulla et sollicitudin. Proin luctus lorem imperdiet pharetra gravida. Vivamus in auctor eros, non dapibus eros. Vestibulum elementum et orci et cursus. Mauris sodales elit at congue interdum. Praesent pretium mi et velit pretium maximus. Mauris sagittis urna ex, luctus dapibus arcu consequat ut. Fusce in condimentum est. Ut euismod augue non lectus aliquam, et pretium est euismod. Ut sed felis turpis. Curabitur condimentum, libero id pretium aliquet, lorem sapien pharetra lorem, sagittis pretium est metus fringilla mi.

Morbi arcu arcu, finibus sed ligula eu, placerat venenatis quam. Aenean purus urna, scelerisque in tortor sed, lobortis facilisis elit. Nullam condimentum accumsan nibh lobortis tincidunt. Nullam eleifend sed sapien id venenatis. Duis ligula elit, hendrerit sed turpis et, semper pharetra lacus. Morbi lectus erat, pharetra in nisi vitae, accumsan blandit odio. Vivamus sodales dolor metus, fermentum pellentesque eros ultricies eu. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Curabitur ullamcorper a augue in sollicitudin. Fusce hendrerit varius leo eget semper. Cras non nisl sed arcu cursus suscipit. Maecenas ipsum tortor, congue ut interdum vulputate, congue in enim. Cras eget condimentum justo. Etiam fringilla facilisis eros placerat vulputate. Cras mattis nisi a finibus gravida. Curabitur sed molestie nibh.

Mauris malesuada ultrices vestibulum. Curabitur sit amet elementum nulla. Donec malesuada fringilla tempor. Aliquam sed risus scelerisque, congue dui in, ultricies nisi. Fusce a rutrum nulla. Nullam at justo in orci facilisis pharetra quis a augue. Donec condimentum posuere velit, sed congue sapien venenatis nec. Fusce tristique at eros ut ultrices. Cras velit enim, sollicitudin in arcu sit amet, blandit placerat tellus.
                            </p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div id="fbCb" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Cadastro E-Van</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-file col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Para prosseguir você deve concordar com os <a href="termsOfUse.aspx" style="color:#0094ff !important;">Termos de Uso</a></p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div id="fbError" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Cadastro E-Van</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-remove col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Ocorreu um erro, por favor verifique os campos e tente novamente</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div id="fbPass" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Cadastro E-Van</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-alert col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">As senhas não conferem</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

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

                <!-- Panel Passageiro -->
                <asp:Panel ID="pPassageiro" runat="server" Visible="true"><br />
                    <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" CssClass="form-control" required="required"></asp:TextBox><br />
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="E-Mail" CssClass="form-control" TextMode="Email" required="required"></asp:TextBox><br />
                    <div class="row">
                        <div class="col-lg-9">
                            <asp:TextBox ID="txtSenha" runat="server" placeholder="Senha" CssClass="form-control" TextMode="Password" required="required" onkeyup="CheckPasswordStrength(this.value)"></asp:TextBox>
                        </div>
                        <div class="col-lg-3">
                            <span id='ajuda' class="glyphicon glyphicon-asterisk" style="cursor: default;">Recomendação de senha</span>
                            <br />
                            <p id="ajudaSenha" style="width: 300px; height: 100px; background: #ffffff; float: right; display: none; text-align: justify; box-shadow: 1px 1px 5px #000; padding: 5px;">
                                É recomendável uma senha que contenha acima de 8 caracteres e contenha letras (maiusculas e minusculas), números e caracteres especiais
                            </p>
                        </div>
                    </div>
                    <br />
                    <span id="password_strength"></span>

                    <asp:TextBox ID="txtSenha2" runat="server" placeholder="Confirmação de Senha" CssClass="form-control" TextMode="Password" required="required"></asp:TextBox><br />
                    <asp:TextBox ID="txtCpf" runat="server" placeholder="CPF" CssClass="form-control" required="required"></asp:TextBox><br />
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
                        
                    </div>
                </asp:Panel>

                <!-- Painel Motorista -->
                <asp:Panel ID="pMotorista" runat="server" Visible="false">
                    <asp:TextBox ID="txtNomeM" runat="server" placeholder="Nome Completo" CssClass="form-control" required="required"></asp:TextBox><br />
                    <asp:TextBox ID="txtEmailM" runat="server" placeholder="E-Mail" CssClass="form-control" TextMode="Email" required="required"></asp:TextBox><br />
                   
                    <div class="row">
                        <div class="col-lg-9">
                            <asp:TextBox ID="txtSenhaM" runat="server" placeholder="Senha" CssClass="form-control" TextMode="Password" required="required" onkeyup="CheckPasswordStrength2(this.value)"></asp:TextBox><br />
                            <span id="password_strength2"></span>
                        </div>
                        <div class="col-lg-3">
                            <span id='ajudam' class="glyphicon glyphicon-asterisk" style="cursor: default;">Recomendação de senha</span>
                            <br />
                            <p id="ajudaSenham" style="width: 300px; height: 100px; background: #ffffff; float: right; display: none; text-align: justify; box-shadow: 1px 1px 5px #000; padding: 5px;">
                                É recomendável uma senha que contenha acima de 8 caracteres e contenha letras (maiusculas e minusculas), números e caracteres especiais
                            </p>
                        </div>
                    </div>

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
                        
                    </div>
                </asp:Panel>

                <br />
                <div class="row">
                    <div class="col-lg-9">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Li e concordo com os Termos de Uso." CssClass="checkbox" />
                        <p>Clique <span style="color:#0094ff !important; cursor:pointer;" onclick="openModalToU()">aqui</span> para ler os Termos de Uso</p>
                    </div>
                    <div class="col-sm-2">
                    </div>
                </div>

                <br />
                <br />
                
                <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
                <p id="feedback" style="display:none; color:#ff0000;">É necessário uma senha no mínimo boa para cadastrar-se no sistema.<br />Digite uma senha melhor.</p>
                <asp:Button ID="btnCadastrar" ClientIDMode="Static" runat="server" Text="Cadastrar" CssClass="btn btn-info" OnClick="btnCadastrar_Click" />
            </div>
        </div>
    </div>
</asp:Content>

