using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;

public partial class admin_need_to_know : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string needString = string.Empty;
        //tblNeedToKnowCollection needTbl = new tblNeedToKnowCollection();
        //needTbl.ReadList();

        //for (int i = 0; i < needTbl.Count; i++)
        //{
        //    needString += "<div class='col-md-6 graph-2'>" +
        //                  "<h3 class='inner-tittle'>Need to know " + (i + 1) + " </h3>" +
        //                  "<div class='panel panel-primary two'>" +
        //                  "<div class='panel-heading'>" + needTbl[i].NeedTitle + "</div><div class='panel-body ont two'>" +
        //                  "<div><img src='../images/need/" + needTbl[i].NeedPicName + "' alt='Halisen persian rugs " + i + "' style='width: 100%;' /></div><p>" + needTbl[i].NeedDetail + "</p></div>" +
        //                  "<div class='panel-footer'><a href='delete-need.aspx?itemCode=" + needTbl[i].id + "'>Delete</a></div></div></div>";

        //}

        needHtml.InnerHtml = needString;



        //////////////////string str = ckDetails.Text;
        //////////////////popoupTbl.adDetails = Server.HtmlDecode(str);

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //tblNeedToKnow needTbl = new tblNeedToKnow();

        //if (txtTitle.Text.Trim().Length > 0)
        //{
        //    needTbl.NeedTitle = txtTitle.Text;
        //    needTbl.NeedDetail = txtDetail.Text;

        //    // file upload start 
        //    string filename = string.Empty;
        //    if (IsPostBack)
        //    {
        //        Boolean fileOK = false;
        //        String path = Server.MapPath("~/images/need/");
        //        if (fuGallery.HasFile)
        //        {
        //            String fileExtension = System.IO.Path.GetExtension(fuGallery.FileName).ToLower();
        //            String[] allowedExtensions = { ".jpg" };
        //            for (int i = 0; i < allowedExtensions.Length; i++)
        //            {
        //                if (fileExtension == allowedExtensions[i])
        //                {
        //                    fileOK = true;
        //                }
        //            }
        //        }

        //        if (fileOK)
        //        {
        //            try
        //            {
        //                fuGallery.PostedFile.SaveAs(path + fuGallery.FileName);
        //                filename = fuGallery.FileName;
        //            }
        //            catch (Exception ex)
        //            {
        //                lblError.Text = "A promblem with uplouding picture";
        //            }
        //        }
        //        else
        //        {
        //            lblError.Text = "Not valid picture";
        //        }
        //    }

        //    // file upload end
        //    if (filename.Trim().Length > 0) needTbl.NeedPicName = filename;
        //    else needTbl.NeedPicName = "default.jpg";

        //    needTbl.NeedPicAddr = "../images/need/";

        //    needTbl.NeedInsertDate = "";
        //    needTbl.NeedStartDate = "";
        //    needTbl.NeedExpDate = "";
        //    needTbl.allow = "1";

        //    needTbl.Create();

        //    Response.Redirect("need-to-know.aspx");
        //}
        //else
        //    lblError.Text = "* please enter title frist.";
    }
}