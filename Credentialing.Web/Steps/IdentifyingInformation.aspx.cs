using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities.Data;
using Credentialing.Entities.Enums;
using System;
using System.Web.UI;

namespace Credentialing.Web.Steps
{
    public partial class IdentifyingInformation : Page
    {
        #region [Protected methods]

        protected void Page_Load(object sender, EventArgs e)
        {
            btnNext.Click += btnNext_Click;
            btnPrevious.Click += btnPrevious_Click;

            if (!IsPostBack)
            {
                LoadUserData();
            }
        }

        #endregion [Protected methods]

        #region [Private methods]

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Steps/Instructions.aspx", true);
            Response.End();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                SaveFormData();
                Response.Redirect("/Steps/PracticeInformation.aspx");
                Response.End();
            }
        }

        private bool ValidateFields()
        {
            bool retVal = true;

            retVal = ValidationHelper.ValidateTextbox(tboxLastName) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxFirstName) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxMiddleName) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxOtherKnownNames) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxHomeMailingAddress) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxCity) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxState) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxZip) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxHomeTelephoneNumber) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxHomeFaxNumber) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxEmailAddress) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxPagerNumber) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxBirthDate) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxBirthPlace) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxSocialSecurityNumber) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxSpecialty) && retVal;
            retVal = ValidationHelper.ValidateTextbox(tboxSubspeciality) && retVal;

            return retVal;
        }

        private void LoadUserData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey);

                if (physicianFormData != null && physicianFormData.IdentifyingInformationId.HasValue)
                {
                    var data = IdentifyingInformationHandler.Instance.GetById(physicianFormData.IdentifyingInformationId.Value);

                    LoadFormData(data);
                }
            }
        }

        private void LoadFormData(Entities.Data.IdentifyingInformation formData)
        {
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
            tboxBirthDate.Text = formData.BirthDate.ToString("MM/yy");
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
        }

        private void SaveFormData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey);

                var formData = new Entities.Data.IdentifyingInformation();

                if (physicianFormData.IdentifyingInformationId.HasValue)
                {
                    formData = IdentifyingInformationHandler.Instance.GetById(physicianFormData.IdentifyingInformationId.Value);
                }

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
                formData.BirthDate = DateHelper.ParseDate(tboxBirthDate.Text);
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
                    var attachment = new Attachment()
                    {
                        FileName = fuAlienRegistrationCard.FileName,
                        Content = fuAlienRegistrationCard.FileBytes
                    };

                    if (formData.AttachmentId.HasValue)
                    {
                        AttachmentHandler.Instance.Delete(formData.AttachmentId.Value);
                    }

                    var id = AttachmentHandler.Instance.Insert(attachment);
                    formData.AttachmentId = id;
                }

                if (formData.IdentifyingInformationId == 0)
                {
                    var id = IdentifyingInformationHandler.Instance.SaveIdentifyingInformation(formData);
                    physicianFormData.IdentifyingInformationId = id;

                    PracticionersApplicationHandler.Instance.Update(physicianFormData);
                }
                else
                {
                    IdentifyingInformationHandler.Instance.Update(formData);
                }
            }
        }

        #endregion [Private methods]
    }
}