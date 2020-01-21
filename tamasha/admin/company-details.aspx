<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="company-details.aspx.cs" Inherits="admin_company_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <!--content-->
			<div class="content">
<div class="women_main">
	<!-- start content -->
	<div class="grids">
					<div class="progressbar-heading grids-heading">
						<h2>Company Details</h2>
					</div>
					<div class="forms-grids">
						<div class="col-md-6">
							<div class="panel panel-widget">
								<div class="my-div">
									<div class="valida">
										<div class="input-info">
											<h3>Basic Details:</h3>
										</div>
										<label for="field-1">Company Name: (required)&nbsp;<span class="at-required-highlight">*</span></label>
										<div class="form-group">
                                            <asp:TextBox ID="txtCoName" name="field-1" runat="server" required="true" class="form-control" plceholder="Eg. Halisen Co."></asp:TextBox>
										</div>
                                        
										<label for="field-1-2">Company Owner: </label>
										<div class="form-group">
                                            <asp:TextBox ID="txtCoOwner" name="field-1-2" runat="server" class="form-control" Placeholder="Eg. Mr.Name"></asp:TextBox>
										</div>

										<label for="field-1-2">Company Owner words: </label>
										<div class="form-group">
                                            <asp:TextBox ID="txtCoOwnerWords" name="field-1-2" runat="server" class="form-control" Placeholder="Slogan for company"></asp:TextBox>
										</div>
                                        <hr>

										<h4>Google location:</h4>
										<div class="row">

											<div class="col-xs-12 col-sm-5">

												<label for="field-1-2">latitude: (required)&nbsp;<span class="at-required-highlight">*</span></label>
												<div class="form-group">
                                                    <asp:TextBox ID="txtLat" runat="server" class="form-control" placeholder="Eg. 56.898643"></asp:TextBox>
												</div>

											</div>

											<div class="col-xs-12 col-sm-7">

												<label for="field-1-2">longitude: (required)&nbsp;<span class="at-required-highlight">*</span></label>
												<div class="form-group">
                                                    <asp:TextBox ID="txtLong" runat="server" class="form-control" placeholder="Eg. 38.348219"></asp:TextBox>
												</div>

											</div>

										</div>

										<hr>

										<h4>Address:</h4>

										<label for="field-4">Address: &nbsp;<span class="at-required-highlight">*</span></label>
										<div class="form-group">
                                            <asp:TextBox ID="txtAddr" runat="server" TextMode="MultiLine" class="form-control" placeholder="Eg. 1 example Rd Provinance Country"></asp:TextBox>
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
                                                <asp:TextBox ID="txtPhone" class="form-control" runat="server" ClientIDMode="Static" placeholder="Eg. 416 111 11111"></asp:TextBox>
											</div>

                                            <label for="field-4">Fax: &nbsp;<span class="at-required-highlight">*</span></label>
											<div class="form-group valid-form">
                                                <asp:TextBox ID="txtFax" class="form-control" runat="server" ClientIDMode="Static" placeholder="Eg. 416 111 11111"></asp:TextBox>
											</div>

											<label for="field-4">Social Number: &nbsp;<span class="at-required-highlight">*</span></label>
											<div class="form-group valid-form">
                                                <asp:TextBox ID="txtSocialNo" class="form-control" runat="server" ClientIDMode="Static" placeholder="Eg. 416 111 11111"></asp:TextBox>
											</div>

                                            <label for="field-4">Inestagram: &nbsp;<span class="at-required-highlight">*</span></label>
											<div class="form-group valid-form">
                                                <asp:TextBox ID="txtInstagram" class="form-control" runat="server" placeholder="Eg. Your instagram ID"></asp:TextBox>
											</div>

                                                <label for="field-4">Facebook: &nbsp;<span class="at-required-highlight">*</span></label>
											<div class="form-group valid-form">
                                                <asp:TextBox ID="txtFabook" class="form-control" runat="server" placeholder="Eg. Your Facebook ID"></asp:TextBox>
											</div>

                                                <label for="field-4">Twitter: &nbsp;<span class="at-required-highlight">*</span></label>
											<div class="form-group valid-form">
                                                <asp:TextBox ID="txtTwitter" class="form-control" runat="server" placeholder="Eg. Your Twitter ID"></asp:TextBox>
											</div>

                                                <label for="field-4">LinkedIn: &nbsp;<span class="at-required-highlight">*</span></label>
											<div class="form-group valid-form">
                                                <asp:TextBox ID="txtLinkedin" class="form-control" runat="server" placeholder="Eg. Your LinkedIn ID"></asp:TextBox>
											</div>

                                                <label for="field-4">youtube: &nbsp;<span class="at-required-highlight">*</span></label>
											<div class="form-group valid-form">
                                                <asp:TextBox ID="txtYoutube" class="form-control" runat="server" placeholder="Eg. Your Youtube ID"></asp:TextBox>
											</div>

											<label for="field-4">Google Plus: &nbsp;<span class="at-required-highlight">*</span></label>
											<div class="form-group valid-form">
                                                <asp:TextBox ID="txtGoogle" class="form-control" runat="server" placeholder="Eg. Your google plus ID"></asp:TextBox>
											</div>

										    <label for="field-4">Email: &nbsp;<span class="at-required-highlight">*</span></label>
											<div class="form-group has-feedback">
                                                <asp:TextBox ID="txtEmail" class="form-control" runat="server" placeholder="Eg. info@email.com"></asp:TextBox>
												<span class="glyphicon form-control-feedback" aria-hidden="true"></span>
												<span class="help-block with-errors">Please enter a valid email address</span>
											</div>

										    <label for="field-4">Company website: </label>
											<div class="form-group">
                                                <asp:TextBox ID="txtWebsite" class="form-control" runat="server" placeholder="Eg. www.website.com"></asp:TextBox>
											</div>

                                            <h4>Company Details:</h4>

										    <label for="field-4">Company Details: &nbsp;<span class="at-required-highlight">*</span></label>
										    <div class="form-group">
                                                <asp:TextBox ID="txtDetails" runat="server" TextMode="MultiLine" class="form-control" placeholder="Eg. Some details about company activities"></asp:TextBox>
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


    <script>
        //$(document).ready(function () {
        //    var tempVal = $("#txtPhone").val();
        //    $("#txtPhone").focus(function () {
        //        if ($("#txtPhone").val().length >= 1) {
        //            var temp = $("#txtPhone").val();

        //            temp = temp.substring(0, 1) + "-" + temp.substring(1, temp.length);



        //            $("#txtPhone").val(temp);
        //            //$("#txtPhone").css("background-color", "red");

        //        }
        //    });
        //    $("#txtPhone").focusout(function () {
        //        $("#txtPhone").val(tempVal);
        //    });
        //});        
    </script>
</asp:Content>

