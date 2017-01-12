using Credentialing.Business.DataAccess;
using Credentialing.Business.Helpers;
using Credentialing.Entities;
using System;
using System.Linq;
using System.Web;

namespace Credentialing.Web.Handlers
{
    /// <summary>
    /// Summary description for DownloadAttachment
    /// </summary>
    public class DownloadAttachment : IHttpHandler
    {
        #region [Properties]

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        #endregion [Properties]

        #region [Public methods]

        public void ProcessRequest(HttpContext context)
        {
            int attachmentId;

            if (int.TryParse(context.Request[Constants.RequestParameters.AttachmentId], out attachmentId))
            {
                if (CheckUserAccess(attachmentId))
                {
                    var attachment = AttachmentHandler.Instance.GetById(attachmentId);
                    var content = AttachmentHandler.Instance.GetAttachmentContent(attachmentId);
                    if (attachment != null)
                    {
                        context.Response.ContentType = "application/octet-stream";
                        context.Response.AppendHeader("Content-Disposition", "attachment; filename=" + attachment.FileName);
                        context.Response.AddHeader("Content-Length", content.Length.ToString());
                        context.Response.BinaryWrite(content);
                        context.Response.End();
                    }
                }
            }
        }

        #endregion [Public methods]

        #region [Private methods]

        private bool CheckUserAccess(int attachmentId)
        {
            var retVal = false;

            var currentUser = MemberHelper.GetCurrentLoggedUser();

            if (currentUser != null)
            {
                if (MemberHelper.IsUserAdmin(currentUser.UserName))
                {
                    retVal = true;
                }
                else if (MemberHelper.IsUserPhysician(currentUser.UserName))
                {
                    var application = PracticionersApplicationHandler.Instance.GetByUserId((Guid)currentUser.ProviderUserKey, true);

                    // check all attachment in physicians application attachments

                    if (application.IdentifyingInformationId.HasValue)
                    {
                        retVal = application.IdentifyingInformation.Attachment.AttachmentId == attachmentId;
                    }

                    if (!retVal && application.EducationId.HasValue)
                    {
                        retVal = application.Education.AttachedDocuments.Any(s => s.AttachmentId == attachmentId);
                    }

                    if (!retVal && application.MedicalProfessionalEducationId.HasValue)
                    {
                        retVal = application.MedicalProfessionalEducation.Attachments.Any(s => s.AttachmentId == attachmentId);
                    }

                    if (!retVal && application.InternshipId.HasValue)
                    {
                        retVal = application.Internship.Attachments.Any(s => s.AttachmentId == attachmentId);
                    }

                    if (!retVal && application.ResidenciesFellowshipId.HasValue)
                    {
                        retVal = application.ResidenciesFellowship.Attachments.Any(s => s.AttachmentId == attachmentId);
                    }

                    if (!retVal && application.BoardCertificationId.HasValue && application.BoardCertification.Attachment != null)
                    {
                        retVal = application.BoardCertification.Attachment.AttachmentId == attachmentId;
                    }

                    if (!retVal && application.OtherCertificationId.HasValue)
                    {
                        retVal = application.OtherCertification.Attachments.Any(s => s.AttachmentId == attachmentId);
                    }

                    if (!retVal && application.MedicalProfessionalLicensureRegistrationId.HasValue)
                    {
                        retVal = application.MedicalProfessionalLicensureRegistration.Attachments.Any(s => s.AttachmentId == attachmentId);
                    }

                    if (!retVal && application.OtherStateMedicalProfessionalLicenseId.HasValue)
                    {
                        retVal = application.OtherStateMedicalProfessionalLicense.Attachments.Any(s => s.AttachmentId == attachmentId);
                    }

                    if (!retVal && application.ProfessionalLiabilityId.HasValue)
                    {
                        retVal = application.ProfessionalLiability.Attachment.AttachmentId == attachmentId;
                    }

                    if (!retVal && application.WorkHistoryId.HasValue)
                    {
                        retVal = application.WorkHistory.Attachments.Any(s => s.AttachmentId == attachmentId);
                    }

                    if (!retVal && application.AttestationQuestionId.HasValue)
                    {
                        retVal = application.AttestationQuestions.AdditionalSheets.Any(s => s.AttachmentId == attachmentId);
                    }

                    if (!retVal && application.CurrentHospitalInstitutionalAffiliationId.HasValue)
                    {
                        retVal = application.CurrentHospitalInstitutionalAffiliations.Attachments.Any(s => s.AttachmentId == attachmentId);
                    }
                }
            }

            return retVal;
        }

        #endregion [Private methods]
    }
}