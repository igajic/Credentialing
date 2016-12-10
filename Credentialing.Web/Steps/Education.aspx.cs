using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities.Data;
using System;
using System.IO;
using System.Web.UI;

namespace Credentialing.Web.Steps
{
    public partial class Education : Page
    {
        public int CurrentStep = 3;

        #region [Protected regions]

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

        #endregion [Protected regions]

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

        private Entities.Data.Education LoadUserData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);

                StepsHelper.Instance.UpdateSteps(physicianFormData);

                if (physicianFormData != null && physicianFormData.Education != null)
                {
                    var data = EducationHandler.Instance.GetById(physicianFormData.EducationId.Value);

                    return data;
                }
            }

            return null;
        }

        private void LoadFormData(Entities.Data.Education data)
        {
            if (data == null) return;

            tboxCollegeUniversityName.Text = data.CollegeUniverityName;
            tboxDegreeReceived.Text = data.DegreeReceived;
            tboxDateOfGraduation.Text = data.DateGraduation.HasValue ? data.DateGraduation.Value.ToString("MM/yy") : string.Empty;
            tboxMailingAddress.Text = data.MailingAddress;
            tboxMailingCity.Text = data.MailingCity;
            tboxMailingState.Text = data.MailingState;
            tboxMailingZip.Text = data.MailingZip;
        }

        private void SaveFormData()
        {
            var formData = new Entities.Data.Education();

            formData.CollegeUniverityName = tboxCollegeUniversityName.Text;
            formData.DegreeReceived = tboxDegreeReceived.Text;
            formData.DateGraduation = string.IsNullOrWhiteSpace(tboxDateOfGraduation.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxDateOfGraduation.Text);
            formData.MailingAddress = tboxMailingAddress.Text;
            formData.MailingCity = tboxMailingCity.Text;
            formData.MailingState = tboxMailingState.Text;
            formData.MailingZip = tboxMailingZip.Text;

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

                    formData.AttachedDocuments.Add(attachment);
                }
            }

            var user = MemberHelper.GetCurrentLoggedUser();
            var userId = (Guid)user.ProviderUserKey;

            PracticionersApplicationHandler.Instance.UpsertEducation(formData, userId);
        }

        private bool ValidateFields()
        {
            var retVal = ValidationHelper.ValidateTextbox(tboxCollegeUniversityName);
            retVal = ValidationHelper.ValidateTextbox(tboxDegreeReceived) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxDateOfGraduation) && retVal;
            retVal = ValidationHelper.ValidateShortDate(tboxDateOfGraduation) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxMailingAddress) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxMailingCity) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxMailingState) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxMailingZip) && retVal;

            return retVal;
        }

        #endregion [Private methods]
    }
}