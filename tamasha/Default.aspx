<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        video {
            height: 370px;
        }

        .other-tabs {
            display: none;
        }

        .sub-title {
            color: whitesmoke;
            font-weight: bold;
            font-style: italic;
            margin: 0 25px;
        }

        .sub-title-news {
            font-size: 9px;
            color: #ef233c;
            margin: 7px 10px;
            /* text-decoration: underline; */
            border-bottom: #ef233c solid 1px;
        }

        .title-block {
            display: block;
            font-size: 12px;
            margin: 5px 0px;
            line-height: 25px;
            border-bottom: 1px solid #80808040;
            padding: 0 5% 0 0;
        }

        .article-body-top {
            height: 281px;
            overflow: hidden;
        }

        .article-body-2 {
            height: 360px;
            overflow: hidden;
        }

        .article-body-3 {
            height: 450px;
            overflow: hidden;
        }

        .article-body-4 {
            height: 450px;
            overflow: hidden;
        }
        /* Slider items */
        .farsi-slider-title a {
            color:white;
        }

        /* limiter of page*/
        .container-limiter {
            padding: 5px;
            background-color: white;
        }
        body {
            background: rgb(204,204,204);
            background: linear-gradient(0deg, rgba(204,204,204,1) 73%, rgba(190,190,190,1) 100%);
        }
    </style>
    <%-- Slider --%>
    <!-- Start WOWSlider.com HEAD section --> <!-- add to the <head> of your page -->
	<link rel="stylesheet" type="text/css" href="engine/style.css" />
	<script type="text/javascript" src="engine/jquery.js"></script>	
    <script src="https://www.youtube.com/iframe_api"></script>

<!-- End WOWSlider.com HEAD section -->
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

   <%-- <!-- Owl Carousel 1_Sldier -->
    <div id="sliderHtml" clientidmode="static" runat="server" style="width: 70%;margin: 0 auto;">
        <div id="owl-carousel-1" class="news-background-filler owl-carousel owl-theme center-owl-nav">
            <!-- ARTICLE -->
            <article class="article thumb-article">
                <div class="article-img">
                    <img class="head-news-img" src="./img/news/1.jpg" alt="">
                </div>
                <div class="article-body">
                    <ul class="article-info">
                        <li class="article-category"><a href="#">News</a></li>
                        <li class="article-type"><i class="fa fa-camera"></i></li>
                    </ul>
                    <h2 class="farsi-position farsi-font farsi-slider-title article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h2>
                    <ul class="article-meta">
                        <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                        <li><i class="fa fa-comments"></i>33</li>
                    </ul>
                </div>
            </article>
            <!-- /ARTICLE -->

            <!-- ARTICLE -->
            <article class="article thumb-article">
                <div class="article-img">
                    <img class="head-news-img" src="./img/news/2.jpg" alt="">
                </div>
                <div class="article-body">
                    <ul class="article-info">
                        <li class="article-category"><a href="#">News</a></li>
                        <li class="article-type"><i class="fa fa-file-text"></i></li>
                    </ul>
                    <h2 class="farsi-position farsi-font farsi-slider-title article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h2>
                    <ul class="article-meta">
                        <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                        <li><i class="fa fa-comments"></i>33</li>
                    </ul>
                </div>
            </article>
            <!-- /ARTICLE -->

            <!-- ARTICLE -->
            <article class="article thumb-article">
                <div class="article-img">
                    <img class="head-news-img" src="./img/news/3.jpg" alt="">
                </div>
                <div class="article-body">
                    <ul class="article-info">
                        <li class="article-category"><a href="#">News</a></li>
                        <li class="article-type"><i class="fa fa-camera"></i></li>
                    </ul>
                    <h2 class="farsi-position farsi-font farsi-slider-title article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h2>
                    <ul class="article-meta">
                        <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                        <li><i class="fa fa-comments"></i>33</li>
                    </ul>
                </div>
            </article>
            <!-- /ARTICLE -->
        </div>
    </div>
    <!-- /Owl Carousel 1 -->--%>


    <%-- New slider  --%>

    <!-- Start WOWSlider.com BODY section -->
<div id="wowslider-container1">
	<div class="ws_images"><ul id="sliderItemsHtml" runat="server" >
		<li><img src="images/1.jpg" alt="1" title="لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم" id="wows1_0"/>
            <h2 class="farsi-position farsi-font farsi-slider-title" style="color:white;"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h2>
		</li>
		<li><img src="images/2.jpg" alt="2" title="slider 2" id="wows1_1"/></li>
		<li><a><img src="images/3.jpg" alt="jquery carousel" title="slider 3" id="wows1_2"/></a></li>
		<li><iframe width="100%" height="100%" src="https://www.youtube.com/embed/Y2ZryaogYIk?autoplay=0&rel=0&enablejsapi=1&playerapiid=ytplayer&wmode=transparent" frameborder="0" allowfullscreen></iframe><img src="images/y2zryaogyik.png" alt="SHALLOW - Lady GaGa & Bradley Cooper (Saxophone Cover)" title="SHALLOW - Lady GaGa & Bradley Cooper (Saxophone Cover)" id="wows1_3"/></li>
		<li><a><img src="images/4.jpg" alt="jquery carousel" title="slider 4" id="wows1_4"/></a></li>
	</ul></div>
	<div class="ws_bullets"><div id="sliderToolTipHtml" runat="server">
		<a href="#" title="1"><span><img src="images/1.jpg" alt="1" style="width:85px;"/>1</span></a>
		<a href="#" title="2"><span><img src="images/2.jpg" alt="2" style="width:85px;"/>2</span></a>
		<a href="#" title="3"><span><img src="images/3.jpg" alt="3" style="width:85px;"/>3</span></a>
		<a href="#" title="SHALLOW - Lady GaGa & Bradley Cooper (Saxophone Cover)"><span><img src="images/tooltips/y2zryaogyik.png" alt="SHALLOW - Lady GaGa & Bradley Cooper (Saxophone Cover)"/>4</span></a>
		<a href="#" title="3"><span><img src="images/4.jpg" alt="4" style="width:85px;"/>4</span></a>
	</div></div>
	<div class="ws_shadow"></div>
	</div>	
	<script type="text/javascript" src="engine/wowslider.js"></script>
	<script type="text/javascript" src="engine/script.js"></script>
<!-- End WOWSlider.com BODY section -->



    <!-- SECTION (TAB NEWS) -->
    <div class="section">
        <!-- CONTAINER -->
        <div class="container container-limiter">
            <!-- ROW -->
            <div class="row">
                <div class="col-md-4">
                    <div class="farsi-position section-title">
                        <h2 class="farsi-font title">اخبار برجسته</h2>
                        <!-- tab nav -->
                        <ul class="farsi-font farsi-float tab-nav pull-left">
                            <li><a data-toggle="tab" href="#tabNews2">پربازدید</a></li>
                            <li class="active"><a data-toggle="tab" href="#tabNews1">جدبدترین ها</a></li>
                        </ul>
                        <!-- /tab nav -->
                    </div>

                    <div id="sideNewsHtml" runat="server" class="tab-content" style="border: 1px solid #80808047; overflow: hidden;">
                        <!-- tab1 -->
                        <div id="tabNews2" class="tab-pane fade in">
                            <div id="popularNewsSideHtml" runat="server" class="row">
                                <!-- Column 1 -->
                                <a class="title-block farsi-font farsi-position article-title" href="#">Testtttttt</a>
                            </div>
                        </div>

                        <div id="tabNews1" class="tab-pane fade in active">
                            <!-- row -->
                            <div id="recentNewsSideHtml" runat="server" class="row">
                            </div>
                            <!-- /row -->
                        </div>
                        <!-- /tab1 -->
                    </div>

                </div>
                <!-- Main Column -->
                <div class="col-md-8">
                    <!-- section title -->
                    <div class="farsi-position section-title">
                        <h2 class="farsi-font title">آخرین اخبار </h2>
                        <!-- tab nav -->
                        <ul id="tabsHtml" runat="server" clientidmode="static" class="farsi-font farsi-float tab-nav pull-left">
                            <li><a data-toggle="tab" href="#tab1">مشاهیر</a></li>
                            <li><a data-toggle="tab" href="#tab2">سینما</a></li>
                            <li><a data-toggle="tab" href="#tab1">موسیقی</a></li>
                            <li><a data-toggle="tab" href="#tab1">مشاغل</a></li>
                            <li><a data-toggle="tab" href="#tab1">ورزشی</a></li>
                            <li class="active"><a data-toggle="tab" href="#tab1">تمام</a></li>
                        </ul>
                        <!-- /tab nav -->
                    </div>
                    <!-- /section title -->

                    <!-- Tab content -->
                    <div id="tabNewsDetailsHtml" runat="server" class="tab-content">
                        <!-- tab1 -->
                        <div id="tab2" class="tab-pane fade in active">
                            <div class="row">
                                <!-- Column 1 -->
                                <div class="col-md-3 col-sm-6">
                                    <!-- ARTICLE -->
                                    <article class="article">
                                        <div class="article-img">
                                            <a href="#">
                                                <img src="./img/img-md-1.jpg" alt="">
                                            </a>
                                            <ul class="article-info">
                                                <li class="article-type"><i class="fa fa-camera"></i></li>
                                            </ul>
                                        </div>
                                        <div class="article-body">
                                            <h4 class="farsi-font farsi-position article-title"><a href="#">Testtttttt</a></h4>
                                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                                            <ul class="article-meta">
                                                <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                                <li><i class="fa fa-comments"></i>33</li>
                                            </ul>
                                        </div>
                                    </article>
                                    <!-- /ARTICLE -->
                                </div>
                                <!-- /Column 1 -->
                                <!-- Column 1 -->
                                <div class="col-md-3 col-sm-6">
                                    <!-- ARTICLE -->
                                    <article class="article">
                                        <div class="article-img">
                                            <a href="#">
                                                <img src="./img/img-md-1.jpg" alt="">
                                            </a>
                                            <ul class="article-info">
                                                <li class="article-type"><i class="fa fa-camera"></i></li>
                                            </ul>
                                        </div>
                                        <div class="article-body">
                                            <h4 class="farsi-font farsi-position article-title"><a href="#">Testtttttt</a></h4>
                                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                                            <ul class="article-meta">
                                                <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                                <li><i class="fa fa-comments"></i>33</li>
                                            </ul>
                                        </div>
                                    </article>
                                    <!-- /ARTICLE -->
                                </div>
                                <!-- /Column 1 -->
                                <!-- Column 1 -->
                                <div class="col-md-3 col-sm-6">
                                    <!-- ARTICLE -->
                                    <article class="article">
                                        <div class="article-img">
                                            <a href="#">
                                                <img src="./img/img-md-1.jpg" alt="">
                                            </a>
                                            <ul class="article-info">
                                                <li class="article-type"><i class="fa fa-camera"></i></li>
                                            </ul>
                                        </div>
                                        <div class="article-body">
                                            <h4 class="farsi-font farsi-position article-title"><a href="#">Testtttttt</a></h4>
                                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                                            <ul class="article-meta">
                                                <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                                <li><i class="fa fa-comments"></i>33</li>
                                            </ul>
                                        </div>
                                    </article>
                                    <!-- /ARTICLE -->
                                </div>
                                <!-- /Column 1 -->
                            </div>
                        </div>

                        <div id="tab1" class="tab-pane fade in active">
                            <!-- row -->
                            <div class="row">
                                <!-- Column 1 -->
                                <div class="col-md-3 col-sm-6">
                                    <!-- ARTICLE -->
                                    <article class="article">
                                        <div class="article-img">
                                            <a href="#">
                                                <img src="./img/img-md-1.jpg" alt="">
                                            </a>
                                            <ul class="article-info">
                                                <li class="article-type"><i class="fa fa-camera"></i></li>
                                            </ul>
                                        </div>
                                        <div class="article-body">
                                            <h4 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h4>
                                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                                            <ul class="article-meta">
                                                <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                                <li><i class="fa fa-comments"></i>33</li>
                                            </ul>
                                        </div>
                                    </article>
                                    <!-- /ARTICLE -->
                                </div>
                                <!-- /Column 1 -->

                                <!-- Column 2 -->
                                <div class="col-md-3 col-sm-6">
                                    <!-- ARTICLE -->
                                    <article class="article">
                                        <div class="article-img">
                                            <a href="#">
                                                <img src="./img/img-md-2.jpg" alt="">
                                            </a>
                                        </div>
                                        <div class="article-body">
                                            <h4 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h4>
                                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                                            <ul class="article-meta">
                                                <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                                <li><i class="fa fa-comments"></i>33</li>
                                            </ul>
                                        </div>
                                    </article>
                                    <!-- /ARTICLE -->
                                </div>
                                <!-- /Column 2 -->

                                <!-- Column 3 -->
                                <div class="col-md-3 col-sm-6">
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
                                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                                            <ul class="article-meta">
                                                <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                                <li><i class="fa fa-comments"></i>33</li>
                                            </ul>
                                        </div>
                                    </article>
                                    <!-- /ARTICLE -->
                                </div>
                                <!-- /Column 3 -->

                                <!-- Column 4 -->
                                <div class="col-md-3 col-sm-6">
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
                                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                                            <ul class="article-meta">
                                                <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                                <li><i class="fa fa-comments"></i>33</li>
                                            </ul>
                                        </div>
                                    </article>
                                    <!-- /ARTICLE -->
                                </div>
                                <!-- Column 4 -->
                            </div>
                            <!-- /row -->

                            <!-- row -->
                            <div class="row">
                                <h2 class="farsi-position farsi-font farsi-title title">آخرین خبرها</h2>
                                <!-- Column 1 -->
                                <div class="col-md-4 col-sm-6">
                                    <!-- ARTICLE -->
                                    <article class="article widget-article">
                                        <div class="article-img">
                                            <a href="#">
                                                <img src="./img/img-widget-1.jpg" alt="">
                                            </a>
                                        </div>
                                        <div class="article-body">
                                            <h4 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h4>
                                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
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
                                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                                            <ul class="article-meta">
                                                <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                                <li><i class="fa fa-comments"></i>33</li>
                                            </ul>
                                        </div>
                                    </article>
                                    <!-- /ARTICLE -->
                                </div>
                                <!-- /Column 1 -->

                                <!-- Column 2 -->
                                <div class="col-md-4 col-sm-6">
                                    <!-- ARTICLE -->
                                    <article class="article widget-article">
                                        <div class="article-img">
                                            <a href="#">
                                                <img src="./img/img-widget-3.jpg" alt="">
                                            </a>
                                        </div>
                                        <div class="article-body">
                                            <h4 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h4>
                                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
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
                                                <img src="./img/img-widget-4.jpg" alt="">
                                            </a>
                                        </div>
                                        <div class="article-body">
                                            <h4 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h4>
                                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                                            <ul class="article-meta">
                                                <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                                <li><i class="fa fa-comments"></i>33</li>
                                            </ul>
                                        </div>
                                    </article>
                                    <!-- /ARTICLE -->
                                </div>
                                <!-- /Column 2 -->

                                <!-- /Column 3 -->
                                <div class="col-md-4 hidden-sm">
                                    <!-- ARTICLE -->
                                    <article class="article widget-article">
                                        <div class="article-img">
                                            <a href="#">
                                                <img src="./img/img-widget-5.jpg" alt="">
                                            </a>
                                        </div>
                                        <div class="article-body">
                                            <h4 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h4>
                                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
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
                                                <img src="./img/img-widget-6.jpg" alt="">
                                            </a>
                                        </div>
                                        <div class="article-body">
                                            <h4 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h4>
                                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                                            <ul class="article-meta">
                                                <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                                <li><i class="fa fa-comments"></i>33</li>
                                            </ul>
                                        </div>
                                    </article>
                                    <!-- /ARTICLE -->
                                </div>
                                <!-- /Column 3 -->
                            </div>
                            <!-- /row -->
                        </div>
                        <!-- /tab1 -->
                    </div>
                    <!-- /tab content -->
                </div>
                <!-- /Main Column -->
            </div>
            <!-- /ROW -->
        </div>
        <!-- /CONTAINER -->
    </div>
    <!-- /SECTION -->

    <!-- SECTION (HIT NEWS) -->
    <div class="section">
        <!-- CONTAINER -->
        <div class="container container-limiter">
            <!-- ROW -->
            <div class="row">
                <!-- Main Column -->
                <div class="col-md-8">
                    <!-- row -->
                    <div class="row">
                        <!-- Column 1 -->
                        <div id="hitNewsSportHtml" runat="server" class="col-md-12 col-sm-6">
                            <!-- section title -->
                            <div class="farsi-position section-title">
                                <h2 class="farsi-font title">اجتماعی</h2>
                            </div>
                            <!-- /section title -->

                            <!-- ARTICLE -->
                            <article class="article col-md-6">
                                <div class="article-img">
                                    <a href="#">
                                        <img src="./img/img-sm-1.jpg" alt="">
                                    </a>
                                    <ul class="article-info">
                                        <li class="article-type"><i class="fa fa-camera"></i></li>
                                    </ul>
                                </div>
                                <div class="article-body">
                                    <h3 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h3>
                                    <ul class="article-meta">
                                        <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                        <li><i class="fa fa-comments"></i>33</li>
                                    </ul>
                                    <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                                </div>
                            </article>

                            <article class="article col-md-6 ">
                                <div class="article-img">
                                    <a href="#">
                                        <img src="./img/img-sm-1.jpg" alt="">
                                    </a>
                                    <ul class="article-info">
                                        <li class="article-type"><i class="fa fa-camera"></i></li>
                                    </ul>
                                </div>
                                <div class="article-body">
                                    <h3 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h3>
                                    <ul class="article-meta">
                                        <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                        <li><i class="fa fa-comments"></i>33</li>
                                    </ul>
                                    <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                                </div>
                            </article>
                            <!-- /ARTICLE -->

                            <!-- ARTICLE -->
                            <article class="article widget-article">
                                <div class="article-img">
                                    <a href="#">
                                        <img src="./img/img-widget-7.jpg" alt="">
                                    </a>
                                </div>
                                <div class="article-body">
                                    <h3 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h3>
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
                                        <img src="./img/img-widget-8.jpg" alt="">
                                    </a>
                                </div>
                                <div class="article-body">
                                    <h3 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h3>
                                    <ul class="article-meta">
                                        <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                        <li><i class="fa fa-comments"></i>33</li>
                                    </ul>
                                </div>
                            </article>
                            <!-- /ARTICLE -->
                        </div>
                        <!-- /Column 1 -->

                       
                    </div>
                    <!-- /row -->

                    <!-- row -->
                    <div id="newsHtml" runat="server" class="row">
                        <!-- section title -->
                        <div class="col-md-12">
                            <div class="farsi-position section-title">
                                <h2 class="farsi-font title">اخبار</h2>
                            </div>
                        </div>
                        <!-- /section    title -->

                        <!-- Column 1 -->
                        <div class="col-md-6 col-sm-6">
                            <!-- ARTICLE -->
                            <article class="article">
                                <div class="article-img">
                                    <a href="#">
                                        <img src="./img/img-sm-3.jpg" alt="">
                                    </a>
                                    <ul class="article-info">
                                        <li class="article-type"><i class="fa fa-camera"></i></li>
                                    </ul>
                                </div>
                                <div class="article-body">
                                    <h3 class="farsi-font farsi-position article-title"><a href="#">1 لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h3>
                                    <ul class="article-meta">
                                        <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                        <li><i class="fa fa-comments"></i>33</li>
                                    </ul>
                                    <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                                </div>
                            </article>
                            <!-- /ARTICLE -->
                        </div>
                        <!-- /Column 1 -->

                        <!-- /Column 2 -->
                        <div class="col-md-6 col-sm-6">
                            <!-- ARTICLE -->
                            <article class="article">
                                <div class="article-img">
                                    <a href="#">
                                        <img src="./img/img-sm-4.jpg" alt="">
                                    </a>
                                    <ul class="article-info">
                                        <li class="article-type"><i class="fa fa-camera"></i></li>
                                    </ul>
                                </div>
                                <div class="article-body">
                                    <h3 class="farsi-font farsi-position article-title"><a href="#">2 لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h3>
                                    <ul class="article-meta">
                                        <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                        <li><i class="fa fa-comments"></i>33</li>
                                    </ul>
                                    <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                                </div>
                            </article>
                            <!-- /ARTICLE -->
                        </div>
                        <!-- /Column 2 -->
                    </div>
                    <!-- /row -->

                    <!-- row -->
                    <div id="newsSmallHtml" runat="server" class="row">
                        <!-- Column 1 -->
                        <div class="col-md-4 col-sm-4">
                            <!-- ARTICLE -->
                            <article class="article">
                                <div class="article-img">
                                    <a href="#">
                                        <img src="./img/img-md-1.jpg" alt="">
                                    </a>
                                    <ul class="article-info">
                                        <li class="article-type"><i class="fa fa-file-text"></i></li>
                                    </ul>
                                </div>
                                <div class="article-body">
                                    <h3 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h3>
                                    <ul class="article-meta">
                                        <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                        <li><i class="fa fa-comments"></i>33</li>
                                    </ul>
                                </div>
                            </article>
                            <!-- /ARTICLE -->
                        </div>
                        <!-- /Column 1 -->

                        <!-- Column 2 -->
                        <div class="col-md-4 col-sm-4">
                            <!-- ARTICLE -->
                            <article class="article">
                                <div class="article-img">
                                    <a href="#">
                                        <img src="./img/img-md-2.jpg" alt="">
                                    </a>
                                    <ul class="article-info">
                                        <li class="article-type"><i class="fa fa-file-text"></i></li>
                                    </ul>
                                </div>
                                <div class="article-body">
                                    <h3 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h3>
                                    <ul class="article-meta">
                                        <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                        <li><i class="fa fa-comments"></i>33</li>
                                    </ul>
                                </div>
                            </article>
                            <!-- /ARTICLE -->
                        </div>
                        <!-- /Column 2 -->

                        <!-- Column 3 -->
                        <div class="col-md-4 col-sm-4">
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
                                    <h3 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h3>
                                    <ul class="article-meta">
                                        <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                        <li><i class="fa fa-comments"></i>33</li>
                                    </ul>
                                </div>
                            </article>
                            <!-- /ARTICLE -->
                        </div>
                        <!-- /Column 3 -->
                    </div>
                    <!-- /row -->
                </div>
                <!-- /Main Column -->

                <!-- Aside Column -->
                <div class="col-md-4">
                    <!-- Ad widget -->
                    <div id="adSide" runat="server" class="widget center-block hidden-xs">
                        <img class="center-block" src="./img/headadbox.jpg" alt="">
                    </div>
                    <!-- /Ad widget -->

                    <!-- social widget -->
                    <%--<div class="widget social-widget">
                        <div class="widget-title">
                            <h2 class="farsi-font title">با ما در ارتباط باشید</h2>
                        </div>
                        <ul>
                            <li><a href="#" class="facebook"><i class="fa fa-facebook"></i>
                                <br>
                                <span>Facebook</span></a></li>
                            <li><a href="#" class="twitter"><i class="fa fa-twitter"></i>
                                <br>
                                <span>Twitter</span></a></li>
                            <li><a href="#" class="google"><i class="fa fa-google"></i>
                                <br>
                                <span>Google+</span></a></li>
                            <li><a href="#" class="instagram"><i class="fa fa-instagram"></i>
                                <br>
                                <span>Instagram</span></a></li>
                            <li><a href="#" class="youtube"><i class="fa fa-youtube"></i>
                                <br>
                                <span>Youtube</span></a></li>
                            <li><a href="#" class="rss"><i class="fa fa-rss"></i>
                                <br>
                                <span>RSS</span></a></li>
                        </ul>
                    </div>--%>
                    <!-- /social widget -->

                    <!-- subscribe widget -->
                    <div class="widget subscribe-widget">
                        <div class="widget-title">
                            <h2 class="farsi-font title">عضویت در خبرنامه</h2>
                        </div>
                        <form>
                            <input class="input" type="email" placeholder="ایمیل را وارد نمایید">
                            <button class="farsi-font farsi-title input-btn">عضویت</button>
                        </form>
                    </div>
                    <!-- /subscribe widget -->

                    <!-- article widget -->
                    <div class="widget">
                        <div class="widget-title">
                            <h2 class="farsi-font title">بیشتر خوانده شده</h2>
                        </div>

                        <div id="moreReadSideHtml" runat="server">
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
                        </div>
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
            </div>
            <!-- /ROW -->
        </div>
        <!-- /CONTAINER -->
    </div>
    <!-- /SECTION -->

    <!-- AD SECTION -->
    <div id="adMiddle" runat="server" class="visible-lg visible-md">
        <img class="center-block" src="./img/headadmiddle.jpg" alt="">
    </div>
    <!-- /AD SECTION -->

    <!-- SECTION (POPULAR VIDEOS) -->
    <div class="section">
        <!-- CONTAINER -->
        <div class="container container-limiter">
            <!-- ROW -->
            <div class="row">
                <!-- Main Column -->
                <div class="col-md-12">
                    <!-- section title -->
                    <div class="farsi-position section-title">
                        <h2 class="farsi-font title">ویدیوهای محبوب</h2>
                        <div id="nav-carousel-2" class="custom-owl-nav pull-left"></div>
                    </div>
                    <!-- /section title -->

                    <!-- owl carousel 2 -->
                    <div id="owl-carousel-2" class="owl-carousel owl-theme">
                        <!-- ARTICLE -->
                        <article class="article thumb-article">
                            <div class="article-img">
                                <video id="video1">
                                    <source src="video/CNN.mp4" type="video/mp4">
                                    Your browser does not support HTML5 video.
                                </video>

                                <%--<img src="./img/img-thumb-1.jpg" alt="">--%>
                            </div>
                            <div class="article-body">
                                <ul class="article-info">
                                    <li class="article-category"><a onclick="playPause()">Play</a></li>
                                    <li class="article-type"><i class="fa fa-video-camera"></i></li>
                                </ul>
                                <h4 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h4>
                                <ul class="article-meta">
                                    <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                    <li><i class="fa fa-comments"></i>33</li>
                                </ul>
                            </div>
                        </article>
                        <!-- /ARTICLE -->

                        <!-- ARTICLE -->
                        <article class="article thumb-article">
                            <div class="article-img">
                                <img src="./img/img-thumb-2.jpg" alt="">
                            </div>
                            <div class="article-body">
                                <ul class="article-info">
                                    <li class="article-category"><a href="#">News</a></li>
                                    <li class="article-type"><i class="fa fa-video-camera"></i></li>
                                </ul>
                                <h4 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h4>
                                <ul class="article-meta">
                                    <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                    <li><i class="fa fa-comments"></i>33</li>
                                </ul>
                            </div>
                        </article>
                        <!-- /ARTICLE -->

                        <!-- ARTICLE -->
                        <article class="article thumb-article">
                            <div class="article-img">
                                <img src="./img/img-thumb-3.jpg" alt="">
                            </div>
                            <div class="article-body">
                                <ul class="article-info">
                                    <li class="article-category"><a href="#">News</a></li>
                                    <li class="article-type"><i class="fa fa-video-camera"></i></li>
                                </ul>
                                <h4 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h4>
                                <ul class="article-meta">
                                    <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                    <li><i class="fa fa-comments"></i>33</li>
                                </ul>
                            </div>
                        </article>
                        <!-- /ARTICLE -->

                        <!-- ARTICLE -->
                        <article class="article thumb-article">
                            <div class="article-img">
                                <img src="./img/img-thumb-4.jpg" alt="">
                            </div>
                            <div class="article-body">
                                <ul class="article-info">
                                    <li class="article-category"><a href="#">News</a></li>
                                    <li class="article-type"><i class="fa fa-video-camera"></i></li>
                                </ul>
                                <h4 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h4>
                                <ul class="article-meta">
                                    <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                    <li><i class="fa fa-comments"></i>33</li>
                                </ul>
                            </div>
                        </article>
                        <!-- /ARTICLE -->
                    </div>
                    <!-- /owl carousel 2 -->
                </div>
                <!-- /Main Column -->
            </div>
            <!-- /ROW -->
        </div>
        <!-- /CONTAINER -->
    </div>
    <!-- /SECTION -->

    <!-- SECTION (NEWS / SIDE BAR) -->
    <div class="section">
        <!-- CONTAINER -->
        <div class="container container-limiter">
            <!-- ROW -->
            <div class="row">
                <!-- Main Column -->
                <div id="popularNewsHtml" runat="server" class="col-md-8">
                    <!-- section title -->
                    <div class="farsi-position section-title">
                        <h2 class="farsi-font title">اخبار</h2>
                    </div>
                    <!-- /section title -->

                    <!-- ARTICLE -->
                    <article class="article row-article">
                        <div class="article-img">
                            <a href="#">
                                <img src="./img/img-md-1.jpg" alt="">
                            </a>
                        </div>
                        <div class="article-body">
                            <ul class="article-info">
                                <li class="article-category"><a href="#">News</a></li>
                                <li class="article-type"><i class="fa fa-file-text"></i></li>
                            </ul>
                            <h4 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h4>
                            <ul class="article-meta">
                                <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                <li><i class="fa fa-comments"></i>33</li>
                            </ul>
                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                        </div>
                    </article>
                    <!-- /ARTICLE -->

                    <!-- ARTICLE -->
                    <article class="article row-article">
                        <div class="article-img">
                            <a href="#">
                                <img src="./img/img-md-2.jpg" alt="">
                            </a>
                        </div>
                        <div class="article-body">
                            <ul class="article-info">
                                <li class="article-category"><a href="#">News</a></li>
                                <li class="article-type"><i class="fa fa-file-text"></i></li>
                            </ul>
                            <h3 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h3>
                            <ul class="article-meta">
                                <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                <li><i class="fa fa-comments"></i>33</li>
                            </ul>
                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                        </div>
                    </article>
                    <!-- /ARTICLE -->

                    <!-- ARTICLE -->
                    <article class="article row-article">
                        <div class="article-img">
                            <a href="#">
                                <img src="./img/img-md-3.jpg" alt="">
                            </a>
                        </div>
                        <div class="article-body">
                            <ul class="article-info">
                                <li class="article-category"><a href="#">News</a></li>
                                <li class="article-type"><i class="fa fa-file-text"></i></li>
                            </ul>
                            <h3 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h3>
                            <ul class="article-meta">
                                <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                <li><i class="fa fa-comments"></i>33</li>
                            </ul>
                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                        </div>
                    </article>
                    <!-- /ARTICLE -->

                    <!-- ARTICLE -->
                    <article class="article row-article">
                        <div class="article-img">
                            <a href="#">
                                <img src="./img/img-md-4.jpg" alt="">
                            </a>
                        </div>
                        <div class="article-body">
                            <ul class="article-info">
                                <li class="article-category"><a href="#">News</a></li>
                                <li class="article-type"><i class="fa fa-file-text"></i></li>
                            </ul>
                            <h3 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h3>
                            <ul class="article-meta">
                                <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                <li><i class="fa fa-comments"></i>33</li>
                            </ul>
                            <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد.</p>
                        </div>
                    </article>
                    <!-- /ARTICLE -->

                    <!-- pagination -->
                    <div class="article-pagination">
                        <ul>
                            <li class="active"><a href="#" class="active">1</a></li>
                            <li><a href="#">2</a></li>
                            <li><a href="#">3</a></li>
                            <li><a href="#"><i class="fa fa-angle-right"></i></a></li>
                        </ul>
                    </div>
                    <!-- /pagination -->
                </div>
                <!-- /Main Column -->

                <!-- Aside Column -->
                <div class="col-md-4">
                    <!-- article widget -->
                    <div class="widget">
                        <div class="widget-title">
                            <h2 class="farsi-font title">اخبار بر جسته</h2>
                        </div>

                        <!-- owl carousel 4 -->
                        <div id="owl-carousel-4" class="owl-carousel owl-theme">
                            <!-- ARTICLE -->
                            <article class="article thumb-article">
                                <div class="article-img">
                                    <img src="./img/img-thumb-1.jpg" alt="">
                                </div>
                                <div class="article-body">
                                    <ul class="article-info">
                                        <li class="article-category"><a href="#">News</a></li>
                                        <li class="article-type"><i class="fa fa-video-camera"></i></li>
                                    </ul>
                                    <h3 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h3>
                                    <ul class="article-meta">
                                        <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                        <li><i class="fa fa-comments"></i>33</li>
                                    </ul>
                                </div>
                            </article>
                            <!-- /ARTICLE -->

                            <!-- ARTICLE -->
                            <article class="article thumb-article">
                                <div class="article-img">
                                    <img src="./img/img-thumb-2.jpg" alt="">
                                </div>
                                <div class="article-body">
                                    <ul class="article-info">
                                        <li class="article-category"><a href="#">News</a></li>
                                        <li class="article-type"><i class="fa fa-video-camera"></i></li>
                                    </ul>
                                    <h3 class="farsi-font farsi-position article-title"><a href="#">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</a></h3>
                                    <ul class="article-meta">
                                        <li><i class="fa fa-clock-o"></i>January 31, 2017</li>
                                        <li><i class="fa fa-comments"></i>33</li>
                                    </ul>
                                </div>
                            </article>
                            <!-- /ARTICLE -->
                        </div>
                        <!-- /owl carousel 4 -->
                    </div>
                    <!-- /article widget -->

                    <!-- galery widget -->
                    <div class="widget galery-widget">
                        <div class="widget-title">
                            <h2 class="farsi-font title">گالری تصاویر</h2>
                        </div>
                        <ul>
                            <li><a href="#">
                                <img src="./img/img-widget-3.jpg" alt=""></a></li>
                            <li><a href="#">
                                <img src="./img/img-widget-4.jpg" alt=""></a></li>
                            <li><a href="#">
                                <img src="./img/img-widget-5.jpg" alt=""></a></li>
                            <li><a href="#">
                                <img src="./img/img-widget-6.jpg" alt=""></a></li>
                            <li><a href="#">
                                <img src="./img/img-widget-7.jpg" alt=""></a></li>
                            <li><a href="#">
                                <img src="./img/img-widget-8.jpg" alt=""></a></li>
                            <li><a href="#">
                                <img src="./img/img-widget-9.jpg" alt=""></a></li>
                            <li><a href="#">
                                <img src="./img/img-widget-10.jpg" alt=""></a></li>
                        </ul>
                    </div>
                    <!-- /galery widget -->

                    <!-- tweets widget -->
                    <div class="widget tweets-widget">
                        <div class="widget-title">
                            <h2 class="farsi-font title">لینک ها</h2>
                        </div>
                        <ul>
                            <li class="tweet">
                                <i class="fa fa-bookmark"></i>
                                <div class="tweet-body">
                                    <p><a href="#">@magnews</a> Populo tritani laboramus ex mei, no eum iuvaret ceteros euripidis <a href="#">https://t.co/DwsTbsmxTP</a></p>
                                </div>
                            </li>
                            <li class="tweet">
                                <i class="fa fa-bookmark"></i>
                                <div class="tweet-body">
                                    <p><a href="#">@magnews</a> Populo tritani laboramus ex mei, no eum iuvaret ceteros euripidis <a href="#">https://t.co/DwsTbsmxTP</a></p>
                                </div>
                            </li>
                            <li class="tweet">
                                <i class="fa fa-bookmark"></i>
                                <div class="tweet-body">
                                    <p><a href="#">@magnews</a> Populo tritani laboramus ex mei, no eum iuvaret ceteros euripidis <a href="#">https://t.co/DwsTbsmxTP</a></p>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <!-- /tweets widget -->
                </div>
                <!-- /Aside Column -->
            </div>
            <!-- /ROW -->
        </div>
        <!-- /CONTAINER -->
    </div>
    <!-- /SECTION -->
    <script> 
        var myVideo = document.getElementById("video1");

        function playPause() {
            if (myVideo.paused)
                myVideo.play();
            else
                myVideo.pause();
        }

        function makeBig() {
            myVideo.width = 560;
        }

        function makeSmall() {
            myVideo.width = 320;
        }

        function makeNormal() {
            myVideo.width = 420;
        }
    </script>
</asp:Content>
