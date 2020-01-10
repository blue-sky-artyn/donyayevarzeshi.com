using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;


public partial class admin_gallery_groups : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string itemsString = string.Empty;
        //tblColorsCollection colorsTbl = new tblColorsCollection();
        //colorsTbl.ReadList();

        //for (int i = 0; i < colorsTbl.Count; i++)
        //{
        //    itemsString += "<a href='#' id='item" + i + "' > - " + colorsTbl[i].colorName + " (" + colorsTbl[i].colorCode + ") " + "</a> <br/>";
        //}
        itemsHtml.InnerHtml = itemsString;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //tblColors colorsTbl = new tblColors();
        //lblError.Visible = false;

        //if (txtColorName.Text.Length > 0)
        //    colorsTbl.colorName = txtColorName.Text;
        //else
        //{
        //    lblError.Text = "*Please fill out the color name frist.";
        //    lblError.Visible = true;
        //}
        //if (txtColorCode.Text.Length > 0)
        //    colorsTbl.colorCode = txtColorCode.Text;
        //else
        //{
        //    lblError.Text = "*Please fill out the color code frist.";
        //    lblError.Visible = true;
        //}

        //colorsTbl.allow = "1";

        //if (lblError.Visible == false)
        //{
        //    colorsTbl.Create();
        //    Response.Redirect("groups-color.aspx");
        //}

        
    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
       
        
        
    }
}