using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Gallery
        string galleryString = string.Empty;
        tblGalleryPicturesCollection galleryTbl = new tblGalleryPicturesCollection();
        galleryTbl.ReadList();

        galleryString = "<h1>Gallery items</h1>";
        if (galleryTbl.Count > 0)
        {
            for (int i = 0; i < galleryTbl.Count; i++)
            {
                galleryString += "<div class='col-md-3 col-sm-6'><div class='content_box'>" +
                                 "<a href='gallery-details.aspx?item=" + galleryTbl[i].id + "'><img src='../" + galleryTbl[i].GalleryPicAddr + galleryTbl[i].GalleryPicName + "' class='img-responsive' alt='Tamasha news gallery'></a>" +
                                 "<h4 style='text-align: center;padding: 5px;'><a> " + galleryTbl[i].GalleryPicTitle + " </a></h4>" +
                                 "<p style='text-align: justify;padding: 5px;'>" + galleryTbl[i].GalleryPicDetail + "</p><div class='grid_1 simpleCart_shelfItem'>" +
                                 "<div class='item_add'><span class='item_price'>Insert Date: " + galleryTbl[i].GalleryInsertDate + "</span></div>" +
                                 "<div class='item_add'><span class='item_price'><a href='gallery-details.aspx?item=" + galleryTbl[i].id + "'>EDIT</a></span></div></div></div></div>";
            }
        }

        galleryHtml.InnerHtml = galleryString;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        tblGalleryPictures galleryTbl = new tblGalleryPictures();

        // file upload start 
        string filename = string.Empty;
        if (IsPostBack)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/images/gallery/");
            if (fuGallery.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(fuGallery.FileName).ToLower();
                String[] allowedExtensions = { ".jpg", ".png", ".bmp", ".gif" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }

            if (fileOK)
            {
                try
                {
                    fuGallery.PostedFile.SaveAs(path + fuGallery.FileName);
                    filename = fuGallery.FileName;
                }
                catch (Exception ex)
                {
                    lblError.Text = "A problem accurred while uplouding picture";
                }
            }
            else
            {
                lblError.Text = "Not valid picture file";
            }
        }

        //file upload end

        if (filename.Trim().Length > 0)
        {

            galleryTbl.GalleryPicTitle = txtTitle.Text;

            galleryTbl.GalleryPicDetail = txtDetail.Text;

            galleryTbl.GalleryPicAddr = "images/gallery/";
            galleryTbl.GalleryPicName = filename;
            galleryTbl.GalleryInsertDate = DateTime.Now.ToString("yyyyMMdd");

            galleryTbl.GalleryStartDate = DateTime.Now.ToString("yyyyMMdd");
            galleryTbl.GalleryStartTime = DateTime.Now.ToString("hh:mm");

            galleryTbl.GalleryEndDate = "";
            galleryTbl.GalleryEndTime = "";

            galleryTbl.idGroup = 1;
            galleryTbl.allow = "1";
            galleryTbl.Create();

            Response.Redirect("picture-gallery.aspx");

        }
        else
            lblError.Text = "* please choose a picture first.";

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //tblSliderCollection sliderTbl = new tblSliderCollection();
        //sliderTbl.ReadList();

        //if (txtUpdateTitle.Text.Trim().Length > 0)
        //{
        //    sliderTbl[0].picTitle = txtUpdateTitle.Text;
        //    if (txtUpdateDetail.Text.Trim().Length > 0)
        //        sliderTbl[0].picDetails = txtUpdateDetail.Text;
        //    else
        //        sliderTbl[0].picDetails = "";
        //}

        //sliderTbl.UpdateList(true);

    }
}