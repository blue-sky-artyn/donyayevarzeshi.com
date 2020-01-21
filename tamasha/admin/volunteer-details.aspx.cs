using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;


public partial class admin_gallery_normal_detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("volunteer.aspx");

        //fill data 

        tblVolunteerCollection volunteerTbl = new tblVolunteerCollection();
        volunteerTbl.ReadList(Criteria.NewCriteria(tblVolunteer.Columns.id, CriteriaOperators.Equal, itemGet));


        
        setPicHtml.InnerHtml = "<img src='images/volunteer.png' class='img-responsive' draggable='false'>";
        

        string addDataString = string.Empty;
        addDataString += "<h3>" + volunteerTbl[0].tile + ":" + volunteerTbl[0].volunteerName + " " + volunteerTbl[0].volunteerFamily + "</h3><br>" +
                         "<span class='code'>Major and field of study: <a>" + volunteerTbl[0].studiedIn +"("+ volunteerTbl[0].levelOfEduation + ")</a></span>" +
                         "<span class='code'>School: <a>" + volunteerTbl[0].SchoolName + "</a></span>" +
                         "<p>Required hours: " + volunteerTbl[0].requiredHours + "</p>" +
                        "<div class='price'>" +
                        "<span class='text'>Emergancy Call:</span>";
       
        addDataString += "<span class='price-new'>" + volunteerTbl[0].emergancyCall + "</span>";
       

        addDataString += "<span class='price-tax'><label class='checkbox'>Employer Details:</label><br/><span><br/>" + 
                         "Employer Name:" +volunteerTbl[0].employerName + "<br>"+
                         "Employer Status:" +volunteerTbl[0].employedStatus + "<br>";

        
        addDataString += "<span class='points'><small>Registration Date: " + volunteerTbl[0].volunteerRegDate + "</small></span><br>";

        addDataString += "</div>" +
                        "<div class='det_nav1'><h4>Address:" + volunteerTbl[0].addr + "</h4><div class='sky-form col col-4'><ul>" +
                        "<li>Tel:" + volunteerTbl[0].telCell + "</li><li>/</li><li>Home:" + volunteerTbl[0].telHome + "</li><li>/</li><li>Work:" + volunteerTbl[0].telWork + "</li>/<li>Email:" + volunteerTbl[0].email + "</li>" +
                        "</ul></div></div>" +
                        "<div class='det_nav1'>" +
                        "<h4>Staff Word: </h4>" +
                        "<div class='sky-form col col-4'>" +
                        "<p>Skills: " + volunteerTbl[0].skills + "</p>" +
                        "<p>Hobbies: " + volunteerTbl[0].hobbies + "</p>" +
                        "<p>Details: " + volunteerTbl[0].details + "</p>";
        if (volunteerTbl[0].allow == "1")
            addDataString += "</div><div class='det_nav1'><h3>Accepted</h3></div></div>";
        else
            addDataString += "</div><div class='det_nav1'><h3>Not Accepted Yet</h3></div></div>";

        addDetailHtml.InnerHtml = addDataString;

    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("volunteer.aspx");

        tblVolunteerCollection volunteerTbl = new tblVolunteerCollection();
        volunteerTbl.ReadList(Criteria.NewCriteria(tblVolunteer.Columns.id, CriteriaOperators.Equal, itemGet));

        volunteerTbl[0].Delete();

        Response.Redirect("volunteer.aspx");

    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("volunteer.aspx");

        tblVolunteerCollection volunteerTbl = new tblVolunteerCollection();
        volunteerTbl.ReadList(Criteria.NewCriteria(tblVolunteer.Columns.id, CriteriaOperators.Equal, itemGet));

        volunteerTbl[0].allow = "1";

        volunteerTbl[0].Update();

        Response.Redirect("volunteer.aspx");
    }
}