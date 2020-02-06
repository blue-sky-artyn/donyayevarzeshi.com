<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="picture-gallery.aspx.cs" Inherits="admin_Default" %>

<%-- Add content controls here --%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <style>
        .slider-details {
            margin: 5px 0;
        }

        .close-btn-slider {
            border: none;
        }

        .normal-btn {
            background: #B52E31;
            padding: 10px 20px;
            font-size: 1em;
            color: #fff;
            text-decoration: none;
            display: block;
            font-weight: 600;
            text-align: center;
            margin-bottom: 2em;
            border: none;
        }

            .normal-btn:hover {
                background: #252525;
            }

        .li-slider {
            list-style: none;
        }
    </style>


    <div class="content">

        <!--//area-->

        <div class="col-md-12 mid-content">
            <div id="sliderHtml" runat="server" class="middle-content">
                <h3>Picture Gallery</h3>
            </div>
            <!--//sreen-gallery-cursual---->
        </div>
        <div class="clearfix"></div>
        <div class="women_main">
            <!-- start content -->

            <div class="check">
                <div>
                    <div id="galleryHtml" runat="server" class="row">
                    <h1>Slider item</h1>


                    <div class="clearfix"></div>

                    </div>
                </div>
            </div>
        </div>

        <div class="fo-top-di">
            <div class="foot-top">
                <h1>New Item:</h1>
                <div class="col-md-6 s-c">
                    <div class="fooll">
                        <h1>* Please choose a picture </h1>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="col-md-6 s-c">
                    <div class="stay">



                        <div class="stay-left">
                            <fieldset class="div_top">
                                <legend>File input</legend>
                                <asp:FileUpload ID="fuGallery" runat="server" Style="margin: 3%" />
                            </fieldset>
                        </div>

                        <div class="clearfix"></div>

                    </div>
                </div>




                <div class="col-md-12 our-st">
                    <div class="our-left">
                        <h4>Details</h4>
                    </div>
                    <ul>
                        <li class="slider-details">
                            <asp:Label ID="lblTitle" runat="server" Text="Enter title:"></asp:Label>
                            <asp:TextBox ID="txtTitle" runat="server" placeholder="Eg. an example of title to show in slider" Width="100%"></asp:TextBox>
                        </li>
                        <li>
                            <asp:Label ID="lblDetails" runat="server" Text="Enter details:"></asp:Label>
                            <asp:TextBox ID="txtDetail" runat="server" placeholder="Eg. details to show in slider" Width="100%" TextMode="MultiLine"></asp:TextBox>
                        </li>
                    </ul>
                    <asp:Label ID="lblError" runat="server" Text="" ForeColor="#B52E31"></asp:Label>
                    <asp:Button ID="btnAdd" runat="server" CssClass="close-btn-slider normal-btn" Text="ADD" OnClick="btnAdd_Click" />
                </div>




                <div class="clearfix"></div>

            </div>

            <div class="footer">
                <div class="clearfix"></div>
                <p>All Rights Reserved | Design by <a href="mailto:i8net2000@yahoo.com">Farhad Taheri</a></p>
            </div>
        </div>
    </div>
    <!--content-->
</asp:Content>
