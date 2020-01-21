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
    public int randomNo(int number1)
    {
        Random rand = new Random((int)DateTime.Now.Ticks);
        int numIterations = 0;
        numIterations = rand.Next(0, number1 - 1);
        
        return numIterations;
    }

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

        tblNewsPicCollection newsPicTbl = new tblNewsPicCollection();
        newsPicTbl.ReadList(Criteria.NewCriteria(tblNewsPic.Columns.newsId, CriteriaOperators.Equal, itemGet));
        
        #region increment number of review a news
        tblNewsDetailsCollection newsDetailsIncTbl = new tblNewsDetailsCollection();
        newsDetailsIncTbl.ReadList(Criteria.NewCriteria(tblNewsDetails.Columns.id, CriteriaOperators.Equal, itemGet));

        int numberOfReview = Convert.ToInt32(newsDetailsTbl[0].incReview) + 1;
        int idGrp = newsDetailsTbl[0].idGroup;
        string title = newsDetailsTbl[0].newsDetTitle;
        string details = newsDetailsTbl[0].newsDetDetails; 
        string subTitle = newsDetailsTbl[0].newsDetSubtitle; 
        string insDate = newsDetailsTbl[0].newsDetInsertDate; 
        string insTime = newsDetailsTbl[0].newsDetInsertTime; 
        int fileType = Convert.ToInt32(newsDetailsTbl[0].topPageFileType.ToString());
        string fileAddr = newsDetailsTbl[0].topPageFileAddr;

        newsDetailsIncTbl[0].incReview = numberOfReview;
        newsDetailsIncTbl[0].idGroup = idGrp;
        newsDetailsIncTbl[0].idAcceptedAdmin = 1;
        newsDetailsIncTbl[0].idStaffCreator = 5;
        newsDetailsIncTbl[0].newsDetTitle = title;
        newsDetailsIncTbl[0].newsDetDetails = details;
        newsDetailsIncTbl[0].newsDetSubtitle = subTitle;
        newsDetailsIncTbl[0].newsDetInsertDate = insDate;
        newsDetailsIncTbl[0].newsDetInsertTime = insTime;
        newsDetailsIncTbl[0].topPageFileType = fileType;
        newsDetailsIncTbl[0].topPageFileAddr = fileAddr;
        newsDetailsIncTbl[0].allow = "1";


        newsDetailsIncTbl[0].Update();
        #endregion
        
        int idCounter = 0;
        //news image
        string imagesString = string.Empty , otherPopPageString = string.Empty;
        if (newsDetailsTbl[0].topPageFileType == 1)
            imagesString += "<div class='article-main-img'><video id='wows1_" + idCounter + "'><source src='../movie/news/top/" + newsDetailsTbl[0].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video></div>";
        else if (newsDetailsTbl[0].topPageFileType == 2)
            imagesString += "<div class='article-main-img'>" + newsDetailsTbl[0].topPageFileAddr + "</div>";
        else
        {
            otherPopPageString += "<li><img src='images/news/top/" + newsDetailsTbl[0].topPageFileAddr + "' alt='اخبار دنیای ورزشی " + newsDetailsTbl[0].id + "' title='دنیای ورزشی' id='wows1_" + idCounter + "'/></li>";
            picThumbString += "<a href='#wows1_" + idCounter + "' title='اخبار دنیای ورزشی'><img src='images/news/top/" + newsDetailsTbl[0].topPageFileAddr + "' alt='اخبار دنیای ورزشی " + newsDetailsTbl[0].id + "' title='دنیای ورزشی' /></a>";

        }

        if (newsPicTbl.Count > 0)
        {
            imagesString += "<div class=\"ws_images\"><ul>";
            if (otherPopPageString.Trim().Length > 0)
            {
                imagesString += otherPopPageString;
                idCounter++;
            }
            for (int i = 0; i < newsPicTbl.Count; i++)
            {
                imagesString += "<li><img src='images/news/sport/" + newsPicTbl[i].picName + "' alt='اخبار دنیای ورزشی " + newsPicTbl[i].id + "' title='دنیای ورزشی' id='wows1_" + idCounter + "'/></li>";
                picThumbString += "<a href='#wows1_" + idCounter + "' title='اخبار دنیای ورزشی'><img src='images/news/sport/" + newsPicTbl[i].picName + "' alt='اخبار دنیای ورزشی " + newsPicTbl[i].id + "' title='دنیای ورزشی' /></a>";
                idCounter++;
            }

            imagesString += "</ul></div><div class=\"ws_thumbs\"><div>";

            imagesString += picThumbString;

            imagesString += "</div></div>" +

            "<div class=\"ws_shadow\"></div>";
        }
        else
            imagesString += "<div class='article-main-img'><img src='images/news/top/" + newsDetailsTbl[0].topPageFileAddr + "' alt ='دنیای ورزشی " + newsDetailsTbl[0].topPageFileAddr + "'></div>";

        imgNewsHtml.InnerHtml = imagesString;

        //news details
        newsDetailString += "<ul class='article-info'><li class='article-category'><a href='#'>ورزشی</a></li><li class='article-type'><i class='fa fa-file-text'></i></li></ul>" +
                            "<h1 class='farsi-font-title farsi-align farsi-direction article-title'>" + newsDetailsTbl[0].newsDetTitle + "</h1>" +
                            "<ul class='article-meta'><li><i class='fa fa-clock-o'></i> " + newsDetailsTbl[0].newsDetInsertDate + " </li></ul>" +
                            "<p class='farsi-font-text farsi-align farsi-direction'>" + newsDetailsTbl[0].newsDetDetails + "</p>";

        newsDetailHtml.InnerHtml = newsDetailString;

        #region Simular News
        string simularNewsString = string.Empty;

        int res;


        do
        {
            res = randomNo(newsDetailsTbl.Count);
        } while (newsDetailsTbl[res].topPageFileType != 0);

        simularNewsString += "<div class='media-body'><div class='media-heading'>"+
                             "<h5 class='farsi-font farsi-title'>"+ newsDetailsTbl[res].newsDetTitle + "</h5><p class='left-alignment reply-time'>April 04, 2017 At 9:30 AM</p>"+
                             "</div><p class='farsi-font farsi-article'>" + newsDetailsTbl[res].newsDetTitle + "</p>" +
                             "</div><div class='media-left'><img src='images/news/top/" + newsDetailsTbl[res].topPageFileAddr + "' alt='" + newsDetailsTbl[res].topPageFileAddr + "'></div>";

        simularNewsHtml.InnerHtml = simularNewsString;
        #endregion

    }
}