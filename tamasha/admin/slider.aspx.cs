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
        //Slider
        string sliderString = string.Empty;
        tblSliderCollection sliderTbl = new tblSliderCollection();
        sliderTbl.ReadList();

        if (sliderTbl.Count > 0)
        {
            txtDetail.Visible = false;
            txtTitle.Visible = false;

            lblTitle.Visible = false;
            lblDetails.Visible = false;

            btnAdd.Text = "UPLOUD";
        }

        if (!IsPostBack)
        {
            if (sliderTbl.Count > 0)
            {
                txtUpdateTitle.Text = sliderTbl[0].SliderTitle;
                txtUpdateDetail.Text = sliderTbl[0].SliderDetail;
            }
        }

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        tblSlider sliderCreateTbl = new tblSlider();


        // file upload start 
        string filename = string.Empty;
        if (IsPostBack)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/video/");
            if (fuGallery.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(fuGallery.FileName).ToLower();
                String[] allowedExtensions = { ".mp4" };
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
        //if (sliderUpdateTbl.Count == 0)
        //{
        //    if (filename.Trim().Length > 0)
        //    {
        //        if (txtTitle.Text.Trim().Length > 0)
        //        {
        //            sliderCreateTbl.picTitle = txtTitle.Text;
        //            if (txtDetail.Text.Trim().Length > 0)
        //                sliderCreateTbl.picDetails = txtDetail.Text;
        //            else
        //                sliderCreateTbl.picDetails = "";
        //            sliderCreateTbl.picAddr = "~/video/";
        //            sliderCreateTbl.picName = filename;
        //            sliderCreateTbl.allow = "1";
        //            sliderCreateTbl.picLink = "";
        //            sliderCreateTbl.dateExp = "";

        //            sliderCreateTbl.Create();

        //            Response.Redirect("sliderTbl.aspx");
        //        }
        //        else
        //            lblError.Text = "* please enter title of slide.";
        //    }
        //    else
        //        lblError.Text = "* please choose a picture first.";
        //}
        //else
        //{
        //    if (filename.Trim().Length > 0)
        //    {
        //        sliderUpdateTbl[0].picName = filename;
        //    }

        //}
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