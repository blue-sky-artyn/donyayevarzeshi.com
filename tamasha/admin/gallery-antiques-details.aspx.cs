using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;


public partial class admin_gallery_normal_detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["item"] != null)
        {
            itemGet = Int32.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("gallery-antiques.aspx");

        //fill data 
        //tblpicAntiquesCollection galleryAntiqueTbl = new tblpicAntiquesCollection();
        //galleryAntiqueTbl.ReadList(Criteria.NewCriteria(tblGalleryPics.Columns.id, CriteriaOperators.Equal, itemGet));

        //if (galleryAntiqueTbl.Count > 0)
        //{
        //    setPicHtml.InnerHtml = "<img src='../images/antiques/" + galleryAntiqueTbl[0].AntiquePicName + "' data-imagezoom='true' class='img-responsive' draggable='false'>";
        //}

        //string addDataString = string.Empty;
        //addDataString += "<h3>" + galleryAntiqueTbl[0].AntiqueTitle + "</h3><br>" +
        //            "<p>" + galleryAntiqueTbl[0].AntiqueDetail + "</p>" +
        //                "<div class='price'>" +
        //                    "<span class='text'>Price:</span>" +
        //                    "<span class='price-new'>$" + galleryAntiqueTbl[0].AntiqueName + ".00</span><span class='price-old'>$" + galleryAntiqueTbl[0].AntiqueName + ".00</span> " +
        //                    "<span class='price-tax'><label class='checkbox'><input type='checkbox' name='checkbox'><i></i>include Ex Tax: 13%</label></span><br>" +
        //                    "<span class='points'><small>Discount 20%</small></span><br>" +
        //                "</div>";
        //addDetailHtml.InnerHtml = addDataString;

        ////fill data in change part
        //if (!IsPostBack)
        //{
        //    //Select old items
        //    txtTitle.Text = galleryAntiqueTbl[0].AntiqueTitle;
        //    txtDetail.Text = galleryAntiqueTbl[0].AntiqueDetail;
        //    lblOldPrice.Text = "$" + galleryAntiqueTbl[0].AntiqueName + ".00";
        //}
    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        //int itemGet = 0;
        //if (Request.QueryString["item"] != null)
        //{
        //    itemGet = Int32.Parse(Request.QueryString["item"]);
        //}
        //else
        //    Response.Redirect("gallery-antiques.aspx");

        //tblpicAntiquesCollection galleryAntiqueTbl = new tblpicAntiquesCollection();
        //galleryAntiqueTbl.ReadList(Criteria.NewCriteria(tblGalleryPics.Columns.id, CriteriaOperators.Equal, itemGet));

        //galleryAntiqueTbl[0].Delete();

        Response.Redirect("gallery-antiques.aspx");

    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["item"] != null)
        {
            itemGet = Int32.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("gallery-antiques.aspx");

        //tblpicAntiquesCollection galleryAntiqueTbl = new tblpicAntiquesCollection();
        //galleryAntiqueTbl.ReadList(Criteria.NewCriteria(tblGalleryPics.Columns.id, CriteriaOperators.Equal, itemGet));

        //if (txtTitle.Text.Trim().Length > 0)
        //{
        //    //gallery items
        //    galleryAntiqueTbl[0].AntiqueTitle = txtTitle.Text;
        //    if (txtDetail.Text.Trim().Length > 0)
        //        galleryAntiqueTbl[0].AntiqueDetail = txtDetail.Text;
        //    else
        //        galleryAntiqueTbl[0].AntiqueDetail = "";

        //    // file upload start 
        //    string filename = string.Empty;
        //    if (IsPostBack)
        //    {
        //        Boolean fileOK = false;
        //        String path = Server.MapPath("~/images/antiques/");
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
        //                lblError.Text = "A problem accurred while uplouding picture";
        //            }
        //        }
        //        else
        //        {
        //            lblError.Text = "Not valid picture file";
        //        }
        //    }

        //    // file upload end
        //    if (filename.Trim().Length > 0)
        //    {
        //        galleryAntiqueTbl[0].AntiquePicName = filename;
        //    }

        //    //staff items
        //    if (txtPrice.Text.Trim().Length > 0)
        //        galleryAntiqueTbl[0].AntiqueName = txtPrice.Text;

        //    galleryAntiqueTbl.UpdateList(true);
        //}
        Response.Redirect("gallery-antiques-details.aspx");
    }
}