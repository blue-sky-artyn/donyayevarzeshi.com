<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="ad-edit.aspx.cs" Inherits="admin_gallery_normal_detail" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <style>
        .btn-in-cp {
            cursor: pointer;
            border: none;
            outline: none;
            display: inline-block;
            font-size: 1em;
            padding: 10px 34px;
            background: #B52E31;
            color: #fff;
            text-transform: uppercase;
            -webkit-transition: all 0.3s ease-in-out;
            -moz-transition: all 0.3s ease-in-out;
            -o-transition: all 0.3s ease-in-out;
            transition: all 0.3s ease-in-out;
        }

            .btn-in-cp:hover {
                background: #252525;
                text-decoration: none;
            }
        /* items to change */
        .change-items {
            margin: 5px 0;
        }

        .left-change-item {
            float: left;
            margin: 0 1%;
            border: 1px solid gray;
            padding: 5px;
            width: 31%;
        }

        .raido-button-list {
            list-style: none;
        }

            .raido-button-list li input {
                float: left;
                margin-right: 5px;
            }

        .textarea-margin-top {
            margin-top: 5px;
        }

        .thumb-image iframe {
            height: 350px;
        }

        .image-extra {
            width: 150px;
            height: 100px;
        }

        .subtitle-news {
            font-style: italic;
            font-size: 14px;
            font-weight: bold;
            text-shadow: grey 1px 1px;
            padding: 0 12px;
            bottom: 15px;
            position: relative;
        }

        .text-line-heigth {
            line-height: 20px;
        }

        .date-exp {
            width: 30%;
            float: left;
        }

        .btn-add-ad {
            position: relative;
            float: right;
            width: 10%;
        }

        .comment-text {
            font-size: 9px;
            color: red;
            padding: 5px;
        }

        .content_box img {
            width: 100%;
            max-height: 250px;
        }
    </style>
    <!--content-->
    <div class="content">
        <div class="women_main">
            <!-- start content -->
            <div class="row single">
                <div class="det">
                    <div class="single_left">
                        <div class="grid images_3_of_2">
                            <div class="flexslider">
                                <!-- FlexSlider -->
                                <script src="js/imagezoom.js"></script>
                                <script defer="" src="js/jquery.flexslider.js"></script>
                                <link rel="stylesheet" href="css/flexslider.css" type="text/css" media="screen">

                                <script>
                                    // Can also be used with $(document).ready()
                                    $(window).load(function () {
                                        $('.flexslider').flexslider({
                                            animation: "slide",
                                            controlNav: "thumbnails"
                                        });
                                    });
                                </script>
                                <!-- //FlexSlider-->



                                <div class="flex-viewport" style="overflow: hidden; position: relative; max-height: min-content;">
                                    <ul class="slides" style="width: 1200%; transition-duration: 0.6s; transform: translate3d(-864px, 0px, 0px);">
                                        <li class="clone" aria-hidden="true" style="width: 288px; float: left; display: block;">
                                            <div id="setPicHtml" runat="server" class="thumb-image">
                                                <img src="../images/gallery/2.jpg" data-imagezoom="true" class="img-responsive" draggable="false">
                                            </div>
                                        </li>

                                    </ul>
                                </div>
                                <ul class="flex-direction-nav">
                                    <li class="flex-nav-prev"><a class="flex-prev" href="#">Previous</a></li>
                                    <li class="flex-nav-next"><a class="flex-next" href="#">Next</a></li>
                                </ul>
                            </div>
                        </div>
                        <div id="adHtml" runat="server" class="desc1 span_3_of_2">
                            <h3>Mehrab</h3>
                            <br>
                            <span class="code">Group: <a>Kashan</a></span>
                            <p>a short decription of the carpet</p>
                            <div class="price">
                                <span class="text">Price:</span>
                                <span class="price-new">$110.00</span><span class="price-old">$100.00</span>
                                <span class="price-tax">
                                    <label class="checkbox">
                                        <input type="checkbox" name="checkbox"><i></i>include Ex Tax: 13%</label></span><br>
                                <span class="points"><small>Discount 20%</small></span><br>
                            </div>
                            <div class="det_nav1">
                                <h4>Select a size :</h4>
                                <div class=" sky-form col col-4">
                                    <ul>
                                        <li>Size: 12*10</li>
                                        <li>/</li>
                                        <li>Color: Red</li>
                                        <li>/</li>
                                        <li>Shape: Sqaure</li>
                                    </ul>
                                </div>
                            </div>


                        </div>


                        <div class="clearfix"></div>

                    </div>




                    <div class="clearfix"></div>
                    <hr />


                    <div class="single_left">
                        <div class="btn_form">
                            <asp:Button ID="btnDel" runat="server" CssClass="btn-in-cp" Text="DEL" OnClick="btnDel_Click" />
                        </div>
                    </div>

                    <div class="grids_of_4">
                        <div class="clearfix"></div>
                        <div class="panel panel-widget forms-panel">
                            <div class="forms">
                                <div class="form-grids widget-shadow" data-example-id="basic-forms">
                                    <div class="form-title">
                                        <h4>Edit news content: </h4>
                                    </div>
                                    <div class="form-body">
                                        <div>

                                            <div class="form-group">
                                                <label for="inputEmail3" class="col-sm-2 control-label">title: </label>
                                                <div class="textarea-margin-top col-sm-9">
                                                    <asp:TextBox ID="txtTitle" class="form-control" runat="server" CssClass="farsi-font-text farsi-direction" placeholder="eg. Give title for educative information" Width="70%"></asp:TextBox>
                                                </div>
                                            </div>

                                            <div class="form-group" style="width: 100%; line-height: 34px; float: left; margin-right: 5px;">
                                                <label for="exampleInputPassword1" style="float: left;">Details: </label>
                                                <CKEditor:CKEditorControl ID="ckDetails" class="form-control"  runat="server" placeholder="A short detail" Width="100%"></CKEditor:CKEditorControl>                                                
                                            </div>

                                            <div class="date-exp">
                                                <label for="field-1-2">Start Date: (required)&nbsp;<span class="at-required-highlight">*</span></label>
                                                <div class="form-group">
                                                    <asp:TextBox ID="txtStart" runat="server" class="form-control" placeholder="20190808" Width="50%"></asp:TextBox>
                                                </div>
                                            </div>

                                            <div class="date-exp">

                                                <label for="field-1-2">Expiery date:</label>
                                                <br />
                                                <div id="rdBtnHtml" runat="server">


                                                    <input type="radio" name="myradio" clientidmode="Static" runat="server" id="rb1" class="rb-inputs" value="0" checked /><label for="rb1">Exact Day</label><br />
                                                    <input type="radio" name="myradio" clientidmode="Static" runat="server" id="rb2" class="rb-inputs" value="1" /><label for="rb1">Period</label><br />
                                                </div>

                                                <div class="form-group">
                                                    <asp:TextBox ID="txtExp" runat="server" ClientIDMode="Static" class="form-control" placeholder="20190812" Width="50%"></asp:TextBox>
                                                    <p class="comment-text">* If leave it blank,there is no expiery day.</p>
                                                </div>
                                                <div class="form-group">
                                                    <asp:DropDownList ClientIDMode="Static" ID="ddlExp" runat="server">
                                                        <asp:ListItem Text="0" Value="0"></asp:ListItem>
                                                        <asp:ListItem Text="1" Value="1" Selected="True"></asp:ListItem>
                                                        <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                                        <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                                        <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                                        <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                                        <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                                        <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                                        <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                                        <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                                        <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                                    </asp:DropDownList>
                                                    <span>Days</span>
                                                </div>
                                            </div>
                                            <div class="date-exp">
                                                <label for="field-1-2">Ad position: (required)&nbsp;<span class="at-required-highlight">*</span></label>
                                                <asp:DropDownList ID="ddlPosition" runat="server">
                                                    <asp:ListItem Text="Top Side" Value="top" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Text="Right Side" Value="right"></asp:ListItem>
                                                    <asp:ListItem Text="Middle" Value="middle"></asp:ListItem>
                                                    <asp:ListItem Text="Bottom" Value="bottom"></asp:ListItem>
                                                </asp:DropDownList>
                                            </div>

                                            <div class="form-group" style="float: left; width: 100%;">
                                                <fieldset class="div_top">
                                                    <legend>* edit ad picture:</legend>
                                                    <asp:FileUpload ID="fuGallery" runat="server" Style="margin: 3%" />
                                                </fieldset>
                                                <p class="help-block">Please choose one picture of item</p>
                                            </div>
                                            <div class="form-group" style="float: left;">
                                                <asp:Label ID="lblError" runat="server" Text="" Visible="false" ForeColor="#B52E31"></asp:Label>
                                                <asp:Button ID="btnAdd" runat="server" class="btn btn-default" Text="UPDATE ITEM" OnClick="btnUpdate_Click" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="single-bottom2">
                        <!-- reserve in order to have cramped space -->
                    </div>
                </div>
            </div>
            <!-- end content -->
        </div>
    </div>
    <script>
        var ddl = document.getElementById("ddlExp");
        var txt = document.getElementById("txtExp");

        var radios = document.getElementsByClassName("rb-inputs");


        ddl.disabled = true;
        ddl.setAttribute("style", "background-color:#eee;");

        for (var i = 0, max = radios.length; i < max; i++) {
            radios[i].onclick = function () {
                if (this.value == 0) {
                    txt.disabled = false;
                    ddl.disabled = true;
                    ddl.setAttribute("style", "background-color:#eee;");
                }
                else if (this.value == 1) {
                    txt.disabled = true;
                    ddl.disabled = false;
                    ddl.style.backgroundcolor = "#eee";
                    ddl.setAttribute("style", "background-color:white;");
                }
            }
        }
    </script>
    <script>
        function disableTextBox() {
            txt.disabled = true;
            ddl.disabled = false;
            ddl.style.backgroundcolor = "#eee";
            ddl.setAttribute("style", "background-color:white;");
        }

        function disableDropDownList() {
            txt.disabled = false;
            ddl.disabled = true;
            ddl.setAttribute("style", "background-color:#eee;");
        }
    </script>
</asp:Content>

