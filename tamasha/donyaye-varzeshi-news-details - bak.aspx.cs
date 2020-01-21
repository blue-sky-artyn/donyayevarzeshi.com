using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

public partial class tamasha_news_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["newsId"] != null)
        {
            itemGet = int.Parse(Request.QueryString["newsId"]);
        }
        else
            Response.Redirect("default.aspx");


        string newsDetailString = "", picThumbString = "";
        tblNewsDetailsCollection newsDetailsTbl = new tblNewsDetailsCollection();
        newsDetailsTbl.ReadList(Criteria.NewCriteria(tblNewsDetails.Columns.id, CriteriaOperators.Equal, itemGet));

        int idCounter = 0;
        //news image
        string imagesString = "<div class=\"ws_images\"><ul>";
        if (newsDetailsTbl[0].topPageFileType == 0)
        {
            imagesString += "<li><img src='images/news/top/" + newsDetailsTbl[0].topPageFileAddr + "' alt='اخبار دنیای ورزشی " + newsDetailsTbl[0].id + "' title='دنیای ورزشی' id='wows1_" + idCounter + "'/></li>";
            picThumbString += "<a href='#wows1_" + idCounter + "' title='اخبار دنیای ورزشی'><img src='images/news/top/" + newsDetailsTbl[0].topPageFileAddr + "' alt='اخبار دنیای ورزشی " + newsDetailsTbl[0].id + "' title='دنیای ورزشی' /></a>";

        }
        else if (newsDetailsTbl[0].topPageFileType == 1)
        {
            imagesString += "<li><video id='wows1_" + idCounter + "'><source src='../movie/news/top/" + newsDetailsTbl[0].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video></li>";
            picThumbString += "<a href='#wows1_" + idCounter + "'' title='اخبار دنیای ورزشی'><video id='video" + idCounter + "'><source src='../movie/news/top/" + newsDetailsTbl[0].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video></a>";
        }
        else
        {
            imagesString += "<li id='wows1_" + idCounter + "'>" + newsDetailsTbl[0].topPageFileAddr + "</li>";
            picThumbString += "<a href='#wows1_" + idCounter + "'' title='اخبار دنیای ورزشی'>" + newsDetailsTbl[0].topPageFileAddr + "</a>";
        }

        idCounter++;
        
        tblNewsPicCollection newsPicTbl = new tblNewsPicCollection();
        newsPicTbl.ReadList(Criteria.NewCriteria(tblNewsPic.Columns.newsId, CriteriaOperators.Equal, itemGet));

        for (int i = 0; i < newsPicTbl.Count; i++)
        {
            imagesString += "<li><img src='images/news/sport/" + newsPicTbl[i].picName + "' alt='اخبار دنیای ورزشی " + newsPicTbl[i].id + "' title='دنیای ورزشی' id='wows1_"+ idCounter + "'/></li>";
            picThumbString += "<a href='#wows1_" + idCounter + "' title='اخبار دنیای ورزشی'><img src='images/news/sport/" + newsPicTbl[i].picName + "' alt='اخبار دنیای ورزشی " + newsPicTbl[i].id + "' title='دنیای ورزشی' /></a>";
            idCounter++;
        }

        tblNewsMovieCollection newsMovieTbl = new tblNewsMovieCollection();
        newsMovieTbl.ReadList(Criteria.NewCriteria(tblNewsMovie.Columns.newsId, CriteriaOperators.Equal, itemGet));

        for (int i = 0; i < newsMovieTbl.Count; i++)
        {
            imagesString += "<li><video id='video" + idCounter + "'><source src='../movie/news/sport/" + newsMovieTbl[i].movieName + "' type='video/mp4' id='wows1_" + newsPicTbl[i].id + "'>Your browser does not support HTML5 video.</video></li>";
            picThumbString += "<a href='#wows1_" + idCounter + "' title='اخبار دنیای ورزشی'><video id='video" + newsMovieTbl[i].id + "'><source src='../movie/news/sport/" + newsMovieTbl[i].movieName + "' type='video/mp4'>Your browser does not support HTML5 video.</video></a>";
            idCounter++;
        }

        tblNewsHyperlinkCollection newsLinksTbl = new tblNewsHyperlinkCollection();
        newsLinksTbl.ReadList(Criteria.NewCriteria(tblNewsHyperlink.Columns.newsId, CriteriaOperators.Equal, itemGet));

        for (int i = 0; i < newsLinksTbl.Count; i++)
        {
            imagesString += "<li id='wows1_" + idCounter + "'>" + newsLinksTbl[i].HyperlinkAddr + "</li>";
            picThumbString += "<a href='#wows1_" + idCounter + "' title='اخبار دنیای ورزشی'>" + newsLinksTbl[i].HyperlinkAddr + "</a>";
            idCounter++;
        }

        imagesString += "</ul></div><div class=\"ws_thumbs\"><div>";



        imagesString += picThumbString;

        imagesString += "</div></div>"+
                            "<div class=\"ws_script\" style=\"position:absolute;left:-99%\"></div>"+
        "<div class=\"ws_shadow\"></div>";


        imgNewsHtml.InnerHtml = imagesString;

        //news details
        newsDetailString += "<ul class='article-info'><li class='article-category'><a href='#'>ورزشی</a></li><li class='article-type'><i class='fa fa-file-text'></i></li></ul>" +
                            "<h1 class='farsi-font-title farsi-align farsi-direction article-title'>" + newsDetailsTbl[0].newsDetTitle + "</h1>" +
                            "<ul class='article-meta'><li><i class='fa fa-clock-o'></i> " + newsDetailsTbl[0].newsDetInsertDate + " </li></ul>" +
                            "<p class='farsi-font-text farsi-align farsi-direction'>" + newsDetailsTbl[0].newsDetDetails + "</p>";

        newsDetailHtml.InnerHtml = newsDetailString;

    }
}