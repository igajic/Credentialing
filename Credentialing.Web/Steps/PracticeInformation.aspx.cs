using Credentialing.Business.Helpers;
using System;
using System.Web.UI;

namespace Credentialing.Web.Steps
{
    public partial class PracticeInformation : Page
    {
        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            btnPrevious.Click += btnPrevious_Click;
            btnNext.Click += btnNext_Click;
        }

        #endregion [Protected methods]

        #region [Private methods]

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                SaveFormData();

                Response.Redirect("/Steps/Education.aspx");
                Response.End();
            }
        }

        private bool Validate()
        {
            var retVal = true;

            retVal = ValidationHelper.ValidateTextbox(tboxPracticeName) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxDepartmentName) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxPrimaryOfficeStreetAddress) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxPrimaryOfficeCityStateZip) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxPrimaryOfficeTelephoneNumber) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxPrimaryOfficeFaxNumber) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxPrimaryOfficeManagerAdministrator) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxPrimaryOfficeManagerTelephoneNumber) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxPrimaryOfficeManagerFaxNumber) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxPrimaryOfficeNameTaxIdNumber) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxPrimaryOfficeFederalTaxIdNumber) && retVal;

            // secondary office
            retVal = ValidationHelper.ValidateTextbox(tboxSecondaryOfficeStreetAddress) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxSecondaryOfficeCity) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxSecondaryOfficeState) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxSecondaryOfficeZip) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxSecondaryOfficeManagerAdministrator) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxSecondaryOfficeManagerTelephoneNumber) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxSecondaryOfficeManagerFaxNumber) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxSecondaryOfficeNameTaxIdNumber) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxSecondaryOfficeFederalTaxIdNumber) && retVal;

            // tertiary office
            retVal = ValidationHelper.ValidateTextbox(tboxTertiaryOfficeStreetAddress) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxTertiaryOfficeCity) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxTertiaryOfficeState) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxTertiaryOfficeZip) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxTertiaryOfficeManagerAdministrator) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxTertiaryOfficeManagerTelephoneNumber) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxTertiaryOfficeManagerFaxNumber) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxTertiaryOfficeNameTaxIdNumber) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxTertiaryOfficeFederalTaxIdNumber) && retVal;

            return retVal;

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Steps/IdentifyingInformation.aspx");
            Response.End();
        }

        private void LoadFormData(Entities.Data.PracticeInformation formData)
        {
            tboxPracticeName.Text = formData.PracticeName;
            tboxDepartmentName.Text = formData.DepartmentName;
            tboxPrimaryOfficeStreetAddress.Text = formData.PrimaryOfficeStreetAddress;
            tboxPrimaryOfficeCityStateZip.Text = formData.PrimaryOfficeCityStateZip;
            tboxPrimaryOfficeTelephoneNumber.Text = formData.PrimaryOfficeTelephoneNumber;
            tboxPrimaryOfficeFaxNumber.Text = formData.PrimaryOfficeFaxNumber;
            tboxPrimaryOfficeManagerAdministrator.Text = formData.PrimaryOfficeManagerAdministrator;
            tboxPrimaryOfficeManagerTelephoneNumber.Text = formData.PrimaryOfficeManagerAdministratorTelephoneNumber;
            tboxPrimaryOfficeManagerFaxNumber.Text = formData.PrimaryOfficeManagerAdministratorFaxNumber;
            tboxPrimaryOfficeNameTaxIdNumber.Text = formData.PrimaryOfficeNameAffiliatedWithTaxIdNumber;
            tboxPrimaryOfficeFederalTaxIdNumber.Text = formData.PrimaryOfficeFederalTaxIdNumber;

            // secondary office
            tboxSecondaryOfficeStreetAddress.Text = formData.SecondaryOfficeStreetAddress;
            tboxSecondaryOfficeCity.Text = formData.SecondaryOfficeCity;
            tboxSecondaryOfficeState.Text = formData.SecondaryOfficeState;
            tboxSecondaryOfficeZip.Text = formData.SecondaryOfficeZip;
            tboxSecondaryOfficeManagerAdministrator.Text = formData.SecondaryOfficeManagerAdministrator;
            tboxSecondaryOfficeManagerTelephoneNumber.Text = formData.SecondaryOfficeManagerAdministratorTelephoneNumber;
            tboxSecondaryOfficeManagerFaxNumber.Text = formData.SecondaryOfficeManagerAdministratorFaxNumber;
            tboxSecondaryOfficeNameTaxIdNumber.Text = formData.SecondaryOfficeNameAffiliatedWithTaxIdNumber;
            tboxSecondaryOfficeFederalTaxIdNumber.Text = formData.SecondaryOfficeFederalTaxIdNumber;

            // tertiary office
            tboxTertiaryOfficeStreetAddress.Text = formData.TertiaryOfficeStreetAddress;
            tboxTertiaryOfficeCity.Text = formData.TertiaryOfficeCity;
            tboxTertiaryOfficeState.Text = formData.TertiaryOfficeState;
            tboxTertiaryOfficeZip.Text = formData.TertiaryOfficeZip;
            tboxTertiaryOfficeManagerAdministrator.Text = formData.TertiaryOfficeManagerAdministrator;
            tboxTertiaryOfficeManagerTelephoneNumber.Text = formData.TertiaryOfficeManagerAdministratorTelephoneNumber;
            tboxTertiaryOfficeManagerFaxNumber.Text = formData.TertiaryOfficeManagerAdministratorFaxNumber;
            tboxTertiaryOfficeNameTaxIdNumber.Text = formData.TertiaryOfficeNameAffiliatedWithTaxIdNumber;
            tboxTertiaryOfficeFederalTaxIdNumber.Text = formData.TertiaryOfficeFederalTaxIdNumber;
        }

        private void SaveFormData()
        {
            var formData = new Entities.Data.PracticeInformation();

            formData.PracticeName = tboxPracticeName.Text;
            formData.DepartmentName = tboxDepartmentName.Text;
            formData.PrimaryOfficeStreetAddress = tboxPrimaryOfficeStreetAddress.Text;
            formData.PrimaryOfficeCityStateZip = tboxPrimaryOfficeCityStateZip.Text;
            formData.PrimaryOfficeTelephoneNumber = tboxPrimaryOfficeTelephoneNumber.Text;
            formData.PrimaryOfficeFaxNumber = tboxPrimaryOfficeFaxNumber.Text;
            formData.PrimaryOfficeManagerAdministrator = tboxPrimaryOfficeManagerAdministrator.Text;
            formData.PrimaryOfficeManagerAdministratorTelephoneNumber = tboxPrimaryOfficeManagerTelephoneNumber.Text;
            formData.PrimaryOfficeManagerAdministratorFaxNumber = tboxPrimaryOfficeManagerFaxNumber.Text;
            formData.PrimaryOfficeNameAffiliatedWithTaxIdNumber = tboxPrimaryOfficeNameTaxIdNumber.Text;
            formData.PrimaryOfficeFederalTaxIdNumber = tboxPrimaryOfficeFederalTaxIdNumber.Text;

            // secondary office
            formData.SecondaryOfficeStreetAddress = tboxSecondaryOfficeStreetAddress.Text;
            formData.SecondaryOfficeCity = tboxSecondaryOfficeCity.Text;
            formData.SecondaryOfficeState = tboxSecondaryOfficeState.Text;
            formData.SecondaryOfficeZip = tboxSecondaryOfficeZip.Text;
            formData.SecondaryOfficeManagerAdministrator = tboxSecondaryOfficeManagerAdministrator.Text;
            formData.SecondaryOfficeManagerAdministratorTelephoneNumber = tboxSecondaryOfficeManagerTelephoneNumber.Text;
            formData.SecondaryOfficeManagerAdministratorFaxNumber = tboxSecondaryOfficeManagerFaxNumber.Text;
            formData.SecondaryOfficeNameAffiliatedWithTaxIdNumber = tboxSecondaryOfficeNameTaxIdNumber.Text;
            formData.SecondaryOfficeFederalTaxIdNumber = tboxSecondaryOfficeFederalTaxIdNumber.Text;

            // tertiary office
            formData.TertiaryOfficeStreetAddress = tboxTertiaryOfficeStreetAddress.Text;
            formData.TertiaryOfficeCity = tboxTertiaryOfficeCity.Text;
            formData.TertiaryOfficeState = tboxTertiaryOfficeState.Text;
            formData.TertiaryOfficeZip = tboxTertiaryOfficeZip.Text;
            formData.TertiaryOfficeManagerAdministrator = tboxTertiaryOfficeManagerAdministrator.Text;
            formData.TertiaryOfficeManagerAdministratorTelephoneNumber = tboxTertiaryOfficeManagerTelephoneNumber.Text;
            formData.TertiaryOfficeManagerAdministratorFaxNumber = tboxTertiaryOfficeManagerFaxNumber.Text;
            formData.TertiaryOfficeNameAffiliatedWithTaxIdNumber = tboxTertiaryOfficeNameTaxIdNumber.Text;
            formData.TertiaryOfficeFederalTaxIdNumber = tboxTertiaryOfficeFederalTaxIdNumber.Text;
        }

        #endregion [Private methods]
    }
}