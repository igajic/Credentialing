using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.IO;
using System.Web.UI;

namespace Credentialing.Web.Steps
{
    public partial class OtherStateMedicalProfessionalLicenses : Page
    {
        private const int CurrentStep = 10;

        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            btnNext.Click += btnNext_Click;
            btnPrevious.Click += btnPrevious_Click;
            lbReview.Click += lbReview_Click;

            if (!IsPostBack)
            {
                var data = LoadUserData();

                //LoadFormData(data);
            }
        }

        #endregion [Protected methods]

        #region [Private methods]

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Response.Redirect(StepsHelper.Instance.AppSteps[CurrentStep - 1].Url, true);
            Response.End();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                SaveFormData();
                Response.Redirect(StepsHelper.Instance.AppSteps[CurrentStep + 1].Url);
                Response.End();
            }
        }

        private Entities.Data.OtherStateMedicalProfessionalLicenses LoadUserData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);

                StepsHelper.Instance.UpdateSteps(physicianFormData);

                if (physicianFormData != null && physicianFormData.OtherStateMedicalProfessionalLicense != null)
                {
                    return physicianFormData.OtherStateMedicalProfessionalLicense;
                }
            }

            return null;
        }

        private void SaveFormData()
        {
            var data = new Entities.Data.OtherStateMedicalProfessionalLicenses();

            data.PrimaryState = tboxPrimaryState.Text;
            data.PrimaryLicenseNumber = tboxPrimaryLicenseNumber.Text;
            data.PrimaryExpirationDate = DateHelper.ParseFullDate(tboxPrimaryExpirationDate.Text);
            data.PrimaryLastExpirationDate = DateHelper.ParseFullDate(tboxPrimaryLastExpirationDate.Text);

            data.SecondaryState = tboxSecondaryState.Text;
            data.SecondaryLicenseNumber = tboxSecondaryLicenseNumber.Text;
            data.SecondaryExpirationDate = DateHelper.ParseFullDate(tboxSecondaryExpirationDate.Text);
            data.SecondaryLastExpirationDate = DateHelper.ParseFullDate(tboxSecondaryLastExpirationDate.Text);

            data.TertiaryState = tboxTertiaryState.Text;
            data.TertiaryLicenseNumber = tboxTertiaryLicenseNumber.Text;
            data.TertiaryExpirationDate = DateHelper.ParseFullDate(tboxTertiaryExpirationDate.Text);
            data.TertiaryLastExpirationDate = DateHelper.ParseFullDate(tboxTertiaryLastExpirationDate.Text);

            if (fuAttachments.HasFiles)
            {
                foreach (var file in fuAttachments.PostedFiles)
                {
                    var attachment = new Attachment
                    {
                        FileName = file.FileName
                    };

                    using (MemoryStream ms = new MemoryStream())
                    {
                        file.InputStream.CopyTo(ms);
                        attachment.Content = ms.ToArray();
                    }

                    data.Attachments.Add(attachment);
                }
            }

            var user = MemberHelper.GetCurrentLoggedUser();
            var userId = (Guid)user.ProviderUserKey;

            PracticionersApplicationHandler.Instance.UpsertOtherStateMedicalProfessionalLicenses(data, userId);
        }

        private void LoadFormData(Entities.Data.OtherStateMedicalProfessionalLicenses data)
        {
            tboxPrimaryState.Text = data.PrimaryState;
            tboxPrimaryLicenseNumber.Text = data.PrimaryLicenseNumber;
            tboxPrimaryExpirationDate.Text = data.PrimaryExpirationDate.HasValue ? data.PrimaryExpirationDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxPrimaryLastExpirationDate.Text = data.PrimaryLastExpirationDate.HasValue ? data.PrimaryLastExpirationDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;

            tboxSecondaryState.Text = data.SecondaryState;
            tboxSecondaryLicenseNumber.Text = data.SecondaryLicenseNumber;
            tboxSecondaryExpirationDate.Text = data.SecondaryExpirationDate.HasValue ? data.SecondaryExpirationDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxSecondaryLastExpirationDate.Text = data.SecondaryLastExpirationDate.HasValue ? data.SecondaryLastExpirationDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;

            tboxTertiaryState.Text = data.TertiaryState;
            tboxTertiaryLicenseNumber.Text = data.TertiaryLicenseNumber;
            tboxTertiaryExpirationDate.Text = data.TertiaryExpirationDate.HasValue ? data.TertiaryExpirationDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxTertiaryLastExpirationDate.Text = data.TertiaryLastExpirationDate.HasValue ? data.TertiaryLastExpirationDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;

            ucAttachments.Attachments = data.Attachments;
        }

        private bool ValidateFields()
        {
            var retVal = true;

            if (!string.IsNullOrWhiteSpace(tboxPrimaryExpirationDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxPrimaryExpirationDate);
            }

            if (!string.IsNullOrWhiteSpace(tboxPrimaryLastExpirationDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxPrimaryLastExpirationDate) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxSecondaryExpirationDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxSecondaryExpirationDate) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxSecondaryLastExpirationDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxSecondaryLastExpirationDate) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxTertiaryExpirationDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxTertiaryExpirationDate) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxTertiaryLastExpirationDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxTertiaryLastExpirationDate) && retVal;
            }

            return retVal;
        }

        private void lbReview_Click(object sender, EventArgs e)
        {
            var formData = LoadUserData() ?? new Entities.Data.OtherStateMedicalProfessionalLicenses();

            formData.Completed = true;

            var user = MemberHelper.GetCurrentLoggedUser();

            PracticionersApplicationHandler.Instance.UpsertOtherStateMedicalProfessionalLicenses(formData, (Guid)user.ProviderUserKey);

            Response.Redirect("/Dashboard/Physician.aspx");
            Response.End();
        }

        #endregion [Private methods]
    }
}