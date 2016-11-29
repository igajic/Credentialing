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
            SaveFormData();
            Response.Redirect("/Steps/PracticeInformation.aspx");
            Response.End();
        }

        private void LoadFormData(Entities.Steps.IdentifyingInformation formData)
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
            tboxBirthDate.Text = formData.BirthDate.ToString(); // TODO: Check date format
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
            var formData = new Entities.Steps.IdentifyingInformation();

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
            formData.BirthDate = DateTime.Parse(tboxBirthDate.Text); // TODO: Check date format
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
                formData.CitizenshipFile = new Attachment
                {
                    FileName = fuAlienRegistrationCard.FileName,
                    Content = fuAlienRegistrationCard.FileBytes
                };
            }
        }

        #endregion [Private methods]
    }
}