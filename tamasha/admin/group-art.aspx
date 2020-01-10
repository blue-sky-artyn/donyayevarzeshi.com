<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="group-art.aspx.cs" Inherits="admin_gallery_groups" %>

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
</asp:Content>

