using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using BlueSky.Artin;


public partial class admin_gallery_normal_detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["adId"] != null)
        {
            itemGet = int.Parse(Request.QueryString["adId"]);
        }
        else
            Response.Redirect("ad.aspx");

        //fill data 
        tblAdCollection adTbl = new tblAdCollection();
        adTbl.ReadList(Criteria.NewCriteria(tblAd.Columns.id, CriteriaOperators.Equal, itemGet));
        tblAdPicCollection adPicTbl = new tblAdPicCollection();
        adPicTbl.ReadList(Criteria.NewCriteria(tblAdPic.Columns.idAd, CriteriaOperators.Equal, adTbl[0].id));

        #region showing data

        if (adPicTbl[0].picName.Length > 3)
        {
            setPicHtml.InnerHtml = "<img src='../images/ad/" + adPicTbl[0].picName + "' class='img-responsive' draggable='false'>";
        }


        string addDataString = string.Empty;
        addDataString += "<h3 class='farsi-direction farsi-font-title'>" + adTbl[0].adTitle + "</h3><br>" +
                         "<span class='code'>Position: <a>" + adTbl[0].adPosition + "</a></span>" +
                         "<p class='farsi-font-text'><span class='subtitle-news'>Details:</span> " + adTbl[0].adDetails + "</p>" +
                         "<div class='price'>" +
                         "<span class='text'></span>";

        addDataString += "<span class='price-new'></span>";


        addDataString += "<span class='price-tax'><label class='checkbox'></label></span><br>";


        addDataString += "<span class='points'><small>Insert Date: " + adTbl[0].dateInsert + "</small> To " + adTbl[0].dateExp + " / " + adTbl[0].periodOfShow + " Days</span><br>";

        addDataString += "</div>";

        adHtml.InnerHtml = addDataString;
        #endregion

        if (!IsPostBack)
        {
            #region filling text boxes 

            txtTitle.Text = adTbl[0].adTitle;
            txtDetail.Text = adTbl[0].adDetails;
            txtStart.Text = adTbl[0].dateStart;

            if (adTbl[0].periodOfShow > 0)
            {
                ddlExp.SelectedValue = adTbl[0].periodOfShow.ToString();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "disableTextBox()", true);
                rb2.Checked = true;
            }
            else
            {
                txtExp.Text = adTbl[0].dateExp;
                ddlExp.SelectedValue = "0";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "disableDropDownList()", true);
                rb1.Checked = true;
            }

            ddlPosition.SelectedValue = adTbl[0].adPosition.Trim();
            #endregion
        }
    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["adId"] != null)
        {
            itemGet = int.Parse(Request.QueryString["adId"]);
        }
        else
            Response.Redirect("ad.aspx");

        tblAdCollection adTbl = new tblAdCollection();
        adTbl.ReadList(Criteria.NewCriteria(tblAd.Columns.id, CriteriaOperators.Equal, itemGet));

        adTbl[0].Delete();

        Response.Redirect("ad-edit.aspx");

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        int itemGet = 0; string fileNameUpdate = string.Empty;
        if (Request.QueryString["adId"] != null)
        {
            itemGet = int.Parse(Request.QueryString["adId"]);
        }
        else
            Response.Redirect("ad.aspx");

        tblAdCollection adTbl = new tblAdCollection();
        adTbl.ReadList(Criteria.NewCriteria(tblAd.Columns.id, CriteriaOperators.Equal, itemGet));

        tblAdPicCollection adPicTbl = new tblAdPicCollection();
        adPicTbl.ReadList(Criteria.NewCriteria(tblAdPic.Columns.idAd, CriteriaOperators.Equal, itemGet));

        #region ad table update

        if (txtTitle.Text.Trim().Length > 0 && txtStart.Text.Trim().Length == 8)
        {
            //int dateIns = Convert.ToInt32(adTbl[0].dateInsert.Trim());
            adTbl[0].adTitle = txtTitle.Text;
            adTbl[0].adDetails = txtDetail.Text;
            adTbl[0].dateStart = txtStart.Text;
            adTbl[0].dateInsert = adTbl[0].dateInsert;
            if (ddlExp.Enabled == true)
            {
                adTbl[0].periodOfShow = Convert.ToInt32(ddlExp.SelectedValue);
                adTbl[0].dateExp = "";
            }
            else
            {
                adTbl[0].dateExp = txtExp.Text;
                adTbl[0].periodOfShow = 0;
            }
            adTbl[0].adPayment = 1;
            adTbl[0].ownerOfBusiness = "";
            adTbl[0].allow = "1";
            adTbl[0].adPosition = ddlPosition.SelectedValue;

            adTbl[0].Update();
            #endregion

            #region picture update

            // file upload start 
            string filename = string.Empty;
            Boolean fileOK = false;
            String fileExtension = System.IO.Path.GetExtension(fuGallery.FileName).ToLower();

            if (IsPostBack)
            {
                String path = Server.MapPath("~/images/ad/");
                if (fuGallery.HasFile)
                {
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


            // file upload end
            if (filename.Trim().Length > 0)
                adPicTbl[0].picName = filename;

            adPicTbl[0].idAd = itemGet;
            adPicTbl[0].picAddr = "../images/ad/";
            adPicTbl[0].picDetail = txtDetail.Text;
            adPicTbl[0].allow = "1";

            adPicTbl[0].Update();
            #endregion
        }

        Response.Redirect("ad.aspx");
    }
}