using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;
using bluesky.artyn;

public partial class admin_company_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        tblStaffCollection staffTbl = new tblStaffCollection();
        staffTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id,CriteriaOperators.Equal,3));

        if (!IsPostBack)
        {
            if (staffTbl.Count > 0)
            {
                txtName.Text = staffTbl[0].StaffName;
                txtFamily.Text = staffTbl[0].StaffFamily;

                txtWordStaff.Text = staffTbl[0].StaffWords;
                txtDetails.Text = staffTbl[0].StaffDetail;
                txtPhone.Text = staffTbl[0].SatffTel;
                txtMobile.Text = staffTbl[0].StaffMobile;

                txtInstagram.Text = staffTbl[0].StaffCertificate;
                txtTwitter.Text = staffTbl[0].StaffPicName;
                txtLinkedin.Text = staffTbl[0].StaffPicAddr;
                txtFabook.Text = staffTbl[0].StaffJobPosition;
                txtYoutube.Text = staffTbl[0].StaffUsername;

                txtEmail.Text = staffTbl[0].StaffEmail;

            }
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string errorMsg = string.Empty;

        tblStaffCollection staffTbl = new tblStaffCollection();
        staffTbl.ReadList(Criteria.NewCriteria(tblStaff.Columns.id, CriteriaOperators.Equal, 3));

        try
        {
            if (txtName.Text.Length > 0)
                staffTbl[0].StaffName = txtName.Text;
            else
                errorMsg = "* Please fill out the value <br />";

            staffTbl[0].StaffFamily = txtFamily.Text;
            staffTbl[0].StaffDetail = txtDetails.Text;


            staffTbl[0].SatffTel = txtPhone.Text;


            staffTbl[0].StaffMobile = txtMobile.Text;

            staffTbl[0].StaffEmail = txtEmail.Text;

            staffTbl[0].StaffCertificate = txtInstagram.Text;
            staffTbl[0].StaffPicName = txtTwitter.Text;
            staffTbl[0].StaffPicAddr = txtLinkedin.Text;
            staffTbl[0].StaffJobPosition = txtFabook.Text;

            staffTbl[0].StaffUsername = txtYoutube.Text;






            //compDetailsTbl.UpdateList(true);
            staffTbl[0].Update();
            ErrorMassage.InnerHtml = "Update is successfully done";

        }
        catch (Exception ex)
        {
            ErrorMassage.InnerHtml = errorMsg + " (" + ex + " )";
            throw;
        }

    }
}