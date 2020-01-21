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
            Response.Redirect("staff.aspx");

        //fill data 

        tblStaffCollection staffTbl = new tblStaffCollection();
        staffTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id, CriteriaOperators.Equal, itemGet));


        if (staffTbl[0].StaffPicName.Length > 0)
        {
            setPicHtml.InnerHtml = "<img src='../images/staff/" + staffTbl[0].StaffPicName + "' class='img-responsive' draggable='false'>";
        }

        string addDataString = string.Empty;
        addDataString += "<h3>" + staffTbl[0].StaffName + " " + staffTbl[0].StaffFamily + "</h3><br>" +
                         "<span class='code'>Major and field of study: <a>" + staffTbl[0].StaffMajor +"("+staffTbl[0].StaffCertificate + ")</a></span>" +
                         "<p>Staff Word: " + staffTbl[0].StaffWords + "</p>" +
                        "<div class='price'>" +
                        "<span class='text'>Job position:</span>";
       
        addDataString += "<span class='price-new'>" + staffTbl[0].StaffJobPosition + "</span>";
       

        addDataString += "<span class='price-tax'><label class='checkbox'>"+ staffTbl[0].StaffBirthdate + "</label></span><br>";

        
            addDataString += "<span class='points'><small>Hiring Date: " + staffTbl[0].StaffHiringDate + "</small></span><br>";

        addDataString += "</div>" +
                        "<div class='det_nav1'><h4></h4><div class='sky-form col col-4'><ul>"+
                        "<li>Tel:"+staffTbl[0].SatffTel+ "</li><li>/</li><li>Mobile:" + staffTbl[0].StaffMobile + "</li><li>/</li><li>Email:" + staffTbl[0].StaffEmail + "</li>" +
                        "</ul></div></div>"+
                         "<div class='det_nav1'>" +
                        "<h4>Staff Word: </h4>" +
                            "<div class='sky-form col col-4'>" +
                                "<p>" + staffTbl[0].StaffWords + "</p></div></div>";
        addDetailHtml.InnerHtml = addDataString;

        //fill data in change part
        //Groups

        //Select old items
        if (!IsPostBack)
        {
            txtName.Text = staffTbl[0].StaffName;
            txtFamily.Text = staffTbl[0].StaffFamily;
            txtBithdate.Text = staffTbl[0].StaffBirthdate;
            txtCertificate.Text = staffTbl[0].StaffCertificate;
            txtMajor.Text = staffTbl[0].StaffMajor;
            txtJobPosition.Text = staffTbl[0].StaffJobPosition;
            txtHiringDate.Text = staffTbl[0].StaffHiringDate;
            txtWord.Text = staffTbl[0].StaffWords;
            txtName.Text = staffTbl[0].StaffName;
            txtDetail.Text = staffTbl[0].StaffDetail;
            txtTel.Text = staffTbl[0].SatffTel;
            txtMob.Text = staffTbl[0].StaffMobile;
            txtEmail.Text = staffTbl[0].StaffEmail;
        }
    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        int itemGet = 0;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("staff.aspx");

        tblStaffCollection staffTbl = new tblStaffCollection();
        staffTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id, CriteriaOperators.Equal, itemGet));

        staffTbl[0].Delete();

        Response.Redirect("staff.aspx");

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        int itemGet = 0;string fileNameUpdate = string.Empty;
        if (Request.QueryString["item"] != null)
        {
            itemGet = int.Parse(Request.QueryString["item"]);
        }
        else
            Response.Redirect("staff.aspx");

        tblStaffCollection staffTbl = new tblStaffCollection();
        staffTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id, CriteriaOperators.Equal, itemGet));

        if (staffTbl.Count > 0)
            fileNameUpdate = staffTbl[0].StaffPicName;

        if (txtName.Text.Trim().Length > 0 && txtFamily.Text.Trim().Length > 0)
        {
            staffTbl[0].StaffName = txtName.Text;
            staffTbl[0].StaffFamily = txtFamily.Text;

            if (txtBithdate.Text.Length > 0)
                staffTbl[0].StaffBirthdate = txtBithdate.Text;
            else
                staffTbl[0].StaffBirthdate = "";


            if (txtCertificate.Text.Length > 0)
                staffTbl[0].StaffCertificate = txtCertificate.Text;
            else
                staffTbl[0].StaffCertificate = "";

            if (txtMajor.Text.Length > 0)
                staffTbl[0].StaffMajor = txtMajor.Text;
            else
                staffTbl[0].StaffMajor = "";

            if (txtJobPosition.Text.Length > 0)
                staffTbl[0].StaffJobPosition = txtJobPosition.Text;
            else
                staffTbl[0].StaffJobPosition = "";

            if (txtHiringDate.Text.Length > 0)
                staffTbl[0].StaffHiringDate = txtHiringDate.Text;
            else
                staffTbl[0].StaffHiringDate = "";

            if (txtWord.Text.Length > 0)
                staffTbl[0].StaffWords = txtWord.Text;
            else
                staffTbl[0].StaffWords = "";

            if (txtDetail.Text.Length > 0)
                staffTbl[0].StaffDetail = txtDetail.Text;
            else
                staffTbl[0].StaffDetail = "";

            if (txtTel.Text.Length > 0)
                staffTbl[0].SatffTel = txtTel.Text;
            else
                staffTbl[0].SatffTel = "";

            if (txtMob.Text.Length > 0)
                staffTbl[0].StaffMobile = txtMob.Text;
            else
                staffTbl[0].StaffMobile = "";

            if (txtEmail.Text.Length > 0)
                staffTbl[0].StaffEmail = txtEmail.Text;
            else
                staffTbl[0].StaffEmail = "";

            // file upload start 
            string filename = string.Empty;
            if (IsPostBack)
            {
                Boolean fileOK = false;
                String path = Server.MapPath("~/images/staff/");
                if (fuGallery.HasFile)
                {
                    String fileExtension = System.IO.Path.GetExtension(fuGallery.FileName).ToLower();
                    String[] allowedExtensions = { ".jpg" };
                    for (int i = 0; i < allowedExtensions.Length; i++)
                    {
                        if (fileExtension == allowedExtensions[i])
                        {
                            fileOK = true;
                        }
                    }
                }

                if (fileOK)
                {
                    try
                    {
                        fuGallery.PostedFile.SaveAs(path + fuGallery.FileName);
                        filename = fuGallery.FileName;
                    }
                    catch (Exception ex)
                    {
                        lblError.Text = "A problem accurred while uplouding picture";
                    }
                }
                else
                {
                    lblError.Text = "Not valid picture file";
                }
            }

            // file upload end
            if (filename.Trim().Length > 0)
                staffTbl[0].StaffPicName = filename;
            else
                staffTbl[0].StaffPicName = fileNameUpdate;
            
            staffTbl[0].Update();
        }

        Response.Redirect("staff-details.aspx?item=" + itemGet);
    }
}