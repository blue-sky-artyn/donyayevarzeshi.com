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
        tblNewsDetailsCollection newsDetailsSportTbl = new tblNewsDetailsCollection();
        newsDetailsSportTbl.ReadList();

        #region news
        //top and big news
        string newsString = "<div class='col-md-12'><div class='farsi-position section-title'><h2 class='farsi-font title'>آرشیو اخبار</h2></div></div>";
        if (newsDetailsSportTbl.Count > 2)
        {
            for (int i = newsDetailsSportTbl.Count - 1; i > newsDetailsSportTbl.Count - 3; i--)
            {
                newsString += "<div class='col-md-6 col-sm-6'><article class='article'><div class='article-img'>" +
                              "<a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsDetailsSportTbl[i].id + "'>";

                if (newsDetailsSportTbl[i].topPageFileType == 0)
                    newsString += "<img src='./images/news/" + newsDetailsSportTbl[i].topPageFileAddr + "' alt='دنیای ورزشی " + newsDetailsSportTbl[i].topPageFileAddr + "'>" +
                                    "</a><ul class='article-info'><li class='article-type'><i class='fa fa-camera'></i></li></ul></div>";
                else if (newsDetailsSportTbl[i].topPageFileType == 1)
                    newsString += "<div><video id='video1'><source src='../movie/news/" + newsDetailsSportTbl[i].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video></div>" +
                                  "</a><ul class='article-info'><li class='article-type'><i class='fa fa-video-camera'></i></li></ul></div>";
                else
                    newsString += newsDetailsSportTbl[i].topPageFileAddr +
                                  "</a><ul class='article-info'><li class='article-type'><i class='fa fa-link'></i></li></ul></div>";


                newsString += "<div class='article-body'><p class='sub-title-news sub-title' style='font-size: 9px;'>" + newsDetailsSportTbl[i].newsDetSubtitle + "</p>" +
                              "<h3 class='farsi-font farsi-position article-title'><a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsDetailsSportTbl[i].id + "'>" + newsDetailsSportTbl[i].newsDetTitle + "</a></h3>" +
                              "<ul class='article-meta'><li><i class='fa fa-clock-o'></i>" + newsDetailsSportTbl[i].newsDetInsertDate + "</li><li><i class='fa fa-comments'></i>" + newsDetailsSportTbl[i].incReview + "</li></ul>" +
                              "<p>" + newsDetailsSportTbl[i].newsDetDetails + "</p></div>" +
                              "</article></div>";
            }
        }
        else
        {
            if (newsDetailsSportTbl.Count > 0)
            {

            newsString += "<div class='col-md-6 col-sm-6'><article class='article'><div class='article-img'>" +
                         "<a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsDetailsSportTbl[0].id + "'>";

            if (newsDetailsSportTbl[0].topPageFileType == 0)
                newsString += "<img src='./images/news/" + newsDetailsSportTbl[0].topPageFileAddr + "' alt='دنیای ورزشی " + newsDetailsSportTbl[0].topPageFileAddr + "'>" +
                                "</a><ul class='article-info'><li class='article-type'><i class='fa fa-camera'></i></li></ul></div>";
            else if (newsDetailsSportTbl[0].topPageFileType == 1)
                newsString += "<div><video id='video1'><source src='../movie/news/" + newsDetailsSportTbl[0].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video></div>" +
                              "</a><ul class='article-info'><li class='article-type'><i class='fa fa-video-camera'></i></li></ul></div>";
            else
                newsString += newsDetailsSportTbl[0].topPageFileAddr +
                              "</a><ul class='article-info'><li class='article-type'><i class='fa fa-link'></i></li></ul></div>";



            newsString += "<div class='article-body'><p class='sub-title-news sub-title' style='font-size: 9px;'>" + newsDetailsSportTbl[0].newsDetSubtitle + "</p>" +
                         "<h3 class='farsi-font farsi-position article-title'><a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsDetailsSportTbl[0].id + "'>" + newsDetailsSportTbl[0].newsDetTitle + "</a></h3>" +
                         "<ul class='article-meta'><li><i class='fa fa-clock-o'></i>" + newsDetailsSportTbl[0].newsDetInsertDate + "</li><li><i class='fa fa-comments'></i>" + newsDetailsSportTbl[0].incReview + "</li></ul>" +
                         "<p>" + newsDetailsSportTbl[0].newsDetDetails + "</p></div>" +
                         "</article></div>";
            }
        }
        newsHtml.InnerHtml = newsString;
        //small news
        string smallNewsString = string.Empty;
        if (newsDetailsSportTbl.Count > 3)
        {
            for (int i = newsDetailsSportTbl.Count - 1; i > newsDetailsSportTbl.Count - 4; i--)
            {
                smallNewsString += "<div class='col-md-4 col-sm-4'><article class='article'><div class='article-img'>";
                if (newsDetailsSportTbl[i].topPageFileType == 0)
                    smallNewsString += "<img src='./images/news/" + newsDetailsSportTbl[i].topPageFileAddr + "' alt='دنیای ورزشی " + newsDetailsSportTbl[i].topPageFileAddr + "'>";
                else if (newsDetailsSportTbl[0].topPageFileType == 1)
                    smallNewsString += "<div><video id='video1'><source src='../movie/news/" + newsDetailsSportTbl[i].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video></div>";
                else
                    smallNewsString += newsDetailsSportTbl[i].topPageFileAddr;
                smallNewsString += "<div class='article-body'><p class='sub-title-news sub-title' style='font-size: 9px;'>" + newsDetailsSportTbl[i].newsDetSubtitle + "</p><ul class='article-info'><li class='article-type'><i class='fa fa-file-text'></i></li></ul></div>" +
                                   "<h3 class='farsi-font farsi-position article-title'><a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsDetailsSportTbl[i].id + "'>" + newsDetailsSportTbl[i].newsDetTitle + "</a></h3>" +
                                   "<ul class='article-meta'><li><i class='fa fa-clock-o'></i>" + newsDetailsSportTbl[i].newsDetInsertDate + "</li><li><i class='fa fa-comments'></i>" + newsDetailsSportTbl[i].incReview + "</li></ul></div></article></div>";
            }
        }
        else
        {
            for (int i = newsDetailsSportTbl.Count - 1; i >= 0; i--)
            {
                smallNewsString += "<div class='col-md-4 col-sm-4'><article class='article'><div class='article-img'>";
                if (newsDetailsSportTbl[i].topPageFileType == 0)
                    smallNewsString += "<img src='./images/news/" + newsDetailsSportTbl[i].topPageFileAddr + "' alt='دنیای ورزشی " + newsDetailsSportTbl[i].topPageFileAddr + "'>";
                else if (newsDetailsSportTbl[0].topPageFileType == 1)
                    smallNewsString += "<div><video id='video1'><source src='../movie/news/" + newsDetailsSportTbl[i].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video></div>";
                else
                    smallNewsString += newsDetailsSportTbl[i].topPageFileAddr;
                smallNewsString += "<div class='article-body'><p class='sub-title-news sub-title' style='font-size: 9px;'>" + newsDetailsSportTbl[i].newsDetSubtitle + "</p><ul class='article-info'><li class='article-type'><i class='fa fa-file-text'></i></li></ul></div>" +
                                   "<h3 class='farsi-font farsi-position article-title'><a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsDetailsSportTbl[i].id + "'>" + newsDetailsSportTbl[i].newsDetTitle + "</a></h3>" +
                                   "<ul class='article-meta'><li><i class='fa fa-clock-o'></i>" + newsDetailsSportTbl[i].newsDetInsertDate + "</li><li><i class='fa fa-comments'></i>" + newsDetailsSportTbl[i].incReview + "</li></ul></div></article></div>";
            }
        }
        newsSmallHtml.InnerHtml = smallNewsString;
        #endregion

    }
}