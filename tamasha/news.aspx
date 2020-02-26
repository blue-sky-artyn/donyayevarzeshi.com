ew<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="news.aspx.cs" Inherits="archive" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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


        /*#menuHtml:first-child {*/
        /*#menuHtml:nth-child(2n) {
          background-color: red ;
        }*/
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
                <div id="popularNewsHtml" runat="server" class="col-md-8">
                    <!-- section title -->
                    <div class="farsi-position section-title">
                        <h2 class="farsi-font title">اخبار محبوب</h2>
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
</asp:Content>

