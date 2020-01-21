<%@ Page Title="" Language="C#" MasterPageFile="~/admin/menu.master" AutoEventWireup="true" CodeFile="stage.aspx.cs" Inherits="admin_gallery_normal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head1" runat="Server">
    <link rel="stylesheet" href="ticket.css" />
    <%--<link rel="stylesheet" href="css/all.css" />--%>
    <style type="text/css">
        .styles_overlay__CLSq- {
            background: rgba(0, 0, 0, 0.75);
            display: flex;
            align-items: flex-start;
            position: fixed;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            overflow-y: auto;
            overflow-x: hidden;
            z-index: 1000;
            padding: 1.2rem;
        }

        .styles_overlayCenter__YHoO7 {
            align-items: center;
        }

        .styles_modal__gNwvD {
            max-width: 800px;
            position: relative;
            padding: 1.2rem;
            background: #ffffff;
            background-clip: padding-box;
            box-shadow: 0 12px 15px 0 rgba(0, 0, 0, 0.25);
            margin: auto;
        }

        .styles_closeButton__20ID4 {
            position: absolute;
            top: 14px;
            right: 14px;
            border: none;
            padding: 0;
            background-color: transparent;
            display: flex;
        }

        .styles_closeIcon__1QwbI {
        }

        .styles_transitionEnter__3j_-a {
            opacity: 0.01;
        }

        .styles_transitionEnterActive___eQs7 {
            opacity: 1;
            transition: opacity 500ms cubic-bezier(0.23, 1, 0.32, 1);
        }

        .styles_transitionExit__1KmEf {
            opacity: 1;
        }

        .styles_transitionExitActive__1nQXw {
            opacity: 0.01;
            transition: opacity 500ms cubic-bezier(0.23, 1, 0.32, 1);
        }

        #stages {
            width: 100%;
            margin: 15px -10px 15px auto;
            height: 150px;
            background-image: url(/images/stage.01490595.gif);
            background-size: 100%;
            background-repeat: no-repeat;
        }
        /* color codes */
        .sold-out-seats {
            color: red;
        }

        .no-sell-seats {
            color: dimgray;
        }
    </style>
    <style>
        .textarea-margin-top {
            margin-top: 5px;
        }
    </style>
    <link rel="stylesheet" href="ticket.css">
    <style type="text/css">
        .styles_overlay__CLSq- {
            background: rgba(0, 0, 0, 0.75);
            display: flex;
            align-items: flex-start;
            position: fixed;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            overflow-y: auto;
            overflow-x: hidden;
            z-index: 1000;
            padding: 1.2rem;
        }

        .styles_overlayCenter__YHoO7 {
            align-items: center;
        }

        .styles_modal__gNwvD {
            max-width: 800px;
            position: relative;
            padding: 1.2rem;
            background: #ffffff;
            background-clip: padding-box;
            box-shadow: 0 12px 15px 0 rgba(0, 0, 0, 0.25);
            margin: auto;
        }

        .styles_closeButton__20ID4 {
            position: absolute;
            top: 14px;
            right: 14px;
            border: none;
            padding: 0;
            background-color: transparent;
            display: flex;
        }

        .styles_closeIcon__1QwbI {
        }

        .styles_transitionEnter__3j_-a {
            opacity: 0.01;
        }

        .styles_transitionEnterActive___eQs7 {
            opacity: 1;
            transition: opacity 500ms cubic-bezier(0.23, 1, 0.32, 1);
        }

        .styles_transitionExit__1KmEf {
            opacity: 1;
        }

        .styles_transitionExitActive__1nQXw {
            opacity: 0.01;
            transition: opacity 500ms cubic-bezier(0.23, 1, 0.32, 1);
        }

        #stages {
            width: 100%;
            margin: 15px -10px 15px auto;
            height: 150px;
            background-image: url(/images/stage.01490595.gif);
            background-size: 100%;
            background-repeat: no-repeat;
        }
        /* color codes */
        .sold-out-seats {
            color: red;
        }

        .no-sell-seats {
            color: dimgray;
        }
    </style>
    <style>
        .textarea-margin-top {
            margin-top: 5px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <!--content-->
    <div class="content">
        <div class="women_main">
            <!-- start content -->
            <div class="w_content">
                <div class="women">
                    <a href="#">
                        <h4>Create a stage </h4>
                    </a>
                    <div class="clearfix"></div>
                </div>
                <!-- grids_of_4 -->
                <div id="addStaffHtml" runat="server"></div>

                <div class="grids_of_4">
                    <div class="clearfix"></div>
                    <div class="panel panel-widget forms-panel">
                        <div class="forms">
                            <div class="form-grids widget-shadow" data-example-id="basic-forms">
                                <div class="form-title">
                                    <h4>Add Stage: </h4>
                                </div>
                                <div class="form-body">
                                    <div>
                                        <div class="form-group">
                                            <label for="inputEmail3" class="col-sm-2 control-label">* Rows of seats: </label>
                                            <div class="col-sm-9">
                                                <asp:DropDownList ID="ddlStageRow" runat="server">
                                                   
                                                    <asp:ListItem Text="1" Value="1" />
                                                    <asp:ListItem Text="2" Value="2" />
                                                    <asp:ListItem Text="3" Value="3" />
                                                    <asp:ListItem Text="4" Value="4" />
                                                    <asp:ListItem Text="5" Value="5" />
                                                    <asp:ListItem Text="6" Value="6" />
                                                    <asp:ListItem Text="7" Value="7" />
                                                    <asp:ListItem Text="8" Value="8" />
                                                    <asp:ListItem Text="9" Value="9" />
                                                    <asp:ListItem Text="10" Value="10" />
                                                    <asp:ListItem Text="11" Value="11" />
                                                    <asp:ListItem Text="12" Value="12" />
                                                    <asp:ListItem Text="13" Value="13" />
                                                    <asp:ListItem Text="14" Value="14" />
                                                    <asp:ListItem Text="15" Value="15" />
                                                    <asp:ListItem Text="16" Value="16" />
                                                    <asp:ListItem Text="17" Value="17" />
                                                    <asp:ListItem Text="18" Value="18" />
                                                    <asp:ListItem Text="19" Value="19" />
                                                    <asp:ListItem Text="20" Value="20" />
                                                    <asp:ListItem Text="21" Value="21" />
                                                    <asp:ListItem Text="22" Value="22" />
                                                    <asp:ListItem Text="23" Value="23" />
                                                    <asp:ListItem Text="24" Value="24" />
                                                    <asp:ListItem Text="25" Value="25" />
                                                    <asp:ListItem Text="26" Value="26" />
                                                    <asp:ListItem Text="27" Value="27" />
                                                    <asp:ListItem Text="28" Value="28" />
                                                    <asp:ListItem Text="29" Value="29" />
                                                    <asp:ListItem Text="30" Value="30" />
                                                    <asp:ListItem Text="31" Value="31" />
                                                </asp:DropDownList>
                                                <asp:Button ID="btnAddRows" runat="server" Text="Add" OnClick="btnAddRows_Click" />
                                            </div>
                                        </div>

                                        <div class="form-group">
                                            <div id="form1" runat="server">
                                                <div id="App">
                                                    <div class="seats">
                                                        <div class="seats-wrap">
                                                            <div id="seats">
                                                                
                                                                <div style="clear: both;"></div>
                                                                <div id="rowNoHtml" runat="server" class="row">
                                                                    
                                                                </div>
                                                                <div class="clearfix"></div>
                                                                <div id="stages"></div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <script>!function (l) { function e(e) { for (var r, t, n = e[0], o = e[1], u = e[2], f = 0, i = []; f < n.length; f++)t = n[f], p[t] && i.push(p[t][0]), p[t] = 0; for (r in o) Object.prototype.hasOwnProperty.call(o, r) && (l[r] = o[r]); for (s && s(e); i.length;)i.shift()(); return c.push.apply(c, u || []), a() } function a() { for (var e, r = 0; r < c.length; r++) { for (var t = c[r], n = !0, o = 1; o < t.length; o++) { var u = t[o]; 0 !== p[u] && (n = !1) } n && (c.splice(r--, 1), e = f(f.s = t[0])) } return e } var t = {}, p = { 2: 0 }, c = []; function f(e) { if (t[e]) return t[e].exports; var r = t[e] = { i: e, l: !1, exports: {} }; return l[e].call(r.exports, r, r.exports, f), r.l = !0, r.exports } f.m = l, f.c = t, f.d = function (e, r, t) { f.o(e, r) || Object.defineProperty(e, r, { enumerable: !0, get: t }) }, f.r = function (e) { "undefined" != typeof Symbol && Symbol.toStringTag && Object.defineProperty(e, Symbol.toStringTag, { value: "Module" }), Object.defineProperty(e, "__esModule", { value: !0 }) }, f.t = function (r, e) { if (1 & e && (r = f(r)), 8 & e) return r; if (4 & e && "object" == typeof r && r && r.__esModule) return r; var t = Object.create(null); if (f.r(t), Object.defineProperty(t, "default", { enumerable: !0, value: r }), 2 & e && "string" != typeof r) for (var n in r) f.d(t, n, function (e) { return r[e] }.bind(null, n)); return t }, f.n = function (e) { var r = e && e.__esModule ? function () { return e.default } : function () { return e }; return f.d(r, "a", r), r }, f.o = function (e, r) { return Object.prototype.hasOwnProperty.call(e, r) }, f.p = "/"; var r = window.webpackJsonp = window.webpackJsonp || [], n = r.push.bind(r); r.push = e, r = r.slice(); for (var o = 0; o < r.length; o++)e(r[o]); var s = n; a() }([])</script>





                                            <asp:TextBox ID="txtCertificate" class="textarea-margin-top form-control" runat="server" Width="25%" placeholder="Enter field of study" Visible="false"></asp:TextBox>
                                        </div>



                                        <div class="form-group" style="width: 35%; line-height: 34px; float: left; margin-right: 5px;">
                                            <label for="exampleInputPassword1" style="float: left;">Staff word: </label>
                                            <asp:TextBox ID="txtWord" class="form-control" runat="server" placeholder="A short words of staff" TextMode="MultiLine"></asp:TextBox>
                                        </div>

                                        <div class="form-group" style="width: 35%; line-height: 34px; float: left; margin-right: 5px;">
                                            <label for="exampleInputPassword1" style="float: left;">Details: </label>
                                            <asp:TextBox ID="txtDetail" class="form-control" runat="server" placeholder="A short detail" TextMode="MultiLine"></asp:TextBox>
                                        </div>

                                        <div class="form-group" style="float: left; width: 100%;">
                                            <fieldset class="div_top">
                                                <legend>* File input</legend>
                                                <asp:FileUpload ID="fuGallery" runat="server" Style="margin: 3%" />
                                            </fieldset>
                                            <p class="help-block">Please choose one picture of item</p>
                                        </div>
                                        <div class="form-group" style="float: left;">
                                            <asp:Label ID="lblError" runat="server" Text="" Visible="false" ForeColor="#B52E31"></asp:Label>
                                            <asp:Button ID="btnAdd" runat="server" class="btn btn-default" Text="ADD ITEM" OnClick="btnAdd_Click" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>




                <!-- end grids_of_4 -->


            </div>
            <div class="clearfix"></div>
            <!-- end content -->
        </div>
    </div>
</asp:Content>

