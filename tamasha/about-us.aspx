<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="about-us.aspx.cs" Inherits="about_toronto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
		iframe{
			border: 1px solid #80808059;
			box-shadow: #80808069 4px 4px 3px;
		}
		.input {margin: 2px 0;}
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
		<!-- SECTION -->
		<div class="section">
			<!-- CONTAINER -->
			<div class="container">
				<!-- ROW -->
				<div class="row">
					<!-- Main Column -->
					<div class="col-md-12">

						<%--<!-- breadcrumb -->
						<ul class="article-breadcrumb">
							<li><a href="default.aspx">Home</a></li>
							<li>About Us</li>
						</ul>
						<!-- /breadcrumb -->--%>
					
						<!-- ARTICLE POST -->
						<article class="article article-post">
							<div id="socialLinksHtml" runat="server" class="article-share">
								<a href="#" class="facebook"><i class="fa fa-facebook"></i></a>
								<a href="#" class="twitter"><i class="fa fa-twitter"></i></a>
								<a href="#" class="google"><i class="fa fa-google-plus"></i></a>
							</div>
							<div class="row">
					<div id="googleMapHtml" runat="server" class="col-md-7">
								<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2880.6334123464253!2d-79.4168236846291!3d43.780467979117184!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x882b2d0e042bb041%3A0xe820c06392355a6!2sFinch%20Station!5e0!3m2!1sen!2sca!4v1582230185676!5m2!1sen!2sca" width="100%" height="20%" frameborder="0" style="border:0;" allowfullscreen=""></iframe>
					</div>
							
							<div id="aboutCoHtml" runat="server" class="farsi-article farsi-direction farsi-font article-body" style="line-height: 35px;font-size: 14px;">
								<h1 class="article-title">Duis urbanitas eam in, tempor consequat.</h1>
								
								<p>Facilisi complectitur eos eu. Est tritani argumentum in, ei suas ignota admodum vim, ipsum choro has ut. Ei vim noluisse luptatum, nominavi mandamus qui ut. Ne usu lucilius mnesarchum, vim ex nisl summo expetenda, in dicta appareat usu. Ea cum altera fuisset adipisci, in sed eius tacimates, eu duo magna numquam placerat.</p>
								<p>Sea at dolorum nominavi adipiscing, ei eam mundi legimus, sit deleniti definiebas et. Pri dicit latine reformidans ne, offendit rationibus incorrupte an qui, eum populo molestie tacimates te. Nec ea facer vituperatoribus, cu pro feugiat minimum platonem. Elit accusam ei per. Duis illum est ut.</p>
								<p>Ex eos esse sale eligendi. Eos ut exerci audire nostrum, at pro dolores tacimates voluptaria. Facete disputando at quo, omittantur philosophia id qui. Ad labore facete suscipiantur sed. Cu iisque sanctus inciderint has, per quodsi liberavisse ea.</p>
								<p>Sit falli nonumes atomorum ex, ipsum populo iisque eum at. Sumo solet omnium eum ad, quis omnium ut ius, volumus splendide sed ad. Mea vide dicta ne, appareat patrioque has an. Wisi sale delectus eum eu, corpora salutatus no sit. Sale interesset eu per.</p>
								<h4>Sit falli nonumes atomorum ex, ipsum populo iisque eum at</h4>
								<p>Facilisi complectitur eos eu. Est tritani argumentum in, ei suas ignota admodum vim, ipsum choro has ut. Ei vim noluisse luptatum, nominavi mandamus qui ut. Ne usu lucilius mnesarchum, vim ex nisl summo expetenda, in dicta appareat usu. Ea cum altera fuisset adipisci, in sed eius tacimates, eu duo magna numquam placerat.</p>
								<p>Sea at dolorum nominavi adipiscing, ei eam mundi legimus, sit deleniti definiebas et. Pri dicit latine reformidans ne, offendit rationibus incorrupte an qui, eum populo molestie tacimates te. Nec ea facer vituperatoribus, cu pro feugiat minimum platonem. Elit accusam ei per. Duis illum est ut.</p>
								<p>Ex eos esse sale eligendi. Eos ut exerci audire nostrum, at pro dolores tacimates voluptaria. Facete disputando at quo, omittantur philosophia id qui. Ad labore facete suscipiantur sed. Cu iisque sanctus inciderint has, per quodsi liberavisse ea.</p>
								<p>Sit falli nonumes atomorum ex, ipsum populo iisque eum at. Sumo solet omnium eum ad, quis omnium ut ius, volumus splendide sed ad. Mea vide dicta ne, appareat patrioque has an. Wisi sale delectus eum eu, corpora salutatus no sit. Sale interesset eu per.</p>
							</div>
							</div>
						</article>
						<!-- /ARTICLE POST -->
						
						<!-- widget tags -->
						<div class="widget-tags">
							<ul>
								<li><a href="#">News</a></li>
								<li><a href="#">Sport</a></li>
								<li><a href="#">Lifestyle</a></li>
								<li><a href="#">Fashion</a></li>
								<li><a href="#">Music</a></li>
								<li><a href="#">Business</a></li>
							</ul>
						</div>
						<!-- /widget tags -->
						
						<!-- reply form -->
						<div class="article-reply-form">
							<div class="farsi-position section-title">
								<h2 class="farsi-font title">ارتباط مستقیم با مدیریت</h2>
							</div>
								
							<form>
								<input id="txtName" runat="server" class="input" placeholder="Name" type="text" style="width: 25%;display: block;">
								<input id="txtEmail" runat="server" class="input" placeholder="Email" type="email" style="width:25%;">
								<input id="txtSubj" runat="server" class="input" placeholder="Subject" type="text">
								<textarea id="txtDetails" runat="server" class="input" placeholder="Message" style="height:120px;"></textarea>
                                <asp:Button ID="btnSend" runat="server" class="input-btn" Text="Send Message" OnClick="btnSend_Click" />
							</form>
						</div>
						<!-- /reply form -->
					</div>
					<!-- /Main Column -->
					
				</div>
				<!-- /ROW -->
			</div>
			<!-- /CONTAINER -->
		</div>
		<!-- /SECTION -->
</asp:Content>

