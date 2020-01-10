using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;

public partial class admin_need_to_know_delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["itemCode"] != null)
        {
            itemGet = Int32.Parse(Request.QueryString["itemCode"]);
        }
        else
            Response.Redirect("need-to-know.aspx");

        //tblNeedToKnowCollection needTbl = new tblNeedToKnowCollection();
        //needTbl.ReadList(Criteria.NewCriteria(tblNeedToKnow.Columns.id, CriteriaOperators.Equal, itemGet));

        //needTbl[0].Delete();

        Response.Redirect("need-to-know.aspx");
    }
}