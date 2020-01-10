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
    public int checkExt(string extStr)
    {
        int result;

        if (extStr == ".jpg" || extStr == ".bmp" || extStr == ".gif" || extStr == ".png")
        {
            result = 0;
        }
        else if (extStr == ".mp4" || extStr == ".mov")
        {
            result = 1;
        }
        else
        {
            result = 2;
        }

        return result;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("news-add-sport.aspx");

        //fill data 

        tblNewsDetailsSportCollection newsDetailsTbl = new tblNewsDetailsSportCollection();
        newsDetailsTbl.ReadList(Criteria.NewCriteria(tblNewsDetailsSport.Columns.id, CriteriaOperators.Equal, itemGet));

        tblNewsPicSportCollection newsPicTbl = new tblNewsPicSportCollection();
        newsPicTbl.ReadList(Criteria.NewCriteria(tblNewsPicSport.Columns.newsId, CriteriaOperators.Equal, itemGet));

        tblNewsHyperlinkSportCollection newsHypTbl = new tblNewsHyperlinkSportCollection();
        newsHypTbl.ReadList(Criteria.NewCriteria(tblNewsHyperlinkSport.Columns.newsId, CriteriaOperators.Equal, itemGet));


        if (newsDetailsTbl[0].topPageFileAddr.Length > 3)
        {
            if (newsDetailsTbl[0].topPageFileType == 0)
                setPicHtml.InnerHtml = "<img src='../images/news/sport/" + newsDetailsTbl[0].topPageFileAddr + "' class='img-responsive' draggable='false'>";
            else if (newsDetailsTbl[0].topPageFileType == 1)
                setPicHtml.InnerHtml = "<video id='video1'><source src='../movie/news/sport/" + newsDetailsTbl[0].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video>";
            else
                setPicHtml.InnerHtml = newsDetailsTbl[0].topPageFileAddr;
        }

        string writerStr = string.Empty;
        tblStaffCollection NewsCreatorTbl = new tblStaffCollection();
        NewsCreatorTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id, CriteriaOperators.Equal, newsDetailsTbl[0].idStaffCreator));

        if (NewsCreatorTbl.Count > 0)
            writerStr = NewsCreatorTbl[0].StaffName + " " + NewsCreatorTbl[0].StaffFamily;

        string addDataString = string.Empty;
        addDataString += "<h3 class='farsi-direction farsi-font-title'>" + newsDetailsTbl[0].newsDetTitle + "</h3><br>" +
                         "<h5 class='farsi-direction farsi-font-text subtitle-text'>" + newsDetailsTbl[0].newsDetSubtitle + "</h5>"+
                         "<span class='code'>Writer: <a>" + writerStr + "</a></span>" +
                         "<p class='farsi-font-text farsi-article'><span class='subtitle-news'>جزییات خبر:</span> " + newsDetailsTbl[0].newsDetDetails + "</p>" +
                         "<div class='price'>" +
                         "<span class='text'></span>";
       
        addDataString += "<span class='price-new'></span>";
       

        addDataString += "<span class='price-tax'><label class='checkbox'></label></span><br>";

        
            addDataString += "<span class='points'><small>Insert Date: " + newsDetailsTbl[0].newsDetInsertDate + "</small></span><br>";

        addDataString += "</div>";

        addDetailHtml.InnerHtml = addDataString;

        //fill data in change part
        //Groups
        tblNewsGroupSportCollection newsGroupTbl = new tblNewsGroupSportCollection();
        newsGroupTbl.ReadList();


        //Select old items
        if (!IsPostBack)
        {
            if (newsDetailsTbl[0].newsDetTitle.Length > 0)
                txtTitle.Text = newsDetailsTbl[0].newsDetTitle;

            if (newsDetailsTbl[0].newsDetSubtitle.Length > 0)
                txtSubTitle.Text = newsDetailsTbl[0].newsDetSubtitle;

            if (newsDetailsTbl[0].newsDetDetails.Length > 0)
                txtDetail.Text = newsDetailsTbl[0].newsDetDetails;

            for (int i = 0; i < newsGroupTbl.Count; i++)
                ddlNewsGroup.Items.Add(new ListItem(newsGroupTbl[i].newsGroupTitle, newsGroupTbl[i].id.ToString()));
            ddlNewsGroup.SelectedValue = newsDetailsTbl[0].idGroup.ToString();
        }


        //extra pictures and movies
        tblNewsMovieSportCollection newsMovieTbl = new tblNewsMovieSportCollection();
        newsMovieTbl.ReadList(Criteria.NewCriteria(tblNewsMovieSport.Columns.newsId, CriteriaOperators.Equal, itemGet));

        tblNewsPicSportCollection newsPictureTbl = new tblNewsPicSportCollection();
        newsPictureTbl.ReadList(Criteria.NewCriteria(tblNewsPicSport.Columns.newsId,CriteriaOperators.Equal, itemGet));


        string extraMovieString = "", extraPicturesString = "", extraHypString = "";

        extraMovieString += "<h3>Movies: </h3><ul>";
        extraPicturesString += "<h3>Pictures: </h3><ul>";
        extraHypString += "<h3>External links: </h3><ul>";

        for (int i = 0; i < newsMovieTbl.Count; i++)
        {
            extraMovieString += "<li class='tumb-ul'> <video id='image-extra video1' ><source src='../movie/news/sport/" + newsMovieTbl[i].movieName + "' type='video/mp4'>Your browser does not support HTML5 video.</video></li>";             
        }

        if (newsMovieTbl.Count == 0) extraMovieString += "<li class='tumb-ul'>There is no video to show</li>";




        for (int i = 0; i < newsPictureTbl.Count; i++)
        {
            extraPicturesString += "<li class='tumb-ul'><img src='../images/news/sport/" + newsPictureTbl[i].picName + "' class='image-extra thumbnail-pictures' alt='" + newsPictureTbl[i].picName + "' /></li>";
        }

        if (newsPictureTbl.Count == 0) extraPicturesString += "<li class='tumb-ul'>There is no picture to show</li>";

        for (int i = 0; i < newsHypTbl.Count; i++)
        {
            extraHypString += "<li class='tumb-ul'>" + newsHypTbl[i].HyperlinkAddr + "</li>";
        }

        if (newsHypTbl.Count == 0) extraHypString += "<li class='tumb-ul'>There is no external link to show</li>";


        extraMovieString += "</ul>";
        extraPicturesString += "</ul>";
        extraHypString += "</ul>";


        extraMovieHtml.InnerHtml = extraMovieString;

        extraPictureHtml.InnerHtml = extraPicturesString;
        extraHypHtml.InnerHtml = extraHypString;

    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("news-details-sport.aspx");

        tblNewsDetailsSportCollection newsTbl = new tblNewsDetailsSportCollection();
        newsTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id, CriteriaOperators.Equal, itemGet));

        newsTbl[0].Delete();

        Response.Redirect("news-add-sport.aspx");

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        int itemGet = 0;string fileNameUpdate = string.Empty;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("news-add-sport.aspx");

        tblNewsDetailsSportCollection newsTbl = new tblNewsDetailsSportCollection();
        newsTbl.ReadList(Criteria.NewCriteria(tblNewsDetailsSport.Columns.id, CriteriaOperators.Equal, itemGet));

        tblNewsPicSport newsPicTbl = new tblNewsPicSport();
        tblNewsMovieSport newsMovieTbl = new tblNewsMovieSport();
        ///newsPicTbl.ReadList(Criteria.NewCriteria(tblNewsPicSport.Columns.newsId, CriteriaOperators.Equal, itemGet));

        string writerStr = string.Empty;
        tblStaffCollection infWriterTbl = new tblStaffCollection();
        infWriterTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id, CriteriaOperators.Equal, newsTbl[0].idStaffCreator));

        if (infWriterTbl.Count > 0)
            writerStr = infWriterTbl[0].StaffName + " " + infWriterTbl[0].StaffFamily;
        else
            writerStr = "Unknown";


        if (txtTitle.Text.Trim().Length > 0 && txtDetail.Text.Trim().Length > 0)
        {
            newsTbl[0].newsDetTitle = txtTitle.Text;
            newsTbl[0].newsDetSubtitle = txtSubTitle.Text;
            newsTbl[0].newsDetDetails = txtDetail.Text;

            newsTbl[0].idGroup = Int32.Parse(ddlNewsGroup.SelectedValue);

            newsTbl[0].topPageFileAddr = newsTbl[0].topPageFileAddr;
            newsTbl[0].topPageFileType = newsTbl[0].topPageFileType;

            newsTbl[0].Update();

            // file upload start 
            string filename = string.Empty;
            Boolean fileOK = false;
            String fileExtension = System.IO.Path.GetExtension(fuGallery.FileName).ToLower();

            //add more external links
            tblNewsHyperlinkSport extLinksTbl = new tblNewsHyperlinkSport();

            extLinksTbl.newsId = itemGet;
            extLinksTbl.HyperlinkAddr = txtExtLinks.Text;
            extLinksTbl.expDate = "";
            extLinksTbl.insertDate = "";
            extLinksTbl.insertTime = "";
            extLinksTbl.allow = "1";

            if (txtExtLinks.Text.Trim().Length > 1)
            {
                extLinksTbl.Create();
            }


            if (checkExt(fileExtension) == 0)
            {
                if (IsPostBack)
                {
                    String path = Server.MapPath("~/images/news/sport/");
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
                    newsPicTbl.picName = filename;
                else
                    newsPicTbl.picName = "default.jpg";


                newsPicTbl.newsId = itemGet;
                newsPicTbl.picAddr = "../images/news/sport/";
                newsPicTbl.picDetail = "";
                newsPicTbl.allow = "1";

                newsPicTbl.Create();
            }
            else if (checkExt(fileExtension) == 1)
            {
                if (IsPostBack)
                {
                    String path = Server.MapPath("~/movie/news/sport/");
                    if (fuGallery.HasFile)
                    {
                        String[] allowedExtensions = { ".mov", ".mp4"};
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
                            lblError.Text = "A problem accurred while uplouding movie";
                        }
                    }
                    else
                    {
                        lblError.Text = "Not valid movie file";
                    }
                }


                // file upload end
                if (filename.Trim().Length > 0)
                    newsMovieTbl.movieName = filename;
                else
                    newsMovieTbl.movieName = "default.jpg";


                newsMovieTbl.movieDetail = "";
                newsMovieTbl.movieAddr = "../movie/news/sport/";
                newsMovieTbl.newsId = itemGet;
                newsMovieTbl.allow = "1";

                newsMovieTbl.Create();

            }
        }

        Response.Redirect("news-details-sport.aspx?item=" + itemGet);
    }
}