using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

public partial class archive : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        tblNewsDetailsCollection newsTbl = new tblNewsDetailsCollection();




        if (IsPostBack)
        {
            #region post back for filtering date
            try
            {
                int startDate = 0; int endDate = 0;
                if (txtStartDate.Text.Length > 0 && txtEndDate.Text.Length > 0)
                {
                    startDate = Convert.ToInt32(txtStartDate.Text.Substring(6, 4) + txtStartDate.Text.Substring(3, 2) + txtStartDate.Text.Substring(0, 2));
                    endDate = Convert.ToInt32(txtEndDate.Text.Substring(6, 4) + txtEndDate.Text.Substring(3, 2) + txtEndDate.Text.Substring(0, 2));
                }

                newsTbl.ReadList(Criteria.NewCriteria(tblNewsDetails.Columns.newsDetInsertDate, CriteriaOperators.GreaterThanOrEqual, startDate) & Criteria.NewCriteria(tblNewsDetails.Columns.newsDetInsertDate, CriteriaOperators.LessThanOrEqual, endDate));

            }
            catch (Exception)
            {

                throw;
            }
            #endregion
        }
        else
        {
            newsTbl.ReadList();
        }

        #region news
        //top and big news
        string newsString = "<div class='col-md-12'><div class='farsi-position section-title'><h2 class='farsi-font title'>آرشیو اخبار</h2></div></div>";
            if (newsTbl.Count > 2)
            {
                for (int i = newsTbl.Count - 1; i > newsTbl.Count - 3; i--)
                {
                    newsString += "<div class='col-md-6 col-sm-6'><article class='article'><div class='article2-img'>" +
                                  "<a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsTbl[i].id + "'>";

                    if (newsTbl[i].topPageFileType == 0)
                        newsString += "<img src='./images/news/" + newsTbl[i].topPageFileAddr + "' alt='دنیای ورزشی " + newsTbl[i].topPageFileAddr + "'>" +
                                        "</a><ul class='article-info'><li class='article-type'><i class='fa fa-camera'></i></li></ul></div>";
                    else if (newsTbl[i].topPageFileType == 1)
                        newsString += "<div><video id='video1'><source src='../movie/news/" + newsTbl[i].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video></div>" +
                                      "</a><ul class='article-info'><li class='article-type'><i class='fa fa-video-camera'></i></li></ul></div>";
                    else
                        newsString += newsTbl[i].topPageFileAddr +
                                      "</a><ul class='article-info'><li class='article-type'><i class='fa fa-link'></i></li></ul></div>";


                    newsString += "<div class='article-body'><p class='sub-title-news sub-title' style='font-size: 9px;'>" + newsTbl[i].newsDetSubtitle + "</p>" +
                                  "<h3 class='farsi-font farsi-position article-title'><a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsTbl[i].id + "'>" + newsTbl[i].newsDetTitle + "</a></h3>" +
                                  "<ul class='article-meta'><li><i class='fa fa-clock-o'></i>" + newsTbl[i].newsDetInsertDate + "</li><li><i class='fa fa-comments'></i>" + newsTbl[i].incReview + "</li></ul>" +
                                  "<p>" + newsTbl[i].newsDetDetails + "</p></div>" +
                                  "</article></div>";
                }
            }
            else
            {
                if (newsTbl.Count > 0)
                {

                    newsString += "<div class='col-md-6 col-sm-6'><article class='article'><div class='article2-img'>" +
                                 "<a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsTbl[0].id + "'>";

                    if (newsTbl[0].topPageFileType == 0)
                        newsString += "<img src='./images/news/" + newsTbl[0].topPageFileAddr + "' alt='دنیای ورزشی " + newsTbl[0].topPageFileAddr + "'>" +
                                        "</a><ul class='article-info'><li class='article-type'><i class='fa fa-camera'></i></li></ul></div>";
                    else if (newsTbl[0].topPageFileType == 1)
                        newsString += "<div><video id='video1'><source src='../movie/news/" + newsTbl[0].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video></div>" +
                                      "</a><ul class='article-info'><li class='article-type'><i class='fa fa-video-camera'></i></li></ul></div>";
                    else
                        newsString += newsTbl[0].topPageFileAddr +
                                      "</a><ul class='article-info'><li class='article-type'><i class='fa fa-link'></i></li></ul></div>";



                    newsString += "<div class='article-body'><p class='sub-title-news sub-title' style='font-size: 9px;'>" + newsTbl[0].newsDetSubtitle + "</p>" +
                                 "<h3 class='farsi-font farsi-position article-title'><a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsTbl[0].id + "'>" + newsTbl[0].newsDetTitle + "</a></h3>" +
                                 "<ul class='article-meta'><li><i class='fa fa-clock-o'></i>" + newsTbl[0].newsDetInsertDate + "</li><li><i class='fa fa-comments'></i>" + newsTbl[0].incReview + "</li></ul>" +
                                 "<p>" + newsTbl[0].newsDetDetails + "</p></div>" +
                                 "</article></div>";
                }
            }
            newsHtml.InnerHtml = newsString;
            //small news
            string smallNewsString = string.Empty;
            if (newsTbl.Count > 3)
            {
                for (int i = newsTbl.Count - 1; i > newsTbl.Count - 4; i--)
                {
                    smallNewsString += "<div class='col-md-4 col-sm-4'><article class='article'><div class='article2-img'>";
                    if (newsTbl[i].topPageFileType == 0)
                        smallNewsString += "<img src='./images/news/" + newsTbl[i].topPageFileAddr + "' alt='دنیای ورزشی " + newsTbl[i].topPageFileAddr + "'>";
                    else if (newsTbl[0].topPageFileType == 1)
                        smallNewsString += "<div><video id='video1'><source src='../movie/news/" + newsTbl[i].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video></div>";
                    else
                        smallNewsString += newsTbl[i].topPageFileAddr;
                    smallNewsString += "<div class='article-body'><p class='sub-title-news sub-title' style='font-size: 9px;'>" + newsTbl[i].newsDetSubtitle + "</p><ul class='article-info'><li class='article-type'><i class='fa fa-file-text'></i></li></ul></div>" +
                                       "<h3 class='farsi-font farsi-position article-title'><a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsTbl[i].id + "'>" + newsTbl[i].newsDetTitle + "</a></h3>" +
                                       "<ul class='article-meta'><li><i class='fa fa-clock-o'></i>" + newsTbl[i].newsDetInsertDate + "</li><li><i class='fa fa-comments'></i>" + newsTbl[i].incReview + "</li></ul></div></article></div>";
                }
            }
            else
            {
                for (int i = newsTbl.Count - 1; i >= 0; i--)
                {
                    smallNewsString += "<div class='col-md-4 col-sm-4'><article class='article'><div class='article2-img'>";
                    if (newsTbl[i].topPageFileType == 0)
                        smallNewsString += "<img src='./images/news/" + newsTbl[i].topPageFileAddr + "' alt='دنیای ورزشی " + newsTbl[i].topPageFileAddr + "'>";
                    else if (newsTbl[0].topPageFileType == 1)
                        smallNewsString += "<div><video id='video1'><source src='../movie/news/" + newsTbl[i].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video></div>";
                    else
                        smallNewsString += newsTbl[i].topPageFileAddr;
                    smallNewsString += "<div class='article-body'><p class='sub-title-news sub-title' style='font-size: 9px;'>" + newsTbl[i].newsDetSubtitle + "</p><ul class='article-info'><li class='article-type'><i class='fa fa-file-text'></i></li></ul></div>" +
                                       "<h3 class='farsi-font farsi-position article-title'><a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsTbl[i].id + "'>" + newsTbl[i].newsDetTitle + "</a></h3>" +
                                       "<ul class='article-meta'><li><i class='fa fa-clock-o'></i>" + newsTbl[i].newsDetInsertDate + "</li><li><i class='fa fa-comments'></i>" + newsTbl[i].incReview + "</li></ul></div></article></div>";
                }
            }
            newsSmallHtml.InnerHtml = smallNewsString;
            #endregion
    }

    protected void btnShow_Click(object sender, EventArgs e)
    {

    }
}