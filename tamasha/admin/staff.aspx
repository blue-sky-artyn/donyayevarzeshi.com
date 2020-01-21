<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="staff.aspx.cs" Inherits="admin_gallery_normal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <style>
        .textarea-margin-top {
            margin-top: 5px;
        }
    </style>
    <!--content-->
<div class="content">
<div class="women_main">
	<!-- start content -->
   <div class="w_content">
		<div class="women">
			<a href="#"><h4>Satff of company </h4></a>
		    <div class="clearfix"></div>	
		</div>
		<!-- grids_of_4 -->
       <div id="addStaffHtml" runat="server"></div>
		
		<div class="grids_of_4">
			<div class="clearfix"></div>
            <div class="panel panel-widget forms-panel">
						<div class="forms">
							<div class="form-grids widget-shadow" data-example-id="basic-forms"> 
								<div class="form-title">
									<h4>Add staff to company: </h4>
								</div>
								<div class="form-body">
									<div> 
                                        <div class="form-group"> 
                                                <label for="inputEmail3" class="col-sm-2 control-label">* Name and Family: </label>
                                                <div class="col-sm-9"> 
                                                    <asp:TextBox ID="txtName" class="form-control" runat="server" placeholder="Enter Name" Width="25%" style="float: left;margin-right: 20px;"></asp:TextBox> <span style="float: left;margin-right: 20px;">,</span>
                                                    <asp:TextBox ID="txtFamily" class="form-control" runat="server" placeholder="Enter Family" Width="25%"  style="float: left;margin-right: 20px;"></asp:TextBox>
                                                </div>
                                        </div> 
                                        
                                        <div class="form-group"> 
                                                <label for="inputEmail3" class="col-sm-2 control-label">Bithdate: </label>
                                                <div class="textarea-margin-top col-sm-9"> 
                                                    <asp:TextBox ID="txtBithdate" class="form-control" runat="server" placeholder="eg. 1984/07/07" Width="25%"></asp:TextBox> 
                                                </div>
                                        </div>

                                        <div class="form-group"> 
                                            <label for="exampleInputPassword1">Certificate details: </label>
                                            <asp:TextBox ID="txtMajor" class="form-control" runat="server" placeholder="Enter Major" Width="25%"></asp:TextBox>
                                            <asp:TextBox ID="txtCertificate" class="textarea-margin-top form-control" runat="server" Width="25%" placeholder="Enter field of study"></asp:TextBox>
                                        </div>
                                        
                                        <div class="form-group" style="width: 26%;line-height: 34px;"> 
                                            <label for="exampleInputPassword1">* Job position: </label>
                                            <asp:TextBox ID="txtJobPosition" class="form-control" runat="server" placeholder="eg. Senior assistant" Width="69.5%"></asp:TextBox> 
                                        </div>

                                        <div class="form-group" style="width: 26%;line-height: 34px;"> 
                                            <label for="exampleInputPassword1">Hiring Date: </label>
                                            <asp:TextBox ID="txtHiringDate" class="form-control" runat="server" placeholder="eg. 2016/01/01" Width="69.5%"></asp:TextBox> 
                                        </div>

                                        <div class="form-group" style="width: 26%;line-height: 34px;"> 
                                            <label for="exampleInputPassword1">Email: </label>
                                            <asp:TextBox ID="txtEmail" class="form-control" runat="server" placeholder="eg. info@uhsco.ca" Width="69.5%"></asp:TextBox> 
                                        </div>

                                        <div class="form-group" style="width: 26%;line-height: 34px;"> 
                                            <label for="exampleInputPassword1">Tel: </label>
                                            <asp:TextBox ID="txtTel" class="form-control" runat="server" placeholder="eg. 41611111111" Width="69.5%"></asp:TextBox> 
                                        </div>

                                        <div class="form-group" style="width: 26%;line-height: 34px;"> 
                                            <label for="exampleInputPassword1">Mobile: </label>
                                            <asp:TextBox ID="txtMob" class="form-control" runat="server" placeholder="eg. 4161111111" Width="69.5%"></asp:TextBox> 
                                        </div>
                                        
                                        <div class="form-group" style="width: 35%;line-height: 34px;float: left;margin-right: 5px;"> 
                                            <label for="exampleInputPassword1" style="float: left;">Staff word: </label>
                                            <asp:TextBox ID="txtWord" class="form-control" runat="server" placeholder="A short words of staff" TextMode="MultiLine"></asp:TextBox>
                                        </div>

                                        <div class="form-group" style="width: 35%;line-height: 34px;float: left;margin-right: 5px;"> 
                                            <label for="exampleInputPassword1" style="float: left;">Details: </label>
                                            <asp:TextBox ID="txtDetail" class="form-control" runat="server" placeholder="A short detail" TextMode="MultiLine"></asp:TextBox>
                                        </div>

                                        <div class="form-group" style="float: left;width:100%;">
                                            <fieldset class="div_top">
                                                    <legend>* File input</legend>
                                                    <asp:FileUpload ID="fuGallery" runat="server" style="margin: 3%"/>
                                            </fieldset>
                                            <p class="help-block">Please choose one picture of item</p> 
                                        </div> 
                                        <div class="form-group" style="float: left;">
                                            <asp:Label ID="lblError" runat="server" Text="" Visible="false" ForeColor="#B52E31"></asp:Label>
                                            <asp:Button ID="btnAdd" runat="server" class="btn btn-default" Text="ADD ITEM" OnClick="btnAdd_Click" />
                                        </div>
									</div> 
								</div>
							</div>
						</div>
					</div>
		</div>
		
		
		
		
		<!-- end grids_of_4 -->
		
		
	</div>
   <div class="clearfix"></div>
	<!-- end content -->
    </div>
</asp:Content>

