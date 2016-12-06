using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class AttachmentHandler
    {
        private static AttachmentHandler _instance;

        public static AttachmentHandler Instance
        {
            get { return _instance ?? (_instance = new AttachmentHandler()); }
        }

        private AttachmentHandler()
        {
        }

        public void Delete(int attachmentId)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
            {
                Delete(conn, attachmentId);
            }
        }

        public void Delete(SqlConnection conn, int attachmentId)
        {
            var sqlCommand = new SqlCommand("DELETE FROM Attachments WHERE AttachmentId = @attachmentId", conn);
            sqlCommand.Parameters.AddWithValue("@attachmentId", attachmentId);


            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.ExecuteNonQuery();
        }

        public List<Attachment> GetReferencedAttachments(string fk, int fkVal)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
            {
                return GetReferencedAttachments(conn, fk, fkVal);
            }
        }

        public List<Attachment> GetReferencedAttachments(SqlConnection conn, string fk, int fkVal)
        {
            var retVal = new List<Attachment>();

            var sqlCommand = new SqlCommand("SELECT * FROM Attachments WHERE " + fk + " = @fkVal", conn);
            sqlCommand.Parameters.AddWithValue("@fkVal", fkVal);

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
                        retVal.Add(ReadAttachmentFields(reader));
                    }
                }
            }

            return retVal;
        }

        public Attachment GetById(int attachmentId)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
            {
                return GetById(conn, attachmentId);
            }
        }

        public Attachment GetById(SqlConnection conn, int attachmentId)
        {
            Attachment retVal = null;

            var sqlCommand = new SqlCommand("SELECT * FROM Attachments WHERE AttachmentId = @attachmentId", conn);
            sqlCommand.Parameters.AddWithValue("@attachmentId", attachmentId);

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            using (var reader = sqlCommand.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        retVal = ReadAttachmentFields(reader);
                    }
                }
            }

            return retVal;
        }

        public int Insert(Attachment attachment)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
            {
                return Insert(conn, attachment);
            }
        }

        public int Insert(SqlConnection conn, Attachment attachment)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO Attachments
                                                    (FileName, Content, EducationId, MedicalProfessionalEducationId, InternshipId, ResidenciesFellowshipId, OtherCertificationsId, MedicalProfessionalLicensureRegistrationsId, OtherStateMedicalProfessionalLicensesId, WorkHistoryId, AttestationQuestionsId)
                                                    OUTPUT INSERTED.AttachmentId
                                                    VALUES
                                                    (@fileName, @content, @educationId, @medicalProfessionalEducationId, @internshipId, @residenciesFellowshipId, @otherCertificationsId, @medicalProfessionalLicensureRegistrationsId, @otherStateMedicalProfessionalLicensesId, @workHistoryId, @attestationQuestionsId)", conn);

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@fileName", attachment.FileName);
            sqlCommand.Parameters.AddWithValue("@content", attachment.Content);
            sqlCommand.Parameters.AddWithValue("@educationId", attachment.EducationId);
            sqlCommand.Parameters.AddWithValue("@medicalProfessionalEducationId", attachment.MedicalProfessionalEducationId);
            sqlCommand.Parameters.AddWithValue("@internshipId", attachment.InternshipId);
            sqlCommand.Parameters.AddWithValue("@residenciesFellowshipId", attachment.ResidenciesFellowshipId);
            sqlCommand.Parameters.AddWithValue("@otherCertificationsId", attachment.OtherCertificationsId);
            sqlCommand.Parameters.AddWithValue("@medicalProfessionalLicensureRegistrationsId", attachment.MedicalProfessionalLicensureRegistrationsId);
            sqlCommand.Parameters.AddWithValue("@otherStateMedicalProfessionalLicensesId", attachment.OtherStateMedicalProfessionalLicensesId);
            sqlCommand.Parameters.AddWithValue("@workHistoryId", attachment.WorkHistoryId);
            sqlCommand.Parameters.AddWithValue("@attestationQuestionsId", attachment.AttestationQuestionsId);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            return (int)sqlCommand.ExecuteScalar();
        }

        #region [Private methods]

        private Attachment ReadAttachmentFields(SqlDataReader reader)
        {
            var retVal = new Attachment();

            retVal.AttachmentId = (int)reader[Constants.AttachmentColumns.AttachmentId];
            retVal.Content = (byte[])reader[Constants.AttachmentColumns.Content];
            retVal.FileName = reader[Constants.AttachmentColumns.FileName] as string;
            retVal.EducationId = reader[Constants.AttachmentColumns.EducationId] as int?;
            retVal.MedicalProfessionalEducationId = reader[Constants.AttachmentColumns.MedicalProfessionalEducationId] as int?;
            retVal.InternshipId = reader[Constants.AttachmentColumns.InternshipId] as int?;
            retVal.ResidenciesFellowshipId = reader[Constants.AttachmentColumns.ResidenciesFellowshipId] as int?;
            retVal.OtherCertificationsId = reader[Constants.AttachmentColumns.OtherCertificationsId] as int?;
            retVal.MedicalProfessionalLicensureRegistrationsId = reader[Constants.AttachmentColumns.MedicalProfessionalLicensureRegistrationsId] as int?;
            retVal.OtherStateMedicalProfessionalLicensesId = reader[Constants.AttachmentColumns.OtherStateMedicalProfessionalLicensesId] as int?;
            retVal.WorkHistoryId = reader[Constants.AttachmentColumns.WorkHistoryId] as int?;
            return retVal;
        }

        #endregion [Private methods]
    }
}