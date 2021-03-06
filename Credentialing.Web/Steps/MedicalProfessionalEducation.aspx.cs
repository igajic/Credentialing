﻿using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities.Data;
using System;
using System.IO;
using System.Web.UI;
using Credentialing.Entities;

namespace Credentialing.Web.Steps
{
    public partial class MedicalProfessionalEducation : Page
    {
        private const int CurrentStep = 4;

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

        private void SaveFormData()
        {
            var formData = LoadUserData() ?? new Entities.Data.MedicalProfessionalEducation();

            formData.PrimaryMedicalProfessionalSchool = tboxMedicalProfessionalSchoolFirst.Text;
            formData.PrimaryDegreeReceived = tboxDegreeReceivedFirst.Text;
            formData.PrimaryDateOfGraduation = string.IsNullOrWhiteSpace(tboxDateGraduationFirst.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxDateGraduationFirst.Text);
            formData.PrimaryMailingAddress = tboxMailingAdrressFirst.Text;
            formData.PrimaryCity = tboxMailingCityFirst.Text;
            formData.PrimaryStateCountry = tboxMailingStateFirst.Text;
            formData.PrimaryZip = tboxMailingZipFirst.Text;

            formData.SecondaryMedicalProfessionalSchool = tboxMedicalProfessionalSchoolSecond.Text;
            formData.SecondaryDegreeReceived = tboxDegreeReceivedSecond.Text;
            formData.SecondaryDateOfGraduation = string.IsNullOrWhiteSpace(tboxDateGraduationSecond.Text) ? (DateTime?)null : DateHelper.ParseDate(tboxDateGraduationSecond.Text);
            formData.SecondaryMailingAddress = tboxMailingAdrressSecond.Text;
            formData.SecondaryCity = tboxMailingCitySecond.Text;
            formData.SecondaryStateCountry = tboxMailingStateSecond.Text;
            formData.SecondaryZip = tboxMailingZipSecond.Text;

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

                    formData.Attachments.Add(attachment);
                }
            }

            var user = MemberHelper.GetCurrentLoggedUser();
            var userId = (Guid)user.ProviderUserKey;

            PracticionersApplicationHandler.Instance.UpsertMedicalProfessionalEducation(formData, userId);
        }

        private bool ValidateFields()
        {
            var retVal = true;

            if (!string.IsNullOrWhiteSpace(tboxDateGraduationFirst.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxDateGraduationFirst) && retVal;
            }

            if (!string.IsNullOrWhiteSpace(tboxDateGraduationSecond.Text))
            {
                retVal = ValidationHelper.ValidateShortDate(tboxDateGraduationSecond) && retVal;
            }

            return retVal;
        }

        private Entities.Data.MedicalProfessionalEducation LoadUserData()
        {
            var user = MemberHelper.GetCurrentLoggedUser();

            if (user != null && MemberHelper.IsUserPhysician(user.UserName))
            {
                var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId((Guid)user.ProviderUserKey, true);

                StepsHelper.Instance.UpdateSteps(physicianFormData);

                if (physicianFormData != null && physicianFormData.MedicalProfessionalEducation != null)
                {
                    return physicianFormData.MedicalProfessionalEducation;
                }
            }

            return null;
        }

        private void LoadFormData(Entities.Data.MedicalProfessionalEducation data)
        {
            if (data == null) return;

            tboxMedicalProfessionalSchoolFirst.Text = data.PrimaryMedicalProfessionalSchool;
            tboxDegreeReceivedFirst.Text = data.PrimaryDegreeReceived;
            tboxDateGraduationFirst.Text = data.PrimaryDateOfGraduation.HasValue ? data.PrimaryDateOfGraduation.Value.ToString(Constants.DateFormats.ShortDateFormat) : string.Empty;
            tboxMailingAdrressFirst.Text = data.PrimaryMailingAddress;
            tboxMailingCityFirst.Text = data.PrimaryCity;
            tboxMailingStateFirst.Text = data.PrimaryStateCountry;
            tboxMailingZipFirst.Text = data.PrimaryZip;

            tboxMedicalProfessionalSchoolSecond.Text = data.SecondaryMedicalProfessionalSchool;
            tboxDegreeReceivedSecond.Text = data.SecondaryDegreeReceived;
            tboxDateGraduationSecond.Text = data.SecondaryDateOfGraduation.HasValue ? data.SecondaryDateOfGraduation.Value.ToString(Constants.DateFormats.ShortDateFormat) : string.Empty;
            tboxMailingAdrressSecond.Text = data.SecondaryMailingAddress;
            tboxMailingCitySecond.Text = data.SecondaryCity;
            tboxMailingStateSecond.Text = data.SecondaryStateCountry;
            tboxMailingZipSecond.Text = data.SecondaryZip;

            ucAttachments.Attachments = data.Attachments;
        }

        private void lbReview_Click(object sender, EventArgs e)
        {
            var formData = LoadUserData() ?? new Entities.Data.MedicalProfessionalEducation();

            formData.Completed = true;

            var user = MemberHelper.GetCurrentLoggedUser();

            PracticionersApplicationHandler.Instance.UpsertMedicalProfessionalEducation(formData, (Guid)user.ProviderUserKey);

            Response.Redirect("/Dashboard/Physician.aspx");
            Response.End();
        }

        #endregion [Private methods]
    }
}