using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;
public partial class admin_gallery_normal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //place pictures
        string sponsorStr = string.Empty;
        tblSponsorPeriodCollection sponsorPrtiodTbl = new tblSponsorPeriodCollection();
        tblSponsorsCollection sponsorTbl = new tblSponsorsCollection();
        sponsorTbl.ReadList();

        sponsorStr += "<div class='grids_of_4'>";
        for (int i = 0; i < sponsorTbl.Count; i++)
        {
            sponsorPrtiodTbl.ReadList(Criteria.NewCriteria(tblSponsorPeriod.Columns.sponsorId, CriteriaOperators.Equal, sponsorTbl[i].id));

            sponsorStr += "<div class='grid1_of_4'><div class='content_box'><a href='sponsor-details.aspx?item=" + sponsorTbl[i].id + "'>" +
                            "<img src='../" + sponsorTbl[i].sponsorPicAddr + sponsorTbl[i].sponsorPicName + "' class='img-responsive' alt='" + sponsorTbl[i].id + "' /></a>" +
                            "<h4><a> " + sponsorTbl[i].sponsorName + " </a></h4>" +
                            "<h4>" + sponsorTbl[i].sponsorCo + "</h4>" +
                            "<p>" + sponsorTbl[i].sponsorDetails + "</p>" +
                            "<div class='grid_1 simpleCart_shelfItem'>";
            if (sponsorPrtiodTbl.Count > 0)
                sponsorStr += "<div class='item_add'><span class='item_price'><p>Start From: <" + sponsorPrtiodTbl[0].startDate + "> TO <" + sponsorPrtiodTbl[0].endDate + "></p></span></div>";

            sponsorStr += "<div class='item_add'><span class='item_price'><a href='sponsor-details.aspx?item=" + sponsorTbl[i].id + "'>EDIT</a></span></div>" +
                            "</div></div></div>";
            if ((i - 1) % 4 == 0)
            {
                sponsorStr += "<div class='clearfix'></div></div>";
                sponsorStr += "<div class='grids_of_4'>";
            }
        }

        addSponsoHtml.InnerHtml = sponsorStr;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string errorString = string.Empty;
        lblError.Visible = false;
        tblSponsors sponsorTbl = new tblSponsors();
        try
        {


            if (txtName.Text.Trim().Length > 0 && txtCo.Text.Trim().Length > 0)
            {
                sponsorTbl.sponsorName = txtName.Text;
                sponsorTbl.sponsorAddr = txtAddr.Text;
                sponsorTbl.sponsorTel = txtTel.Text;
                sponsorTbl.sponsorCo = txtCo.Text;
                sponsorTbl.sponsorEmail = txtEmail.Text;
                sponsorTbl.sponsorDetails = txtDetail.Text;
                sponsorTbl.allow = "1";

                // file upload start 
                string filename = string.Empty;
                if (IsPostBack)
                {
                    Boolean fileOK = false;
                    String path = Server.MapPath("~/images/sponsor/");
                    if (fuGallery.HasFile)
                    {
                        String fileExtension = System.IO.Path.GetExtension(fuGallery.FileName).ToLower();
                        String[] allowedExtensions = { ".jpg", ".png", ".bmp", ".tif" };
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
                            lblError.Text = "A promblem with uplouding picture";
                        }
                    }
                    else
                    {
                        lblError.Text = "Not valid picture";
                    }
                }

                // file upload end

                sponsorTbl.sponsorPicAddr = "images/sponsor/";
                if (filename.Length > 0)
                    sponsorTbl.sponsorPicName = filename;
                else
                    lblError.Visible = true;



                if (lblError.Visible == false)
                {
                    sponsorTbl.Create();

                    #region add period for sponsor
                    tblSponsorsCollection sponsorLastId = new tblSponsorsCollection();
                    sponsorLastId.ReadList();

                    tblSponsorPeriod sponsorPriodTbl = new tblSponsorPeriod();

                    sponsorPriodTbl.sponsorId = sponsorLastId[sponsorLastId.Count - 1].id;
                    if (txtStartFrom.Text.Trim().Length > 0)
                        sponsorPriodTbl.startDate = Convert.ToInt32(txtStartFrom.Text);
                    else
                        sponsorPriodTbl.startDate = 0;

                    if (txtEndOf.Text.Trim().Length > 0)
                        sponsorPriodTbl.endDate = Convert.ToInt32(txtEndOf.Text);
                    else
                        sponsorPriodTbl.endDate = 0;
                    sponsorPriodTbl.allow = "1";
                    sponsorPriodTbl.Create();
                    #endregion

                    Response.Redirect("sponsors.aspx");
                }
                else
                {
                    lblError.Text = "* Please fill nesessary items";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "* Please fill nesessary items";
                lblError.Visible = true;
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = true;
        }
    }
}