using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;


public partial class main : System.Web.UI.MasterPage
{
    private string giveMeAd(int adStyleId)
    {
        string dateNow = DateTime.Now.ToString("yyyyMMdd");
        Random ranNumber = new Random();
        int ranNum = 0; string ret = "";

        tblAdCollection AdTbl = new tblAdCollection();
        AdTbl.ReadList(Criteria.NewCriteria(tblAd.Columns.idStyleGrp, CriteriaOperators.Equal, adStyleId));

        tblAdPicCollection adPicTbl = new tblAdPicCollection();

        if (AdTbl.Count > 0)
        {
            while (true)
            {
                ranNum = ranNumber.Next(0, AdTbl.Count);
                int dateAd = Convert.ToInt32(AdTbl[ranNum].dateStart.Substring(0, 2) + AdTbl[ranNum].dateStart.Substring(3, 2) + AdTbl[ranNum].dateStart.Substring(6, 4));

                if (dateAd >= Convert.ToInt32(dateNow))
                {
                    adPicTbl.ReadList(Criteria.NewCriteria(tblAdPic.Columns.idAd, CriteriaOperators.Equal, AdTbl[ranNum].id));
                    ret = adPicTbl[0].picAddr + adPicTbl[0].picName;
                    break;
                }
            }
            return (ret);
        }
        else
            return ("none");

        //return ("./img/headad.jpg");
        //  return ("./img/headadbox.jpg");

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //Menu
        string menuString = string.Empty;
        tblMenuCollection menuTbl = new tblMenuCollection();
        menuTbl.ReadList();

        string subMenuString = string.Empty;
        tblSubMenuCollection subMenuTbl = new tblSubMenuCollection();

        for (int i = 0; i < menuTbl.Count; i++)
        {
            //get sub menu
            subMenuTbl.ReadList(Criteria.NewCriteria(tblSubMenu.Columns.MenuId, CriteriaOperators.Equal, menuTbl[i].id));

            menuString += "<li><a href='#'>" + menuTbl[i].menuItem + "</a></li>";
            //subMenuString += "<li><a href='#'>" + subMenuTbl[0].SubMenuTitle + "</a></li>";
        }

        //menuHtml.InnerHtml = menuString;
        //subMenuHtml.InnerHtml = subMenuString;

        #region footer details

        // ---------------- footer -----------------
        string socialFooterStr = "";
        tblCompanyCollection companyDetailTbl = new tblCompanyCollection();
        companyDetailTbl.ReadList();
        if (companyDetailTbl.Count > 0)
        {
            coDetailHtml.InnerHtml = companyDetailTbl[0].CoDetail;
            if (companyDetailTbl[0].Facebook.Trim().Length > 0)
                socialFooterStr += "<li><a href='"+ companyDetailTbl[0].Facebook + "' class='facebook'><i class='fa fa-facebook'></i></a></li>";
            if (companyDetailTbl[0].Twitter.Trim().Length > 0)
                socialFooterStr += "<li><a href='" + companyDetailTbl[0].Twitter + "' class='twitter'><i class='fa fa-twitter'></i></a></li>";
            if (companyDetailTbl[0].GooglePlus.Trim().Length > 0)
                socialFooterStr += "<li><a href='" + companyDetailTbl[0].GooglePlus + "' class='google'><i class='fa fa-google'></i></a></li>";
            if (companyDetailTbl[0].Instagram.Trim().Length > 0)
                socialFooterStr += "<li><a href='" + companyDetailTbl[0].Instagram + "' class='instagram'><i class='fa fa-instagram'></i></a></li>";
            if (companyDetailTbl[0].youtube.Trim().Length > 0)
                socialFooterStr += "<li><a href='" + companyDetailTbl[0].youtube + "' class='youtube'><i class='fa fa-youtube'></i></a></li>";
            if (companyDetailTbl[0].Linkedin.Trim().Length > 0)
                socialFooterStr += "<li><a href='" + companyDetailTbl[0].Linkedin + "' class='rss'><i class='fa fa-linkedin-square'></i></a></li>";
        }

        socialFooterHtml.InnerHtml = socialFooterStr;
        #endregion

        #region Ad
        string ret = "none";
        tblAdStyleCollection adStyleTbl = new tblAdStyleCollection();
        adStyleTbl.ReadList();

        for (int i = 0; i < adStyleTbl.Count; i++)
        {
            // ----------------- FOR POSITION OF 980*120 --------------------
            if (adStyleTbl[i].styleWidth > 600 && adStyleTbl[i].styleHeight > 105)
            {

            }
            // ----------------- FOR POSITION OF 980*90 --------------------
            else if (adStyleTbl[i].styleWidth > 600 && adStyleTbl[i].styleHeight <= 105)
            {
                ret = giveMeAd(adStyleTbl[i].id);
                if (ret != "none")
                    adHeaderHtml.Src = ret;
            }
            // ----------------- FOR POSITION OF 300*250 --------------------
            else if (adStyleTbl[i].styleWidth <= 600 && adStyleTbl[i].styleHeight >= 250)
            {
                ret = giveMeAd(adStyleTbl[i].id);
                if (ret != "none")
                    adSquareHtml.Src = ret;
            }
        }

        #endregion

        tblGalleryPicturesCollection galleryTbl = new tblGalleryPicturesCollection();
        galleryTbl.ReadList();

        #region footer gallery
        string pictureGalleriesStr = "";
        int minLengthGallery = 0;

        if (galleryTbl.Count > 12)
            minLengthGallery = galleryTbl.Count - 13;

        for (int i = galleryTbl.Count - 1; i > minLengthGallery; i--)
            pictureGalleriesStr += "<li><a href='picture-gallery.aspx'><img src='" + galleryTbl[i].GalleryPicAddr + galleryTbl[i].GalleryPicName + "' alt=''></a></li>";

        gallery1Html.InnerHtml = pictureGalleriesStr;
        #endregion

        tblNewsHitCollection hitNewsTbl = new tblNewsHitCollection();
        hitNewsTbl.ReadList();

        tblNewsDetailsCollection newsDetailsTbl = new tblNewsDetailsCollection();

        #region hit news footer

        string hitNewsFooterStr = "";
        int minLength = 0;
        if (hitNewsTbl.Count > 5)
            minLength = hitNewsTbl.Count - 6;

        for (int i = hitNewsTbl.Count - 1; i >= minLength; i--)
        {
            newsDetailsTbl.ReadList(Criteria.NewCriteria(tblNewsDetails.Columns.id, CriteriaOperators.Equal, hitNewsTbl[i].newsId));

            hitNewsFooterStr += "<article class='article widget-article'><div class='farsi-float article4-img'><a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsDetailsTbl[0].id + "'>" +
                                "<img src='images/news/" + newsDetailsTbl[0].topPageFileAddr + "' alt='" + newsDetailsTbl[0].topPageFileAddr + "'>" +
                                "</a></div><div class='article-body'>" +
                                "<h4 class='farsi-position farsi-font article-title'><a href='donyaye-varzeshi-news-details.aspx?newsId=" + newsDetailsTbl[0].id + "'>" + newsDetailsTbl[0].newsDetTitle + "</a></h4>" +
                                "<ul class='article-meta'><li><i class='fa fa-clock-o'></i>" + newsDetailsTbl[0].newsDetInsertDate + "</li><li><i class='fa fa-comments'></i>" + newsDetailsTbl[0].incReview + "</li></ul>" +
                                "</div></article>";


        }

        hitNewsFooterHtml.InnerHtml += hitNewsFooterStr;
        #endregion

    }

    protected void btnSub_Click(object sender, EventArgs e)
    {
        string dateInsert = DateTime.Now.ToString("yyyyMMdd");
        tblMemberOfDailyEmail dailyMemberTbl = new tblMemberOfDailyEmail();

        #region check existance
        bool flag = true;
        tblMemberOfDailyEmailCollection checkEmailTbl = new tblMemberOfDailyEmailCollection();
        checkEmailTbl.ReadList(Criteria.NewCriteria(tblMemberOfDailyEmail.Columns.memberEmail, CriteriaOperators.Like, txtEmailSub.Value.Trim()));
        if (checkEmailTbl.Count > 0)
            flag = false;
        #endregion

        if (txtEmailSub.Value.Trim().Length > 0 && flag)
        {
            dailyMemberTbl.memberName = "";
            dailyMemberTbl.memberSurname = "";
            dailyMemberTbl.memberEmail = txtEmailSub.Value.Trim();
            dailyMemberTbl.memberInsDate = Convert.ToInt32(dateInsert);
            dailyMemberTbl.memberExpDate = 0;
            dailyMemberTbl.memberRequestToDea = "1";
            dailyMemberTbl.allow = "1";

            dailyMemberTbl.Create();
        }
        else
            if (flag == false)
            txtErrorHtml.InnerText = "ایمیل قبلا ثبت شده است";
        else
            txtErrorHtml.InnerText = "ایمیل را وارد نمایید";
    }
}
