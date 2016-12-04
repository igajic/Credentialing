using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class PracticionersApplicationHandler
    {
        private static PracticionersApplicationHandler _instance;

        public static PracticionersApplicationHandler Instance
        {
            get { return _instance ?? (_instance = new PracticionersApplicationHandler()); }
        }

        private PracticionersApplicationHandler()
        {
        }

        public PracticionerApplication GetByUserId(Guid userId, bool deepLoad = false)
        {
            PracticionerApplication retVal = null;
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
            {
                var sqlCommand = new SqlCommand("SELECT * FROM PracticionerApplications WHERE UserId = @userId", conn);
                sqlCommand.Parameters.AddWithValue("@userId", userId);

                conn.Open();

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
            }

            return retVal;
        }

        public int Insert(PracticionerApplication application)
        {
            int retVal;
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
            {
                var sqlCommand = new SqlCommand(@"INSERT INTO PracticionerApplications
                                                    (UserId, AttestationQuestionsId, BoardCertificationId, CurrentHospitalInstitutionalAffiliationsId, EducationId, IdentifyingInformationId, InternshipId,MedicalProfessionalEducationId, MedicalProfessionalLicensureRegistrationsId, OtherCertificationsId, OtherStateMedicalProfessionalLicensesId, PeerReferencesId, PracticeInformationId, ProfessionalLiabilityId, ResidenciesFellowshipId, WorkHistoryId)
                                                    OUTPUT INSERTED.PracticionerApplicationId
                                                    VALUES
                                                    (@userId, @attestationQuestionsId, @boardCertificationId, @currentHospitalInstitutionalAffiliationsId, @educationId, @identifyingInformationId, @internshipId, @medicalProfessionalEducationId, @medicalProfessionalLicensureRegistrationsId, @otherCertificationsId, @otherStateMedicalProfessionalLicensesId, @peerReferencesId, @practiceInformationId, @professionalLiabilityId, @residenciesFellowshipId, @workHistoryId)", conn);
                conn.Open();

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

                retVal = (int)sqlCommand.ExecuteScalar();
            }

            return retVal;
        }

        public void Update(PracticionerApplication application)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
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
                conn.Open();

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
        }
    }
}