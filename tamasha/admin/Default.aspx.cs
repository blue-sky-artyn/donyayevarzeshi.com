using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;


public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        tblCompanyCollection coDetTbl = new tblCompanyCollection();
        coDetTbl.ReadList();
        if (coDetTbl[0].CoAddr.Trim().Length > 0)
            coDetHtml.InnerHtml = "<li><i class='add'></i>"+coDetTbl[0].CoAddr+"</li>";

        if (coDetTbl[0].Tel.Trim().Length > 0)
            coDetHtml.InnerHtml += "<li><i class='phone'></i>" + coDetTbl[0].Tel + "</li>";

        if (coDetTbl[0].Email.Trim().Length > 0)
            coDetHtml.InnerHtml += "<li><a href='mailto:info@halisen.ca'><i class='mail'> </i>" + coDetTbl[0].Email + "</a></li>";

    }
}