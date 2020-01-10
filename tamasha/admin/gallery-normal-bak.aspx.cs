using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using halidll;

public partial class admin_gallery_normal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //place pictures
        string addPicString = string.Empty;
        tblStaffDetailsCollection staffDetailsTbl = new tblStaffDetailsCollection();
        tblGalleryPicsCollection galleryTbl = new tblGalleryPicsCollection();
        galleryTbl.ReadList();

        for (int i = 0; i < galleryTbl.Count; i++)
        {
            staffDetailsTbl.ReadList(Criteria.NewCriteria(tblStaffDetails.Columns.idPic, CriteriaOperators.Equal, galleryTbl[i].id));
            addPicString += "<div class='grid1_of_4 flip-card'><div class='content_box flip-card-inner'><div class='flip-card-front'>" +
                            "<a href='gallery-normal-details.aspx?item=" + galleryTbl[i].id + "'>" +
                            "<img src='../images/gallery/" + galleryTbl[i].picName + "' class='img-responsive' alt='halisenGallery" + galleryTbl[i].id + "'></a></div>" +
                            "<div class='grid_1 simpleCart_shelfItem flip-card-back'>" +
                            "<h1><a style='color: white;'> " + galleryTbl[i].picTile + " </a></h1>" +
                            "<p>" + galleryTbl[i].picDetail + "</p>" +
                            "<h6 style='padding: 10% 0;'>Price: $" + staffDetailsTbl[0].staffPrice + ".00</h6>" +
                            "<a class='edit-gallery-button' href='gallery-normal-details.aspx?item=" + galleryTbl[i].id + "'>EDIT</a></div></div></div>";
        }
        //addPicHtml.InnerHtml = addPicString;


        //fill the drop down lists
        tblColorsCollection colorsTbl = new tblColorsCollection();
        colorsTbl.ReadList();

        tblShapeCollection shapesTbl = new tblShapeCollection();
        shapesTbl.ReadList();

        tblSizeCollection sizeTbl = new tblSizeCollection();
        sizeTbl.ReadList();

        tblGalleryGroupCollection groupsTbl = new tblGalleryGroupCollection();
        groupsTbl.ReadList();

        for (int i = 0; i < colorsTbl.Count; i++)
        {
            ddlColors.Items.Add(new ListItem(colorsTbl[i].colorName, colorsTbl[i].id.ToString()));
        }

        for (int i = 0; i < shapesTbl.Count; i++)
        {
            ddlShape.Items.Add(new ListItem(shapesTbl[i].ShapeName, shapesTbl[i].id.ToString()));
        }

        for (int i = 0; i < sizeTbl.Count; i++)
        {
            ddlSize.Items.Add(new ListItem(sizeTbl[i].size, sizeTbl[i].id.ToString()));
        }

        for (int i = 0; i < groupsTbl.Count; i++)
        {
            // ddlGropus.Items.Add(groupsTbl[i].GroupTitle);
            ddlGropus.Items.Add(new ListItem(groupsTbl[i].GroupTitle, sizeTbl[i].id.ToString()));
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string errorString = string.Empty;
        lblError.Visible = false;
        tblGalleryPics galleryTbl = new tblGalleryPics();
        if (txtPrice.Text.Trim().Length > 0)
        {
            if (txtTitle.Text.Length > 0)
                galleryTbl.picTile = txtTitle.Text;
            else
            {
                errorString = "* Please fill out title";
                lblError.Visible = true;
            }


            // file upload start 
            string filename = string.Empty;
            if (IsPostBack)
            {
                Boolean fileOK = false;
                String path = Server.MapPath("~/images/gallery/");
                if (fuGallery.HasFile)
                {
                    String fileExtension = System.IO.Path.GetExtension(fuGallery.FileName).ToLower();
                    String[] allowedExtensions = { ".jpg" };
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
                        lblError.Text = "مشکل بارگزاری فایل عکس";
                    }
                }
                else
                {
                    lblError.Text = "فایل انتخابی معتبر نیست";
                }
            }

            // file upload end

            galleryTbl.picAddr = "~/images/gallery/";
            galleryTbl.picName = filename;

            galleryTbl.picLink = "";
            galleryTbl.allow = "1";

            if (txtDetails.Text.Trim().Length > 0)
                galleryTbl.picDetail = txtDetails.Text;
            else
                galleryTbl.picDetail = "";

            galleryTbl.idGalleryGroup = Int32.Parse(ddlGropus.SelectedValue);

            if (lblError.Visible == false)
                galleryTbl.Create();

            //staff details
            tblStaffDetails staffTbl = new tblStaffDetails();

            tblGalleryPicsCollection picIdTbl = new tblGalleryPicsCollection();
            picIdTbl.ReadList();

            int idPic = picIdTbl[picIdTbl.Count - 1].id;

            staffTbl.idPic = idPic;
            staffTbl.staffPrice = Int32.Parse(txtPrice.Text);

            staffTbl.idColor = Int32.Parse(ddlColors.SelectedValue);
            staffTbl.idShape = Int32.Parse(ddlShape.SelectedValue);
            staffTbl.idSize = Int32.Parse(ddlSize.SelectedValue);

            staffTbl.allow = "1";

            if (lblError.Visible == false)
                staffTbl.Create();
        }
        else
        {
            errorString = "* Please fill out price";
            lblError.Visible = true;
        }
    }
}