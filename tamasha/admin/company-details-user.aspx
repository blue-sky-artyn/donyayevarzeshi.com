<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="company-details-user.aspx.cs" Inherits="admin_company_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <style>
        .id-form {
            width: 49%;
            display: inline
        }
    </style>
    <!--content-->
			<div class="content">
<div class="women_main">
	<!-- start content -->
	<div class="grids">
					<div class="progressbar-heading grids-heading">
						<h2>Users Details</h2>
					</div>
					<div class="forms-grids">
						<div class="col-md-6">
							<div class="panel panel-widget">
								<div class="my-div">
									<div class="valida">
										<div class="input-info">
											<h3>Basic Details:</h3>
										</div>
										<label for="field-1">Full Name: (required)&nbsp;<span class="at-required-highlight">*</span></label>
										<div class="form-group">
                                            <asp:TextBox ID="txtName" name="field-1" runat="server" required="true" class="id-form form-control" plceholder="Enter name"></asp:TextBox>
										
                                            <asp:TextBox ID="txtFamily" name="field-1-2" runat="server" class="id-form form-control" Placeholder="Enter surname"></asp:TextBox>
										</div>

                                        <hr>

										<h4>Details:</h4>

										<label for="field-4">Word of staff: &nbsp;<span class="at-required-highlight">*</span></label>
										<div class="form-group">
                                            <asp:TextBox ID="txtWordStaff" runat="server" TextMode="MultiLine" class="form-control" placeholder="Enter value"></asp:TextBox>
										</div>

                                        <label for="field-4">details of staff: &nbsp;<span class="at-required-highlight">*</span></label>
										<div class="form-group">
                                            <asp:TextBox ID="txtDetails" runat="server" TextMode="MultiLine" class="form-control" placeholder="Enter value"></asp:TextBox>
										</div>
									
										
									</div>
								</div>
							</div>
						</div>
						<div class="col-md-6">
							<div class="panel panel-widget">
								<div class="validation-grids widget-shadow" data-example-id="basic-forms"> 
									<div class="input-info">
										<h3>Contact informations :</h3>
									</div>
									<div class="form-body form-body-info">
										<div data-toggle="validator" novalidate="true">
										    <label for="field-4">Tel: &nbsp;<span class="at-required-highlight">*</span></label>
											<div class="form-group valid-form">
                                                <asp:TextBox ID="txtPhone" class="form-control" runat="server" placeholder="Eg. 416 111 11111"></asp:TextBox>
											</div>

                                            <label for="field-4">Mobile: &nbsp;<span class="at-required-highlight">*</span></label>
											<div class="form-group valid-form">
                                                <asp:TextBox ID="txtMobile" class="form-control" runat="server" placeholder="Eg. 416 111 11111"></asp:TextBox>
											</div>

                                            <label for="field-4">Inestagram: &nbsp;<span class="at-required-highlight">*</span></label>
											<div class="form-group valid-form">
                                                <asp:TextBox ID="txtInstagram" class="form-control" runat="server" placeholder="Eg. Your instagram ID"></asp:TextBox>
											</div

                                                <label for="field-4">Facebook: &nbsp;<span class="at-required-highlight">*</span></label>
											<div class="form-group valid-form">
                                                <asp:TextBox ID="txtFabook" class="form-control" runat="server" placeholder="Eg. Your Facebook ID"></asp:TextBox>
											</div

                                                <label for="field-4">Twitter: &nbsp;<span class="at-required-highlight">*</span></label>
											<div class="form-group valid-form">
                                                <asp:TextBox ID="txtTwitter" class="form-control" runat="server" placeholder="Eg. Your Twitter ID"></asp:TextBox>
											</div

                                                <label for="field-4">LinkedIn: &nbsp;<span class="at-required-highlight">*</span></label>
											<div class="form-group valid-form">
                                                <asp:TextBox ID="txtLinkedin" class="form-control" runat="server" placeholder="Eg. Your LinkedIn ID"></asp:TextBox>
											</div

                                                <label for="field-4">youtube: &nbsp;<span class="at-required-highlight">*</span></label>
											<div class="form-group valid-form">
                                                <asp:TextBox ID="txtYoutube" class="form-control" runat="server" placeholder="Eg. Your Youtube ID"></asp:TextBox>
											</div

										    <label for="field-4">Email: &nbsp;<span class="at-required-highlight">*</span></label>
											<div class="form-group has-feedback">
                                                <asp:TextBox ID="txtEmail" class="form-control" runat="server" placeholder="Eg. info@email.com"></asp:TextBox>
												<span class="glyphicon form-control-feedback" aria-hidden="true"></span>
												<span class="help-block with-errors">Please enter a valid email address</span>
											</div>
											
											<div class="form-group">
                                                <span id="ErrorMassage" runat="server" style="color: #B52E31;"></span>
                                                <asp:Button ID="btnSave" runat="server" class="btn btn-primary" Text="UPDATE" OnClick="btnSave_Click" />
											</div>
										</div>
									</div>
								</div>
							</div>
							
						</div>
						<div class="clearfix"> </div>
					</div>
				</div>

	<!-- end content -->
	
<div class="footer">

					<div class="clearfix"> </div>
						<p>All Rights Reserved | Design by <a href="mailto:i8net2000@yahoo.com">Farhad Taheri</a></p>
			</div>
</div>

</div>
			<!--content-->
</asp:Content>

