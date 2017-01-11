using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class OtherStateMedicalProfessionalLicensesHandler
    {
        private static OtherStateMedicalProfessionalLicensesHandler _instance;

        public static OtherStateMedicalProfessionalLicensesHandler Instance
        {
            get { return _instance ?? (_instance = new OtherStateMedicalProfessionalLicensesHandler()); }
        }

        private OtherStateMedicalProfessionalLicensesHandler()
        {
        }

        public OtherStateMedicalProfessionalLicenses GetById(int otherStateMedicalProfessionalLicensesId, bool deepLoad = false)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                return GetById(conn, null, otherStateMedicalProfessionalLicensesId, deepLoad);
            }
        }

        public OtherStateMedicalProfessionalLicenses GetById(SqlConnection conn, SqlTransaction trans, int otherStateMedicalProfessionalLicensesId, bool deepLoad = false)
        {
            OtherStateMedicalProfessionalLicenses retVal = null;

            var sqlCommand = new SqlCommand("SELECT * FROM OtherStateMedicalProfessionalLicenses WHERE otherStateMedicalProfessionalLicensesId = @otherStateMedicalProfessionalLicensesId", conn);
            sqlCommand.Parameters.AddWithValue("@otherStateMedicalProfessionalLicensesId", otherStateMedicalProfessionalLicensesId);
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
                        retVal = new OtherStateMedicalProfessionalLicenses();

                        retVal.OtherStateMedicalProfessionalLicensesId = (int)reader[Constants.OtherStateMedicalProfessionalLicensesColumns.OtherStateMedicalProfessionalLicensesId];
                        retVal.PrimaryState = reader[Constants.OtherStateMedicalProfessionalLicensesColumns.PrimaryState] as string;
                        retVal.PrimaryLicenseNumber = reader[Constants.OtherStateMedicalProfessionalLicensesColumns.PrimaryLicenseNumber] as string;
                        retVal.PrimaryExpirationDate = Convert.IsDBNull(reader[Constants.OtherStateMedicalProfessionalLicensesColumns.PrimaryExpirationDate]) ? null : (DateTime?)reader[Constants.OtherStateMedicalProfessionalLicensesColumns.PrimaryExpirationDate];
                        retVal.PrimaryLastExpirationDate = Convert.IsDBNull(reader[Constants.OtherStateMedicalProfessionalLicensesColumns.PrimaryLastExpirationDate]) ? null : (DateTime?)reader[Constants.OtherStateMedicalProfessionalLicensesColumns.PrimaryLastExpirationDate];

                        retVal.SecondaryState = reader[Constants.OtherStateMedicalProfessionalLicensesColumns.SecondaryState] as string;
                        retVal.SecondaryLicenseNumber = reader[Constants.OtherStateMedicalProfessionalLicensesColumns.SecondaryLicenseNumber] as string;
                        retVal.SecondaryExpirationDate = Convert.IsDBNull(reader[Constants.OtherStateMedicalProfessionalLicensesColumns.SecondaryExpirationDate]) ? null : (DateTime?)reader[Constants.OtherStateMedicalProfessionalLicensesColumns.SecondaryExpirationDate];
                        retVal.SecondaryLastExpirationDate = Convert.IsDBNull(reader[Constants.OtherStateMedicalProfessionalLicensesColumns.SecondaryLastExpirationDate]) ? null : (DateTime?)reader[Constants.OtherStateMedicalProfessionalLicensesColumns.SecondaryLastExpirationDate];

                        retVal.TertiaryState = reader[Constants.OtherStateMedicalProfessionalLicensesColumns.TertiaryState] as string;
                        retVal.TertiaryLicenseNumber = reader[Constants.OtherStateMedicalProfessionalLicensesColumns.TertiaryLicenseNumber] as string;
                        retVal.TertiaryExpirationDate = Convert.IsDBNull(reader[Constants.OtherStateMedicalProfessionalLicensesColumns.TertiaryExpirationDate]) ? null : (DateTime?)reader[Constants.OtherStateMedicalProfessionalLicensesColumns.TertiaryExpirationDate];
                        retVal.TertiaryLastExpirationDate = Convert.IsDBNull(reader[Constants.OtherStateMedicalProfessionalLicensesColumns.TertiaryLastExpirationDate]) ? null : (DateTime?)reader[Constants.OtherStateMedicalProfessionalLicensesColumns.TertiaryLastExpirationDate];
                        retVal.Completed = Convert.IsDBNull(reader[Constants.AttestationQuestionsColumns.Completed]) ? null : (bool?)reader[Constants.AttestationQuestionsColumns.Completed];
                    }
                }
            }

            if (deepLoad && retVal != null)
            {
                retVal.Attachments = AttachmentHandler.Instance.GetReferencedAttachments(conn, trans, "OtherStateMedicalProfessionalLicensesId", retVal.OtherStateMedicalProfessionalLicensesId);
            }

            return retVal;
        }


        public int Insert(OtherStateMedicalProfessionalLicenses info)
        {
            int retVal;

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                retVal = Insert(conn, null, info);
            }

            return retVal;
        }

        public int Insert(SqlConnection conn, SqlTransaction trans, OtherStateMedicalProfessionalLicenses info)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO OtherStateMedicalProfessionalLicenses
                                                    (PrimaryState, PrimaryLicenseNumber, PrimaryExpirationDate, PrimaryLastExpirationDate, SecondaryState, SecondaryLicenseNumber, SecondaryExpirationDate, SecondaryLastExpirationDate, TertiaryState, TertiaryLicenseNumber, TertiaryExpirationDate, TertiaryLastExpirationDate, Completed)
                                                    OUTPUT INSERTED.OtherStateMedicalProfessionalLicensesId
                                                    VALUES
                                                    (@primaryState, @primaryLicenseNumber, @primaryExpirationDate, @primaryLastExpirationDate, @secondaryState, @secondaryLicenseNumber, @secondaryExpirationDate, @secondaryLastExpirationDate, @tertiaryState, @tertiaryLicenseNumber, @tertiaryExpirationDate, @tertiaryLastExpirationDate, @completed)", conn);
            if (trans != null) sqlCommand.Transaction = trans;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@primaryState", info.PrimaryState);
            sqlCommand.Parameters.AddWithValue("@primaryLicenseNumber", info.PrimaryLicenseNumber);
            sqlCommand.Parameters.AddWithValue("@primaryExpirationDate", info.PrimaryExpirationDate);
            sqlCommand.Parameters.AddWithValue("@primaryLastExpirationDate", info.PrimaryLastExpirationDate);

            sqlCommand.Parameters.AddWithValue("@secondaryState", info.SecondaryState);
            sqlCommand.Parameters.AddWithValue("@secondaryLicenseNumber", info.SecondaryLicenseNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryExpirationDate", info.SecondaryExpirationDate);
            sqlCommand.Parameters.AddWithValue("@secondaryLastExpirationDate", info.SecondaryLastExpirationDate);

            sqlCommand.Parameters.AddWithValue("@tertiaryState", info.TertiaryState);
            sqlCommand.Parameters.AddWithValue("@tertiaryLicenseNumber", info.TertiaryLicenseNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryExpirationDate", info.TertiaryExpirationDate);
            sqlCommand.Parameters.AddWithValue("@tertiaryLastExpirationDate", info.TertiaryLastExpirationDate);

            sqlCommand.Parameters.AddWithValue("@completed", info.Completed);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            return (int)sqlCommand.ExecuteScalar();
        }

        public void Update(OtherStateMedicalProfessionalLicenses info)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                Update(conn, null, info);
            }
        }

        public void Update(SqlConnection conn, SqlTransaction trans, OtherStateMedicalProfessionalLicenses info)
        {
            var sqlCommand = new SqlCommand(@"UPDATE OtherStateMedicalProfessionalLicenses
                                                SET
                                                    PrimaryState = @primaryState, 
                                                    PrimaryLicenseNumber = @primaryLicenseNumber, 
                                                    PrimaryExpirationDate = @primaryExpirationDate, 
                                                    PrimaryLastExpirationDate = @primaryLastExpirationDate, 

                                                    SecondaryState = @secondaryState, 
                                                    SecondaryLicenseNumber = @secondaryLicenseNumber, 
                                                    SecondaryExpirationDate = @secondaryExpirationDate, 
                                                    SecondaryLastExpirationDate = @secondaryLastExpirationDate , 
    
                                                    TertiaryState = @tertiaryState,
                                                    TertiaryLicenseNumber = @tertiaryLicenseNumber,
                                                    TertiaryExpirationDate = @tertiaryExpirationDate, 
                                                    TertiaryLastExpirationDate = @tertiaryLastExpirationDate,

                                                    Completed = @completed
                                                    
                                                WHERE OtherStateMedicalProfessionalLicensesId = @otherStateMedicalProfessionalLicensesId", conn);

            if (trans != null) sqlCommand.Transaction = trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@otherStateMedicalProfessionalLicensesId", info.OtherStateMedicalProfessionalLicensesId);
            sqlCommand.Parameters.AddWithValue("@primaryState", info.PrimaryState);
            sqlCommand.Parameters.AddWithValue("@primaryLicenseNumber", info.PrimaryLicenseNumber);
            sqlCommand.Parameters.AddWithValue("@primaryExpirationDate", info.PrimaryExpirationDate);
            sqlCommand.Parameters.AddWithValue("@primaryLastExpirationDate", info.PrimaryLastExpirationDate);

            sqlCommand.Parameters.AddWithValue("@secondaryState", info.SecondaryState);
            sqlCommand.Parameters.AddWithValue("@secondaryLicenseNumber", info.SecondaryLicenseNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryExpirationDate", info.SecondaryExpirationDate);
            sqlCommand.Parameters.AddWithValue("@secondaryLastExpirationDate", info.SecondaryLastExpirationDate);

            sqlCommand.Parameters.AddWithValue("@tertiaryState", info.TertiaryState);
            sqlCommand.Parameters.AddWithValue("@tertiaryLicenseNumber", info.TertiaryLicenseNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryExpirationDate", info.TertiaryExpirationDate);
            sqlCommand.Parameters.AddWithValue("@tertiaryLastExpirationDate", info.TertiaryLastExpirationDate);

            sqlCommand.Parameters.AddWithValue("@completed", info.Completed);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            sqlCommand.ExecuteNonQuery();
        }
    }
}