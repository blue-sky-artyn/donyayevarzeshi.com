<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="sponsors.aspx.cs" Inherits="admin_gallery_normal" %>

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
			<a href="#"><h4>Sponsors </h4></a>
		    <div class="clearfix"></div>	
		</div>
		<!-- grids_of_4 -->
       <div id="addSponsoHtml" runat="server"></div>
		
		<div class="grids_of_4">
			<div class="clearfix"></div>
            <div class="panel panel-widget forms-panel">
						<div class="forms">
							<div class="form-grids widget-shadow" data-example-id="basic-forms"> 
								<div class="form-title">
									<h4>Add sponsor: </h4>
								</div>
								<div class="form-body">
									<div> 
                                        <div class="form-group"> 
                                                <label for="inputEmail3" class="col-sm-2 control-label">* Full Name: </label>
                                                <div class="col-sm-9"> 
                                                    <asp:TextBox ID="txtName" class="form-control" runat="server" placeholder="Enter Full Name" Width="25%" style="float: left;margin-right: 20px;"></asp:TextBox>
                                                </div>
                                        </div> 
                                        
                                        <div class="form-group"> 
                                                <label for="inputEmail3" class="col-sm-2 control-label">* Company Name: </label>
                                                <div class="textarea-margin-top col-sm-9"> 
                                                    <asp:TextBox ID="txtCo" class="form-control" runat="server" placeholder="eg. TICC Co." Width="25%"></asp:TextBox> 
                                                </div>
                                        </div>

                                        

                                        <div class="form-group" style="width: 26%;line-height: 34px;"> 
                                            <label for="exampleInputPassword1">Email: </label>
                                            <asp:TextBox ID="txtEmail" class="form-control" runat="server" placeholder="eg. info@email.ca" Width="69.5%"></asp:TextBox> 
                                        </div>

                                        <div class="form-group" style="width: 26%;line-height: 34px;"> 
                                            <label for="exampleInputPassword1">Tel: </label>
                                            <asp:TextBox ID="txtTel" class="form-control" runat="server" placeholder="eg. 41611111111" Width="69.5%"></asp:TextBox> 
                                        </div>
                                        <div class="form-group">
                                            <blockquote>
                                            <label for="exampleInputEmail1">Start from: </label>
                                            <asp:TextBox ID="txtStartFrom" runat="server" Width="15%"></asp:TextBox>

                                            <label for="exampleInputEmail1">End of: </label>
                                            <asp:TextBox ID="txtEndOf" runat="server" Width="15%"></asp:TextBox>

                                            </blockquote>
                                        </div>

                                        <div class="form-group" style="width: 100%;line-height: 34px;"> 
                                            <label for="exampleInputPassword1">Address: </label>
                                            <asp:TextBox ID="txtAddr" class="form-control" runat="server" placeholder="Ener address" ></asp:TextBox> 
                                        </div>

                                        <div class="form-group" style="width: 100%;line-height: 34px;float: left;margin-right: 5px;"> 
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

