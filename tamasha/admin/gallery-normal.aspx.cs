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
        //tblStaffDetailsCollection staffDetailsTbl = new tblStaffDetailsCollection();
        //tblGalleryPicsCollection galleryTbl = new tblGalleryPicsCollection();
        //galleryTbl.ReadList();

        //addPicString += "<div class='grids_of_4'>";
        //for (int i = 1; i <= galleryTbl.Count; i++)
        //{
        //    staffDetailsTbl.ReadList(Criteria.NewCriteria(tblStaffDetails.Columns.idPic, CriteriaOperators.Equal, galleryTbl[i - 1].id));

        //    addPicString += "<div class='grid1_of_4'><div class='content_box'><a href='gallery-normal-details.aspx?item=" + galleryTbl[i - 1].id + "'>" +
        //                    "<img src='../images/gallery/" + galleryTbl[i - 1].picName + "' class='img-responsive' alt='halisenGallery" + galleryTbl[i - 1].id + "' /></a>" +
        //                    "<h4><a> " + galleryTbl[i - 1].picTile + " </a></h4>" +
        //                    "<p>" + galleryTbl[i - 1].picDetail + "</p>" +
        //                    "<div class='grid_1 simpleCart_shelfItem'>" +
        //                    "<div class='item_add'><span class='item_price'><h6>Price: $" + staffDetailsTbl[0].staffPrice + ".00</h6></span></div>" +
        //                    "<div class='item_add'><span class='item_price'><a href='gallery-normal-details.aspx?item=" + galleryTbl[i - 1].id + "'>EDIT</a></span></div>" +
        //                    "</div></div></div>";
        //    if (i % 4 == 0)
        //    {
        //        addPicString += "<div class='clearfix'></div></div>";
        //        addPicString += "<div class='grids_of_4'>";
        //    }
        //}

        //addPicHtml.InnerHtml = addPicString;

        ////fill the drop down lists
        //tblColorsCollection colorsTbl = new tblColorsCollection();
        //colorsTbl.ReadList();

        //tblShapeCollection shapesTbl = new tblShapeCollection();
        //shapesTbl.ReadList();

        //tblSizeCollection sizeTbl = new tblSizeCollection();
        //sizeTbl.ReadList();

        //tblGalleryGroupCollection groupsTbl = new tblGalleryGroupCollection();
        //groupsTbl.ReadList();

        //for (int i = 0; i < colorsTbl.Count; i++)
        //{
        //    ddlColors.Items.Add(new ListItem(colorsTbl[i].colorName, colorsTbl[i].id.ToString()));
        //}

        //for (int i = 0; i < shapesTbl.Count; i++)
        //{
        //    ddlShape.Items.Add(new ListItem(shapesTbl[i].ShapeName, shapesTbl[i].id.ToString()));
        //}

        //for (int i = 0; i < sizeTbl.Count; i++)
        //{
        //    ddlSize.Items.Add(new ListItem(sizeTbl[i].size, sizeTbl[i].id.ToString()));
        //}

        //for (int i = 0; i < groupsTbl.Count; i++)
        //{
        //    // ddlGropus.Items.Add(groupsTbl[i].GroupTitle);
        //    ddlGropus.Items.Add(new ListItem(groupsTbl[i].GroupTitle, sizeTbl[i].id.ToString()));
        //}
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string errorString = string.Empty;
        lblError.Visible = false;
        //tblGalleryPics galleryTbl = new tblGalleryPics();
        //if (txtPrice.Text.Trim().Length > 0)
        //{
        //    if (txtTitle.Text.Length > 0)
        //        galleryTbl.picTile = txtTitle.Text;
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
        //        String path = Server.MapPath("~/images/gallery/");
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

        //    galleryTbl.picAddr = "~/images/gallery/";
        //    galleryTbl.picName = filename;

        //    galleryTbl.picLink = "";
        //    galleryTbl.allow = "1";

        //    if (txtDetails.Text.Trim().Length > 0)
        //        galleryTbl.picDetail = txtDetails.Text;
        //    else
        //        galleryTbl.picDetail = "";

        //    galleryTbl.idGalleryGroup = Int32.Parse(ddlGropus.SelectedValue);

        //    if (lblError.Visible == false)
        //        galleryTbl.Create();

        //    //staff details
        //    tblStaffDetails staffTbl = new tblStaffDetails();

        //    tblGalleryPicsCollection picIdTbl = new tblGalleryPicsCollection();
        //    picIdTbl.ReadList();

        //    int idPic = picIdTbl[picIdTbl.Count - 1].id;

        //    staffTbl.idPic = idPic;
        //    staffTbl.staffPrice = Int32.Parse(txtPrice.Text);

        //    staffTbl.idColor = Int32.Parse(ddlColors.SelectedValue);
        //    staffTbl.idShape = Int32.Parse(ddlShape.SelectedValue);
        //    staffTbl.idSize = Int32.Parse(ddlSize.SelectedValue);

        //    staffTbl.allow = "1";

        //    if (lblError.Visible == false)
        //        staffTbl.Create();
        //    Response.Redirect("gallery-normal.aspx");
        //}
        //else
        //{
        //    errorString = "* Please fill out price";
        //    lblError.Visible = true;
        //}
    }
}