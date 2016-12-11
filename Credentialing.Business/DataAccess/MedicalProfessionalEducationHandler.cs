using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class MedicalProfessionalEducationHandler
    {
        private static MedicalProfessionalEducationHandler _instance;

        public static MedicalProfessionalEducationHandler Instance
        {
            get { return _instance ?? (_instance = new MedicalProfessionalEducationHandler()); }
        }

        private MedicalProfessionalEducationHandler()
        {
        }

        public MedicalProfessionalEducation GetById(int id, bool deepLoad = false)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                return GetById(conn, null, id, deepLoad);
            }
        }

        public MedicalProfessionalEducation GetById(SqlConnection conn, SqlTransaction trans, int id, bool deepLoad = false)
        {
            MedicalProfessionalEducation retVal = null;

            var sqlCommand = new SqlCommand("SELECT * FROM MedicalProfessionalEducations WHERE MedicalProfessionalEducationId = @medicalProfessionalEducationId", conn);
            sqlCommand.Parameters.AddWithValue("@medicalProfessionalEducationId", id);
            if (trans != null) sqlCommand.Transaction = trans;


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
                        retVal = new MedicalProfessionalEducation();

                        retVal.MedicalProfessionalEducationId = (int) reader[Constants.MedicalProfessionalEducationColumns.MedicalProfessionalEducationId];

                        retVal.PrimaryMedicalProfessionalSchool = reader[Constants.MedicalProfessionalEducationColumns.PrimaryMedicalProfessionalSchool] as string;
                        retVal.PrimaryDegreeReceived = reader[Constants.MedicalProfessionalEducationColumns.PrimaryDegreeReceived] as string;
                        retVal.PrimaryDateOfGraduation = Convert.IsDBNull(reader[Constants.MedicalProfessionalEducationColumns.PrimaryDateOfGraduation]) ? null : (DateTime?) reader[Constants.MedicalProfessionalEducationColumns.PrimaryDateOfGraduation];
                        retVal.PrimaryMailingAddress = reader[Constants.MedicalProfessionalEducationColumns.PrimaryMailingAddress] as string;
                        retVal.PrimaryCity = reader[Constants.MedicalProfessionalEducationColumns.PrimaryCity] as string;
                        retVal.PrimaryStateCountry = reader[Constants.MedicalProfessionalEducationColumns.PrimaryStateCountry] as string;
                        retVal.PrimaryZip = reader[Constants.MedicalProfessionalEducationColumns.PrimaryZip] as string;

                        retVal.SecondaryMedicalProfessionalSchool = reader[Constants.MedicalProfessionalEducationColumns.SecondaryMedicalProfessionalSchool] as string;
                        retVal.SecondaryDegreeReceived = reader[Constants.MedicalProfessionalEducationColumns.SecondaryDegreeReceived] as string;
                        retVal.SecondaryDateOfGraduation = Convert.IsDBNull(reader[Constants.MedicalProfessionalEducationColumns.SecondaryDateOfGraduation]) ? null : (DateTime?) reader[Constants.MedicalProfessionalEducationColumns.SecondaryDateOfGraduation];
                        retVal.SecondaryMailingAddress = reader[Constants.MedicalProfessionalEducationColumns.SecondaryMailingAddress] as string;
                        retVal.SecondaryCity = reader[Constants.MedicalProfessionalEducationColumns.SecondaryCity] as string;
                        retVal.SecondaryStateCountry = reader[Constants.MedicalProfessionalEducationColumns.SecondaryStateCountry] as string;
                        retVal.SecondaryZip = reader[Constants.MedicalProfessionalEducationColumns.SecondaryZip] as string;
                    }
                }
            }

            if (deepLoad && retVal != null)
            {
                retVal.Attachments = AttachmentHandler.Instance.GetReferencedAttachments(conn, trans, "MedicalProfessionalEducationId", retVal.MedicalProfessionalEducationId);
            }

            return retVal;
        }

        public int Insert(MedicalProfessionalEducation medicalEducation)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                return Insert(conn, null, medicalEducation);
            }
        }

        public int Insert(SqlConnection conn, SqlTransaction trans, MedicalProfessionalEducation medicalEducation)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO MedicalProfessionalEducations
                                                    (PrimaryMedicalProfessionalSchool, PrimaryDegreeReceived, PrimaryDateOfGraduation, PrimaryMailingAddress, PrimaryCity, PrimaryStateCountry, PrimaryZip, SecondaryMedicalProfessionalSchool, SecondaryDegreeReceived, SecondaryDateOfGraduation, SecondaryMailingAddress, SecondaryCity, SecondaryStateCountry, SecondaryZip)
                                                    OUTPUT INSERTED.MedicalProfessionalEducationId
                                                    VALUES
                                                    (@primaryMedicalProfessionalSchool, @primaryDegreeReceived, @primaryDateOfGraduation, @primaryMailingAddress, @primaryCity, @primaryStateCountry, @primaryZip, @secondaryMedicalProfessionalSchool, @secondaryDegreeReceived, @secondaryDateOfGraduation, @secondaryMailingAddress, @secondaryCity, @secondaryStateCountry, @secondaryZip)", conn);
            if (trans != null) sqlCommand.Transaction = trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@primaryMedicalProfessionalSchool", medicalEducation.PrimaryMedicalProfessionalSchool);
            sqlCommand.Parameters.AddWithValue("@primaryDegreeReceived", medicalEducation.PrimaryDegreeReceived);
            sqlCommand.Parameters.AddWithValue("@primaryDateOfGraduation", medicalEducation.PrimaryDateOfGraduation);
            sqlCommand.Parameters.AddWithValue("@primaryMailingAddress", medicalEducation.PrimaryMailingAddress);
            sqlCommand.Parameters.AddWithValue("@primaryCity", medicalEducation.PrimaryCity);
            sqlCommand.Parameters.AddWithValue("@primaryStateCountry", medicalEducation.PrimaryStateCountry);
            sqlCommand.Parameters.AddWithValue("@primaryZip", medicalEducation.PrimaryZip);
            sqlCommand.Parameters.AddWithValue("@secondaryMedicalProfessionalSchool", medicalEducation.SecondaryMedicalProfessionalSchool);
            sqlCommand.Parameters.AddWithValue("@secondaryDegreeReceived", medicalEducation.SecondaryDegreeReceived);
            sqlCommand.Parameters.AddWithValue("@secondaryDateOfGraduation", medicalEducation.SecondaryDateOfGraduation);
            sqlCommand.Parameters.AddWithValue("@secondaryMailingAddress", medicalEducation.SecondaryMailingAddress);
            sqlCommand.Parameters.AddWithValue("@secondaryCity", medicalEducation.SecondaryCity);
            sqlCommand.Parameters.AddWithValue("@secondaryStateCountry", medicalEducation.SecondaryStateCountry);
            sqlCommand.Parameters.AddWithValue("@secondaryZip", medicalEducation.SecondaryZip);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            var retVal = (int)sqlCommand.ExecuteScalar();

            return retVal;
        }

        public void Update(MedicalProfessionalEducation medicalEducation)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                Update(conn, null, medicalEducation);
            }
        }

        public void Update(SqlConnection conn, SqlTransaction trans, MedicalProfessionalEducation medicalEducation)
        {
            var sqlCommand = new SqlCommand(@"UPDATE MedicalProfessionalEducations
                                                    SET
                                                        PrimaryMedicalProfessionalSchool = @primaryMedicalProfessionalSchool,
                                                        PrimaryDegreeReceived =  @primaryDegreeReceived,
                                                        PrimaryDateOfGraduation = @primaryDateOfGraduation,
                                                        PrimaryMailingAddress = @primaryMailingAddress,
                                                        PrimaryCity = @primaryCity,
                                                        PrimaryStateCountry = @primaryStateCountry,
                                                        PrimaryZip = @primaryZip,

                                                        SecondaryMedicalProfessionalSchool = @secondaryMedicalProfessionalSchool,
                                                        SecondaryDegreeReceived = @secondaryDegreeReceived,
                                                        SecondaryDateOfGraduation = @secondaryDateOfGraduation,
                                                        SecondaryMailingAddress = @secondaryMailingAddress,
                                                        SecondaryCity = @secondaryCity,
                                                        SecondaryStateCountry = @secondaryStateCountry,
                                                        SecondaryZip = @secondaryZip
                                                    WHERE MedicalProfessionalEducationId = @medicalProfessionalEducationId", conn);

            if (trans != null) sqlCommand.Transaction = trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@medicalProfessionalEducationId", medicalEducation.MedicalProfessionalEducationId);
            sqlCommand.Parameters.AddWithValue("@primaryMedicalProfessionalSchool", medicalEducation.PrimaryMedicalProfessionalSchool);
            sqlCommand.Parameters.AddWithValue("@primaryDegreeReceived", medicalEducation.PrimaryDegreeReceived);
            sqlCommand.Parameters.AddWithValue("@primaryDateOfGraduation", medicalEducation.PrimaryDateOfGraduation);
            sqlCommand.Parameters.AddWithValue("@primaryMailingAddress", medicalEducation.PrimaryMailingAddress);
            sqlCommand.Parameters.AddWithValue("@primaryCity", medicalEducation.PrimaryCity);
            sqlCommand.Parameters.AddWithValue("@primaryStateCountry", medicalEducation.PrimaryStateCountry);
            sqlCommand.Parameters.AddWithValue("@primaryZip", medicalEducation.PrimaryZip);
            sqlCommand.Parameters.AddWithValue("@secondaryMedicalProfessionalSchool", medicalEducation.SecondaryMedicalProfessionalSchool);
            sqlCommand.Parameters.AddWithValue("@secondaryDegreeReceived", medicalEducation.SecondaryDegreeReceived);
            sqlCommand.Parameters.AddWithValue("@secondaryDateOfGraduation", medicalEducation.SecondaryDateOfGraduation);
            sqlCommand.Parameters.AddWithValue("@secondaryMailingAddress", medicalEducation.SecondaryMailingAddress);
            sqlCommand.Parameters.AddWithValue("@secondaryCity", medicalEducation.SecondaryCity);
            sqlCommand.Parameters.AddWithValue("@secondaryStateCountry", medicalEducation.SecondaryStateCountry);
            sqlCommand.Parameters.AddWithValue("@secondaryZip", medicalEducation.SecondaryZip);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            sqlCommand.ExecuteNonQuery();
        }
    }
}