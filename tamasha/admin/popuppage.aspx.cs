using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

public partial class admin_need_to_know : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Add ddl
        tblAdCollection popupAdTbl = new tblAdCollection();
        popupAdTbl.ReadList();

        if (!IsPostBack)
        {
           
        }
        //place data
        string adString = string.Empty;
        tblAdPicCollection popoupAdPic = new tblAdPicCollection();
        popoupAdPic.ReadList();

        for (int i = 0; i < popupAdTbl.Count; i++)
        {
            popoupAdPic.ReadList(Criteria.NewCriteria(tblAdPic.Columns.idAd, CriteriaOperators.Equal, popupAdTbl[i].id));

            adString += "<div class='col-md-6 graph-2'>" +
                          "<h3 class='inner-tittle'>News " + (i + 1) + " </h3>" +
                          "<div class='panel panel-primary two'>" +
                          "<div class='panel-heading'>" + popupAdTbl[i].adTitle + "(" + popupAdTbl[i].dateStart+ " / " + popupAdTbl[i].dateExp + ")" + "</div><div class='panel-body ont two'>" +
                          "<div><img src='../" + popoupAdPic[0].picAddr + "' alt='Hsco corp health care " + i + "' style='width: 100%;' /></div><p>" + popupAdTbl[i].adDetails + "</p></div>" +
                          "<div class='panel-footer'><a href='add-details.aspx?item=" + popupAdTbl[i].id + "'>edit</a></div></div></div>";

        }

        infHtml.InnerHtml = adString;

        

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        tblAd popoupTbl = new tblAd();
        DateTime dateTime = DateTime.UtcNow.Date;
        string datedate = dateTime.ToString("yyyyMMdd");
        


        if (txtTitle.Text.Trim().Length > 0)
        {
            popoupTbl.adTitle = txtTitle.Text;

            if (ckDetails.Text.Trim().Length > 0)
            {
                string str = ckDetails.Text;
                popoupTbl.adDetails = Server.HtmlDecode(str);
            }
            else
                popoupTbl.adDetails = "";

            popoupTbl.dateInsert = datedate;

            if (txtYearFrom.Text.Length < 4 || txtMonthFrom.Text.Length < 2 || txtDayFrom.Text.Length < 2)
                popoupTbl.dateStart = datedate;
            else
                popoupTbl.dateStart = txtYearFrom.Text + txtMonthFrom.Text + txtDayFrom.Text;

            if (txtYearTo.Text.Length < 4 || txtMonthTo.Text.Length < 2 || txtDayTo.Text.Length < 2)
                popoupTbl.dateExp = datedate;
            else
                popoupTbl.dateExp = txtYearTo.Text + txtMonthTo.Text + txtDayTo.Text;

            popoupTbl.allow = "1";
            popoupTbl.periodOfShow = 1;
            popoupTbl.adPayment = 1;
            popoupTbl.ownerOfBusiness = "";

            popoupTbl.Create();


            tblAdCollection popupAdCountIdTbl = new tblAdCollection();
            popupAdCountIdTbl.ReadList();


            tblAdPic popupAdPicTbl = new tblAdPic();

            // file upload start 
            string filename = string.Empty;
            if (IsPostBack)
            {
                Boolean fileOK = false;
                String path = Server.MapPath("~/images/");
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
                        lblError.Text = "A promblem with uplouding picture";
                    }
                }
                else
                {
                    lblError.Text = "Not valid picture";
                }
            }

            //file upload end
            if (filename.Trim().Length > 0)
                popupAdPicTbl.picAddr = "images/" + filename;
            //else error

            popupAdPicTbl.idAd = popupAdCountIdTbl[popupAdCountIdTbl.Count - 1].id;
            popupAdPicTbl.allow = "1";
            popupAdPicTbl.picName = "";
            popupAdPicTbl.picDetail = "";

            popupAdPicTbl.Create();




            tblAdStyle popupAdStyle = new tblAdStyle();

            popupAdStyle.idAd = popupAdCountIdTbl[popupAdCountIdTbl.Count - 1].id;
            popupAdStyle.styleTitle = rbStyle.SelectedValue;
            popupAdStyle.styleContent = "";
            popupAdStyle.styleDetails = "";



            popupAdStyle.Create();



            Response.Redirect("popuppage.aspx");
        }
        else
            lblError.Text = "* please enter title frist.";
    }
}