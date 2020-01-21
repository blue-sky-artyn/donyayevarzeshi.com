<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="working-hours.aspx.cs" Inherits="admin_gallery_groups" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
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
									<div class="col-md-6 form-body">
										<div class="form-horizontal"> 
                                            <div class="form-group"> 
                                                <label for="inputEmail3" class="col-sm-2 control-label">Monday</label>
                                                <div class="col-sm-9"> 
                                                    <asp:TextBox ID="txtHourMon" class="form-control" runat="server" placeholder="Eg. 9:30 – 21:00"></asp:TextBox>
                                                </div>
                                            </div> 
                                            <div class="form-group"> 
                                                <label for="inputEmail3" class="col-sm-2 control-label">Tuesday</label>
                                                <div class="col-sm-9"> 
                                                    <asp:TextBox ID="txtHourTus" class="form-control" runat="server" placeholder="Eg. 9:30 – 21:00"></asp:TextBox>
                                                </div>
                                            </div> 
                                             <div class="form-group"> 
                                                <label for="inputEmail3" class="col-sm-2 control-label">Wednesday</label>
                                                <div class="col-sm-9"> 
                                                    <asp:TextBox ID="txtHourWed" class="form-control" runat="server" placeholder="Eg. 9:30 – 21:00"></asp:TextBox>
                                                </div>
                                            </div> 
                                            <div class="col-sm-offset-2"> 
                                                <asp:Label ID="lblError" runat="server" Text="* Please fill out the group name frist." ForeColor="#B52E31" Visible="False"></asp:Label>
                                                <asp:Button ID="btnAdd1" class="btn btn-default" runat="server" Text="CREATE" OnClick="btnAdd_Click" />
                                            </div> 
										</div> 
									</div>

                                    <div class="col-md-6 form-body">
										<div class="form-horizontal"> 
                                            <div class="form-group"> 
                                                <label for="inputEmail3" class="col-sm-2 control-label">Thursday</label>
                                                <div class="col-sm-9"> 
                                                    <asp:TextBox ID="txtHourThu" class="form-control" runat="server" placeholder="Eg. 9:30 – 21:00"></asp:TextBox>
                                                </div>
                                            </div> 
                                            <div class="form-group"> 
                                                <label for="inputEmail3" class="col-sm-2 control-label">Friday</label>
                                                <div class="col-sm-9"> 
                                                    <asp:TextBox ID="txtHourFri" class="form-control" runat="server" placeholder="Eg. 9:30 – 21:00"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="form-group"> 
                                                <label for="inputEmail3" class="col-sm-2 control-label">Saturday</label>
                                                <div class="col-sm-9"> 
                                                    <asp:TextBox ID="txtHourSat" class="form-control" runat="server" placeholder="Eg. 9:30 – 21:00"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="form-group"> 
                                                <label for="inputEmail3" class="col-sm-2 control-label">Sunday</label>
                                                <div class="col-sm-9"> 
                                                    <asp:TextBox ID="txtHourSun" class="form-control" runat="server" placeholder="Eg. 9:30 – 21:00"></asp:TextBox>
                                                </div>
                                            </div> 
                                            <div class="col-sm-offset-2"> 
                                                <asp:Label ID="Label1" runat="server" Text="* Please fill out the group name frist." ForeColor="#B52E31" Visible="False"></asp:Label>
                                                <asp:Button ID="btnAdd2" class="btn btn-default" runat="server" Text="CREATE" OnClick="btnAdd_Click" />
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
</asp:Content>

