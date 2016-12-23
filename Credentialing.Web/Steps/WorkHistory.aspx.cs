using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.IO;
using System.Web.UI;

namespace Credentialing.Web.Steps
{
    public partial class WorkHistory : Page
    {
        private const int CurrentStep = 13;

        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            btnNext.Click += btnNext_Click;
            btnPrevious.Click += btnPrevious_Click;

            if (!IsPostBack)
            {
                var data = LoadUserData();

                LoadFormData(data);
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

        private Entities.Data.WorkHistory LoadUserData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);

                StepsHelper.Instance.UpdateSteps(physicianFormData);

                if (physicianFormData != null && physicianFormData.WorkHistory != null)
                {
                    return physicianFormData.WorkHistory;
                }
            }

            return null;
        }

        private void LoadFormData(Entities.Data.WorkHistory data)
        {
            if (data == null) return;

            tboxPrimaryNamePracticeEmployer.Text = data.PrimaryNamePracticeEmployer;
            tboxPrimaryContactName.Text = data.PrimaryContactName;
            tboxPrimaryTelephoneNumber.Text = data.PrimaryTelephoneNumber;
            tboxPrimaryFaxNumber.Text = data.PrimaryFaxNumber;
            tboxPrimaryPracticeAddress.Text = data.PrimaryPracticeAddress;
            tboxPrimaryCity.Text = data.PrimaryCity;
            tboxPrimaryState.Text = data.PrimaryState;
            tboxPrimaryZip.Text = data.PrimaryZip;
            tboxPrimaryStartDate.Text = data.PrimaryStartDate.HasValue ? data.PrimaryStartDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxPrimaryEndDate.Text = data.PrimaryEndDate.HasValue ? data.PrimaryEndDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;

            tboxSecondaryNamePracticeEmployer.Text = data.SecondaryNamePracticeEmployer;
            tboxSecondaryContactName.Text = data.SecondaryContactName;
            tboxSecondaryTelephoneNumber.Text = data.SecondaryTelephoneNumber;
            tboxSecondaryFaxNumber.Text = data.SecondaryFaxNumber;
            tboxSecondaryPracticeAddress.Text = data.SecondaryPracticeAddress;
            tboxSecondaryCity.Text = data.SecondaryCity;
            tboxSecondaryState.Text = data.SecondaryState;
            tboxSecondaryZip.Text = data.SecondaryZip;
            tboxSecondaryStartDate.Text = data.SecondaryStartDate.HasValue ? data.SecondaryStartDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxSecondaryEndDate.Text = data.SecondaryEndDate.HasValue ? data.SecondaryEndDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;

            tboxTertiaryNamePracticeEmployer.Text = data.TertiaryNamePracticeEmployer;
            tboxTertiaryContactName.Text = data.TertiaryContactName;
            tboxTertiaryTelephoneNumber.Text = data.TertiaryTelephoneNumber;
            tboxTertiaryFaxNumber.Text = data.TertiaryFaxNumber;
            tboxTertiaryPracticeAddress.Text = data.TertiaryPracticeAddress;
            tboxTertiaryCity.Text = data.TertiaryCity;
            tboxTertiaryState.Text = data.TertiaryState;
            tboxTertiaryZip.Text = data.TertiaryZip;
            tboxTertiaryStartDate.Text = data.TertiaryStartDate.HasValue ? data.TertiaryStartDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;
            tboxTertiaryEndDate.Text = data.TertiaryEndDate.HasValue ? data.TertiaryEndDate.Value.ToString(Constants.DateFormats.FullDateFormat) : string.Empty;

            tboxExplanation.Text = data.Explanation;
        }

        private void SaveFormData()
        {
            var data = LoadUserData() ?? new Entities.Data.WorkHistory();

            data.PrimaryNamePracticeEmployer = tboxPrimaryNamePracticeEmployer.Text;
            data.PrimaryContactName = tboxPrimaryContactName.Text;
            data.PrimaryTelephoneNumber = tboxPrimaryTelephoneNumber.Text;
            data.PrimaryFaxNumber = tboxPrimaryFaxNumber.Text;
            data.PrimaryPracticeAddress = tboxPrimaryPracticeAddress.Text;
            data.PrimaryCity = tboxPrimaryCity.Text;
            data.PrimaryState = tboxPrimaryState.Text;
            data.PrimaryZip = tboxPrimaryZip.Text;
            data.PrimaryStartDate = DateHelper.ParseFullDate(tboxPrimaryStartDate.Text);
            data.PrimaryEndDate = DateHelper.ParseFullDate(tboxPrimaryEndDate.Text);

            data.SecondaryNamePracticeEmployer = tboxSecondaryNamePracticeEmployer.Text;
            data.SecondaryContactName = tboxSecondaryContactName.Text;
            data.SecondaryTelephoneNumber = tboxSecondaryTelephoneNumber.Text;
            data.SecondaryFaxNumber = tboxSecondaryFaxNumber.Text;
            data.SecondaryPracticeAddress = tboxSecondaryPracticeAddress.Text;
            data.SecondaryCity = tboxSecondaryCity.Text;
            data.SecondaryState = tboxSecondaryState.Text;
            data.SecondaryZip = tboxSecondaryZip.Text;
            data.SecondaryStartDate = DateHelper.ParseFullDate(tboxSecondaryStartDate.Text);
            data.SecondaryEndDate = DateHelper.ParseFullDate(tboxSecondaryEndDate.Text);

            data.TertiaryNamePracticeEmployer = tboxTertiaryNamePracticeEmployer.Text;
            data.TertiaryContactName = tboxTertiaryContactName.Text;
            data.TertiaryTelephoneNumber = tboxTertiaryTelephoneNumber.Text;
            data.TertiaryFaxNumber = tboxTertiaryFaxNumber.Text;
            data.TertiaryPracticeAddress = tboxTertiaryPracticeAddress.Text;
            data.TertiaryCity = tboxTertiaryCity.Text;
            data.TertiaryState = tboxTertiaryState.Text;
            data.TertiaryZip = tboxTertiaryZip.Text;
            data.TertiaryStartDate = DateHelper.ParseFullDate(tboxTertiaryStartDate.Text);
            data.TertiaryEndDate = DateHelper.ParseFullDate(tboxTertiaryEndDate.Text);

            tboxExplanation.Text = data.Explanation;

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

            PracticionersApplicationHandler.Instance.UpsertWorkHistory(data, userId);
        }

        private bool ValidateFields()
        {
            var retVal = true;

            if (!string.IsNullOrWhiteSpace(tboxPrimaryStartDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxPrimaryStartDate);
            }

            if (!string.IsNullOrWhiteSpace(tboxPrimaryEndDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxPrimaryEndDate);
            }

            if (!string.IsNullOrWhiteSpace(tboxSecondaryStartDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxSecondaryStartDate);
            }

            if (!string.IsNullOrWhiteSpace(tboxSecondaryEndDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxSecondaryEndDate);
            }

            if (!string.IsNullOrWhiteSpace(tboxTertiaryStartDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxTertiaryStartDate);
            }

            if (!string.IsNullOrWhiteSpace(tboxTertiaryEndDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxTertiaryEndDate);
            }

            return retVal;
        }

        private void lbReview_Click(object sender, EventArgs e)
        {
            var formData = LoadUserData() ?? new Entities.Data.WorkHistory();

            formData.Completed = true;

            var user = MemberHelper.GetCurrentLoggedUser();

            PracticionersApplicationHandler.Instance.UpsertWorkHistory(formData, (Guid)user.ProviderUserKey);

            Response.Redirect("/Dashboard/Physician.aspx");
            Response.End();
        }

        #endregion [Private methods]
    }
}