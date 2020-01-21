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
        string addStaff = string.Empty;
        tblStaffCollection staffTbl = new tblStaffCollection();
        staffTbl.ReadList();
        
        addStaff += "<div class='grids_of_4'>";
        for (int i = 0; i < staffTbl.Count; i++)
        {
            addStaff += "<div class='grid1_of_4'><div class='content_box'><a href='staff-details.aspx?item=" + staffTbl[i].id + "'>" +
                            "<img src='../images/staff/" + staffTbl[i].StaffPicName + "' class='img-responsive' alt='" + staffTbl[i].id + "' /></a>" +
                            "<h4><a> " + staffTbl[i].StaffName + " "  + staffTbl[i].StaffFamily + " </a></h4>" +
                            "<h4>" + staffTbl[i].StaffCertificate + "</h4>" +
                            "<p>" + staffTbl[i].StaffDetail + "</p>" +
                            "<div class='grid_1 simpleCart_shelfItem'>" +
                            "<div class='item_add'><span class='item_price'><h6>" + staffTbl[i].StaffJobPosition + "</h6></span></div>" +
                            "<div class='item_add'><span class='item_price'><a href='staff-details.aspx?item=" + staffTbl[i].id + "'>EDIT</a></span></div>" +
                            "</div></div></div>";
            if ((i - 1) % 4 == 0)
            {
                addStaff += "<div class='clearfix'></div></div>";
                addStaff += "<div class='grids_of_4'>";
            }
        }

        addStaffHtml.InnerHtml = addStaff;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string errorString = string.Empty;
        lblError.Visible = false;
        tblStaff staffTbl = new tblStaff();
        try
        {


            if (true)//(txtJobPosition.Text.Trim().Length > 0 && txtName.Text.Trim().Length > 0 && txtFamily.Text.Trim().Length > 0)
            {
                staffTbl.idCompany = 1;

                //staffTbl.StaffName = txtName.Text;
                //staffTbl.StaffFamily = txtFamily.Text;
                //staffTbl.StaffJobPosition = txtJobPosition.Text;
                //staffTbl.idStaffRole = 1;
                //staffTbl.StaffBirthdate = "";
                //staffTbl.StaffHiringDate = "";
                //staffTbl.StaffStartDate = "";
                //staffTbl.StaffEndDate = "";
                //staffTbl.StaffUsername = "";
                //staffTbl.StaffPassword = "";

                //if (txtBithdate.Text.Length > 0)
                //    staffTbl.StaffBirthdate = txtBithdate.Text;
                //else
                //    staffTbl.StaffBirthdate = "";

                // file upload start 
                string filename = string.Empty;
                if (IsPostBack)
                {
                    Boolean fileOK = false;
                    String path = Server.MapPath("~/images/staff/");
                    if (fuGallery.HasFile)
                    {
                        String fileExtension = System.IO.Path.GetExtension(fuGallery.FileName).ToLower();
                        String[] allowedExtensions = { ".jpg", ".png", ".bmp", ".tif" };
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
                            lblError.Text = "A promblem with uplouding picture";
                        }
                    }
                    else
                    {
                        lblError.Text = "Not valid picture";
                    }
                }

                // file upload end

                //staffTbl.StaffPicAddr = "images/staff/";
                //if (filename.Length > 0)
                //    staffTbl.StaffPicName = filename;
                //else
                //    lblError.Visible = true;

                //if (txtHiringDate.Text.Trim().Length > 0)
                //    staffTbl.StaffHiringDate = txtHiringDate.Text;
                //else
                //    staffTbl.StaffHiringDate = "";

                //if (txtMajor.Text.Trim().Length > 0)
                //    staffTbl.StaffMajor = txtMajor.Text;
                //else
                //    staffTbl.StaffMajor = "";

                //if (txtCertificate.Text.Trim().Length > 0)
                //    staffTbl.StaffCertificate = txtCertificate.Text;
                //else
                //    staffTbl.StaffCertificate = "";

                //if (txtWord.Text.Trim().Length > 0)
                //    staffTbl.StaffWords = txtWord.Text;
                //else
                //    staffTbl.StaffWords = "";

                //staffTbl.allow = "1";

                //if (txtDetail.Text.Trim().Length > 0)
                //    staffTbl.StaffDetail = txtDetail.Text;
                //else
                //    staffTbl.StaffDetail = "";

                //if (txtEmail.Text.Trim().Length > 0)
                //    staffTbl.StaffEmail = txtEmail.Text;
                //else
                //    staffTbl.StaffEmail = "";

                //if (txtTel.Text.Trim().Length > 0)
                //    staffTbl.SatffTel = txtTel.Text;
                //else
                //    staffTbl.SatffTel = "";

                //if (txtMob.Text.Trim().Length > 0)
                //    staffTbl.StaffMobile = txtMob.Text;
                //else
                //    staffTbl.StaffMobile = "";

                //if (lblError.Visible == false)
                //    staffTbl.Create();

                Response.Redirect("staff.aspx");
            }
            else
            {
                lblError.Text = "* Please fill nesessary items";
                lblError.Visible = true;
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.ToString();
            lblError.Visible = true;
            throw;
        }
    }

    protected void btnAddRows_Click(object sender, EventArgs e)
    {
        string rowNoStr = string.Empty;
        int rowNo = Convert.ToInt32(ddlStageRow.SelectedValue);


        for (int i = 0; i < rowNo; i++)
        {
            rowNoStr += "<div class='mainseat' style='float: left;'><span class='rowNumber'>" + i + "</span></div>" +
                        "<label>Seats:</label><select>";
            for (int j = 0; j < 43; j++)
            {
                rowNoStr += "<option value='" + j + "'>" + j + "</option>";
            }
            rowNoStr += "</select>";
            for (int j = 0; j < 43; j++)
            {
                rowNoStr+="<div class='mainseat' style='float: left;'><span class='icon-sofa is-clone'><i class='fa fa-user-o' aria-hidden='true'></i></div>";
            }
            rowNoStr += "<div class='mainseat' style='float: left;'><span class='rowNumber'>" + i + "</span></div>" +
                        "<div class='clearfix'></div>";

        }

        rowNoHtml.InnerHtml = rowNoStr;
    }
}