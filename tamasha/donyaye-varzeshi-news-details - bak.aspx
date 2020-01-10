<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="donyaye-varzeshi-news-details - bak.aspx.cs" Inherits="tamasha_news_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <link rel="stylesheet" type="text/css" href="engine1/style.css" />
    <script type="text/javascript" src="engine1/jquery.js"></script>


    <style>
        .left-alignment {text-align: left;}
        .right-alignment {text-align: right;}
        iframe {height: 450px;}
        video {
            width: 85px;
            height: 48px;
            position: relative;
            top: 22px;
        }
        /* news */
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    	<!-- SECTION -->
		<div class="section">
			<!-- CONTAINER -->
			<div class="container">
				<!-- ROW -->
				<div class="row">
                    	<!-- Aside Column -->
					<div class="col-md-4">
						<!-- Ad widget -->
						<div class="widget center-block hidden-xs">
							<img class="center-block" src="./img/ad-1.jpg" alt=""> 
						</div>
						<!-- /Ad widget -->
						
						<!-- social widget -->
						<div class="widget social-widget">
							<div class="widget-title">
								<h2 class="farsi-font title">با ما در ارتباط باشید</h2>
							</div>
							<ul>
								<li><a href="#" class="facebook"><i class="fa fa-facebook"></i><br><span>Facebook</span></a></li>
								<li><a href="#" class="twitter"><i class="fa fa-twitter"></i><br><span>Twitter</span></a></li>
								<li><a href="#" class="google"><i class="fa fa-google"></i><br><span>Google+</span></a></li>
								<li><a href="#" class="instagram"><i class="fa fa-instagram"></i><br><span>Instagram</span></a></li>
								<li><a href="#" class="youtube"><i class="fa fa-youtube"></i><br><span>Youtube</span></a></li>
								<li><a href="#" class="rss"><i class="fa fa-rss"></i><br><span>RSS</span></a></li>
							</ul>
						</div>
						<!-- /social widget -->
						
						<!-- subscribe widget -->
						<div class="widget subscribe-widget">
							<div class="widget-title">
								<h2 class="title">عضویت در خبرنامه</h2>
							</div>
							<form>
								<input class="input" type="email" placeholder="ایمیل را وارد نمایید">
								<button class="input-btn">عضویت</button>
							</form>
						</div>
						<!-- /subscribe widget -->
						
						 <!-- article widget -->
                         <div class="widget">
                            <div class="widget-title">
                                <h2 class="farsi-font title">بیشتر خوانده شده</h2>
                            </div>

                            <!-- owl carousel 3 -->
                            <div id="owl-carousel-3" class="owl-carousel owl-theme center-owl-nav">
                                <!-- ARTICLE -->
                                <article class="article">
                                    <div class="article-img">
                                        <a href="#">
                                            <img src="./img/img-md-3.jpg" alt="">
                                        </a>
                                        <ul class="article-info">
                                            <li class="article-type"><i class="fa fa-file-text"></i></li>
                                        </ul>
                                    </div>
                                    <div class="article-body">
                                        <h4 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h4>
                                        <ul class="article-meta">
                                            <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                            <li><i class="fa fa-comments"></i>33</li>
                                        </ul>
                                    </div>
                                </article>
                                <!-- /ARTICLE -->

                                <!-- ARTICLE -->
                                <article class="article">
                                    <div class="article-img">
                                        <a href="#">
                                            <img src="./img/img-md-4.jpg" alt="">
                                        </a>
                                        <ul class="article-info">
                                            <li class="article-type"><i class="fa fa-file-text"></i></li>
                                        </ul>
                                    </div>
                                    <div class="article-body">
                                        <h4 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h4>
                                        <ul class="article-meta">
                                            <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                            <li><i class="fa fa-comments"></i>33</li>
                                        </ul>
                                    </div>
                                </article>
                                <!-- /ARTICLE -->
                            </div>
                            <!-- /owl carousel 3 -->

                            <!-- ARTICLE -->
                            <article class="article widget-article">
                                <div class="article-img">
                                    <a href="#">
                                        <img src="./img/img-widget-1.jpg" alt="">
                                    </a>
                                </div>
                                <div class="article-body">
                                    <h4 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h4>
                                    <ul class="article-meta">
                                        <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                        <li><i class="fa fa-comments"></i>33</li>
                                    </ul>
                                </div>
                            </article>
                            <!-- /ARTICLE -->

                            <!-- ARTICLE -->
                            <article class="article widget-article">
                                <div class="article-img">
                                    <a href="#">
                                        <img src="./img/img-widget-2.jpg" alt="">
                                    </a>
                                </div>
                                <div class="article-body">
                                    <h4 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h4>
                                    <ul class="article-meta">
                                        <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                        <li><i class="fa fa-comments"></i>33</li>
                                    </ul>
                                </div>
                            </article>
                            <!-- /ARTICLE -->

                            <!-- ARTICLE -->
                            <article class="article widget-article">
                                <div class="article-img">
                                    <a href="#">
                                        <img src="./img/img-widget-3.jpg" alt="">
                                    </a>
                                </div>
                                <div class="article-body">
                                    <h4 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h4>
                                    <ul class="article-meta">
                                        <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                        <li><i class="fa fa-comments"></i>33</li>
                                    </ul>
                                </div>
                            </article>
                            <!-- /ARTICLE -->
                        </div>
                         <!-- /article widget -->
						
					</div>
					<!-- /Aside Column -->

					<!-- Main Column -->
					<div class="col-md-8">

						<!-- breadcrumb -->
						<ul class="article-breadcrumb">
							<li><a href="#">Home</a></li>
							<li><a href="#">News</a></li>
							<li>Sport News</li>
						</ul>
						<!-- /breadcrumb -->
					
						<!-- ARTICLE POST -->
						<article class="article article-post">
							<div class="article-share">
								<a href="#" class="facebook"><i class="fa fa-facebook"></i></a>
								<a href="#" class="twitter"><i class="fa fa-twitter"></i></a>
								<a href="#" class="google"><i class="fa fa-google-plus"></i></a>
							</div>
                            <!-- News image -->
							
                            <!-- News caserol -->


                            <div id="imgNewsHtml" runat="server" ClientIDMode="static">
                            <div class="ws_images"><ul>
		                            <li><img src="data1/images/dsc_2325.jpg" alt="DSC_2325" title="DSC_2325" id="wows1_0"/></li>
		                            <li><img src="data1/images/dsc_2326.jpg" alt="DSC_2326" title="DSC_2326" id="wows1_1"/></li>
		                            <li><img src="data1/images/dsc_2327.jpg" alt="DSC_2327" title="DSC_2327" id="wows1_2"/></li>
		                            <li><a href="http://wowslider.net"><img src="data1/images/dsc_2332.jpg" alt="responsive slider" title="DSC_2332" id="wows1_3"/></a></li>
		                            <li><img src="data1/images/dsc_2333.jpg" alt="DSC_2333" title="DSC_2333" id="wows1_4"/></li>
	                            </ul></div>
	                            <div class="ws_thumbs">
                            <div>
		                            <a href="#wows1_0" title="DSC_2325"><img src="data1/tooltips/dsc_2325.jpg" alt="" /></a>
		                            <a href="#wows1_1" title="DSC_2326"><img src="data1/tooltips/dsc_2326.jpg" alt="" /></a>
		                            <a href="#wows1_2" title="DSC_2327"><img src="data1/tooltips/dsc_2327.jpg" alt="" /></a>
		                            <a href="#wows1_3" title="DSC_2332"><img src="data1/tooltips/dsc_2332.jpg" alt="" /></a>
		                            <a href="#wows1_4" title="DSC_2333"><img src="data1/tooltips/dsc_2333.jpg" alt="" /></a>
	                            </div>
                            </div>
                            <div class="ws_script" style="position:absolute;left:-99%"><a href="http://wowslider.net">wow slider</a> by WOWSlider.com v8.8</div>
                            <div class="ws_shadow"></div>
                            </div>	



                            




                            <script type="text/javascript" src="engine1/wowslider.js"></script>
                            <script type="text/javascript" src="engine1/script.js"></script>





                            <!-- News details -->
							<div id="newsDetailHtml" runat="server" class="article-body">
								<ul class="article-info">
									<li class="article-category"><a href="#">ورزشی</a></li>
									<li class="article-type"><i class="fa fa-file-text"></i></li>
								</ul>
								<h1 class="article-title">Duis urbanitas eam in, tempor consequat.</h1>
								<ul class="article-meta">
									<li><i class="fa fa-clock-o"></i> April 04, 2017</li>
									<%--<li><i class="fa fa-comments"></i> 33</li>--%>
								</ul>
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
						</article>
						<!-- /ARTICLE POST -->
						
						<!-- widget tags -->
						<div class="widget-tags">
							<ul>
								<li><a href="default.aspx">اخبار</a></li>
								<li><a href="#">ورزشی</a></li>
								<li><a href="#">هنری</a></li>
								<li><a href="#">فشن</a></li>
								<li><a href="#">موسیفی</a></li>
								<li><a href="#">اخبار پربازدید</a></li>
							</ul>
						</div>
						<!-- /widget tags -->
						
						<!-- article comments -->
						<div class="article-comments">
							<div class="section-title">
								<h2 class="farsi-font farsi-article title">اخبار مشابه</h2>
							</div>
								
							<!-- comment -->
							<div class="media">
								
								<div class="media-body">
									<div class="media-heading">
										<h5 class="farsi-font farsi-title">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم </h5><p class="left-alignment reply-time">April 04, 2017 At 9:30 AM</p>
									</div>
									<p class="farsi-font farsi-article">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>				
									<%--<a href="#" class="reply-btn">Reply</a>--%>
								</div>
								
								<div class="media-left">
									<img src="img/av-1.jpg" alt="">
								</div>
							</div>
							<!-- /comment -->
						</div>
						<!-- /article comments -->
					</div>
					<!-- /Main Column -->
					
				
				</div>
				<!-- /ROW -->
			</div>
			<!-- /CONTAINER -->
		</div>
		<!-- /SECTION -->
		
		<!-- AD SECTION -->
		<div class="room-bottom visible-lg visible-md">
			<img class="center-block" src="./img/ad-3.jpg" alt="">
		</div>
		<!-- /AD SECTION -->
	

</asp:Content>

