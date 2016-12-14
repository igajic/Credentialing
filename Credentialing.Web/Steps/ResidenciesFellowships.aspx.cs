using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities.Data;
using System;
using System.IO;
using System.Web.UI;

namespace Credentialing.Web.Steps
{
    public partial class ResidencesFellowships : Page
    {
        private const int CurrentStep = 6;

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

        private ResidenciesFellowship LoadUserData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);

                StepsHelper.Instance.UpdateSteps(physicianFormData);

                if (physicianFormData != null && physicianFormData.Internship != null)
                {
                    return physicianFormData.ResidenciesFellowship;
                }
            }

            return null;
        }

        private void SaveFormData()
        {
            var formData = new ResidenciesFellowship();

            formData.PrimaryInstitution = tboxInstitutionFirst.Text;
            formData.PrimaryProgramDirector = tboxProgramDirectorFirst.Text;
            formData.PrimaryMailingAddress = tboxMailingAddressFirst.Text;
            formData.PrimaryCity = tboxCityFirst.Text;
            formData.PrimaryState = tboxStateFirst.Text;
            formData.PrimaryTypeTraining = tboxTrainingTypeFirst.Text;
            formData.PrimarySpecialty = tboxSpecialtyFirst.Text;
            formData.PrimaryFrom = string.IsNullOrWhiteSpace(tboxFromDateFirst.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxFromDateFirst.Text);
            formData.PrimaryTo = string.IsNullOrWhiteSpace(tboxToDateFirst.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxToDateFirst.Text);

            if (rbtnProgramFirstYes.Checked)
            {
                formData.PrimaryCompleted = true;
            }
            else if (rbtnProgramFirstNo.Checked)
            {
                formData.PrimaryCompleted = false;
            }
            else
            {
                formData.PrimaryCompleted = null;
            }

            formData.SecondaryInstitution = tboxInstitutionSecond.Text;
            formData.SecondaryProgramDirector = tboxProgramDirectorSecond.Text;
            formData.SecondaryMailingAddress = tboxMailingAddressSecond.Text;
            formData.SecondaryCity = tboxCitySecond.Text;
            formData.SecondaryState = tboxStateSecond.Text;
            formData.SecondaryTypeTraining = tboxTrainingTypeSecond.Text;
            formData.SecondarySpecialty = tboxSpecialtySecond.Text;
            formData.SecondaryFrom = string.IsNullOrWhiteSpace(tboxFromDateSecond.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxFromDateSecond.Text);
            formData.SecondaryTo = string.IsNullOrWhiteSpace(tboxToDateSecond.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxToDateSecond.Text);

            if (rbtnProgramSecondYes.Checked)
            {
                formData.SecondaryCompleted = true;
            }
            else if (rbtnProgramSecondNo.Checked)
            {
                formData.SecondaryCompleted = false;
            }
            else
            {
                formData.SecondaryCompleted = null;
            }

            formData.TertiaryInstitution = tboxInstitutionThird.Text;
            formData.TertiaryProgramDirector = tboxProgramDirectorThird.Text;
            formData.TertiaryMailingAddress = tboxMailingAddressThird.Text;
            formData.TertiaryCity = tboxCityThird.Text;
            formData.TertiaryState = tboxStateThird.Text;
            formData.TertiaryTypeTraining = tboxTrainingTypeThird.Text;
            formData.TertiarySpecialty = tboxSpecialtyThird.Text;
            formData.TertiaryFrom = string.IsNullOrWhiteSpace(tboxFromDateThird.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxFromDateThird.Text);
            formData.TertiaryTo = string.IsNullOrWhiteSpace(tboxToDateThird.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxToDateThird.Text);

            if (rbtnProgramThirdYes.Checked)
            {
                formData.TertiaryCompleted = true;
            }
            else if (rbtnProgramThirdNo.Checked)
            {
                formData.TertiaryCompleted = false;
            }
            else
            {
                formData.TertiaryCompleted = null;
            }

            if (fuResidencies.HasFiles)
            {
                foreach (var file in fuResidencies.PostedFiles)
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

            PracticionersApplicationHandler.Instance.UpsertResidenciesFellowship(formData, userId);
        }

        private bool ValidateFields()
        {
            bool retVal = true;

            if (!string.IsNullOrWhiteSpace(tboxFromDateFirst.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxFromDateFirst) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxToDateFirst.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxToDateFirst) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxFromDateSecond.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxFromDateSecond) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxToDateSecond.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxToDateSecond) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxFromDateThird.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxFromDateThird) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxToDateThird.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxToDateThird) && retVal;
            }

            return retVal;
        }

        private void LoadFormData(ResidenciesFellowship formData)
        {
            if (formData == null) return;

            tboxInstitutionFirst.Text = formData.PrimaryInstitution;
            tboxProgramDirectorFirst.Text = formData.PrimaryProgramDirector;
            tboxMailingAddressFirst.Text = formData.PrimaryMailingAddress;
            tboxCityFirst.Text = formData.PrimaryCity;
            tboxStateFirst.Text = formData.PrimaryState;
            tboxTrainingTypeFirst.Text = formData.PrimaryTypeTraining;
            tboxSpecialtyFirst.Text = formData.PrimarySpecialty;
            tboxFromDateFirst.Text = formData.PrimaryFrom.HasValue ? formData.PrimaryFrom.Value.ToString("MM/yy") : string.Empty;
            tboxToDateFirst.Text = formData.PrimaryTo.HasValue ? formData.PrimaryTo.Value.ToString("MM/yy") : string.Empty;

            if (formData.PrimaryCompleted.HasValue)
            {
                if (formData.PrimaryCompleted.Value) rbtnProgramFirstYes.Checked = true;
                else rbtnProgramFirstNo.Checked = true;
            }
            else
            {
                rbtnProgramFirstNo.Checked = false;
                rbtnProgramFirstYes.Checked = false;
            }

            tboxInstitutionSecond.Text = formData.SecondaryInstitution;
            tboxProgramDirectorSecond.Text = formData.SecondaryProgramDirector;
            tboxMailingAddressSecond.Text = formData.SecondaryMailingAddress;
            tboxCitySecond.Text = formData.SecondaryCity;
            tboxStateSecond.Text = formData.SecondaryState;
            tboxTrainingTypeSecond.Text = formData.SecondaryTypeTraining;
            tboxSpecialtySecond.Text = formData.SecondarySpecialty;
            tboxFromDateSecond.Text = formData.SecondaryFrom.HasValue ? formData.SecondaryFrom.Value.ToString("MM/yy") : string.Empty;
            tboxToDateSecond.Text = formData.SecondaryTo.HasValue ? formData.SecondaryTo.Value.ToString("MM/yy") : string.Empty;

            if (formData.SecondaryCompleted.HasValue)
            {
                if (formData.SecondaryCompleted.Value) rbtnProgramSecondYes.Checked = true;
                else rbtnProgramSecondNo.Checked = true;
            }
            else
            {
                rbtnProgramSecondNo.Checked = false;
                rbtnProgramSecondYes.Checked = false;
            }

            tboxInstitutionThird.Text = formData.TertiaryInstitution;
            tboxProgramDirectorThird.Text = formData.TertiaryProgramDirector;
            tboxMailingAddressThird.Text = formData.TertiaryMailingAddress;
            tboxCityThird.Text = formData.TertiaryCity;
            tboxStateThird.Text = formData.TertiaryState;
            tboxTrainingTypeThird.Text = formData.TertiaryTypeTraining;
            tboxSpecialtyThird.Text = formData.TertiarySpecialty;
            tboxFromDateThird.Text = formData.TertiaryFrom.HasValue ? formData.TertiaryFrom.Value.ToString("MM/yy") : string.Empty;
            tboxToDateThird.Text = formData.TertiaryTo.HasValue ? formData.TertiaryTo.Value.ToString("MM/yy") : string.Empty;

            if (formData.TertiaryCompleted.HasValue)
            {
                if (formData.TertiaryCompleted.Value) rbtnProgramThirdYes.Checked = true;
                else rbtnProgramThirdNo.Checked = true;
            }
            else
            {
                rbtnProgramThirdNo.Checked = false;
                rbtnProgramThirdYes.Checked = false;
            }
        }

        #endregion [Private methods]
    }
}