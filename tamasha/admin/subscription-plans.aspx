<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="subscription-plans.aspx.cs" Inherits="admin_need_to_know" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <style>
        .sign-between-style {
        }

            .sign-between-style:after {
                content: " ";
                border-right: 1px solid;
                padding: 0 2.5% 0 10px;
            }

        .sign-end-style {
        }

            .sign-end-style:after {
                content: " ";
                padding: 0 2.5% 0 10px;
            }
        .elements-in-page {
            padding: 0 15px;
        }
    </style>
    <!--content-->
    <div class="content">
        <div class="women_main">
            <!-- start content -->
            <div class="tab-main">
                <div class="col-md-12">
                    <h2 class="inner-tittle">Add Plan</h2>
                    <div>
                        <label for="field-1-2">Title: </label>
                        <div class="form-group">
                            <asp:TextBox ID="txtTitle" runat="server" Width="100%"></asp:TextBox>
                        </div>




                        <div class="form-group">
                            <blockquote>
                                <label for="exampleInputEmail1">Start from: </label>
                                <asp:TextBox ID="txtStart" runat="server" Width="15%" placeholder="eg. 20191201"></asp:TextBox>

                                <label for="exampleInputEmail1">End to: </label>
                                <asp:TextBox ID="txtEnd" runat="server" Width="15%" placeholder="eg. 20191201"></asp:TextBox>

                            </blockquote>
                        </div>

                        <div class="form-group">

                            <label for="exampleInputEmail1">Price: </label>
                            <asp:TextBox ID="txtPrice" runat="server" Width="15%" placeholder="eg. 120"></asp:TextBox><span class="sign-between-style">$</span>

                            <label for="exampleInputEmail1">Capacity: </label>
                            <asp:TextBox ID="txtCapacity" runat="server" Width="15%" placeholder="eg. 50"></asp:TextBox><span class="sign-end-style">Members</span>

                        </div>

                        <label for="field-1-2">Description: </label>
                        <div class="form-group">
                            <asp:TextBox ID="txtDetail" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
                        </div>


                        <div>
                            <asp:Label ID="lblError" runat="server" Text="" ForeColor="#FF3300"></asp:Label>
                            <asp:Button ID="btnAdd" runat="server" Text="ADD" OnClick="btnAdd_Click" />
                        </div>
                    </div>
                </div>
                <!--/tabs-inner-->
                <div class="tab-inner">
                    <div id="tabs" class="tabs">
                        <h2 class="inner-tittle">Subscription Plans: </h2>
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

