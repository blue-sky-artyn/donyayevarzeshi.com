    <%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="popuppage.aspx.cs" Inherits="admin_need_to_know" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <style>
        .date-boxes {
            width: 19%;
            height: 30px;
            margin: 0 5px;
        }
        .date-place {
            width: 50%;
            float: left;
        }
        .clear-float {
            clear: both;
        }
        #rbStyle tbody tr td label {
            display: contents;
        }
        #rbStyle tbody tr td input {
            margin: 0 10px;
        }
        .today-text {
            padding: 15px;
            color: red;
            font-weight: bolder;
            font-style: italic;
            text-shadow: 1px 1px;
        }
    </style>
    <!--content-->
    <div class="content">
        <div class="women_main">
            <!-- start content -->
            <div class="tab-main">
                <!--/tabs-inner-->
                <div class="tab-inner">
                    <div class="col-md-12 graph-2">
                        <h3 class="inner-tittle">Pop up Page Content</h3>
                        <div class="form-body">
                            <div>
                                <div class="form-group">
                                    <label for="exampleInputEmail1">Today: </label>
                                    <p class="today-text">20191010</p>
                                </div>
                                <div class="form-group">
                                    <label for="exampleInputEmail1">Title: </label>
                                    <asp:TextBox ID="txtTitle" runat="server" Width="100%"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="exampleInputEmail1">Description: </label>
                                    <asp:TextBox ID="txtDetail" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                    <asp:RadioButtonList ID="rbStyle" ClientIDMode="Static" runat="server" Width="100%">
                                        <asp:ListItem Value="text-top" Selected="True">Shows Top</asp:ListItem>
                                        <asp:ListItem value="text-center">Shows Center</asp:ListItem>
                                        <asp:ListItem Value="text-bottom">Shows Bottom</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="date-place form-group">
                                    <label for="exampleInputEmail1">From: </label>
                                    <asp:TextBox ID="txtYearFrom" runat="server" CssClass="date-boxes" TextMode="MultiLine" placeholder="year, eg 2019"></asp:TextBox>/
                                    <asp:TextBox ID="txtMonthFrom" runat="server" CssClass="date-boxes" TextMode="MultiLine" placeholder="month, eg 02"></asp:TextBox>/
                                    <asp:TextBox ID="txtDayFrom" runat="server" CssClass="date-boxes" TextMode="MultiLine" placeholder="day, eg 05"></asp:TextBox>
                                </div>
                                <div class="date-place form-group">
                                    <label for="exampleInputEmail1">To: </label>
                                    <asp:TextBox ID="txtYearTo" runat="server" CssClass="date-boxes" TextMode="MultiLine" placeholder="year, eg 2019"></asp:TextBox>/
                                    <asp:TextBox ID="txtMonthTo" runat="server" CssClass="date-boxes" TextMode="MultiLine" placeholder="month, eg 02"></asp:TextBox>/
                                    <asp:TextBox ID="txtDayTo" runat="server" CssClass="date-boxes" TextMode="MultiLine" placeholder="day, eg 05"></asp:TextBox>
                                </div>
                                <div class="clear-float">
                                    <div class="form-group">
                                        <fieldset class="div_top">
                                            <legend>Picture:</legend>
                                            <asp:FileUpload ID="fuGallery" runat="server" Style="margin: 3%" />
                                        </fieldset>
                                    </div>
                                    <asp:Label ID="lblError" runat="server" Text="" ForeColor="#CC3300"></asp:Label>
                                    <asp:Button ID="btnAdd" runat="server" Text="ADD" CssClass="btn btn-default" OnClick="btnAdd_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div id="infHtml" runat="server">
                    <div class="col-md-6 graph-2">
                        <h3 class="inner-tittle">Panel with footer </h3>
                        <div class="panel panel-primary two">
                            <div class="panel-heading">Panel with panel-primary class</div>
                            <div class="panel-body ont two">
                                <div>
                                    <img src="../images/sale1.jpg" alt="" style="width: 100%;" />
                                </div>
                                <p>Panel Content Chickweed Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. okra pea winter purslane coriander yarrow sweet pepper radish garlic brussels sprout groundnut summer purslane earthnut pea Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. tomato spring onion azuki bean gourd.</p>
                            </div>
                            <div class="panel-footer">
                                <a href="delete-need.aspx?itemCode=1">Delete</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6 graph-2">
                        <h3 class="inner-tittle">Panel with footer </h3>
                        <div class="panel panel-primary two">
                            <div class="panel-heading">Panel with panel-primary class</div>
                            <div class="panel-body ont two">
                                <div>
                                    <img src="../images/sale1.jpg" alt="" style="width: 100%;" />
                                </div>
                                <p>Panel Content Chickweed Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. okra pea winter purslane coriander yarrow sweet pepper radish garlic brussels sprout groundnut summer purslane earthnut pea Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. tomato spring onion azuki bean gourd.</p>
                            </div>
                            <div class="panel-footer">
                                <a href="#">Delete</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6 graph-2">
                        <h3 class="inner-tittle">Panel with footer </h3>
                        <div class="panel panel-primary two">
                            <div class="panel-heading">Panel with panel-primary class</div>
                            <div class="panel-body ont two">
                                <div>
                                    <img src="../images/sale1.jpg" alt="" style="width: 100%;" />
                                </div>
                                <p>Panel Content Chickweed Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. okra pea winter purslane coriander yarrow sweet pepper radish garlic brussels sprout groundnut summer purslane earthnut pea Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. tomato spring onion azuki bean gourd.</p>
                            </div>
                            <div class="panel-footer">
                                <a href="#">Panel footer</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="clearfix"></div>
            </div>
        </div>
        <!-- end content -->
    </div>
    </div>
    <!--content-->
</asp:Content>

