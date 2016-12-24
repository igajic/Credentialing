using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using System;
using System.Web.UI;

namespace Credentialing.Web.Steps
{
    public partial class PracticeInformation : Page
    {
        private const int CurrentStep = 2;

        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            btnPrevious.Click += btnPrevious_Click;
            btnNext.Click += btnNext_Click;
            lbReview.Click += lbReview_Click;

            if (!IsPostBack)
            {
                var data = LoadUserData();

                LoadFormData(data);
            }
        }

        #endregion [Protected methods]

        #region [Private methods]

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveFormData();

            Response.Redirect(StepsHelper.Instance.AppSteps[CurrentStep + 1].Url);
            Response.End();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Response.Redirect(StepsHelper.Instance.AppSteps[CurrentStep - 1].Url);
            Response.End();
        }

        private Entities.Data.PracticeInformation LoadUserData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);

                StepsHelper.Instance.UpdateSteps(physicianFormData);

                if (physicianFormData != null && physicianFormData.PracticeInformation != null)
                {
                    return physicianFormData.PracticeInformation;
                }
            }

            return null;
        }

        private void LoadFormData(Entities.Data.PracticeInformation formData)
        {
            if (formData == null) return;

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
            var formData = LoadUserData() ?? new Entities.Data.PracticeInformation();

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

            var user = MemberHelper.GetCurrentLoggedUser();
            var userId = (Guid)user.ProviderUserKey;

            PracticionersApplicationHandler.Instance.UpsertPracticeInformation(formData, userId);
        }

        private void lbReview_Click(object sender, EventArgs e)
        {
            var formData = LoadUserData() ?? new Entities.Data.PracticeInformation();

            formData.Completed = true;

            var user = MemberHelper.GetCurrentLoggedUser();

            PracticionersApplicationHandler.Instance.UpsertPracticeInformation(formData, (Guid)user.ProviderUserKey);

            Response.Redirect("/Dashboard/Physician.aspx");
            Response.End();
        }

        #endregion [Private methods]
    }
}