<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="faq.aspx.cs" Inherits="admin_need_to_know" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <!--content-->
    <div class="content">
        <div class="women_main">
            <!-- start content -->
            <div class="tab-main">
                <div class="col-md-12">
                    <h2 class="inner-tittle">Add item</h2>
                    <div>
                        <div>Title:
                            <asp:TextBox ID="txtTitle" runat="server" Width="100%"></asp:TextBox></div>
                        <div>Description:
                            <asp:TextBox ID="txtDetail" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox></div>
                        <div>
                            <asp:Label ID="lblError" runat="server" Text="" ForeColor="#FF3300"></asp:Label>
                            <asp:Button ID="btnAdd" runat="server" Text="ADD" OnClick="btnAdd_Click" /></div>
                    </div>
                </div>
                <!--/tabs-inner-->
                <div class="tab-inner">
                    <div id="tabs" class="tabs">
                        <h2 class="inner-tittle">Need to know </h2>
                        <div class="graph">
                            <div class="content tab">
                                <section id="faqHtml" runat="server" class="content-current">
                                    <div class="mediabox">
                                        <i class="fa fa-shopping-cart"></i>
                                        <h3>Industry's standard</h3>
                                        <p>Chickweed okra pea winter purslane coriander yarrow sweet pepper radish garlic brussels sprout groundnut summer purslane earthnut pea tomato spring onion azuki bean gourd. </p>
                                        <a href="delete-faq.aspx?itemCode=1">Delete</a>
                                    </div>
                                    <div class="mediabox">
                                        <i class="fa fa-sitemap"></i>
                                        <h3>Into electronic</h3>
                                        <p>Chickweed okra pea winter purslane coriander yarrow sweet pepper radish garlic brussels sprout groundnut summer purslane earthnut pea tomato spring onion azuki bean gourd. </p>
                                        <a href="delete-faq.aspx?itemCode=1">Delete</a>
                                    </div>
                                    <div class="mediabox">
                                        <i class="fa fa-suitcase"></i>
                                        <h3>Various versions</h3>
                                        <p>Chickweed okra pea winter purslane coriander yarrow sweet pepper radish garlic brussels sprout groundnut summer purslane earthnut pea tomato spring onion azuki bean gourd. </p>
                                        <a href="delete-faq.aspx?itemCode=1">Delete</a>
                                    </div>
                                    <div class="mediabox">
                                        <i class="fa fa-suitcase"></i>
                                        <h3>Various versions</h3>
                                        <p>Chickweed okra pea winter purslane coriander yarrow sweet pepper radish garlic brussels sprout groundnut summer purslane earthnut pea tomato spring onion azuki bean gourd. </p>
                                    </div>
                                    <div class="mediabox">
                                        <i class="fa fa-suitcase"></i>
                                        <h3>Various versions</h3>
                                        <p>Chickweed okra pea winter purslane coriander yarrow sweet pepper radish garlic brussels sprout groundnut summer purslane earthnut pea tomato spring onion azuki bean gourd. </p>
                                    </div>  
                                    <div class="mediabox">
                                        <i class="fa fa-suitcase"></i>
                                        <h3>Various versions</h3>
                                        <p>Chickweed okra pea winter purslane coriander yarrow sweet pepper radish garlic brussels sprout groundnut summer purslane earthnut pea tomato spring onion azuki bean gourd. </p>
                                    </div>
                                </section>
                            </div>
                            <!-- /content -->
                        </div>
                        <!-- /tabs -->
                    </div>
                    <div class="clearfix"></div>
                </div>
            </div>
            <!-- end content -->
        </div>
    </div>
    <!--content-->
</asp:Content>

