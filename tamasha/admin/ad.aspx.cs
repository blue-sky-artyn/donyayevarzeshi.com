using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlueSky.Artin;
using Cruder.Core;
public partial class admin_gallery_normal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string adString = string.Empty;
        tblAdCollection adTbl = new tblAdCollection();
        adTbl.ReadList();
        tblAdPicCollection adPicTbl = new tblAdPicCollection();


        adString += " <div class='grids_of_4'>";
        int counter = 1;
        for (int i = 0; i < adTbl.Count; i++)
        {
            adPicTbl.ReadList(Criteria.NewCriteria(tblAdPic.Columns.idAd, CriteriaOperators.Equal, adTbl[i].id));
            if (counter == 4)
                adString += " <div class='grids_of_4'>";

            adString += "<div class='grid1_of_4'><div class='content_box'>" +
                         "<a><img src='../images/ad/" + adPicTbl[0].picName + "' class='img-responsive' alt='" + adPicTbl[0].picName + "'></a><h4><a>" + adTbl[i].adTitle + "</a></h4>" +
                         "<p>" + adTbl[i].adDetails + "</p><div class='grid_1 simpleCart_shelfItem'>" +
                         "<div class='item_add'><span class='item_price'><h6>" + adTbl[i].dateStart;
            if (adTbl[i].periodOfShow > 0)
                adString += "FOR " + adTbl[i].periodOfShow + " Days</h6></span></div>";
            else
                adString += "TO " + adTbl[i].dateExp + "</h6></span></div>";

            adString += "<div class='item_add'><span class='item_price'><a href='ad-edit.aspx?adId=" + adTbl[i].id + "'>EDIT</a></span><span class='item_price'>" +
                         "<a href='ad-del.aspx?adId=" + adTbl[i].id + " '>DELETE</a></span></div></div></div></div>";
            if (counter == 4)
            {
                adString += "</div>";
                counter = 1;
            }
            counter++;
        }

        adString += "</div>";

        adHtml.InnerHtml = adString;

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        tblAd adTbl = new tblAd();
        tblAdPic adPicTbl = new tblAdPic();

        string dateInsert = DateTime.Now.ToString("yyyy/MM/dd");
        if (txtTitle.Text.Trim().Length > 0 && txtStart.Text.Trim().Length == 8)
        {
            try
            {


                adTbl.adTitle = txtTitle.Text;
                adTbl.adDetails = txtDetail.Text;
                adTbl.dateInsert = dateInsert;
                adTbl.dateStart = txtStart.Text;
                if (ddlExp.Enabled == true)
                {
                    adTbl.periodOfShow = Convert.ToInt32(ddlExp.SelectedValue);
                    adTbl.dateExp = "";
                }
                else
                {
                    adTbl.dateExp = txtExp.Text;
                    adTbl.periodOfShow = 0;
                }
                adTbl.adPayment = 1;
                adTbl.ownerOfBusiness = "";
                adTbl.allow = "1";
                adTbl.adPosition = ddlPosition.SelectedValue;

                #region File upload
                Boolean fileOK = false;
                String path = Server.MapPath("~/images/ad/");
                string filename = string.Empty;

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
                        lblError.Text = "A problem with uplouding picture";
                    }
                }
                else
                {
                    lblError.Text = "Not valid picture";
                }
                #endregion

                if (filename.Length > 0)
                    adTbl.Create();

                tblAdCollection adIdTbl = new tblAdCollection();
                adIdTbl.ReadList();

                adPicTbl.idAd = adIdTbl[adIdTbl.Count - 1].id;
                adPicTbl.picName = filename;
                adPicTbl.picAddr = "~/images/ad/";
                adPicTbl.picDetail = txtDetail.Text;
                adPicTbl.allow = "1";

                adPicTbl.Create();



            }
            catch (Exception ex)
            {
                lblError.Text = "There was an error and function has droped, " + ex.ToString();
            }
        }
        else
            lblError.Text = "Requierd filds must be completed...";
    }
}