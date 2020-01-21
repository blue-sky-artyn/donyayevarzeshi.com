using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;


public partial class admin_gallery_groups : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string itemsString = string.Empty;
        tblWorkingHoursCollection workingHoursTbl = new tblWorkingHoursCollection();
        workingHoursTbl.ReadList();

        for (int i = 0; i < workingHoursTbl.Count; i++)
        {
            itemsString += "<div class='popup panel-footer'>" +
                            workingHoursTbl[i].weekDay + "- <a id=\"" + workingHoursTbl[i].id + "\" Class='clickable'>" + workingHoursTbl[i].hour + "</a><br />" +
                            "</div";
        }
        if (!IsPostBack)
        {

            if (workingHoursTbl.Count > 0)
                txtHourMon.Text = workingHoursTbl[0].hour;
            else if (workingHoursTbl.Count > 1)
                txtHourTus.Text = workingHoursTbl[1].hour;
            else if (workingHoursTbl.Count > 2)
                txtHourWed.Text = workingHoursTbl[2].hour;
            else if (workingHoursTbl.Count > 3)
                txtHourThu.Text = workingHoursTbl[3].hour;
            else if (workingHoursTbl.Count > 4)
                txtHourFri.Text = workingHoursTbl[4].hour;
            else if (workingHoursTbl.Count > 5)
                txtHourSat.Text = workingHoursTbl[5].hour;
            else if (workingHoursTbl.Count > 6)
                txtHourSun.Text = workingHoursTbl[6].hour;
        }

        itemsHtml.InnerHtml = itemsString;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {


    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {

        tblWorkingHoursCollection workingHoursTbl = new tblWorkingHoursCollection();
        workingHoursTbl.ReadList();

        if (txtHourMon.Text.Trim().Length > 0)
            workingHoursTbl[0].hour = txtHourMon.Text;
        else
            workingHoursTbl[0].hour = "";

        if (txtHourTus.Text.Trim().Length > 0)
            workingHoursTbl[1].hour = txtHourTus.Text;
        else
            workingHoursTbl[1].hour = "";

        if (txtHourWed.Text.Trim().Length > 0)
            workingHoursTbl[2].hour = txtHourWed.Text;
        else
            workingHoursTbl[2].hour = "";

        if (txtHourThu.Text.Trim().Length > 0)
            workingHoursTbl[3].hour = txtHourThu.Text;
        else
            workingHoursTbl[3].hour = "";

        if (txtHourFri.Text.Trim().Length > 0)
            workingHoursTbl[4].hour = txtHourFri.Text;
        else
            workingHoursTbl[4].hour = "";

        if (txtHourSat.Text.Trim().Length > 0)
            workingHoursTbl[5].hour = txtHourSat.Text;
        else
            workingHoursTbl[5].hour = "";

        if (txtHourSun.Text.Trim().Length > 0)
            workingHoursTbl[6].hour = txtHourSun.Text;
        else
            workingHoursTbl[6].hour = "";

        workingHoursTbl.UpdateList(true);
    }
}