<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="news-flagged.aspx.cs" Inherits="admin_news_flagged_sport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <style>
        .top-news {
            position: absolute;
            bottom: 30px;
            left: -6%;
            font-size: 10px;
            color: red;
            font-weight: bold;
            letter-spacing: 2px;
        }
    </style>
    <!--content-->
			<div class="content">
<div class="women_main">
	<!-- start content -->
	<div class="catalog">				
			<div id="tabs" class="tabs">
					
						<div class="graph">
							<nav>
								<ul id="newsGroupTabHtml" runat="server">
									<li class="tab-current"><a href="#section-1" class="icon-shop"><span>General</span></a></li>
									<li><a href="#section-2" class="icon-cup"><span>Lorem</span></a></li>
									<li><a href="#section-3" class="icon-food"><span>Ipsum</span></a></li>
									<li><a href="#section-4" class="icon-lab"><span>Desc</span></a></li>
									<li><a href="#section-5" class="icon-truck"><span>Dummy</span></a></li>
									<li><a href="#section-6" class="icon-food"><span>Readable</span></a></li>
									<li><a href="#section-7" class="icon-lab"><span>Standard</span></a></li>
									<li><a href="#section-8" class="icon-truck"><span>Various</span></a></li>
								</ul>
							</nav>
								<div id="newsTitleHtml" runat="server" class="content tab">
									<section id="section-1" class="content-current">
										<div class="fo-top">
											<div class="form-group">
												
												<div class="col-sm-12 ctl">
													<div class="checkbox"><span id="text" class="top-news" style="display:none" >(Checked as top news)</span> <label> <input type="checkbox" id="myCheck" onclick="myFunction()"> Check me out </label> </div>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Model</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="The Rock and Roll Destroyer">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">SKU</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="Zol_r_lrg">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Weight</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="0.4400">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Status</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Enabled</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Tax Class</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Taxable Goods</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">URL Key</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="The Rock and Roll Destroyer">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Visibility</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Non where</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Allow Gift Message</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Use config</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Manufacturer</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value=""></option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Set Product as New from Date</label>
												<div class="col-sm-8 ctl">
													 <form>
														<input type="date" value="Select date" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Select date';}">
														<span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
													</form>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Set Product as New to Date</label>
												<div class="col-sm-8 ctl">
													 <form>
														<input type="date" value="Select date" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Select date';}">
														<span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
													</form>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
									</section>
									<section id="section-2">
										
										
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">SKU</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="Zol_r_lrg">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Weight</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="0.4400">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Status</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Enabled</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Tax Class</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Taxable Goods</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">URL Key</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="The Rock and Roll Destroyer">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Visibility</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Non where</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Allow Gift Message</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Use config</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Manufacturer</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value=""></option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Set Product as New from Date</label>
												<div class="col-sm-8 ctl">
													 <form>
														<input type="date" value="Select date" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Select date';}">
														<span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
													</form>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Set Product as New to Date</label>
												<div class="col-sm-8 ctl">
													 <form>
														<input type="date" value="Select date" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Select date';}">
														<span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
													</form>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
									</section>
									<section id="section-3">
										
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Status</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Enabled</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Tax Class</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Taxable Goods</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">URL Key</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="The Rock and Roll Destroyer">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Visibility</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Non where</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Allow Gift Message</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Use config</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Manufacturer</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value=""></option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Set Product as New from Date</label>
												<div class="col-sm-8 ctl">
													 <form>
														<input type="date" value="Select date" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Select date';}">
														<span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
													</form>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Set Product as New to Date</label>
												<div class="col-sm-8 ctl">
													 <form>
														<input type="date" value="Select date" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Select date';}">
														<span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
													</form>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
									</section>
									<section id="section-4">
										
										
										
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Weight</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="0.4400">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Status</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Enabled</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Tax Class</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Taxable Goods</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">URL Key</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="The Rock and Roll Destroyer">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Visibility</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Non where</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Allow Gift Message</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Use config</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Manufacturer</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value=""></option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Set Product as New from Date</label>
												<div class="col-sm-8 ctl">
													 <form>
														<input type="date" value="Select date" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Select date';}">
														<span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
													</form>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Set Product as New to Date</label>
												<div class="col-sm-8 ctl">
													 <form>
														<input type="date" value="Select date" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Select date';}">
														<span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
													</form>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
									</section>
									<section id="section-5">
										
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Weight</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="0.4400">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Status</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Enabled</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Tax Class</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Taxable Goods</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">URL Key</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="The Rock and Roll Destroyer">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Visibility</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Non where</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Allow Gift Message</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Use config</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Manufacturer</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value=""></option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Set Product as New from Date</label>
												<div class="col-sm-8 ctl">
													 <form>
														<input type="date" value="Select date" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Select date';}">
														<span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
													</form>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group ctl">
												<label for="focusedinput" class="col-sm-2 control-label">Set Product as New to Date</label>
												<div class="col-sm-8">
													 <form>
														<input type="date" value="Select date" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Select date';}">
														<span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
													</form>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
									</section>
									<section id="section-6">
										
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">SKU</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="Zol_r_lrg">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Weight</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="0.4400">
												</div>
												<div class="col -sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Status</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Enabled</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Tax Class</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Taxable Goods</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">URL Key</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="The Rock and Roll Destroyer">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Visibility</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Non where</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Allow Gift Message</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Use config</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Manufacturer</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value=""></option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Set Product as New from Date</label>
												<div class="col-sm-8 ctl">
													 <form>
														<input type="date" value="Select date" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Select date';}">
														<span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
													</form>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Set Product as New to Date</label>
												<div class="col-sm-8 ctl">
													 <form>
														<input type="date" value="Select date" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Select date';}">
														<span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
													</form>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
									</section>
									<section id="section-7">
										
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Status</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Enabled</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Tax Class</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Taxable Goods</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">URL Key</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="The Rock and Roll Destroyer">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Visibility</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Non where</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Allow Gift Message</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Use config</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Manufacturer</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value=""></option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Set Product as New from Date</label>
												<div class="col-sm-8 ctl">
													 <form>
														<input type="date" value="Select date" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Select date';}">
														<span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
													</form>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Set Product as New to Date</label>
												<div class="col-sm-8 ctl">
													 <form>
														<input type="date" value="Select date" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Select date';}">
														<span class="glyphicon glyphicon-calendar" aria-hidden="true"></span>
													</form>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
									</section>
									<section id="section-8">
										
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">SKU</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="Zol_r_lrg">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Weight</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="0.4400">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Status</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Enabled</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Tax Class</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Taxable Goods</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">URL Key</label>
												<div class="col-sm-8 ctl">
													<input type="text" class="form-control1" id="focusedinput" placeholder="The Rock and Roll Destroyer">
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Visibility</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Non where</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Allow Gift Message</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value="">Use config</option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										<div class="fo-top">
											<div class="form-group">
												<label for="focusedinput" class="col-sm-2 control-label">Manufacturer</label>
												<div class="col-sm-8 ctl">
													<select name="field-2" id="field-2" required="true" class="form-control">
														<option value=""></option>
														<option value="val-1">Value 1</option>
														<option value="val-2">Value 2</option>
													</select>
												</div>
												<div class="col-sm-2 hp">
													<p class="help-block">(GLOBAL)</p>
												</div>
												<div class="clearfix"></div>
											</div>
										</div>
										
									
									</section>
																	
																	
											
								</div><!-- /content -->
						</div>
												<!-- /tabs -->
											</div>	
								<script src="js/cbpFWTabs.js"></script>
									<script>
										new CBPFWTabs( document.getElementById( 'tabs' ) );
									</script>
											
	</div>
	<!-- end content -->
    <asp:Button ID="btnUpdate" runat="server" ClientIDMode="Static" Text="Update" OnClick="btnUpdate_Click" />
</div>

</div>
			<!--content-->
    <script>
        //Read cookie contents
        function getCookie(cname) {
            var name = cname + "=";
            var decodedCookie = decodeURIComponent(document.cookie);
            var ca = decodedCookie.split(';');
            for (var i = 0; i < ca.length; i++) {
                var c = ca[i];
                while (c.charAt(0) == ' ') {
                    c = c.substring(1);
                }
                if (c.indexOf(name) == 0) {
                    return c.substring(name.length, c.length);
                }
            }
            return "";
        };



        //Set flag
        for (var i = 0; i < document.getElementsByClassName("newsClass").length; i++) {
            document.getElementsByClassName("newsClass")[i].addEventListener("click", function () {

                var idName = this.id;
                var checkBox = document.getElementById(idName);
                var text = document.getElementById("text" + idName);

                if (checkBox.checked == true) {
                    text.style.display = "inline";
                } else {
                    text.style.display = "none";
                }
            });
        };
       
        //update checked checkboxes cookie
        document.getElementById("btnUpdate").addEventListener("click", myFunction);

        function myFunction() {
            var checkBoxes = document.getElementsByClassName("newsClass");
            var cookieCounter = 0;
            var checkedBoxArr = [];

            for (var i = 0; i < checkBoxes.length; i++) {
                if (checkBoxes[i].checked == true) {
                    //alert(checkBoxes[i].id);
                    checkedBoxArr[cookieCounter] = checkBoxes[i].id;
                    cookieCounter++;
                }
            }

            document.cookie = "chkId=" + checkedBoxArr;
           
        }
           
    </script>

</asp:Content>

