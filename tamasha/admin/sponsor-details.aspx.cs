using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;


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
            Response.Redirect("sponsors.aspx");

        //fill data 

        tblSponsorsCollection sponsorTbl = new tblSponsorsCollection();
        sponsorTbl.ReadList(Criteria.NewCriteria(tblSponsors.Columns.id, CriteriaOperators.Equal, itemGet));

        tblSponsorPeriodCollection sponsorPeriodTbl = new tblSponsorPeriodCollection();
        sponsorPeriodTbl.ReadList(Criteria.NewCriteria(tblSponsorPeriod.Columns.sponsorId, CriteriaOperators.Equal, itemGet));


        if (sponsorTbl[0].sponsorPicName.Length > 0)
        {
            setPicHtml.InnerHtml = "<img src='../" + sponsorTbl[0].sponsorPicAddr + sponsorTbl[0].sponsorPicName + "' class='img-responsive' draggable='false'>";
        }

        string addDataString = string.Empty;
        addDataString += "<h3>" + sponsorTbl[0].sponsorName + "</h3><br>" +
                         "<span class='code'>Comapny Name: <a>" + sponsorTbl[0].sponsorCo + "</a></span>" +
                         "<div class='price'>";

        addDataString += "<span class='points'><small>Start from: <" + sponsorPeriodTbl[0].startDate + "> TO <" + sponsorPeriodTbl[0].endDate + "></small></span><br>";

        addDataString += "</div>" +
                        "<div class='det_nav1'>" +
                        "<h4>Tel:<p>" + sponsorTbl[0].sponsorTel + "</p></h4>" +
                        "<h4>Email:<p> " + sponsorTbl[0].sponsorEmail + "</p></h4>" +
                        "<h4>Address:<p> " + sponsorTbl[0].sponsorAddr + "</p></h4>" +
                        "</div>" +
                        "<div class='det_nav1'>" +
                        "<h4>Details:</h4>" +
                        "<div class='sky-form col col-4'>" +
                        "<p>" + sponsorTbl[0].sponsorDetails + "</p></div></div>";
        addDetailHtml.InnerHtml = addDataString;

        //fill data in change part
        //Groups

        //Select old items
        if (!IsPostBack)
        {
            txtName.Text = sponsorTbl[0].sponsorName;
            txtCo.Text = sponsorTbl[0].sponsorCo;
            txtEmail.Text = sponsorTbl[0].sponsorEmail;
            txtTel.Text = sponsorTbl[0].sponsorTel;
            txtStartFrom.Text = sponsorPeriodTbl[0].startDate.ToString();
            txtEndOf.Text = sponsorPeriodTbl[0].endDate.ToString();
            txtAddr.Text = sponsorTbl[0].sponsorAddr;
            txtDetail.Text = sponsorTbl[0].sponsorDetails;
        }
    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("sponsors.aspx");

        tblSponsorsCollection sponsorTbl = new tblSponsorsCollection();
        sponsorTbl.ReadList(Criteria.NewCriteria(tblSponsors.Columns.id, CriteriaOperators.Equal, itemGet));

        sponsorTbl[0].Delete();

        Response.Redirect("sponsors.aspx");

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        int itemGet = 0; string fileNameUpdate = string.Empty;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("sponsors.aspx");

        tblSponsorsCollection sponsorTbl = new tblSponsorsCollection();
        sponsorTbl.ReadList(Criteria.NewCriteria(tblSponsors.Columns.id, CriteriaOperators.Equal, itemGet));

        tblSponsorPeriodCollection sponsorPeriodTbl = new tblSponsorPeriodCollection();
        sponsorPeriodTbl.ReadList(Criteria.NewCriteria(tblSponsorPeriod.Columns.sponsorId, CriteriaOperators.Equal, itemGet));


        if (sponsorTbl.Count > 0)
            fileNameUpdate = sponsorTbl[0].sponsorPicName;

        if (txtName.Text.Trim().Length > 0 && txtCo.Text.Trim().Length > 0)
        {
            sponsorTbl[0].sponsorName = txtName.Text;

            sponsorTbl[0].sponsorCo = txtCo.Text;
            sponsorTbl[0].sponsorTel = txtTel.Text;
            sponsorTbl[0].sponsorEmail = txtEmail.Text;
            sponsorTbl[0].sponsorAddr = txtAddr.Text;
            sponsorTbl[0].sponsorDetails = txtDetail.Text;
            if (txtStartFrom.Text.Trim().Length > 0)
                sponsorPeriodTbl[0].startDate = Convert.ToInt32(txtStartFrom.Text);
            else
                sponsorPeriodTbl[0].startDate = 0;

            if (txtEndOf.Text.Trim().Length > 0)
                sponsorPeriodTbl[0].endDate = Convert.ToInt32(txtEndOf.Text);
            else
                sponsorPeriodTbl[0].endDate = 0;

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
                        lblError.Text = "A problem accurred while uplouding picture";
                    }
                }
                else
                {
                    lblError.Text = "Not valid picture file";
                }
            }

            // file upload end
            if (filename.Trim().Length > 0)
                sponsorTbl[0].sponsorPicName = filename;
            else
                sponsorTbl[0].sponsorPicName = fileNameUpdate;

            sponsorTbl[0].Update();
            sponsorPeriodTbl[0].Update();
        }

        Response.Redirect("sponsor-details.aspx?item=" + itemGet);
    }
}