<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="socials.aspx.cs" Inherits="admin_gallery_groups" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <!--content-->
    <div class="content">
        <div class="women_main">
            <!-- start content -->
            <div class="grids">
                <div class="progressbar-heading grids-heading">
                    <h2>Social accounts:</h2>
                </div>


                <div class="panel panel-widget forms-panel">
                    <div class="forms">
                        <div class="inline-form widget-shadow">
                            <div class="form-title">
                                <h4>Add socials to user:</h4>
                            </div>
                            <div class="form-body">
                                <div data-example-id="simple-form-inline">
                                    <div class="form-inline">
                                        <div class="form-group">
                                            <asp:TextBox ID="txtSocialName" runat="server" class="form-control" placeholder="Eg. Linkedin"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox ID="txtSocialLink" runat="server" class="form-control" placeholder="Eg. www.linkedin.com?userId=347264"></asp:TextBox>
                                        </div>
                                        <div class="checkbox">
                                            <label>
                                                <asp:DropDownList ID="ddlUser" runat="server"></asp:DropDownList>
                                                choose a user frist </label>
                                        </div>
                                        <asp:Label ID="lblError" runat="server" Text="" ForeColor="#FF3300"></asp:Label>
                                        <asp:Button ID="btnAdd" runat="server" class="btn btn-default" Text="ADD" OnClick="btnAdd_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="panel panel-widget forms-panel">
                    <div class="forms">
                        <div class="form-two widget-shadow">
                            <div class="form-title">
                                <h4>Delete social links:</h4>
                            </div>
                            
                        </div>
                    </div>
                
                   
                    <div id="socialHtml" runat="server" class="forms">
                        <h3 class="title1">User 1</h3>
                        <div class="form-three widget-shadow">
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label for="focusedinput" class="col-sm-2 control-label">Linkedin</label>
                                    <div class="col-sm-8">
                                        <div class="col-sm-11">
                                            <p class="help-block">www.linkedin.com?userId=32564</p>
                                        </div>
                                        <a href="delete-social.aspx?socialId=1">DEL</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                
            </div>

            <!-- end content -->
</asp:Content>

