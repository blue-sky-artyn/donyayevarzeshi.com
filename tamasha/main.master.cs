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

        // ---------------- footer -----------------
        tblCompanyCollection companyDetailTbl = new tblCompanyCollection();
        companyDetailTbl.ReadList();

        //coDetailHtml.InnerHtml = companyDetailTbl[0].CoDetail;

        #region Ad
        string dateNow = DateTime.Now.ToString("yyyyMMdd");
        tblAdCollection AdTbl = new tblAdCollection();       
        AdTbl.ReadList();

        tblAdPicCollection adPicTbl = new tblAdPicCollection();

        for (int i = 0; i < AdTbl.Count; i++)
        {
            if (Convert.ToInt32(AdTbl[i].dateStart.Trim()) >= Convert.ToInt32(dateNow))
            {
                if (AdTbl[i].adPosition.Trim() == "top")
                {
                    adPicTbl.ReadList(Criteria.NewCriteria(tblAdPic.Columns.idAd, CriteriaOperators.Equal, AdTbl[i].id));
                    adHeader.InnerHtml = "<img class='center-block' src='./images/ad/" + adPicTbl[0].picName + "' alt='" + adPicTbl[0].picName + "'>";
                }
            }
            
        }

        #endregion

    }

    protected void btnSub_Click(object sender, EventArgs e)
    {
        string dateInsert = DateTime.Now.ToString("yyyyMMdd");
        tblMemberOfDailyEmail dailyMemberTbl = new tblMemberOfDailyEmail();

        if (txtEmailSub.Value.Trim().Length > 0)
        {
            dailyMemberTbl.memberName = "";
            dailyMemberTbl.memberSurname = "";
            dailyMemberTbl.memberEmail = txtEmailSub.Value;
            dailyMemberTbl.memberInsDate = Convert.ToInt32(dateInsert);
            dailyMemberTbl.memberExpDate = 0;
            dailyMemberTbl.memberRequestToDea = "1";
            dailyMemberTbl.allow = "1";

            dailyMemberTbl.Create();
        }
    }
}
