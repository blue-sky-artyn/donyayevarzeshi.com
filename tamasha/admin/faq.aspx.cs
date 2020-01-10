using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using BlueSky.Artin;

public partial class admin_need_to_know : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string faqString = string.Empty;
        tblFAQCollection faqTbl = new tblFAQCollection();
        faqTbl.ReadList();

        for (int i = 0; i < faqTbl.Count; i++)
        {
            faqString += "<div class='mediabox'><i class='fa fa-sitemap'></i>" +
                         "<h3>" + faqTbl[i].faqTitle + "</h3>" +
                         "<p>" + faqTbl[i].faqDetail + "</p><a href='faq-delete.aspx?itemCode=" + faqTbl[i].id + "'>Delete</a></div>";
        }

        faqHtml.InnerHtml = faqString;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        tblFAQ faqTbl = new tblFAQ();

        if (txtTitle.Text.Trim().Length > 0)
        {
            faqTbl.faqTitle = txtTitle.Text;
            faqTbl.faqDetail = txtDetail.Text;
            faqTbl.allow = "1";
            faqTbl.Create();

            Response.Redirect("faq.aspx");
        }
        else
            lblError.Text = "* Please enter question frist.";


    }
}