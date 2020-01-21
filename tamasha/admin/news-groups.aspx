<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="news-groups.aspx.cs" Inherits="admin_gallery_groups" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <!--content-->
			<div class="content">
<div class="women_main">
	<!-- start content -->
	<div class="grids">
					<div class="progressbar-heading grids-heading">
						<h2>Groups</h2>
					</div>
					<div class="panel panel-widget forms-panel">
						<div class="forms">
							<div class="form-grids widget-shadow" data-example-id="basic-forms"> 
								<div class="form-title">
									<h4>Groups :</h4>
								</div>
								<div class="form-body">
									<div> 
                                        <div id="itemsHtml" runat="server" class="checkbox"> 
                                            
                                        </div>
                                        <p style="color: #B52E31;">* Please choose one to make changes</p>
									</div> 
								</div>
							</div>
						</div>
					</div>
					<div class="panel panel-widget forms-panel">
						<div class="forms">
							<div class=" form-grids form-grids-right">
								<div class="widget-shadow " data-example-id="basic-forms"> 
									<div class="form-title">
										<h4>Add groups:</h4>
									</div>
									<div class="form-body">
										<div class="form-horizontal"> 
                                            <div class="form-group"> 
                                                <label for="inputEmail3" class="col-sm-2 control-label">Group Name</label>
                                                <div class="col-sm-9"> 
                                                    <asp:TextBox ID="txtGroupName" class="form-control" runat="server" placeholder="Eg. Main category"></asp:TextBox>
                                                </div>
                                            </div> 
                                            <div class="form-group">
                                                <label for="inputPassword3" class="col-sm-2 control-label">Group detail</label> 
                                                <div class="col-sm-9"> 
                                                    <asp:TextBox ID="txtGroupDetail" class="form-control" runat="server" placeholder="Eg. a short description about this type"></asp:TextBox>
                                                </div>
                                            </div> 
                                            <div class="col-sm-offset-2"> 
                                                <asp:Label ID="lblError" runat="server" Text="* Please fill out the group name frist." ForeColor="#B52E31" Visible="False"></asp:Label>
                                                <asp:Button ID="btnAdd" class="btn btn-default" runat="server" Text="CREATE" OnClick="btnAdd_Click" />
                                            </div> 
										</div> 
									</div>
								</div>
							</div>
						</div>	
					</div>
					
				</div>

	<!-- end content -->

    </div>
                <style>
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

                .modal-body select, input, textarea {
                    margin: 5px 0;
                }

                .modal-body span {
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
                        <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label></h2>
                </div>
                <div class="modal-body">
                    Title of Service Group:
                    <asp:TextBox ID="txtTitleUpdate" runat="server"></asp:TextBox><br />
                    <span>Description of Service Group: </span>
                    <asp:TextBox ID="txtDetailUpdate" runat="server" TextMode="MultiLine"></asp:TextBox><br />

                </div>
                <div class="modal-footer">
                    <asp:Button ID="btnUpdate" runat="server" class="btn btn-default" Text="UPDATE" OnClick="btnUpdate_Click" />
                    <asp:Button ID="btnDel" runat="server" class="btn btn-default" Text="DELETE" OnClick="btnDel_Click" />
                    <h3>Make change / delete the contents</h3>
                </div>
            </div>
            <!-- end of content of update popup page -->
        </div>


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