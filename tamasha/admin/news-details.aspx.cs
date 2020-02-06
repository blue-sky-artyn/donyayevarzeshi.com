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
            Response.Redirect("news-add.aspx");

        //fill data 

        tblNewsDetailsCollection newsDetailsTbl = new tblNewsDetailsCollection();
        newsDetailsTbl.ReadList(Criteria.NewCriteria(tblNewsDetails.Columns.id, CriteriaOperators.Equal, itemGet));

        tblNewsPicCollection newsPicTbl = new tblNewsPicCollection();
        newsPicTbl.ReadList(Criteria.NewCriteria(tblNewsPic.Columns.newsId, CriteriaOperators.Equal, itemGet));

        tblNewsHyperlinkCollection newsHypTbl = new tblNewsHyperlinkCollection();
        newsHypTbl.ReadList(Criteria.NewCriteria(tblNewsHyperlink.Columns.newsId, CriteriaOperators.Equal, itemGet));



        if (newsDetailsTbl.Count > 0)
        {
            if (newsDetailsTbl[0].topPageFileAddr.Length > 3)
            {
                if (newsDetailsTbl[0].topPageFileType == 0)
                    setPicHtml.InnerHtml = "<img src='../images/news/" + newsDetailsTbl[0].topPageFileAddr + "' class='img-responsive' draggable='false'>";
                else if (newsDetailsTbl[0].topPageFileType == 1)
                    setPicHtml.InnerHtml = "<video id='video1'><source src='../movie/news/" + newsDetailsTbl[0].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video>";
                else
                    setPicHtml.InnerHtml = newsDetailsTbl[0].topPageFileAddr;
            }
        }

        string writerStr = string.Empty;
        tblStaffCollection NewsCreatorTbl = new tblStaffCollection();
        NewsCreatorTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id, CriteriaOperators.Equal, newsDetailsTbl[0].idStaffCreator));

        if (NewsCreatorTbl.Count > 0)
            writerStr = NewsCreatorTbl[0].StaffName + " " + NewsCreatorTbl[0].StaffFamily;

        string addDataString = string.Empty;
        addDataString += "<h3>" + newsDetailsTbl[0].newsDetTitle + "</h3><br>" +
                        "<h5 class='farsi-direction farsi-font-text subtitle-text'>" + newsDetailsTbl[0].newsDetSubtitle + "</h5>" +
                        "<span class='code'>Writer: <a>" + writerStr + "</a></span>" +
                        "<p>News Details: " + newsDetailsTbl[0].newsDetDetails + "</p>" +
                        "<div class='price'>" +
                        "<span class='text'></span>";

        addDataString += "<span class='price-new'></span>";


        addDataString += "<span class='price-tax'><label class='checkbox'></label></span><br>";


        addDataString += "<span class='points'><small>Insert Date: " + newsDetailsTbl[0].newsDetInsertDate + "</small></span><br>";

        addDataString += "</div>";

        addDetailHtml.InnerHtml = addDataString;

        //fill data in change part
        //Groups
        tblNewsGroupCollection newsGroupTbl = new tblNewsGroupCollection();
        newsGroupTbl.ReadList();


        //Select old items
        if (!IsPostBack)
        {
            if (newsDetailsTbl[0].newsDetTitle.Length > 0)
                txtTitle.Text = newsDetailsTbl[0].newsDetTitle;

            if (newsDetailsTbl[0].newsDetDetails.Length > 0)
                ckNews.Text = newsDetailsTbl[0].newsDetDetails;

            for (int i = 0; i < newsGroupTbl.Count; i++)
                ddlNewsGroup.Items.Add(new ListItem(newsGroupTbl[i].newsGroupTitle, newsGroupTbl[i].id.ToString()));
            ddlNewsGroup.SelectedValue = newsDetailsTbl[0].idGroup.ToString();
        }

        #region extera items(Pics/Movies/Links)

        //extra pictures and movies
        tblNewsMovieCollection newsMovieTbl = new tblNewsMovieCollection();
        newsMovieTbl.ReadList(Criteria.NewCriteria(tblNewsMovie.Columns.newsId, CriteriaOperators.Equal, itemGet));

        tblNewsPicCollection newsPictureTbl = new tblNewsPicCollection();
        newsPictureTbl.ReadList(Criteria.NewCriteria(tblNewsPic.Columns.newsId, CriteriaOperators.Equal, itemGet));


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
        #endregion

    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("news-details.aspx");

        tblNewsDetailsCollection newsTbl = new tblNewsDetailsCollection();
        newsTbl.ReadList(Criteria.NewCriteria(tblNewsDetails.Columns.id, CriteriaOperators.Equal, itemGet));

        newsTbl[0].Delete();

        Response.Redirect("news-add.aspx");

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        int itemGet = 0;string fileNameUpdate = string.Empty;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("news-add.aspx");

        tblNewsDetailsCollection newsTbl = new tblNewsDetailsCollection();
        newsTbl.ReadList(Criteria.NewCriteria(tblNewsDetails.Columns.id, CriteriaOperators.Equal, itemGet));

        //tblNewsPicCollection newsPicTbl = new tblNewsPicCollection();
        //newsPicTbl.ReadList(Criteria.NewCriteria(tblNewsPic.Columns.newsId, CriteriaOperators.Equal, itemGet));

        string writerStr = string.Empty;
        tblStaffCollection infWriterTbl = new tblStaffCollection();
        infWriterTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id, CriteriaOperators.Equal, newsTbl[0].idStaffCreator));

        if (infWriterTbl.Count > 0)
            writerStr = infWriterTbl[0].StaffName + " " + infWriterTbl[0].StaffFamily;
        else
            writerStr = "Unknown";



        //if (newsPicTbl.Count > 0)
        //    fileNameUpdate = newsPicTbl[0].picName;


        if (txtTitle.Text.Trim().Length > 0 && ckNews.Text.Trim().Length > 0)
        {
            newsTbl[0].newsDetTitle = txtTitle.Text;
            string str = ckNews.Text;
            newsTbl[0].newsDetDetails = Server.HtmlDecode(str);
            newsTbl[0].idGroup = Int32.Parse(ddlNewsGroup.SelectedValue);


            // file upload start 
            string filename = string.Empty;
            if (IsPostBack)
            {
                Boolean fileOK = false;
                String path = Server.MapPath("~/images/news/");
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
                newsTbl[0].topPageFileAddr = filename;
            else
                newsTbl[0].topPageFileAddr = fileNameUpdate;

            newsTbl[0].Update();
            
        }

        Response.Redirect("news-details.aspx?item=" + itemGet);
    }
}