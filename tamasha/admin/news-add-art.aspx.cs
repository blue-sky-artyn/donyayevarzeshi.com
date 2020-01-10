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
        tblNewsGroupArtCollection newsGroupTbl = new tblNewsGroupArtCollection();
        newsGroupTbl.ReadList();

        //tblNewsPicArtCollection newsPicTbl = new tblNewsPicArtCollection();

        if (!IsPostBack)
        {
            for (int i = 0; i < newsGroupTbl.Count; i++)
            {
                ddlNewsGroup.Items.Add(new ListItem(newsGroupTbl[i].newsGroupTitle, newsGroupTbl[i].id.ToString()));
            }
        }
        //place data
        string newsString = string.Empty;
        tblNewsDetailsArtCollection newsTbl = new tblNewsDetailsArtCollection();
        newsTbl.ReadList();

        string addRow = "<div class='row'>";
        int countSteps = 0;

        for (int i = 0; i < newsTbl.Count; i++)
        {
            newsGroupTbl.ReadList(Criteria.NewCriteria(tblNewsGroupArt.Columns.id, CriteriaOperators.Equal, newsTbl[i].idGroup));
            //newsPicTbl.ReadList(Criteria.NewCriteria(tblNewsPicArt.Columns.newsId, CriteriaOperators.Equal, newsTbl[i].id));

            if (countSteps == 0)
            {
                newsString += addRow;
            }

            newsString += "<div class='col-md-6 graph-2'>" +
                          "<h3 class='inner-tittle'>News " + (i + 1) + " </h3>" +
                          "<div class='panel panel-primary two'>" +
                          "<div class='panel-heading'>" + newsTbl[i].newsDetTitle + "(" + newsGroupTbl[0].newsGroupTitle + ")" + "</div><div class='panel-body ont two'>";
            if (newsTbl[i].topPageFileType == 0)
                newsString += "<div><img src='../images/news/top/" + newsTbl[i].topPageFileAddr + "' alt='مجله تماشا " + i + "' style='width: 100%;' /></div>";
            else if (newsTbl[i].topPageFileType == 1)
                newsString += "<div><video id='video1'><source src='../movie/news/top/" + newsTbl[i].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video></div>";
            else
                newsString += "<div>" + newsTbl[i].topPageFileAddr + "</div>";

            newsString += "<p>" + newsTbl[i].newsDetDetails + "</p></div>" +
                          "<div class='panel-footer'><a href='news-details-art.aspx?item=" + newsTbl[i].id + "'>edit</a></div></div></div>";
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
        string dateInsert = DateTime.Now.ToString("yyyy/MM/dd");
        string timeInsert = DateTime.Now.ToString("hh:mm:ss");


        tblNewsDetailsArt newsTbl = new tblNewsDetailsArt();
        
        if (txtTitle.Text.Trim().Length > 0)
        {
            newsTbl.newsDetTitle = txtTitle.Text;

            if (txtDetail.Text.Trim().Length > 0)
                newsTbl.newsDetDetails = txtDetail.Text;
            else
                newsTbl.newsDetDetails = "";

            newsTbl.idAcceptedAdmin = 1;
            newsTbl.idStaffCreator = 5;
            newsTbl.newsDetInsertDate = dateInsert;
            newsTbl.newsDetInsertTime = timeInsert;



            
            newsTbl.incReview = 1;

            newsTbl.idGroup = Int32.Parse(ddlNewsGroup.SelectedValue);

            newsTbl.allow = "1";



            // file upload start 
            string filename = string.Empty;
            Boolean fileOK = false;
            String path = Server.MapPath("~/images/news/top/");

            // if picture
            if (rb1.Value == "0")
            {
                newsTbl.topPageFileType = 0;

                if (IsPostBack)
                {
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
                }

                //file upload end
                if (filename.Trim().Length > 0) newsTbl.topPageFileAddr = filename;
                else newsTbl.topPageFileAddr = "default.jpg";
            }
            else if (rb2.Value == "1")
            {
                newsTbl.topPageFileType = 1;

                if (IsPostBack)
                {
                    if (fuGallery.HasFile)
                    {
                        String fileExtension = System.IO.Path.GetExtension(fuGallery.FileName).ToLower();
                        String[] allowedExtensions = { ".mov", ".mp4", ".ogv"};
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
                }

                //file upload end
                if (filename.Trim().Length > 0) newsTbl.topPageFileAddr = filename;
                else newsTbl.topPageFileAddr = "default.jpg";
            }
            else if (rb3.Value == "2")
            {
                newsTbl.topPageFileType = 2;
                newsTbl.topPageFileAddr = txtLink.Text;



            }

            newsTbl.newsDetSubtitle = txtSubTitle.Text;

            newsTbl.Create();

            Response.Redirect("news-add-art.aspx");
        }
        else
            lblError.Text = "* please enter title frist.";
    }
}