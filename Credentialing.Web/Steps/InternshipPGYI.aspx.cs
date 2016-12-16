using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities.Data;
using System;
using System.IO;
using System.Web.UI;

namespace Credentialing.Web.Steps
{
    public partial class InternshipPGYI : Page
    {
        private const int CurrentStep = 5;

        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            btnNext.Click += btnNext_Click;
            btnPrevious.Click += btnPrevious_Click;

            if (!IsPostBack)
            {
                //var data = LoadUserData();
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
                //SaveFormData();
                Response.Redirect(StepsHelper.Instance.AppSteps[CurrentStep + 1].Url);
                Response.End();
            }
        }

        private void SaveFormData()
        {
            var formData = new Internship();

            formData.Institution = tboxInstitution.Text;
            formData.ProgramDirector = tboxProgramDirector.Text;
            formData.MailingAddress = tboxMailingAddress.Text;
            formData.City = tboxMailingCity.Text;
            formData.StateCountry = tboxMailingStateCountry.Text;
            formData.Zip = tboxMailingZip.Text;
            formData.TypeOfInternship = tboxTypeInternship.Text;
            formData.Specialty = tboxSpecialty.Text;
            formData.SpecialtyFrom = string.IsNullOrWhiteSpace(tboxFromDate.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxFromDate.Text);
            formData.SpecialtyFrom = string.IsNullOrWhiteSpace(tboxToDate.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxToDate.Text);

            if (fuInternship.HasFiles)
            {
                foreach (var file in fuInternship.PostedFiles)
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

                    formData.Attachments.Add(attachment);
                }
            }

            var user = MemberHelper.GetCurrentLoggedUser();
            var userId = (Guid)user.ProviderUserKey;

            PracticionersApplicationHandler.Instance.UpsertInternshipInformation(formData, userId);
        }

        private bool ValidateFields()
        {
            bool retVal = true;

            if (!string.IsNullOrWhiteSpace(tboxFromDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxFromDate) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxToDate.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxToDate) && retVal;
            }

            return retVal;
        }

        private Internship LoadUserData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);

                StepsHelper.Instance.UpdateSteps(physicianFormData);

                if (physicianFormData != null && physicianFormData.Internship != null)
                {
                    return physicianFormData.Internship;
                }
            }

            return null;
        }

        private void LoadFormData(Internship data)
        {
            if (data == null) return;
            tboxInstitution.Text = data.Institution;
            tboxProgramDirector.Text = data.ProgramDirector;
            tboxMailingAddress.Text = data.MailingAddress;
            tboxMailingCity.Text = data.City;
            tboxMailingStateCountry.Text = data.StateCountry;
            tboxMailingZip.Text = data.Zip;
            tboxTypeInternship.Text = data.TypeOfInternship;
            tboxSpecialty.Text = data.Specialty;
            tboxFromDate.Text = data.SpecialtyFrom.HasValue ? data.SpecialtyFrom.Value.ToString("MM/yy") : string.Empty;
            tboxToDate.Text = data.SpecialtyTo.HasValue ? data.SpecialtyTo.Value.ToString("MM/yy") : string.Empty;
        }

        private void lbReview_Click(object sender, EventArgs e)
        {
            var formData = LoadUserData() ?? new Entities.Data.Internship();

            formData.Completed = true;

            var user = MemberHelper.GetCurrentLoggedUser();

            PracticionersApplicationHandler.Instance.UpsertInternshipInformation(formData, (Guid)user.ProviderUserKey);

            Response.Redirect("/Dashboard/Physician.aspx");
            Response.End();
        }

        #endregion [Private methods]
    }
}