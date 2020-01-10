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
        //tblGalleryGroupCollection galleryGroupsTbl = new tblGalleryGroupCollection();
        //galleryGroupsTbl.ReadList();

        //for (int i = 0; i < galleryGroupsTbl.Count; i++)
        //{
        //    itemsString += "<a href='#' id='item" + i + "' >" + galleryGroupsTbl[i].GroupTitle + "</a> <br />";
        //}
        //itemsHtml.InnerHtml = itemsString;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //tblGalleryGroup GalleryGroupTbl = new tblGalleryGroup();
        //lblError.Visible = false;

        //if (txtGroupName.Text.Length > 0)
        //    GalleryGroupTbl.GroupTitle = txtGroupName.Text;
        //else
        //    lblError.Visible = true;

        //if (txtGroupDetail.Text.Length > 0)
        //    GalleryGroupTbl.GroupDetails = txtGroupDetail.Text;
        //else
        //    GalleryGroupTbl.GroupDetails = "";
        //if (lblError.Visible == false)
        //{
        //    GalleryGroupTbl.Create();
        Response.Redirect("groups-color.aspx");
        //}

        

    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
       
        
        
    }

}