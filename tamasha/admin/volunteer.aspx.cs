using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;
public partial class admin_gallery_normal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //place pictures
        string addVolunteerStr = string.Empty;
        tblVolunteerCollection volunteerTbl = new tblVolunteerCollection();
        volunteerTbl.ReadList();

        addVolunteerStr += "<div class='grids_of_4'>";
        for (int i = 0; i < volunteerTbl.Count; i++)
        {
            addVolunteerStr += "<div class='grid1_of_4'><div class='content_box'><h4><a href='volunteer-details.aspx?item=" + volunteerTbl[i].id + "'>" + volunteerTbl[i].tile + ":"+volunteerTbl[i].volunteerName+" " + volunteerTbl[i].volunteerFamily + "</a></h4>" +
                            "<a>Registration Date: " + volunteerTbl[i].volunteerRegDate + "</a>" +
                            "<h4>" + volunteerTbl[i].skills + "</h4>" +
                            "<p>" + volunteerTbl[i].email + "\\" + volunteerTbl[i].telCell +"\\"+ volunteerTbl[i].telHome +"\\"+ volunteerTbl[i].telWork + " </p>" +
                            "<div class='grid_1 simpleCart_shelfItem'>" +
                            "<div class='item_add'><span class='item_price'><h6>Required Hours: " + volunteerTbl[i].requiredHours + "</h6></span></div>" +
                            "<div class='item_add'><span class='item_price'><a href='volunteer-details.aspx?item=" + volunteerTbl[i].id + "'>EDIT</a></span></div>" +
                            "</div></div></div>";
            if ((i - 1) % 4 == 0)
            {
                addVolunteerStr += "<div class='clearfix'></div></div>";
                addVolunteerStr += "<div class='grids_of_4'>";
            }
        }

        addVolunteerHtml.InnerHtml = addVolunteerStr;
    }
}