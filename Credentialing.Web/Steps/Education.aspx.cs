using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities.Data;
using System;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using Credentialing.Entities;

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
            lbReview.Click += lbReview_Click;

            if (!IsPostBack)
            {
                var data = LoadUserData();

                //LoadFormData(data);
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
                //SaveFormData();
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
                    return physicianFormData.Education;
                }
            }

            return null;
        }

        private void LoadFormData(Entities.Data.Education data)
        {
            if (data == null) return;

            tboxCollegeUniversityName.Text = data.CollegeUniverityName;
            tboxDegreeReceived.Text = data.DegreeReceived;
            tboxDateOfGraduation.Text = data.DateGraduation.HasValue ? data.DateGraduation.Value.ToString(Constants.DateFormats.ShortDateFormat) : string.Empty;
            tboxMailingAddress.Text = data.MailingAddress;
            tboxMailingCity.Text = data.MailingCity;
            tboxMailingState.Text = data.MailingState;
            tboxMailingZip.Text = data.MailingZip;

            ucAttachments.Attachments = data.AttachedDocuments;
        }

        private void SaveFormData()
        {
            var formData = LoadUserData() ?? new Entities.Data.Education();

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
            var retVal = true;

            if (!string.IsNullOrWhiteSpace(tboxDateOfGraduation.Text))
            {

                retVal = ValidationHelper.ValidateShortDate(tboxDateOfGraduation);
            }

            return retVal;
        }

        private void lbReview_Click(object sender, EventArgs e)
        {
            var formData = LoadUserData() ?? new Entities.Data.Education();

            formData.Completed = true;

            var user = MemberHelper.GetCurrentLoggedUser();

            PracticionersApplicationHandler.Instance.UpsertEducation(formData, (Guid)user.ProviderUserKey);

            Response.Redirect("/Dashboard/Physician.aspx");
            Response.End();
        }

        #endregion [Private methods]
    }
}