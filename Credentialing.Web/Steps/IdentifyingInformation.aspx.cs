using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities.Data;
using Credentialing.Entities.Enums;
using System;
using System.Globalization;
using System.Web.UI;
using Credentialing.Entities;

namespace Credentialing.Web.Steps
{
    public partial class IdentifyingInformation : Page
    {
        private int CurrentStep = 1;

        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            btnNext.Click += btnNext_Click;
            btnPrevious.Click += btnPrevious_Click;
            lbReview.Click += lbReview_Click;

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

        private bool ValidateFields()
        {
            bool retVal = true;

            if (!string.IsNullOrWhiteSpace(tboxBirthDate.Text))
            {
                retVal = ValidationHelper.ValidateFullDate(tboxBirthDate) && retVal;
            }

            return retVal;
        }

        private Entities.Data.IdentifyingInformation LoadUserData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);

                StepsHelper.Instance.UpdateSteps(physicianFormData);

                if (physicianFormData != null)
                {

                    return physicianFormData.IdentifyingInformation;
                }
            }

            return null;
        }

        private void LoadFormData(Entities.Data.IdentifyingInformation formData)
        {
            if(formData == null) return;

            tboxLastName.Text = formData.LastName;
            tboxFirstName.Text = formData.FirstName;
            tboxMiddleName.Text = formData.MiddleName;
            tboxOtherKnownNames.Text = formData.OtherKnownNames;
            tboxHomeMailingAddress.Text = formData.HomeMailingAddress;
            tboxCity.Text = formData.City;
            tboxState.Text = formData.State;
            tboxZip.Text = formData.Zip;
            tboxHomeTelephoneNumber.Text = formData.HomeTelephoneNumber;
            tboxHomeFaxNumber.Text = formData.HomeFaxNumber;
            tboxEmailAddress.Text = formData.EmailAddress;
            tboxPagerNumber.Text = formData.PagerNumber;
            tboxBirthDate.Text = formData.BirthDate.HasValue ? formData.BirthDate.Value.ToString("MM/dd/yyyy") : string.Empty;
            tboxBirthPlace.Text = formData.BirthPlace;
            tboxSocialSecurityNumber.Text = formData.SocialSecurityNumber;
            tboxSpecialty.Text = formData.Specialty;
            tboxRaceEthnicity.Text = formData.RaceEthnicity;
            tboxSubspeciality.Text = formData.Subspecialties;

            if (formData.Gender == Gender.Female)
            {
                rbtnFemale.Checked = true;
            }
            else if (formData.Gender == Gender.Male)
            {
                rbtnMale.Checked = true;
            }
            else
            {
                rbtnMale.Checked = false;
                rbtnFemale.Checked = false;
            }

            if (formData.AttachmentId.HasValue)
            {
                hlAttachment.Text = formData.Attachment.FileName;
                hlAttachment.NavigateUrl = string.Format("/Handlers/DownloadAttachment.ashx?{0}={1}", Constants.RequestParameters.AttachmentId, formData.AttachmentId);
                hlAttachment.Visible = true;
            }
            else
            {
                hlAttachment.Visible = false;
            }
        }

        private void SaveFormData()
        {
            var formData = LoadUserData() ?? new Entities.Data.IdentifyingInformation();

            formData.LastName = tboxLastName.Text;
            formData.FirstName = tboxFirstName.Text;
            formData.MiddleName = tboxMiddleName.Text;
            formData.OtherKnownNames = tboxOtherKnownNames.Text;
            formData.HomeMailingAddress = tboxHomeMailingAddress.Text;
            formData.City = tboxCity.Text;
            formData.State = tboxState.Text;
            formData.Zip = tboxZip.Text;
            formData.HomeTelephoneNumber = tboxHomeTelephoneNumber.Text;
            formData.HomeFaxNumber = tboxHomeFaxNumber.Text;
            formData.EmailAddress = tboxEmailAddress.Text;
            formData.PagerNumber = tboxPagerNumber.Text;
            formData.BirthDate = string.IsNullOrWhiteSpace(tboxBirthDate.Text) ? (DateTime?)null : DateTime.Parse(tboxBirthDate.Text, new CultureInfo("en-US"));
            formData.BirthPlace = tboxBirthPlace.Text;
            formData.SocialSecurityNumber = tboxSocialSecurityNumber.Text;
            formData.Specialty = tboxSpecialty.Text;
            formData.RaceEthnicity = tboxRaceEthnicity.Text;
            formData.Subspecialties = tboxSubspeciality.Text;

            if (rbtnMale.Checked)
            {
                formData.Gender = Gender.Male;
            }
            else if (rbtnFemale.Checked)
            {
                formData.Gender = Gender.Female;
            }
            else
            {
                formData.Gender = null;
            }

            if (fuAlienRegistrationCard.HasFile)
            {
                formData.Attachment = new Attachment
                {
                    FileName = fuAlienRegistrationCard.FileName,
                    Content = fuAlienRegistrationCard.FileBytes
                };
            }

            var user = MemberHelper.GetCurrentLoggedUser();

            PracticionersApplicationHandler.Instance.UpsertIdentifyingInformation(formData, (Guid)user.ProviderUserKey);
        }

        private void lbReview_Click(object sender, EventArgs e)
        {
            var formData = LoadUserData() ?? new Entities.Data.IdentifyingInformation();

            formData.Completed = true;

            var user = MemberHelper.GetCurrentLoggedUser();

            PracticionersApplicationHandler.Instance.UpsertIdentifyingInformation(formData, (Guid)user.ProviderUserKey);

            Response.Redirect("/Dashboard/Physician.aspx");
            Response.End();
        }

        #endregion [Private methods]
    }
}