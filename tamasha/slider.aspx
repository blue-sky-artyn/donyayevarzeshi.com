<%@ Page Language="C#" AutoEventWireup="true" CodeFile="slider.aspx.cs" Inherits="slider" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <title></title>
    <!-- Start WOWSlider.com HEAD section --> <!-- add to the <head> of your page -->
	<link rel="stylesheet" type="text/css" href="engine/style.css" />
	<script type="text/javascript" src="engine/jquery.js"></script>	
    <script src="https://www.youtube.com/iframe_api"></script>

</head>
<body>
    <form id="form1" runat="server">
       <!-- Owl Carousel 1_Sldier -->
    	<!-- Start WOWSlider.com BODY section --> <!-- add to the <body> of your page -->
	<div id="wowslider-container1">
	<div class="ws_images"><ul>
		<li><img src="images/1.jpg" alt="1" title="slider 1" id="wows1_0"/></li>
		<li><img src="images/2.jpg" alt="2" title="slider 2" id="wows1_1"/></li>
		<li><a><img src="images/3.jpg" alt="jquery carousel" title="slider 3" id="wows1_2"/></a></li>
		<li><iframe width="100%" height="100%" src="https://www.youtube.com/embed/Y2ZryaogYIk?autoplay=0&rel=0&enablejsapi=1&playerapiid=ytplayer&wmode=transparent" frameborder="0" allowfullscreen></iframe><img src="images/y2zryaogyik.png" alt="SHALLOW - Lady GaGa & Bradley Cooper (Saxophone Cover)" title="SHALLOW - Lady GaGa & Bradley Cooper (Saxophone Cover)" id="wows1_3"/></li>
	</ul></div>
	<div class="ws_bullets"><div>
		<a href="#" title="1"><span><img src="images/tooltips/1.jpg" alt="1"/>1</span></a>
		<a href="#" title="2"><span><img src="images/tooltips/2.jpg" alt="2"/>2</span></a>
		<a href="#" title="3"><span><img src="images/tooltips/3.jpg" alt="3"/>3</span></a>
		<a href="#" title="SHALLOW - Lady GaGa & Bradley Cooper (Saxophone Cover)"><span><img src="images/tooltips/y2zryaogyik.png" alt="SHALLOW - Lady GaGa & Bradley Cooper (Saxophone Cover)"/>4</span></a>
	</div></div>
	<div class="ws_shadow"></div>
	</div>	
	<script type="text/javascript" src="engine/wowslider.js"></script>
	<script type="text/javascript" src="engine/script.js"></script>
	<!-- End WOWSlider.com BODY section -->
    </form>
    	
</body>
</html>
