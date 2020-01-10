using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;

public partial class admin_gallery_normal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //place pictures
        string addPicString = string.Empty;
        //tblpicAntiquesCollection antiquesTbl = new tblpicAntiquesCollection();
        //antiquesTbl.ReadList();

        //addPicString += "<div class='grids_of_4'>";
        //for (int i = 0; i < antiquesTbl.Count; i++)
        //{
        //    addPicString += "<div class='grid1_of_4'><div class='content_box'><a href='gallery-normal-details.aspx?item=" + antiquesTbl[i].id + "'>" +
        //                    "<img src='../images/antiques/" + antiquesTbl[i].AntiquePicName + "' class='img-responsive' alt='halisenGallery" + antiquesTbl[i].id + "' /></a>" +
        //                    "<h4><a> " + antiquesTbl[i].AntiqueTitle + " </a></h4>" +
        //                    "<p>" + antiquesTbl[i].AntiqueDetail + "</p>" +
        //                    "<div class='grid_1 simpleCart_shelfItem'>" +
        //                    "<div class='item_add'><span class='item_price'><h6>Price: $" + antiquesTbl[0].AntiqueName + ".00</h6></span></div>" +
        //                    "<div class='item_add'><span class='item_price'><a href='gallery-antiques-details.aspx?item=" + antiquesTbl[i].id + "'>EDIT</a></span></div>" +
        //                    "</div></div></div>";
        //    if ((i-1) % 4 == 0)
        //    {
        //        addPicString += "<div class='clearfix'></div></div>";
        //        addPicString += "<div class='grids_of_4'>";
        //    }
        //}

        addPicHtml.InnerHtml = addPicString;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string errorString = string.Empty;
        lblError.Visible = false;
        //tblpicAntiques antiquesTbl = new tblpicAntiques();
        //if (txtPrice.Text.Trim().Length > 0)
        //{
        //    if (txtTitle.Text.Length > 0)
        //        antiquesTbl.AntiqueTitle = txtTitle.Text;
        //    else
        //    {
        //        errorString = "* Please fill out title";
        //        lblError.Visible = true;
        //    }


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
        //                lblError.Text = "A promblem with uplouding picture";
        //            }
        //        }
        //        else
        //        {
        //            lblError.Text = "Not valid picture";
        //        }
        //    }

        //    // file upload end

        //    antiquesTbl.AntiquePicAddr = "~/images/antiques/";
        //    antiquesTbl.AntiquePicName = filename;

        //    antiquesTbl.AntiqueName = txtPrice.Text;
        //    antiquesTbl.allow = "1";

        //    if (txtDetails.Text.Trim().Length > 0)
        //        antiquesTbl.AntiqueDetail = txtDetails.Text;
        //    else
        //        antiquesTbl.AntiqueDetail = "";

           
        //    if (lblError.Visible == false)
        //        antiquesTbl.Create();

        //    Response.Redirect("gallery-antiques.aspx");
        //}
        //else
        //{
        //    errorString = "* Please fill out price";
        //    lblError.Visible = true;
        //}
    }
}