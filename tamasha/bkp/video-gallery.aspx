<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="video-gallery.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        video {
            /*height: 370px;*/
            width: 100%;
        }

        .other-tabs {
            display: none;
        }
        .new-video-attr {}
        .new-video-attr .video-pre {
            position: relative;
            z-index: 99;
            zoom: 1.5;
        }
        .new-video-attr .video-pre-small video {zoom: 1.2;}
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
        .head-news-img {
            min-height: inherit;
            max-height: inherit;
        }
        .article.thumb-article {
            height: initial;
        }
        .news-background-filler {
            background-color: transparent;
        }

        .clear-float {
            clear:both;
        }
    </style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <!-- Owl Carousel 1_Sldier -->
    <div id="sliderHtml" clientidmode="static" runat="server">
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
    <!-- /Owl Carousel 1 -->

 
     <!-- SECTION (TAB NEWS) -->
    <div class="section">
        <!-- CONTAINER -->
        <div class="container">
            <!-- ROW -->
            <div class="row">
                
                <!-- Main Column -->
                <div class="col-md-12">
                    <!-- section title -->
                    <div class="farsi-position section-title">
                        <!-- tab nav -->
                        <ul id="tabsHtml" runat="server" clientidmode="static" class="farsi-font farsi-float tab-nav">
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
                    <div id="tabNewsDetailsHtml" runat="server" class="clear-float tab-content">
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
  

    <!-- AD SECTION -->
    <div id="adMiddle" runat="server" class="visible-lg visible-md" style="margin: 15px 0;">
        <img class="center-block" src="./img/headadmiddle.jpg" alt="">
    </div>
    <!-- /AD SECTION -->
    
    
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {

          $(".article").mouseenter(function(){
              $(this).addClass("new-video-attr");
            });

            $(".article").mouseleave(function(){
              //alert("test");
              //alert($(this).attr("class"));
              $(this).removeClass("new-video-attr");
          });
        });
    </script>
    
    
    
    
    
    <script> 
        
        //var myVideo = document.getElementById("video1");
        //myVideo = this.
        
        //var myVideo = document.getElementById("videoSlider1");
            



        function playPause1() {

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
