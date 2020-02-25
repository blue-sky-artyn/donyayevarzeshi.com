using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

public partial class about_toronto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string socialStr = string.Empty;string googleMapStr = "";string coDetailsStr = "";string coOwnerWord = "";
        tblCompanyCollection coTbl = new tblCompanyCollection();
        coTbl.ReadList();
        if (coTbl.Count > 0)
        {
            #region social links
            if (coTbl[0].Facebook.Trim().Length > 0)
                socialStr += "<a href='"+ coTbl[0].Facebook + "' class='facebook'><i class='fa fa-facebook'></i></a>";
            if (coTbl[0].Twitter.Trim().Length > 0)
                socialStr += "<a href='"+ coTbl[0].Twitter+ "' class='twitter'><i class='fa fa-twitter'></i></a>";
            if (coTbl[0].youtube.Trim().Length > 0)
                socialStr += "<a href='"+ coTbl[0].youtube + "' class='google'><i class='fa fa-youtube'></i></a>";

            #endregion

            #region google map
            googleMapStr = coTbl[0].CoLocA;
            #endregion

            #region company details
	        coDetailsStr = "<h1 class='article-title'>"+ coTbl[0].CoName + "</h1>";

            coDetailsStr += coTbl[0].CoDetail;


            coOwnerWord = coTbl[0].CoOwnerWord;
            #endregion

        }

        socialLinksHtml.InnerHtml = socialStr;
        googleMapHtml.InnerHtml = googleMapStr;

        aboutCoHtml.InnerHtml = coDetailsStr;
        aboutCoHtml.InnerHtml += "<h2>سخن صاحب امتیاز</h2>";
        aboutCoHtml.InnerHtml += coOwnerWord;
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        
    }
}