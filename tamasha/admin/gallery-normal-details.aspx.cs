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
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("gallery-normal.aspx");

        //fill data 
        //tblGalleryPicsCollection galleryPicTbl = new tblGalleryPicsCollection();
        //galleryPicTbl.ReadList(Criteria.NewCriteria(tblGalleryPics.Columns.id, CriteriaOperators.Equal, itemGet));

        //tblGalleryGroupCollection galleryGroupTbl = new tblGalleryGroupCollection();
        //galleryGroupTbl.ReadList(Criteria.NewCriteria(tblGalleryGroup.Columns.id, CriteriaOperators.Equal, galleryPicTbl[0].idGalleryGroup));

        //tblStaffDetailsCollection staffTbl = new tblStaffDetailsCollection();
        //staffTbl.ReadList(Criteria.NewCriteria(tblStaffDetails.Columns.idPic, CriteriaOperators.Equal, galleryPicTbl[0].id));

        //tblSizeCollection sizeTbl = new tblSizeCollection();
        //sizeTbl.ReadList(Criteria.NewCriteria(tblSize.Columns.id, CriteriaOperators.Equal, staffTbl[0].idSize));

        //tblColorsCollection colorTbl = new tblColorsCollection();
        //colorTbl.ReadList(Criteria.NewCriteria(tblColors.Columns.id, CriteriaOperators.Equal, staffTbl[0].idColor));

        //tblShapeCollection shapeTbl = new tblShapeCollection();
        //shapeTbl.ReadList(Criteria.NewCriteria(tblShape.Columns.id, CriteriaOperators.Equal, staffTbl[0].idShape));

        //if (galleryPicTbl.Count > 0)
        //{
        //    setPicHtml.InnerHtml = "<img src='../images/gallery/" + galleryPicTbl[0].picName + "' data-imagezoom='true' class='img-responsive' draggable='false'>";
        //}

        //string discountValueString = string.Empty; int discountType = -1, newValue = -1;
        //if (!IsPostBack)
        //{
        //    //Discount Value
        //    tblDiscountCollection discountValue = new tblDiscountCollection();
        //    discountValue.ReadList(Criteria.NewCriteria(tblDiscount.Columns.staffId, CriteriaOperators.Equal, staffTbl[0].id));

        //    if (discountValue.Count == 0)
        //        rblDiscount.SelectedValue = "1";
        //    else
        //    {
        //        if (discountValue[0].DiscountAmont > 0)
        //        {
        //            txtDiscount.Text = discountValue[0].DiscountAmont.ToString();
        //            rblDiscount.SelectedValue = "1";
        //            discountType = 1;
        //            discountValueString = discountValue[0].DiscountAmont.ToString();
        //            newValue = int.Parse(discountValue[0].DiscountAmont.ToString());
        //        }
        //        else
        //        {
        //            txtDiscount.Text = discountValue[0].DiscountPercent.ToString();
        //            rblDiscount.SelectedValue = "2";
        //            discountType = 2;
        //            discountValueString = discountValue[0].DiscountPercent.ToString();
        //            newValue = int.Parse(staffTbl[0].staffPrice.ToString()) - (int.Parse(staffTbl[0].staffPrice.ToString()) * int.Parse(discountValue[0].DiscountPercent.ToString()) / 100);
        //        }
        //    }
        //}
        //else
        //{
        //    //Discount Value
        //    tblDiscountCollection discountValue = new tblDiscountCollection();
        //    discountValue.ReadList(Criteria.NewCriteria(tblDiscount.Columns.staffId, CriteriaOperators.Equal, staffTbl[0].id));
        //    if (discountValue.Count > 0)
        //    {
        //        if (discountValue[0].DiscountAmont > 0)
        //        {
        //            discountType = 1;
        //            discountValueString = discountValue[0].DiscountAmont.ToString();
        //            newValue = int.Parse(discountValue[0].DiscountAmont.ToString());
        //        }
        //        else
        //        {
        //            discountType = 2;
        //            discountValueString = discountValue[0].DiscountPercent.ToString();
        //            newValue = int.Parse(staffTbl[0].staffPrice.ToString()) - (int.Parse(staffTbl[0].staffPrice.ToString()) * int.Parse(discountValue[0].DiscountPercent.ToString()) / 100);
        //        }
        //    }
        //}
        //string addDataString = string.Empty;
        //addDataString += "<h3>" + galleryPicTbl[0].picTile + "</h3><br>" +
        //            "<span class='code'>Group: <a>" + galleryGroupTbl[0].GroupTitle + "</a></span>" +
        //            "<p>" + galleryPicTbl[0].picDetail + "</p>" +
        //                "<div class='price'>" +
        //                    "<span class='text'>Price:</span>";
        //if (newValue > -1)
        //    addDataString += "<span class='price-new'>$" + newValue + ".00</span><span class='price-old'>$" + staffTbl[0].staffPrice + ".00</span> ";
        //else
        //    addDataString += "<span class='price-new'>$" + staffTbl[0].staffPrice + ".00</span><span class='price-old'>$" + staffTbl[0].staffPrice + ".00</span> ";


        //addDataString += "<span class='price-tax'><label class='checkbox'><input type='checkbox' name='checkbox'><i></i>include Ex Tax: 13%</label></span><br>";

        //if (discountType == 1)
        //    addDataString += "<span class='points'><small>Discount Value: " + discountValueString + "</small></span><br>";
        //else if (discountType == 2)
        //    addDataString += "<span class='points'><small>Discount Percent: " + discountValueString + "%</small></span><br>";

        //addDataString += "</div><div class='det_nav1'>" +
        //                "<h4>Product Details :</h4>" +
        //                    "<div class='sky-form col col-4'>" +
        //                        "<ul><li>Size: " + sizeTbl[0].size + "</li>" +
        //                            "<li>/</li>" +
        //                            "<li>Color: " + colorTbl[0].colorName + "</li>" +
        //                            "<li>/</li>" +
        //                            "<li>Shape: " + shapeTbl[0].ShapeName + "</li>" +
        //                        "</ul></div></div>";
        //addDetailHtml.InnerHtml = addDataString;

        ////fill data in change part
        //if (!IsPostBack)
        //{
        //    //Groups
        //    tblGalleryGroupCollection groupChangeTbl = new tblGalleryGroupCollection();
        //    groupChangeTbl.ReadList();
        //    for (int i = 0; i < groupChangeTbl.Count; i++)
        //    {
        //        ddlGroup.Items.Add(new ListItem(groupChangeTbl[i].GroupTitle, groupChangeTbl[i].id.ToString()));
        //    }

        //    //Colors
        //    tblColorsCollection colorChangeTbl = new tblColorsCollection();
        //    colorChangeTbl.ReadList();
        //    for (int i = 0; i < colorChangeTbl.Count; i++)
        //    {
        //        ddlColor.Items.Add(new ListItem(colorChangeTbl[i].colorName, colorChangeTbl[i].id.ToString()));
        //    }

        //    //Shapes
        //    tblShapeCollection shapeChangeTbl = new tblShapeCollection();
        //    shapeChangeTbl.ReadList();
        //    for (int i = 0; i < shapeChangeTbl.Count; i++)
        //    {
        //        ddlShape.Items.Add(new ListItem(shapeChangeTbl[i].ShapeName, shapeChangeTbl[i].id.ToString()));
        //    }

        //    //Sizes
        //    tblSizeCollection sizeChangeTbl = new tblSizeCollection();
        //    sizeChangeTbl.ReadList();
        //    for (int i = 0; i < sizeChangeTbl.Count; i++)
        //    {
        //        ddlSize.Items.Add(new ListItem(sizeChangeTbl[i].size, sizeChangeTbl[i].id.ToString()));
        //    }

        //    //Select old items
        //    txtTitle.Text = galleryPicTbl[0].picTile;
        //    txtDetail.Text = galleryPicTbl[0].picDetail;
        //    lblOldPrice.Text = "$" + staffTbl[0].staffPrice + ".00";

        //    ddlGroup.SelectedValue = galleryGroupTbl[0].id.ToString();
        //    ddlColor.SelectedValue = colorTbl[0].id.ToString();
        //    ddlShape.SelectedValue = staffTbl[0].idShape.ToString();
        //    ddlSize.SelectedValue = staffTbl[0].idSize.ToString();

        //}

    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("gallery-normal.aspx");

        //tblGalleryPicsCollection galleryTbl = new tblGalleryPicsCollection();
        //galleryTbl.ReadList(Criteria.NewCriteria(tblGalleryPics.Columns.id, CriteriaOperators.Equal, itemGet));

        //galleryTbl[0].Delete();

        Response.Redirect("gallery-normal.aspx");

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("gallery-normal.aspx");

        //tblGalleryPicsCollection galleryTbl = new tblGalleryPicsCollection();
        //galleryTbl.ReadList(Criteria.NewCriteria(tblGalleryPics.Columns.id, CriteriaOperators.Equal, itemGet));

        //tblStaffDetailsCollection staffTbl = new tblStaffDetailsCollection();
        //staffTbl.ReadList(Criteria.NewCriteria(tblStaffDetails.Columns.idPic, CriteriaOperators.Equal, itemGet));

        //if (txtTitle.Text.Trim().Length > 0)
        //{
        //    //gallery items
        //    galleryTbl[0].idGalleryGroup = int.Parse(ddlGroup.SelectedValue);
        //    galleryTbl[0].picTile = txtTitle.Text;
        //    if (txtDetail.Text.Trim().Length > 0)
        //        galleryTbl[0].picDetail = txtDetail.Text;
        //    else
        //        galleryTbl[0].picDetail = "";

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
        //    if (filename.Trim().Length > 0)
        //    {
        //        galleryTbl[0].picName = filename;
        //    }

        //    //staff items
        //    staffTbl[0].idColor = int.Parse(ddlColor.SelectedValue);
        //    staffTbl[0].idShape = int.Parse(ddlShape.SelectedValue);
        //    staffTbl[0].idSize = int.Parse(ddlSize.SelectedValue);
        //    if (txtPrice.Text.Trim().Length > 0)
        //        staffTbl[0].staffPrice = int.Parse(txtPrice.Text);

        //    tblDiscountCollection discountCheckExisty = new tblDiscountCollection();
        //    discountCheckExisty.ReadList(Criteria.NewCriteria(tblDiscount.Columns.staffId, CriteriaOperators.Equal, staffTbl[0].id));
        //    if (discountCheckExisty.Count == 0)
        //    {
        //        tblDiscount discountCreate = new tblDiscount();
        //        if (rblDiscount.SelectedValue == "1")
        //        {
        //            discountCreate.staffId = staffTbl[0].id;
        //            discountCreate.DiscountPercent = 0;

        //            if (txtDiscount.Text.Trim().Length > 0)
        //                discountCreate.DiscountAmont = int.Parse(txtDiscount.Text);
        //            else
        //                discountCreate.DiscountAmont = 0;


        //            discountCreate.DiscountPeriodFrom = "0";
        //            discountCreate.DiscountPeriodTo = "0";

        //            discountCreate.Create();
        //        }
        //        else
        //        {
        //            discountCreate.staffId = staffTbl[0].id;
        //            discountCreate.DiscountPercent = int.Parse(txtDiscount.Text);
        //            discountCreate.DiscountAmont = 0;
        //            discountCreate.DiscountPeriodFrom = "0";
        //            discountCreate.DiscountPeriodTo = "0";

        //            discountCreate.Create();
        //        }
        //    }
        //    else
        //    {
        //        if (rblDiscount.SelectedValue == "1")
        //        {
        //            discountCheckExisty[0].staffId = staffTbl[0].id;
        //            discountCheckExisty[0].DiscountPercent = 0;
        //            discountCheckExisty[0].DiscountAmont = int.Parse(txtDiscount.Text);
        //            discountCheckExisty[0].DiscountPeriodFrom = "0";
        //            discountCheckExisty[0].DiscountPeriodTo = "0";

        //            discountCheckExisty.UpdateList(true);
        //        }
        //        else
        //        {
        //            discountCheckExisty[0].staffId = staffTbl[0].id;
        //            discountCheckExisty[0].DiscountPercent = int.Parse(txtDiscount.Text);
        //            discountCheckExisty[0].DiscountAmont = 0;
        //            discountCheckExisty[0].DiscountPeriodFrom = "0";
        //            discountCheckExisty[0].DiscountPeriodTo = "0";

        //            discountCheckExisty.UpdateList(true);
        //        }
        //    }

        //    staffTbl.UpdateList(true);
        //    galleryTbl.UpdateList(true);
        //}
        Response.Redirect("gallery-normal-details.aspx?item=" + itemGet);
    }
}