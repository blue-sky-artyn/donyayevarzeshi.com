<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="gallery-normal.aspx.cs" Inherits="admin_gallery_normal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <!--content-->
<div class="content">
<div class="women_main">
	<!-- start content -->
   <div class="w_content">
		<div class="women">
			<a href="#"><h4>Normal gallery of carpets </h4></a>
			<ul class="w_nav">
						<li>Sort : </li>
		     			<li><a class="active" href="#">Price: low </a></li> |
		     			<li><a href="#">Price: high </a></li> |
		     			<li><a href="#">Arrival </a></li> |
		     			<li><a href="#">Group </a></li> |
		     			<li><a href="#">Clear </a></li> 
		     			<div class="clear"></div>	
		     </ul>
		     <div class="clearfix"></div>	
		</div>
		<!-- grids_of_4 -->
       <div id="addPicHtml" runat="server"></div>
		
		<div class="grids_of_4">
			<div class="clearfix"></div>
            <div class="panel panel-widget forms-panel">
						<div class="forms">
							<div class="form-grids widget-shadow" data-example-id="basic-forms"> 
								<div class="form-title">
									<h4>Add to gallery: </h4>
								</div>
								<div class="form-body">
									<div> 
                                        <div class="checkbox"> 
                                            <span>Groups of types: </span><asp:DropDownList ID="ddlGropus" runat="server"></asp:DropDownList>
                                        </div> 
                                        <div class="checkbox"> 
                                            <span>Groups of colors: </span><asp:DropDownList ID="ddlColors" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="checkbox"> 
                                            <span>Groups of shapes: </span><asp:DropDownList ID="ddlShape" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="checkbox"> 
                                            <span>Groups of size: </span><asp:DropDownList ID="ddlSize" runat="server"></asp:DropDownList>
                                        </div>
                                        <hr />
                                        <div class="form-group"> 
                                            <label for="exampleInputEmail1">Picture Title: </label> 
                                            <asp:TextBox ID="txtTitle" class="form-control" runat="server" placeholder="Eg. Hoze Design"></asp:TextBox>
                                        </div>
                                        <div class="form-group"> 
                                            <label for="exampleInputPassword1">Picture Details: </label>
                                            <asp:TextBox ID="txtDetails" class="form-control" runat="server" placeholder="Eg. a short description of item" TextMode="MultiLine"></asp:TextBox>
                                        </div>
                                        <div class="form-group" style="width: 26%;line-height: 34px;"> 
                                            <label for="exampleInputPassword1" style="float: left;">Item Price: </label>
                                            <asp:TextBox ID="txtPrice" class="form-control" runat="server" placeholder="Eg. 1200" style="width: 70%;float: left;margin-right: 5px;"></asp:TextBox> $ 
                                        </div>
                                        <div class="form-group">
                                            <fieldset class="div_top">
                                                    <legend>File input</legend>
                                                    <asp:FileUpload ID="fuGallery" runat="server" style="margin: 3%"/>
                                            </fieldset>
                                            <p class="help-block">Please choose one picture of item</p> 
                                        </div> 
                                        <asp:Label ID="lblError" runat="server" Text="" Visible="false" ForeColor="#B52E31"></asp:Label>
                                        <asp:Button ID="btnAdd" runat="server" class="btn btn-default" Text="ADD ITEM" OnClick="btnAdd_Click" />
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

