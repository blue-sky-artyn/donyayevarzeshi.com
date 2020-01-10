using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cruder.Core;

public partial class admin_company_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //tblCompanyDetailCollection coDetails = new tblCompanyDetailCollection();
        //coDetails.ReadList();

        //if (coDetails.Count > 0)
        //{
        //    txtCoName.Text = coDetails[0].CompanyName;
        //    txtCoOwner.Text = coDetails[0].CompanyOwner;
        //    txtLat.Text = coDetails[0].CompanyLocA;
        //    txtLong.Text = coDetails[0].CompanyLocB;
        //    txtAddr.Text = coDetails[0].CompanyAddr;
        //    txtPhone.Text = coDetails[0].CompanyTel;
        //    txtFax.Text = coDetails[0].CompanyFax;
        //    txtEmail.Text = coDetails[0].CompanyEmail;
        //    txtWebsite.Text = coDetails[0].CompanyWebsite;
        //    txtDetails.Text = coDetails[0].CompanyDetails;
        //}
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string errorMsg = string.Empty;

        //tblCompanyDetailCollection compDetailsTbl = new tblCompanyDetailCollection();
        //compDetailsTbl.ReadList();

        ////try
        ////{
        //if (txtCoName.Text.Length > 0)
        //        compDetailsTbl[0].CompanyName = txtCoName.Text;
        //    else
        //        errorMsg = "* Please fill out the company name <br />";

        //    if (txtCoOwner.Text.Length > 0)
        //        compDetailsTbl[0].CompanyOwner = txtCoOwner.Text;
        //    else
        //        compDetailsTbl[0].CompanyOwner = "";

        //    if (txtLat.Text.Length > 0)
        //        compDetailsTbl[0].CompanyLocA = txtLat.Text;
        //    else
        //        errorMsg += "* Please fill out the latitude <br />";

        //    if (txtLong.Text.Length > 0)
        //        compDetailsTbl[0].CompanyLocB = txtLong.Text;
        //    else
        //        errorMsg += "* Please fill out the longitude <br />";

        //    if (txtAddr.Text.Length > 0)
        //        compDetailsTbl[0].CompanyAddr = txtAddr.Text;
        //    else
        //        errorMsg += "* Please fill out the address <br />";

        //    if (txtPhone.Text.Length > 0)
        //        compDetailsTbl[0].CompanyTel = txtPhone.Text;
        //    else
        //        errorMsg += "* Please fill out the phone number <br />";

        //    if (txtFax.Text.Length > 0)
        //        compDetailsTbl[0].CompanyFax = txtFax.Text;
        //    else
        //        errorMsg += "* Please fill out the Fax <br />";

        //    if (txtEmail.Text.Length > 0)
        //        compDetailsTbl[0].CompanyEmail = txtEmail.Text;
        //    else
        //        errorMsg += "* Please fill out the Email <br />";

        //    if (txtWebsite.Text.Length > 0)
        //        compDetailsTbl[0].CompanyWebsite = txtWebsite.Text;
        //    else
        //        compDetailsTbl[0].CompanyWebsite = "";

        //    if (txtDetails.Text.Length > 0)
        //        compDetailsTbl[0].CompanyDetails = txtDetails.Text;
        //    else
        //        compDetailsTbl[0].CompanyDetails = "";

        //    compDetailsTbl.UpdateList(true);
        //ErrorMassage.InnerHtml = "Update is successfully done";

        //}
        //catch (Exception)
        //{
        //    ErrorMassage.InnerHtml = errorMsg;
        //    throw;
        //}

    }
}