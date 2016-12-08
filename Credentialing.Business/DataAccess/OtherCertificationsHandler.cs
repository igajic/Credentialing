using System;
using System.Data;
using Credentialing.Entities.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using Credentialing.Entities;

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
                        retVal.OtherCertificationsId = (int) reader[Constants.OtherCertificationsColumns.OtherCertificationsId];
                        retVal.PrimaryType = reader[Constants.OtherCertificationsColumns.PrimaryType] as string;
                        retVal.PrimaryNumber = reader[Constants.OtherCertificationsColumns.PrimaryNumber] as string;
                        retVal.PrimaryDate = (DateTime) reader[Constants.OtherCertificationsColumns.PrimaryDate];
                        retVal.SecondaryType = reader[Constants.OtherCertificationsColumns.SecondaryType] as string;
                        retVal.SecondaryNumber = reader[Constants.OtherCertificationsColumns.SecondaryNumber] as string;
                        retVal.SecondaryDate = (DateTime) reader[Constants.OtherCertificationsColumns.SecondaryDate];
                    }
                }
            }

            return retVal;
        }
    }
}