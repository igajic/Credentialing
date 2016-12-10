using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class EducationHandler
    {
        private static EducationHandler _instance;

        public static EducationHandler Instance
        {
            get { return _instance ?? (_instance = new EducationHandler()); }
        }

        private EducationHandler()
        {
        }

        public Education GetById(int id, bool deepLoad = false)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                return GetById(conn, null, id, deepLoad);
            }
        }

        public Education GetById(SqlConnection conn, SqlTransaction trans, int id, bool deepLoad = false)
        {
            Education retVal = null;

            var sqlCommand = new SqlCommand(@"SELECT *
                                                  FROM Educations
                                                  WHERE EducationId = @educationId", conn);
            sqlCommand.Parameters.AddWithValue("@educationId", id);
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
                        retVal = new Education();

                        retVal.EducationId = (int)reader[Constants.EducationColumns.EducationId];
                        retVal.CollegeUniverityName = reader[Constants.EducationColumns.CollegeUniverityName] as string;
                        retVal.DateGraduation = (DateTime)reader[Constants.EducationColumns.DateGraduation];
                        retVal.DegreeReceived = reader[Constants.EducationColumns.DegreeReceived] as string;
                        retVal.EducationId = (int)reader[Constants.EducationColumns.EducationId];
                        retVal.MailingAddress = reader[Constants.EducationColumns.MailingAddress] as string;
                        retVal.MailingCity = reader[Constants.EducationColumns.MailingCity] as string;
                        retVal.MailingState = reader[Constants.EducationColumns.MailingState] as string;
                        retVal.MailingZip = reader[Constants.EducationColumns.MailingZip] as string;
                    }
                }
            }

            if (deepLoad && retVal != null)
            {
                retVal.AttachedDocuments = AttachmentHandler.Instance.GetReferencedAttachments(conn, trans, "EducationId", retVal.EducationId);
            }

            return retVal;
        }

        public int Insert(Education education)
        {
            int retVal;
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                retVal = Insert(conn, null, education);
            }

            return retVal;
        }

        public int Insert(SqlConnection conn, SqlTransaction trans, Education education)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO Educations
                                                    (CollegeUniverityName, DegreeReceived, DateGraduation, MailingAddress, MailingCity, MailingState, MailingZip)
                                                    OUTPUT INSERTED.EducationId
                                                    VALUES
                                                    (@collegeUniverityName, @degreeReceived, @dateGraduation, @mailingAddress, @mailingCity, @mailingState, @mailingZip)", conn);
            if (trans != null) sqlCommand.Transaction = trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@collegeUniverityName", education.CollegeUniverityName);
            sqlCommand.Parameters.AddWithValue("@degreeReceived", education.DegreeReceived);
            sqlCommand.Parameters.AddWithValue("@dateGraduation", education.DateGraduation);
            sqlCommand.Parameters.AddWithValue("@mailingAddress", education.MailingAddress);
            sqlCommand.Parameters.AddWithValue("@mailingCity", education.MailingCity);
            sqlCommand.Parameters.AddWithValue("@mailingState", education.MailingState);
            sqlCommand.Parameters.AddWithValue("@mailingZip", education.MailingZip);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            return (int)sqlCommand.ExecuteScalar();
        }

        public void Update(Education education)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                Update(conn, null, education);
            }
        }

        public void Update(SqlConnection conn, SqlTransaction trans, Education education)
        {
            var sqlCommand = new SqlCommand(@"UPDATE Educations
                                                    SET CollegeUniverityName = @collegeUniverityName,
                                                        DegreeReceived = @degreeReceived,
                                                        DateGraduation = @dateGraduation,
                                                        MailingAddress = @mailingAddress,
                                                        MailingCity = @mailingCity,
                                                        MailingState = @mailingState,
                                                        MailingZip = @mailingZip
                                                    WHERE EducationId = @educationId", conn);
            if (trans != null) sqlCommand.Transaction = trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@educationId", education.EducationId);
            sqlCommand.Parameters.AddWithValue("@collegeUniverityName", education.CollegeUniverityName);
            sqlCommand.Parameters.AddWithValue("@degreeReceived", education.DegreeReceived);
            sqlCommand.Parameters.AddWithValue("@dateGraduation", education.DateGraduation);
            sqlCommand.Parameters.AddWithValue("@mailingAddress", education.MailingAddress);
            sqlCommand.Parameters.AddWithValue("@mailingCity", education.MailingCity);
            sqlCommand.Parameters.AddWithValue("@mailingState", education.MailingState);
            sqlCommand.Parameters.AddWithValue("@mailingZip", education.MailingZip);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            sqlCommand.ExecuteNonQuery();
        }
    }
}