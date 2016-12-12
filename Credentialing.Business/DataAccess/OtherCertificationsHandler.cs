using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class OtherCertificationsHandler
    {
        private static OtherCertificationsHandler _instance;

        public static OtherCertificationsHandler Instance
        {
            get { return _instance ?? (_instance = new OtherCertificationsHandler()); }
        }

        private OtherCertificationsHandler()
        {
        }

        public OtherCertifications GetById(int otherCertificationsId, bool deepLoad = false)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                return GetById(conn, null, otherCertificationsId, deepLoad);
            }
        }

        public OtherCertifications GetById(SqlConnection conn, SqlTransaction trans, int otherCertificationsId, bool deepLoad = false)
        {
            OtherCertifications retVal = null;

            var sqlCommand = new SqlCommand(@"SELECT *
                                                  FROM OtherCertifications
                                                  WHERE InternshipId = @internshipId", conn);
            sqlCommand.Parameters.AddWithValue("@internshipId", otherCertificationsId);
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
                        retVal = new OtherCertifications();
                        retVal.OtherCertificationsId = (int)reader[Constants.OtherCertificationsColumns.OtherCertificationsId];
                        retVal.PrimaryType = reader[Constants.OtherCertificationsColumns.PrimaryType] as string;
                        retVal.PrimaryNumber = reader[Constants.OtherCertificationsColumns.PrimaryNumber] as string;
                        retVal.PrimaryDate = Convert.IsDBNull(reader[Constants.OtherCertificationsColumns.PrimaryDate]) ? null : (DateTime?)reader[Constants.OtherCertificationsColumns.PrimaryDate];
                        retVal.SecondaryType = reader[Constants.OtherCertificationsColumns.SecondaryType] as string;
                        retVal.SecondaryNumber = reader[Constants.OtherCertificationsColumns.SecondaryNumber] as string;
                        retVal.SecondaryDate = Convert.IsDBNull(reader[Constants.OtherCertificationsColumns.SecondaryDate]) ? null : (DateTime?)reader[Constants.OtherCertificationsColumns.SecondaryDate];
                    }
                }
            }

            if (deepLoad && retVal != null)
            {
                retVal.Attachments = AttachmentHandler.Instance.GetReferencedAttachments(conn, trans, "OtherCertificationsId", retVal.OtherCertificationsId);
            }

            return retVal;
        }

        public int Insert(OtherCertifications info)
        {
            int retVal;

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                retVal = Insert(conn, null, info);
            }

            return retVal;
        }

        public int Insert(SqlConnection conn, SqlTransaction trans, OtherCertifications info)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO OtherCertifications
                                                    (PrimaryType, PrimaryNumber, PrimaryDate, SecondaryType, SecondaryNumber, SecondaryDate)
                                                    OUTPUT INSERTED.OtherCertificationsId
                                                    VALUES
                                                    (@primaryType, @primaryNumber, @primaryDate, @secondaryType, @secondaryNumber, @secondaryDate)", conn);
            if (trans != null) sqlCommand.Transaction = trans;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@primaryType", info.PrimaryType);
            sqlCommand.Parameters.AddWithValue("@primaryNumber", info.PrimaryNumber);
            sqlCommand.Parameters.AddWithValue("@primaryDate", info.PrimaryDate);
            sqlCommand.Parameters.AddWithValue("@secondaryType", info.SecondaryType);
            sqlCommand.Parameters.AddWithValue("@secondaryNumber", info.SecondaryNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryDate", info.SecondaryDate);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            return (int)sqlCommand.ExecuteScalar();
        }

        public void Update(OtherCertifications info)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                Update(conn, null, info);
            }
        }

        public void Update(SqlConnection conn, SqlTransaction trans, OtherCertifications info)
        {
            var sqlCommand = new SqlCommand(@"UPDATE OtherCertifications
                                                SET
                                                    PrimaryType = @primaryType,
                                                    PrimaryNumber = @primaryNumber,
                                                    PrimaryDate = @primaryDate, 
                                                    SecondaryType = @secondaryType, 
                                                    SecondaryNumber = @secondaryNumber,
                                                    SecondaryDate = @secondaryDate
                                                WHERE OtherCertificationsId = @otherCertifications", conn);
            if (trans != null) sqlCommand.Transaction = trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            sqlCommand.Parameters.AddWithValue("@otherCertifications", info.OtherCertificationsId);
            sqlCommand.Parameters.AddWithValue("@primaryType", info.PrimaryType);
            sqlCommand.Parameters.AddWithValue("@primaryNumber", info.PrimaryNumber);
            sqlCommand.Parameters.AddWithValue("@primaryDate", info.PrimaryDate);
            sqlCommand.Parameters.AddWithValue("@secondaryType", info.SecondaryType);
            sqlCommand.Parameters.AddWithValue("@secondaryNumber", info.SecondaryNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryDate", info.SecondaryDate);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            sqlCommand.ExecuteNonQuery();
        }
    }
}