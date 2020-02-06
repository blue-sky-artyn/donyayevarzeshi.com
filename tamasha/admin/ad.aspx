<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="ad.aspx.cs" Inherits="admin_gallery_normal" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <style>
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
            <div class="w_content">
                <div class="col-md-12">
                    <h2 class="inner-tittle">Add an advertisment</h2>
                    <div>
                        <div class="form-group">
                            Title:
                            <asp:TextBox ID="txtTitle" runat="server" Width="100%"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            Description:
                            <CKEditor:CKEditorControl ID="ckDetails" class="form-control"  runat="server" placeholder="A short detail" Width="100%"></CKEditor:CKEditorControl>
                        </div>
                        <div class="form-group">
                            <fieldset class="div_top">
                                <legend>Select ad File:</legend>
                                <asp:FileUpload ClientIDMode="Static" ID="fuGallery" runat="server" Style="margin: 3%" />
                            </fieldset>
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
                            <input type="radio" name="myradio" clientidmode="Static" runat="server" id="rb1" class="rb-inputs" value="0" checked /><label for="rb1">Exact Day</label><br />
                            <input type="radio" name="myradio" clientidmode="Static" runat="server" id="rb2" class="rb-inputs" value="1" /><label for="rb1">Period</label><br />


                            <div class="form-group">
                                <asp:TextBox ID="txtExp" runat="server" ClientIDMode="Static" class="form-control" placeholder="20190812" Width="50%"></asp:TextBox>
                                <p class="comment-text">* If leave it blank,there is no expiery day.</p>
                            </div>
                            <div class="form-group">
                                <asp:DropDownList ClientIDMode="Static" ID="ddlExp" runat="server">
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
                        <div class="form-group">
                        </div>
                        <div style="clear: both;">
                            <asp:Label ID="lblError" runat="server" Text="" ForeColor="#FF3300"></asp:Label>
                            <asp:Button ID="btnAdd" runat="server" CssClass="btn-add-ad" Text="ADD" OnClick="btnAdd_Click" />
                        </div>
                    </div>
                </div>




                <div class="women">
                    <a href="#">
                        <h4>Add advertisments</h4>
                    </a>
                    <%--<ul class="w_nav">
                        <li>Sort : </li>
                        <li><a class="active" href="#">Price: low </a></li>
                        |
		     			<li><a href="#">Price: high </a></li>
                        |
		     			<li><a href="#">Arrival </a></li>
                        |
		     			<li><a href="#">Group </a></li>
                        |
		     			<li><a href="#">Clear </a></li>
                        <div class="clear"></div>
                    </ul>--%>
                    <div class="clearfix"></div>
                </div>
                <!-- grids_of_4 -->
                <div id="adHtml" runat="server">
                    <div class="grids_of_4">
                        <div class="grid1_of_4">
                            <div class="content_box">
                                <a href="details.html">
                                    <img src="../images/gallery/1.jpg" class="img-responsive" alt="">
                                </a>
                                <h4><a href="details.html">Carpet type </a></h4>
                                <p>Carpet details</p>
                                <div class="grid_1 simpleCart_shelfItem">

                                    <div class="item_add">
                                        <span class="item_price">
                                            <h6>ONLY $109.00</h6>
                                        </span>
                                    </div>
                                    <div class="item_add">
                                        <span class="item_price"><a href="#">EDIT</a></span>
                                        <span class="item_price"><a href="#">DELETE</a></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="grid1_of_4">
                            <div class="content_box">
                                <a href="details.html">
                                    <img src="../images/gallery/2.jpg" class="img-responsive" alt="">
                                </a>
                                <h4><a href="details.html">Duis autem</a></h4>
                                <p>It is a long established fact that</p>
                                <div class="grid_1 simpleCart_shelfItem">

                                    <div class="item_add">
                                        <span class="item_price">
                                            <h6>ONLY $95.00</h6>
                                        </span>
                                    </div>
                                    <div class="item_add"><span class="item_price"><a href="#">add to cart</a></span></div>
                                </div>
                            </div>
                        </div>
                        <div class="grid1_of_4">
                            <div class="content_box">
                                <a href="details.html">
                                    <img src="../images/gallery/3.jpg" class="img-responsive" alt="">
                                </a>
                                <h4><a href="details.html">Duis autem</a></h4>
                                <p>It is a long established fact that</p>
                                <div class="grid_1 simpleCart_shelfItem">

                                    <div class="item_add">
                                        <span class="item_price">
                                            <h6>ONLY $68.00</h6>
                                        </span>
                                    </div>
                                    <div class="item_add"><span class="item_price"><a href="#">add to cart</a></span></div>
                                </div>
                            </div>
                        </div>
                        <div class="grid1_of_4">
                            <div class="content_box">
                                <a href="details.html">
                                    <img src="../images/gallery/4.jpg" class="img-responsive" alt="">
                                </a>
                                <h4><a href="details.html">Duis autem</a></h4>
                                <p>It is a long established fact that</p>
                                <div class="grid_1 simpleCart_shelfItem">

                                    <div class="item_add">
                                        <span class="item_price">
                                            <h6>ONLY $74.00</h6>
                                        </span>
                                    </div>
                                    <div class="item_add"><span class="item_price"><a href="#">add to cart</a></span></div>
                                </div>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="grids_of_4">
                        <div class="grid1_of_4">
                            <div class="content_box">
                                <a href="details.html">
                                    <img src="../images/gallery/5.jpg" class="img-responsive" alt="">
                                </a>
                                <h4><a href="details.html">Duis autem</a></h4>
                                <p>It is a long established fact that</p>
                                <div class="grid_1 simpleCart_shelfItem">

                                    <div class="item_add">
                                        <span class="item_price">
                                            <h6>ONLY $80.00</h6>
                                        </span>
                                    </div>
                                    <div class="item_add"><span class="item_price"><a href="#">add to cart</a></span></div>
                                </div>
                            </div>
                        </div>
                        <div class="grid1_of_4">
                            <div class="content_box">
                                <a href="details.html">
                                    <img src="../images/gallery/6.jpg" class="img-responsive" alt="">
                                </a>
                                <h4><a href="details.html">Duis autem</a></h4>
                                <p>It is a long established fact that</p>
                                <div class="grid_1 simpleCart_shelfItem">

                                    <div class="item_add">
                                        <span class="item_price">
                                            <h6>ONLY $65.00</h6>
                                        </span>
                                    </div>
                                    <div class="item_add"><span class="item_price"><a href="#">add to cart</a></span></div>
                                </div>
                            </div>
                        </div>
                        <div class="grid1_of_4">
                            <div class="content_box">
                                <a href="details.html">
                                    <img src="../images/gallery/7.jpg" class="img-responsive" alt="">
                                </a>
                                <h4><a href="details.html">Duis autem</a></h4>
                                <p>It is a long established fact that</p>
                                <div class="grid_1 simpleCart_shelfItem">

                                    <div class="item_add">
                                        <span class="item_price">
                                            <h6>ONLY $90.00</h6>
                                        </span>
                                    </div>
                                    <div class="item_add"><span class="item_price"><a href="#">add to cart</a></span></div>
                                </div>
                            </div>
                        </div>
                        <div class="grid1_of_4">
                            <div class="content_box">
                                <a href="details.html">
                                    <img src="../images/gallery/8.jpg" class="img-responsive" alt="">
                                </a>
                                <h4><a href="details.html">Duis autem</a></h4>
                                <p>It is a long established fact that</p>
                                <div class="grid_1 simpleCart_shelfItem">

                                    <div class="item_add">
                                        <span class="item_price">
                                            <h6>ONLY $75.00</h6>
                                        </span>
                                    </div>
                                    <div class="item_add"><span class="item_price"><a href="#">add to cart</a></span></div>
                                </div>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="grids_of_4">
                        <div class="grid1_of_4">
                            <div class="content_box">
                                <a href="details.html">
                                    <img src="../images/gallery/9.jpg" class="img-responsive" alt="">
                                </a>
                                <h4><a href="details.html">Duis autem</a></h4>
                                <p>It is a long established fact that</p>
                                <div class="grid_1 simpleCart_shelfItem">

                                    <div class="item_add">
                                        <span class="item_price">
                                            <h6>ONLY $99.00</h6>
                                        </span>
                                    </div>
                                    <div class="item_add"><span class="item_price"><a href="#">add to cart</a></span></div>
                                </div>
                            </div>
                        </div>
                        <div class="grid1_of_4">
                            <div class="content_box">
                                <a href="details.html">
                                    <img src="../images/gallery/2.jpg" class="img-responsive" alt="">
                                </a>
                                <h4><a href="details.html">Duis autem</a></h4>
                                <p>It is a long established fact that</p>
                                <div class="grid_1 simpleCart_shelfItem">

                                    <div class="item_add">
                                        <span class="item_price">
                                            <h6>ONLY $76.00</h6>
                                        </span>
                                    </div>
                                    <div class="item_add"><span class="item_price"><a href="#">add to cart</a></span></div>
                                </div>
                            </div>
                        </div>
                        <div class="grid1_of_4">
                            <div class="content_box">
                                <a href="details.html">
                                    <img src="../images/gallery/3.jpg" class="img-responsive" alt="">
                                </a>
                                <h4><a href="details.html">Duis autem</a></h4>
                                <p>It is a long established fact that</p>
                                <div class="grid_1 simpleCart_shelfItem">

                                    <div class="item_add">
                                        <span class="item_price">
                                            <h6>ONLY $58.00</h6>
                                        </span>
                                    </div>
                                    <div class="item_add"><span class="item_price"><a href="#">add to cart</a></span></div>
                                </div>
                            </div>
                        </div>
                        <div class="grid1_of_4">
                            <div class="content_box">
                                <a href="details.html">
                                    <img src="../images/gallery/4.jpg" class="img-responsive" alt="">
                                </a>
                                <h4><a href="details.html">Duis autem</a></h4>
                                <p>It is a long established fact that</p>
                                <div class="grid_1 simpleCart_shelfItem">

                                    <div class="item_add">
                                        <span class="item_price">
                                            <h6>ONLY $112.00</h6>
                                        </span>
                                    </div>
                                    <div class="item_add"><span class="item_price"><a href="#">add to cart</a></span></div>
                                </div>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>

                </div>


                <!-- end grids_of_4 -->


            </div>
            <div class="clearfix"></div>
            <!-- end content -->

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
</asp:Content>

