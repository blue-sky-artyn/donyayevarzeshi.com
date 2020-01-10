using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using BlueSky.Artin;

public partial class admin_need_to_know : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Add ddl
        tblNewsGroupSportCollection newsGroupTbl = new tblNewsGroupSportCollection();
        newsGroupTbl.ReadList();

        tblNewsPicSportCollection newsPicTbl = new tblNewsPicSportCollection();

        if (!IsPostBack)
        {
            for (int i = 0; i < newsGroupTbl.Count; i++)
            {
                ddlNewsGroup.Items.Add(new ListItem(newsGroupTbl[i].newsGroupTitle, newsGroupTbl[i].id.ToString()));
            }
        }
        //place data
        string newsString = string.Empty;
        tblNewsDetailsSportCollection newsTbl = new tblNewsDetailsSportCollection();
        newsTbl.ReadList();

        string addRow = "<div class='row'>";
        int countSteps = 0;

        for (int i = 0; i < newsTbl.Count; i++)
        {
            newsGroupTbl.ReadList(Criteria.NewCriteria(tblNewsGroupSport.Columns.id, CriteriaOperators.Equal, newsTbl[i].idGroup));
            newsPicTbl.ReadList(Criteria.NewCriteria(tblNewsPicSport.Columns.newsId, CriteriaOperators.Equal, newsTbl[i].id));

            if (countSteps == 0)
            {
                newsString += addRow;
            }

            newsString += "<div class='col-md-6 graph-2'>" +
                          "<h3 class='inner-tittle'>News " + (i + 1) + " </h3>" +
                          "<div class='panel panel-primary two'>" +
                          "<div class='panel-heading'>" + newsTbl[i].newsDetTitle + "(" + newsGroupTbl[0].newsGroupTitle + ")" + "</div><div class='panel-body ont two'>" +
                          "<div><img src='../images/news/sport/" + newsPicTbl[0].picName + "' alt='Hsco corp health care " + i + "' style='width: 100%;' /></div><p>" + newsTbl[i].newsDetDetails + "</p></div>" +
                          "<div class='panel-footer'><a href='news-details-sport.aspx?item=" + newsTbl[i].id + "'>edit</a></div></div></div>";
            countSteps++;
            if (countSteps == 2)
            {
                countSteps = 0;
                newsString += "</div>";
            }
        }

        infHtml.InnerHtml = newsString;

        

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        tblNewsDetailsSport newsTbl = new tblNewsDetailsSport();

        if (txtTitle.Text.Trim().Length > 0)
        {
            newsTbl.newsDetTitle = txtTitle.Text;

            if (txtDetail.Text.Trim().Length > 0)
                newsTbl.newsDetDetails = txtDetail.Text;
            else
                newsTbl.newsDetDetails = "";

            newsTbl.idAcceptedAdmin = 1;
            newsTbl.idStaffCreator = 1;
            newsTbl.newsDetInsertDate = "";
            newsTbl.newsDetInsertTime = "";
            newsTbl.incReview = 1;

            newsTbl.idGroup = Int32.Parse(ddlNewsGroup.SelectedValue);

            newsTbl.allow = "1";

            newsTbl.Create();



            tblNewsPicSport newsPicTbl = new tblNewsPicSport();

            // file upload start 
            string filename = string.Empty;
            if (IsPostBack)
            {
                Boolean fileOK = false;
                String path = Server.MapPath("~/images/news/sport/");
                if (fuGallery.HasFile)
                {
                    String fileExtension = System.IO.Path.GetExtension(fuGallery.FileName).ToLower();
                    String[] allowedExtensions = { ".jpg" , ".png" , ".bmp" , ".gif" };
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
            if (filename.Trim().Length > 0) newsPicTbl.picName = filename;
            else newsPicTbl.picName = "default.jpg";

            tblNewsDetailsSportCollection idDetTbl = new tblNewsDetailsSportCollection();
            idDetTbl.ReadList();

            newsPicTbl.newsId = idDetTbl[idDetTbl.Count - 1].id;
            newsPicTbl.picAddr = "../images/news/sport/";
            newsPicTbl.picDetail = "";
            newsPicTbl.allow = "1";

            newsPicTbl.Create();



            Response.Redirect("news-add-sport.aspx");
        }
        else
            lblError.Text = "* please enter title frist.";
    }
}