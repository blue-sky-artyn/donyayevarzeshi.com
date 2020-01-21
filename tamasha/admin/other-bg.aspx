<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="other-bg.aspx.cs" Inherits="admin_Default" %>

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
    
        /* Popup container - can be anything you want */
        .popup {
            position: relative;
            /*display: inline-block;*/
            cursor: pointer;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }

            /* The actual popup */
            .popup .popuptext {
                width: 99%;
                background-color: #555;
                color: #fff;
                text-align: center;
                border-radius: 6px;
                padding: 8px 0;
                position: absolute;
                z-index: 1;
                bottom: 125%;
                left: 14%;
                margin-left: -80px;
            }

                /* Popup arrow */
                .popup .popuptext::after {
                    content: "";
                    position: absolute;
                    top: 100%;
                    left: 50%;
                    margin-left: -5px;
                    border-width: 5px;
                    border-style: solid;
                    border-color: #555 transparent transparent transparent;
                }

        /* Toggle this class - hide and show the popup */
        .hidden-item {
            display: none;
        }



        iframe {
            border: none;
            width: 97%;
            min-height: 210px;
        }

        /* The Modal (background) */
        .modal {
            display: none; /* Hidden by default */
            position: fixed; /* Stay in place */
            z-index: 1; /* Sit on top */
            padding-top: 100px; /* Location of the box */
            left: 15%;
            top: 0;
            width: 85%; /* Full width */
            height: 100%; /* Full height */
            overflow: auto; /* Enable scroll if needed */
            background-color: rgb(0,0,0); /* Fallback color */
            background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
        }

        /* Modal Content */
        .modal-content {
            position: relative;
            background-color: #fefefe;
            margin: auto;
            padding: 0;
            border: 1px solid #888;
            width: 80%;
            box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2),0 6px 20px 0 rgba(0,0,0,0.19);
            -webkit-animation-name: animatetop;
            -webkit-animation-duration: 0.4s;
            animation-name: animatetop;
            animation-duration: 0.4s
        }

        /* Add Animation */
        @-webkit-keyframes animatetop {
            from {
                top: -300px;
                opacity: 0
            }

            to {
                top: 0;
                opacity: 1
            }
        }

        @keyframes animatetop {
            from {
                top: -300px;
                opacity: 0
            }

            to {
                top: 0;
                opacity: 1
            }
        }

        /* The Close Button */
        .close {
            color: white;
            float: right;
            font-size: 28px;
            font-weight: bold;
        }

            .close:hover,
            .close:focus {
                color: #000;
                text-decoration: none;
                cursor: pointer;
            }

        .modal-header {
            padding: 2px 16px;
            background-color: #b52e31;
            color: white;
        }
        .modal-header h2 {
            font-size: 20px;
        }
        .modal-body {
            padding: 2px 16px;
        }
        .modal-body select,input,textarea {
            margin: 5px 0;
        }
        .modal-body span{
            float: left;
            margin-right: 5px;
        }
        .modal-footer {
            padding: 4px 16px;
            background-color: #b52e31;
            color: white;
        }
        .modal-footer h3 {
            margin-top: 1%;
            float: left;
        }
        .modal-footer input {
            margin-top: 1%;
        }
    </style>

    <div class="content">

        <!--//area-->

        <div class="col-md-12 mid-content">
            <div id="sliderHtml" runat="server" class="middle-content">
                <h3>Slider show first page</h3>
            </div>
            <!--//sreen-gallery-cursual---->
        </div>
        <div class="clearfix"></div>
        <div class="women_main">
            <!-- start content -->
           
            <div class="check">
                <div class="col-md-12 cart-items">
                    <h1>Slider item</h1>
                    <div id="slidersUpdateHtml" runat="server" class="cart-header">
                        <div class="col-md-6 cart-sec simpleCart_shelfItem">
                            <div class="cart-item cyc">
                                <img src="../images/logo.png" class="img-responsive" alt="">
                            </div>
                            <div class="cart-item-info">
                               <ul class="li-slider">
                                   <li class="slider-details">Slider Title:
                                       <asp:TextBox ID="txtUpdateTitle" runat="server" Width="95%"></asp:TextBox>
                                   </li>
                                   <li class="slider-details">Slider Detail:
                                       <asp:TextBox ID="txtUpdateDetail" runat="server" Width="100%" TextMode="MultiLine"></asp:TextBox>
                                   </li>
                                </ul>
                                <%--<asp:Button ID="btnEdit" runat="server" class="normal-btn" Text="EDIT" style="width: 20%;" OnClick="btnEdit_Click"/>--%>
                            </div>
                            <div class="clearfix"></div>

                        </div>
                        <div class="col-md-6 cart-sec simpleCart_shelfItem">
                            <div class="cart-item cyc">
                                <img src="../images/logo.png" class="img-responsive" alt="">
                            </div>
                            <div class="cart-item-info">
                               <ul class="li-slider">
                                   <li class="slider-details">Slider Title:
                                       <asp:TextBox ID="TextBox1" runat="server" Width="95%"></asp:TextBox>
                                   </li>
                                   <li class="slider-details">Slider Detail:
                                       <asp:TextBox ID="TextBox2" runat="server" Width="100%" TextMode="MultiLine"></asp:TextBox>
                                   </li>
                                </ul>
                                
                            </div>
                            <div class="clearfix"></div>

                        </div>
                        </div>
                    </div>
                    
                </div>

                <div class="clearfix"></div>
            </div>

        </div>

        <div class="fo-top-di">
            <div class="foot-top">

                <div class="col-md-6 s-c">
                    <li>
                        <div class="fooll">
                            <h1>* Please choose a picture </h1>
                        </div>
                    </li>
                    <li></li>
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
                <div class="clearfix"></div>

            </div>
            <div class="footer">

                <div class="col-md-5 our-st">
                    <div class="our-left">
                        <h4>Details</h4>
                    </div>

                    <li class="slider-details">
                        <asp:Label ID="lblTitle" runat="server" Text="Enter title:"></asp:Label>
                        <asp:TextBox ID="txtTitle" runat="server" placeholder="Eg. an example of title to show in slider" Width="83%"></asp:TextBox></li>
                    <li>
                        <asp:Label ID="lblDetails" runat="server" Text="Enter details:"></asp:Label>
                        <asp:TextBox ID="txtDetail" runat="server" placeholder="Eg. details to show in slider" Width="100%" TextMode="MultiLine"></asp:TextBox></li>
                    <asp:Label ID="lblError" runat="server" Text="" ForeColor="#B52E31" Visible="False"></asp:Label>
                    <asp:Button ID="btnAdd" runat="server" CssClass="close-btn-slider normal-btn" Text="ADD" OnClick="btnAdd_Click" />
                </div>

                <div class="clearfix"></div>
                <p>All Rights Reserved | Design by <a href="mailto:i8net2000@yahoo.com">Farhad Taheri</a></p>
            </div>
        </div>
    </div>
    <!--content-->
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton4" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton5" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton6" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton7" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton8" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton9" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton10" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton11" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton12" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton13" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton14" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton15" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton16" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton17" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton18" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton19" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton20" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton21" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton22" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton23" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton24" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton25" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton26" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton27" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton28" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton29" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton30" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton31" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton32" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton33" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton34" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton35" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton36" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton37" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton38" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton39" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton40" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton41" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton42" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton43" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton44" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton45" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton46" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton47" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton48" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton49" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton50" runat="server" OnClick="lbUpdate_Click"></asp:LinkButton>


            <div id="myModal" class="modal">
                <!-- Modal to show for update content -->
                <div class="modal-content">
                    <div class="modal-header">
                        <span onclick="closePopup();" class="close">&times;</span>
                        <h2>
                            <asp:Label ID="Label1" runat="server" Text=""></asp:Label></h2>
                    </div>
                    <div class="modal-body">
                        Title of Service: <asp:TextBox ID="txtTitleUpdate" runat="server"></asp:TextBox><br />
                        <span>Description of Service: </span> <asp:TextBox ID="txtDetailUpdate" runat="server" TextMode="MultiLine"></asp:TextBox><br />
                        
                                            <fieldset class="div_top">
                                                    <legend>* File input</legend>
                                                    <asp:FileUpload ID="fuUpdate" runat="server" style="margin: 3%"/>
                                            </fieldset>
                                            <p class="help-block">Please choose one picture of item</p> 
                                        
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="btnUpdate" runat="server" class="btn btn-default" Text="UPDATE" OnClick="btnUpdate_Click" />
                        <asp:Button ID="btnDel" runat="server" class="btn btn-default" Text="DELETE" OnClick="btnDel_Click" />
                        <h3>Make change / delete the contents</h3>
                    </div>
                </div>
                <!-- end of content of update popup page -->
            </div>
            <div class="clearfix"></div>
        </div>
    </div>
    <!-- end content -->
    </div>
    </div>
    <!--content-->

    <script>
        // Get the modal
        var modal = document.getElementById('myModal');

        // Get the button that opens the modal
        var btn = document.getElementById("myBtn");

        // Get the <span> element that closes the modal
        var span = document.getElementsByClassName("close")[0];

        // When the user clicks the button, open the modal 
        btn.onclick = function () {
            modal.style.display = "block";
        }

        // When the user clicks on <span> (x), close the modal
        span.onclick = function () {
            modal.style.display = "none";
        }

        // When the user clicks anywhere outside of the modal, close it
        window.onclick = function (event) {
            if (event.target == modal) {
                modal.style.display = "none";
            }
        }
    </script>

    <script>
        function open() {
            var modal = document.getElementById('myModal');

            // When the user clicks the button, open the modal 

            modal.style.display = "block";

        }
    </script>

    <script>
        function closePopup() {
            var modal = document.getElementById('myModal');

            modal.style.display = "none";
        }
    </script>

    <script>
        var modal = document.getElementById('myModal');
        window.onclick = function (event) {
            if (event.target == modal) {
                modal.style.display = "none";
            }
        }
    </script>

    <script>
        //var valueToSet = document.getElementsByClassName("clickable");
        //valueToSet.onclick = function () {
        //    alert(valueToSet.id);
        //}
        var idElement;
        $(document).ready(function () {
            $(".clickable").click(function () {
                // $(this).hide();
                idElement = $(this).attr('id');
                //document.cookie = idElement;

                //time to expire
                var currentdate = new Date();

                //currentdate.setDate(currentdate.getDate() + 1);
                currentdate.setHours(currentdate.getHours() + 1);

                var expires = currentdate.toUTCString();

                document.cookie = "idElement=" + idElement + ";path=/;expires=" + expires + ";";
            });
        });

        //var valueToSet = $("clickable");
    </script>

    <script>
        function killCookie() {
            var currentdate = new Date();
            currentdate.setDate(currentdate.getDate() - 10);
            var expires = currentdate.toUTCString();

            document.cookie = "idElement=;path=/;expires=" + expires + ";";
        }
    </script>
</asp:Content>
