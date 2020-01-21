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

        #region archive News
        newsDetailsSportTbl.ReadList();
        string popularNews = "<div class='farsi-position section-title'><h2 class='farsi-font title'>آرشیو اخبار</h2></div>";

        if (newsDetailsSportTbl.Count > 5)
        {
            for (int i = 0; i < 5; i++)
            {
                popularNews += "<article class='article row-article'><div class='article-img'><a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsDetailsSportTbl[i].id + "'>";

                if (newsDetailsSportTbl[i].topPageFileType == 0)
                    popularNews += "<img src='./images/news/top/" + newsDetailsSportTbl[i].topPageFileAddr + "' alt='دنیای ورزشی " + newsDetailsSportTbl[i].topPageFileAddr + "'>";
                else if (newsDetailsSportTbl[0].topPageFileType == 1)
                    popularNews += "<div><video id='video1'><source src='../movie/news/top/" + newsDetailsSportTbl[i].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video></div>";
                else
                    popularNews += newsDetailsSportTbl[i].topPageFileAddr;

                popularNews += "</a></div><div class='article-body'>" +
                            "<ul class='article-info'><li class='article-category'><a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsDetailsSportTbl[i].id + "'>News</a></li><li class='article-type'><i class='fa fa-file-text'></i></li></ul>" +
                            "<p class='sub-title-news sub-title' style='font-size: 9px;'>" + newsDetailsSportTbl[i].newsDetSubtitle + "</p>" +
                            "<h4 class='farsi-font farsi-position article-title'><a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsDetailsSportTbl[i].id + "'>" + newsDetailsSportTbl[i].newsDetTitle + "</a></h4>" +
                            "<ul class='article-meta'><li><i class='fa fa-clock-o'></i>" + newsDetailsSportTbl[i].newsDetInsertDate + "</li><li><i class='fa fa-comments'></i>" + newsDetailsSportTbl[i].incReview + "</li></ul>" +
                            "<p>" + newsDetailsSportTbl[i].newsDetDetails + "</p></div></article>";
            }
        }
        else
        {
            for (int i = 0; i < newsDetailsSportTbl.Count; i++)
            {
                popularNews += "<article class='article row-article'><div class='article-img'><a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsDetailsSportTbl[i].id + "'>";

                if (newsDetailsSportTbl[i].topPageFileType == 0)
                    popularNews += "<img src='./images/news/top/" + newsDetailsSportTbl[i].topPageFileAddr + "' alt='دنیای ورزشی " + newsDetailsSportTbl[i].topPageFileAddr + "'>";
                else if (newsDetailsSportTbl[0].topPageFileType == 1)
                    popularNews += "<div><video id='video1'><source src='../movie/news/top/" + newsDetailsSportTbl[i].topPageFileAddr + "' type='video/mp4'>Your browser does not support HTML5 video.</video></div>";
                else
                    popularNews += newsDetailsSportTbl[i].topPageFileAddr;

                popularNews += "</a></div><div class='article-body'>" +
                            "<p class='sub-title-news sub-title' style='font-size: 9px;'>" + newsDetailsSportTbl[i].newsDetSubtitle + "</p><ul class='article-info'><li class='article-category'><a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsDetailsSportTbl[i].id + "'>News</a></li><li class='article-type'><i class='fa fa-file-text'></i></li></ul>" +
                            "<h4 class='farsi-font farsi-position article-title'><a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsDetailsSportTbl[i].id + "'>" + newsDetailsSportTbl[i].newsDetTitle + "</a></h4>" +
                            "<ul class='article-meta'><li><i class='fa fa-clock-o'></i>" + newsDetailsSportTbl[i].newsDetInsertDate + "</li><li><i class='fa fa-comments'></i>" + newsDetailsSportTbl[i].incReview + "</li></ul>" +
                            "<p>" + newsDetailsSportTbl[i].newsDetDetails + "</p></div></article>";
            }
        }
        popularNewsHtml.InnerHtml = popularNews;
        #endregion

    }
}