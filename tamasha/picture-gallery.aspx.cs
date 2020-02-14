using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Cruder.Core;
using bluesky.artyn;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;





public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        #region SQL query
        string databaseName = "[azhmang1_weather].[dbo].[tblUnitsPower]";
        string ConStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(ConStr))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM " + databaseName))    //select * from [azhmang1_weather].[dbo].[tblUnitsPower] where UnitDate = '20190721'  ORDER BY UnitId,UnitHour
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;

                    using (DataTable dt = new DataTable())
                    {
                        //sda.Fill(dt);
                    }
                }
            }
        }
        #endregion

        tblGalleryPicturesCollection galleryTbl = new tblGalleryPicturesCollection();
        galleryTbl.ReadList();
        tblGalleryGroupCollection galleryGrpTbl = new tblGalleryGroupCollection();
        galleryGrpTbl.ReadList();

        #region slider

        string sliderString = "<div id='owl-carousel-1' class='news-background-filler owl-carousel owl-theme center-owl-nav'>";
        if (galleryTbl.Count > 5)
        {
            for (int i = galleryTbl.Count - 1; i > galleryTbl.Count - 6; i--)
            {
                
                    sliderString += "<article class='article thumb-article'><div class='article-img'>" +
                                    "<img class='head-news-img' src='" + galleryTbl[i].GalleryPicAddr + galleryTbl[i].GalleryPicName + "' alt='دنیای ورزشی " + galleryTbl[i].GalleryPicName + "'>" +
                                    "</div><div class='article-body'><ul class='article-info'>" +
                                    "<li class='article-category'><a href='#'>Archive</a></li><li class='article-type'><i class='fa fa-camera'></i></li></ul>" +
                                    //"<p class='sub-title' style='font-size: 9px;'>" + pictureGalleryTbl[i].GalleryPicTitle + "</p>" +
                                    "<h2 class='farsi-position farsi-font farsi-slider-title article-title'><a href='#?picId=" + galleryTbl[i].id + "'>" + galleryTbl[i].GalleryPicTitle + "</a></h2>" +
                                    "<ul class='article-meta'>" +
                                    "<li><i class='fa fa-clock-o'></i>" + galleryTbl[i].GalleryInsertDate + "</li>" +
                                    //"<li><i class='fa fa-comments'></i>" + pictureGalleryTbl[i].incReview + "</li>" +
                                    "</ul></div></article>";
                


            }
        }
        else
        {
            for (int i = galleryTbl.Count - 1; i > 0; i--)
            {
                    sliderString += "<article class='article thumb-article'><div class='article-img'>" +
                                    "<img class='head-news-img' src='" + galleryTbl[i].GalleryPicAddr + galleryTbl[i].GalleryPicName + "' alt='دنیای ورزشی " + galleryTbl[i].GalleryPicName + "'>" +
                                    "</div><div class='article-body'><ul class='article-info'>" +
                                    "<li class='article-category'><a href='#'>Archive</a></li><li class='article-type'><i class='fa fa-camera'></i></li></ul>" +
                                     //"<p class='sub-title' style='font-size: 9px;'>" + newsDetailsSportTbl[i].newsDetSubtitle + "</p>" +
                                     "<h2 class='farsi-position farsi-font farsi-slider-title article-title'><a href='#?picId=" + galleryTbl[i].id + "'>" + galleryTbl[i].GalleryPicTitle + "</a></h2>" +
                                    "<ul class='article-meta'>" +
                                    "<li><i class='fa fa-clock-o'></i>" + galleryTbl[i].GalleryInsertDate + "</li>" +
                                    //"<li><i class='fa fa-comments'></i>" + pictureGalleryTbl[i].incReview + "</li>" +
                                    "</ul></div></article>";
            }
        }
        sliderString += "</div></div>";
        sliderHtml.InnerHtml = sliderString;
        #endregion


        #region tabMenu
        string tabsStrings = string.Empty;
        if (galleryGrpTbl.Count > 0)
        {
            tabsStrings += "<li  class='active'><a data-toggle='tab' href='#tab" + galleryGrpTbl[0].id + "'>" + galleryGrpTbl[0].GalleryGroupTitle + "</a></li>";
        }

        for (int i = 1; i < galleryGrpTbl.Count; i++)
        {
            tabsStrings += "<li><a data-toggle='tab' href='#tab" + galleryGrpTbl[i].id + "'>" + galleryGrpTbl[i].GalleryGroupTitle + "</a></li>";
        }
        tabsHtml.InnerHtml = tabsStrings;
        #endregion


        #region news in tab
        string newsTabBarString = string.Empty;
        for (int j = 0; j < galleryGrpTbl.Count; j++)
        {
            galleryTbl.ReadList(Criteria.NewCriteria(tblNewsDetails.Columns.idGroup, CriteriaOperators.Equal, galleryGrpTbl[j].id));
            if (j == 0)
                newsTabBarString += "<div id='tab" + galleryGrpTbl[j].id + "' class='tab-pane fade in active'><div class='row'>";
            else
                newsTabBarString += "<div id='tab" + galleryGrpTbl[j].id + "' class='tab-pane fade'><div class='row'>";

            if (galleryTbl.Count < 5)
            {
                for (int i = 0; i < galleryTbl.Count; i++)
                {
                    newsTabBarString += "<div class='col-md-4 col-sm-6'><article class='article'><div class='article-img'>";


                    newsTabBarString += "<a href='donyaye-varzeshi-news-details.aspx?newsId=" + galleryTbl[i].id + "'><img src='" + galleryTbl[i].GalleryPicAddr + galleryTbl[i].GalleryPicName + "' alt='" + galleryTbl[i].GalleryPicName + "'></a><ul class='article-info'><li class='article-type'><i class='fa fa-camera'></i>";

                    newsTabBarString += "</li></ul></div><div class='article-body article-body-top'>" +
                                        "<p class='sub-title-news sub-title' style='font-size: 9px;'>" + galleryTbl[i].GalleryPicTitle + "</p>" +
                                        "<h4 class='farsi-font farsi-position article-title'><a href='donyaye-varzeshi-news-details.aspx?newsId=" + galleryTbl[i].id + "'>" + galleryTbl[i].GalleryPicTitle + "</a></h4>" +
                                        "<p>" + galleryTbl[i].GalleryPicDetail + "</p>" +
                                        "<ul class='article-meta'><li><i class='fa fa-clock-o'></i>" + galleryTbl[i].GalleryInsertDate + "</li>" +
                                        //"<li><i class='fa fa-comments'></i>" + galleryTbl[i].incReview + "</li>" +
                                        "</ul></div></article></div>";
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    newsTabBarString += "<div class='col-md-3 col-sm-6'><article class='article'><div class='article-img'>" +
                                        "<a href='#'><img src='" + galleryTbl[i].GalleryPicAddr + galleryTbl[i].GalleryPicName + "' alt='" + galleryTbl[i].GalleryPicName + "'></a>" +
                                        "<ul class='article-info'><li class='article-type'><i class='fa fa-camera'></i></li></ul></div><div class='article-body article-body-top'>" +
                                        "<p class='sub-title-news sub-title' style='font-size: 9px;'>" + galleryTbl[i].GalleryPicTitle + "</p>" +
                                        "<h4 class='farsi-font farsi-position article-title'><a href='#'>" + galleryTbl[i].GalleryPicTitle + "</a></h4>" +
                                        "<p>" + galleryTbl[i].GalleryPicDetail + "</p>" +
                                        "<ul class='article-meta'><li><i class='fa fa-clock-o'></i>" + galleryTbl[i].GalleryInsertDate + "</li>" +
                                        //"<li><i class='fa fa-comments'></i>" + galleryTbl[i].incReview + "</li>" +
                                        "</ul></div></article></div>";
                }

            }
            newsTabBarString += "</div></div>";
        }
        tabNewsDetailsHtml.InnerHtml = newsTabBarString;
        #endregion


    }
}