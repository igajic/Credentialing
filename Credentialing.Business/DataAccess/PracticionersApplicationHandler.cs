using Credentialing.Entities;
using Credentialing.Entities.Data;
using log4net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class PracticionersApplicationHandler
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(PracticionersApplicationHandler));
        private static PracticionersApplicationHandler _instance;

        public static PracticionersApplicationHandler Instance
        {
            get { return _instance ?? (_instance = new PracticionersApplicationHandler()); }
        }

        private PracticionersApplicationHandler()
        {
        }

        public PracticionerApplication GetByUserId(SqlConnection conn, Guid userId, bool deepLoad = false)
        {
            PracticionerApplication retVal = null;

            var sqlCommand = new SqlCommand("SELECT * FROM PracticionerApplications WHERE UserId = @userId", conn);
            sqlCommand.Parameters.AddWithValue("@userId", userId);

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            using (var reader = sqlCommand.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        retVal = new PracticionerApplication();

                        retVal.PracticionerApplicationId = (int)reader[Constants.PracticionerApplicationColumns.PracticionerApplicationId];
                        retVal.UserId = (Guid)reader[Constants.PracticionerApplicationColumns.UserId];
                        retVal.AttestationQuestionId = reader[Constants.PracticionerApplicationColumns.AttestationQuestionsId] as int?;
                        retVal.BoardCertificationId = reader[Constants.PracticionerApplicationColumns.BoardCertificationId] as int?;
                        retVal.CurrentHospitalInstitutionalAffiliationId = reader[Constants.PracticionerApplicationColumns.CurrentHospitalInstitutionalAffiliationsId] as int?;
                        retVal.EducationId = reader[Constants.PracticionerApplicationColumns.EducationId] as int?;
                        retVal.IdentifyingInformationId = reader[Constants.PracticionerApplicationColumns.IdentifyingInformationId] as int?;
                        retVal.InternshipId = reader[Constants.PracticionerApplicationColumns.InternshipId] as int?;
                        retVal.MedicalProfessionalEducationId = reader[Constants.PracticionerApplicationColumns.MedicalProfessionalEducationId] as int?;
                        retVal.OtherCertificationId = reader[Constants.PracticionerApplicationColumns.OtherCertificationsId] as int?;
                        retVal.OtherStateMedicalProfessionalLicenseId = reader[Constants.PracticionerApplicationColumns.OtherStateMedicalProfessionalLicensesId] as int?;
                        retVal.PeerReferenceId = reader[Constants.PracticionerApplicationColumns.PeerReferencesId] as int?;
                        retVal.PracticeInformationId = reader[Constants.PracticionerApplicationColumns.PracticeInformationId] as int?;
                        retVal.ProfessionalLiabilityId = reader[Constants.PracticionerApplicationColumns.ProfessionalLiabilityId] as int?;
                        retVal.ResidenciesFellowshipId = reader[Constants.PracticionerApplicationColumns.ResidenciesFellowshipId] as int?;
                        retVal.WorkHistoryId = reader[Constants.PracticionerApplicationColumns.WorkHistoryId] as int?;

                        if (deepLoad)
                        {
                            if (retVal.IdentifyingInformationId.HasValue)
                            {
                                retVal.IdentifyingInformation = IdentifyingInformationHandler.Instance.GetById(retVal.IdentifyingInformationId.Value, true);
                            }

                            if (retVal.PracticeInformationId.HasValue)
                            {
                                retVal.PracticeInformation = PracticeInformationHandler.Instance.GetById(retVal.PracticeInformationId.Value, true);
                            }

                            if (retVal.EducationId.HasValue)
                            {
                                retVal.Education = EducationHandler.Instance.GetById(retVal.EducationId.Value, true);
                            }
                        }
                    }
                }
            }

            return retVal;
        }

        public PracticionerApplication GetByUserId(Guid userId, bool deepLoad = false)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
            {
                return GetByUserId(conn, userId, deepLoad);
            }
        }

        public int Insert(SqlConnection conn, PracticionerApplication application)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO PracticionerApplications
                                                    (UserId, AttestationQuestionsId, BoardCertificationId, CurrentHospitalInstitutionalAffiliationsId, EducationId, IdentifyingInformationId, InternshipId,MedicalProfessionalEducationId, MedicalProfessionalLicensureRegistrationsId, OtherCertificationsId, OtherStateMedicalProfessionalLicensesId, PeerReferencesId, PracticeInformationId, ProfessionalLiabilityId, ResidenciesFellowshipId, WorkHistoryId)
                                                    OUTPUT INSERTED.PracticionerApplicationId
                                                    VALUES
                                                    (@userId, @attestationQuestionsId, @boardCertificationId, @currentHospitalInstitutionalAffiliationsId, @educationId, @identifyingInformationId, @internshipId, @medicalProfessionalEducationId, @medicalProfessionalLicensureRegistrationsId, @otherCertificationsId, @otherStateMedicalProfessionalLicensesId, @peerReferencesId, @practiceInformationId, @professionalLiabilityId, @residenciesFellowshipId, @workHistoryId)", conn);

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@userId", application.UserId);
            sqlCommand.Parameters.AddWithValue("@attestationQuestionsId", application.AttestationQuestionId);
            sqlCommand.Parameters.AddWithValue("@boardCertificationId", application.BoardCertificationId);
            sqlCommand.Parameters.AddWithValue("@currentHospitalInstitutionalAffiliationsId", application.CurrentHospitalInstitutionalAffiliationId);
            sqlCommand.Parameters.AddWithValue("@educationId", application.EducationId);
            sqlCommand.Parameters.AddWithValue("@identifyingInformationId", application.IdentifyingInformationId);
            sqlCommand.Parameters.AddWithValue("@internshipId", application.InternshipId);
            sqlCommand.Parameters.AddWithValue("@medicalProfessionalEducationId", application.MedicalProfessionalEducationId);
            sqlCommand.Parameters.AddWithValue("@medicalProfessionalLicensureRegistrationsId", application.MedicalProfessionalLicensureRegistrationId);
            sqlCommand.Parameters.AddWithValue("@otherCertificationsId", application.OtherCertificationId);
            sqlCommand.Parameters.AddWithValue("@otherStateMedicalProfessionalLicensesId", application.OtherStateMedicalProfessionalLicenseId);
            sqlCommand.Parameters.AddWithValue("@peerReferencesId", application.PeerReferenceId);
            sqlCommand.Parameters.AddWithValue("@practiceInformationId", application.PracticeInformationId);
            sqlCommand.Parameters.AddWithValue("@professionalLiabilityId", application.ProfessionalLiabilityId);
            sqlCommand.Parameters.AddWithValue("@residenciesFellowshipId", application.ResidenciesFellowshipId);
            sqlCommand.Parameters.AddWithValue("@workHistoryId", application.WorkHistoryId);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            return (int)sqlCommand.ExecuteScalar();
        }

        public int Insert(PracticionerApplication application)
        {
            int retVal;
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
            {
                retVal = Insert(conn, application);
            }

            return retVal;
        }

        public void Update(SqlConnection conn, PracticionerApplication application)
        {
            var sqlCommand = new SqlCommand(@"UPDATE PracticionerApplications
                                                    SET UserId = @userId,
                                                        AttestationQuestionsId = @attestationQuestionsId,
                                                        BoardCertificationId = @boardCertificationId,
                                                        CurrentHospitalInstitutionalAffiliationsId = @currentHospitalInstitutionalAffiliationsId,
                                                        EducationId = @educationId,
                                                        IdentifyingInformationId = @identifyingInformationId,
                                                        InternshipId = @internshipId,
                                                        MedicalProfessionalEducationId = @medicalProfessionalEducationId,
                                                        MedicalProfessionalLicensureRegistrationsId = @medicalProfessionalLicensureRegistrationsId,
                                                        OtherCertificationsId = @otherCertificationsId,
                                                        OtherStateMedicalProfessionalLicensesId = @otherStateMedicalProfessionalLicensesId,
                                                        PeerReferencesId = @peerReferencesId,
                                                        PracticeInformationId = @practiceInformationId,
                                                        ProfessionalLiabilityId = @professionalLiabilityId,
                                                        ResidenciesFellowshipId = @residenciesFellowshipId,
                                                        WorkHistoryId = @workHistoryId
                                                    WHERE PracticionerApplicationId = @practicionerApplicationId
                                                    ", conn);

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@practicionerApplicationId", application.PracticionerApplicationId);
            sqlCommand.Parameters.AddWithValue("@userId", application.UserId);
            sqlCommand.Parameters.AddWithValue("@attestationQuestionsId", application.AttestationQuestionId);
            sqlCommand.Parameters.AddWithValue("@boardCertificationId", application.BoardCertificationId);
            sqlCommand.Parameters.AddWithValue("@currentHospitalInstitutionalAffiliationsId", application.CurrentHospitalInstitutionalAffiliationId);
            sqlCommand.Parameters.AddWithValue("@educationId", application.EducationId);
            sqlCommand.Parameters.AddWithValue("@identifyingInformationId", application.IdentifyingInformationId);
            sqlCommand.Parameters.AddWithValue("@internshipId", application.InternshipId);
            sqlCommand.Parameters.AddWithValue("@medicalProfessionalEducationId", application.MedicalProfessionalEducationId);
            sqlCommand.Parameters.AddWithValue("@medicalProfessionalLicensureRegistrationsId", application.MedicalProfessionalLicensureRegistrationId);
            sqlCommand.Parameters.AddWithValue("@otherCertificationsId", application.OtherCertificationId);
            sqlCommand.Parameters.AddWithValue("@otherStateMedicalProfessionalLicensesId", application.OtherStateMedicalProfessionalLicenseId);
            sqlCommand.Parameters.AddWithValue("@peerReferencesId", application.PeerReferenceId);
            sqlCommand.Parameters.AddWithValue("@practiceInformationId", application.PracticeInformationId);
            sqlCommand.Parameters.AddWithValue("@professionalLiabilityId", application.ProfessionalLiabilityId);
            sqlCommand.Parameters.AddWithValue("@residenciesFellowshipId", application.ResidenciesFellowshipId);
            sqlCommand.Parameters.AddWithValue("@workHistoryId", application.WorkHistoryId);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            sqlCommand.ExecuteNonQuery();
        }

        public void Update(PracticionerApplication application)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
            {
                Update(conn, application);
            }
        }

        public bool UpsertIdentifyingInformation(IdentifyingInformation formData, Guid userId)
        {
            bool retVal = true;

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
            {
                conn.Open();
                var trans = conn.BeginTransaction();
                try
                {
                    if (formData.Attachment != null)
                    {
                        AttachmentHandler.Instance.Delete(conn, formData.AttachmentId.Value);

                        var id = AttachmentHandler.Instance.Insert(conn, formData.Attachment);
                        formData.AttachmentId = id;
                    }

                    var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId(conn, userId);
                    if (!physicianFormData.IdentifyingInformationId.HasValue)
                    {
                        var id = IdentifyingInformationHandler.Instance.Insert(conn, formData);
                        physicianFormData.IdentifyingInformationId = id;

                        PracticionersApplicationHandler.Instance.Update(conn, physicianFormData);
                    }
                    else
                    {
                        formData.IdentifyingInformationId = physicianFormData.IdentifyingInformationId.Value;
                        IdentifyingInformationHandler.Instance.Update(conn, formData);
                    }

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    Log.Error(ex);

                    retVal = false;
                }
            }

            return retVal;
        }

        public bool UpsertEducation(Education formData, Guid userId)
        {
            var retVal = true;

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
            {
                conn.Open();
                var trans = conn.BeginTransaction();
                try
                {
                    var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId(conn, userId);
                    if (physicianFormData.EducationId.HasValue)
                    {
                        formData.EducationId = physicianFormData.EducationId.Value;
                        EducationHandler.Instance.Update(conn, formData);
                    }
                    else
                    {
                        var id = EducationHandler.Instance.Insert(conn, formData);
                        physicianFormData.EducationId = id;

                        PracticionersApplicationHandler.Instance.Update(conn, physicianFormData);
                    }

                    if (formData.AttachedDocuments.Count > 0)
                    {
                        var existingAttachments = AttachmentHandler.Instance.GetReferencedAttachments(conn, "EducationId", formData.EducationId);
                        foreach (var attachment in existingAttachments)
                        {
                            AttachmentHandler.Instance.Delete(conn, attachment.AttachmentId);
                        }

                        foreach (var attachment in formData.AttachedDocuments)
                        {
                            attachment.EducationId = physicianFormData.EducationId;
                            AttachmentHandler.Instance.Insert(conn, attachment);
                        }
                    }
                }
                catch (Exception ex)
                {
                    trans.Rollback();

                    Log.Error(ex);

                    retVal = false;
                }
            }

            return retVal;
        }

        public bool UpsertMedicalProfessionalEducation(MedicalProfessionalEducation formData, Guid userId)
        {
            var retVal = true;

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
            {
                conn.Open();
                var trans = conn.BeginTransaction();
                try
                {
                    var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId(conn, userId);

                    if (physicianFormData.MedicalProfessionalEducationId.HasValue)
                    {
                        formData.MedicalProfessionalEducationId = physicianFormData.MedicalProfessionalEducationId.Value;
                        MedicalProfessionalEducationHandler.Instance.Update(conn, formData);
                    }
                    else
                    {
                        var id = MedicalProfessionalEducationHandler.Instance.Insert(conn, formData);
                        physicianFormData.MedicalProfessionalEducationId = id;

                        PracticionersApplicationHandler.Instance.Update(conn, physicianFormData);
                    }

                    if (formData.Attachments.Count > 0)
                    {
                        var existingAttachments = AttachmentHandler.Instance.GetReferencedAttachments(conn, "MedicalProfessionalEducationId", formData.MedicalProfessionalEducationId);
                        foreach (var attachment in existingAttachments)
                        {
                            AttachmentHandler.Instance.Delete(conn, attachment.AttachmentId);
                        }

                        foreach (var attachment in formData.Attachments)
                        {
                            attachment.MedicalProfessionalEducationId = physicianFormData.MedicalProfessionalEducationId;
                            AttachmentHandler.Instance.Insert(conn, attachment);
                        }
                    }
                }
                catch (Exception ex)
                {
                    trans.Rollback();

                    Log.Error(ex);

                    retVal = false;
                }
            }

            return retVal;
        }

        public bool UpsertPracticeInformation(PracticeInformation formData, Guid userId)
        {
            var retVal = true;

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
            {
                conn.Open();
                var trans = conn.BeginTransaction();
                try
                {
                    var physicianFormData = PracticionersApplicationHandler.Instance.GetByUserId(conn, userId);
                    if (!physicianFormData.PracticeInformationId.HasValue)
                    {
                        var id = PracticeInformationHandler.Instance.Insert(conn, formData);
                        physicianFormData.PracticeInformationId = id;

                        PracticionersApplicationHandler.Instance.Update(conn, physicianFormData);
                    }
                    else
                    {
                        formData.PracticeInformationId = physicianFormData.PracticeInformationId.Value;
                        PracticeInformationHandler.Instance.Update(conn, formData);
                    }
                }
                catch (Exception ex)
                {
                    trans.Rollback();

                    Log.Error(ex);

                    retVal = false;
                }
            }

            return retVal;
        }
    }
}