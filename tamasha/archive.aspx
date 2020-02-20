<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="archive.aspx.cs" Inherits="archive" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .datapicker {
            padding: 15px 0;
        }

        .datapicker-title {
            margin: 0 10px;
            font-weight: bold;
        }
        .article-body p img {
            width:100%;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <!-- SECTION (HIT NEWS) -->
    <div class="section">
        <!-- CONTAINER -->
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="farsi-position section-title">
                        <h2 class="farsi-font title">اخبار</h2>
                    </div>
                    <div class="datapicker row">
                        <div class="farsi-font farsi-align farsi-dir row">
                            <h2>بازه را مشخص نمایید:</h2>
                        </div>

                        <!-- Main Column -->
                        <div class="col-md-6">
                            <div class="form-group">
                                <blockquote>
                                    <label for="exampleInputEmail1">Start date: </label>
                                    <asp:TextBox ID="txtStartDate" ClientIDMode="Static" runat="server" Width="50%" placeholder="eg. 20190101" AutoCompleteType="Disabled" autocomplete="off"></asp:TextBox>
                                    <p class="comment-text">* If leave it blank,it starts from today.</p>
                                </blockquote>
                            </div>
                        </div>


                        <div class="col-md-6">
                            <div class="form-group">
                                <blockquote>
                                    <label for="exampleInputEmail1">End date: </label>
                                    <asp:TextBox ID="txtEndDate" ClientIDMode="Static" runat="server" Width="50%" placeholder="eg. 20190101" autocomplete="off"></asp:TextBox>
                                    <p class="comment-text">* If leave it blank,there is no expiery day.</p>
                                </blockquote>
                            </div>
                        </div>



                        <div class="col-md-2">
                            <div class="form-group">
                                <asp:Button ID="btnShow" runat="server" Text="نمایش" CssClass="farsi-font farsi-title input-btn" OnClick="btnShow_Click" />
                            </div>
                        </div>



                    </div>

                </div>
            </div>
            <!-- ROW -->
            <div class="row">
                <!-- Main Column -->
                <div class="col-md-8">


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
                    <div class="widget social-widget">
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
                    </div>
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



    <!-- Date picker jquer -->
    <%--<link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/smoothness/jquery-ui.css">--%>
    <link rel="stylesheet" href="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.10.4/themes/smoothness/jquery-ui.css">
    <style>
        .ui-datepicker-month, .ui-datepicker-year {
            color: black;
        }
    </style>
    <script src="//code.jquery.com/jquery-1.12.4.js"></script>
    <script src="//code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <%--<script src="js/datepicker-fa.js"></script>--%>

    <script>
        $(document).ready(function () {

            $("#txtStartDate").datepicker({
                appendText: 'dd/mm/yyyy',
                dateFormat: 'dd/mm/yy',

                //showOn: 'both',
                //buttonText: 'Calender',

                numberOfMonths: 2,


                changeMonth: true,
                changeYear: true,
                //minDate: new Date(2005, 1, 1),
                //maxDate: new Date(2015,11,31)

            });

            $("#txtEndDate").datepicker({
                appendText: 'dd/mm/yyyy',
                dateFormat: 'dd/mm/yy',

                numberOfMonths: 2,

                changeMonth: true,
                changeYear: true,
            });
        });
    </script>

</asp:Content>


