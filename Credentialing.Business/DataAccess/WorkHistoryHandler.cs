using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class WorkHistoryHandler
    {
        private static WorkHistoryHandler _instance;

        public static WorkHistoryHandler Instance
        {
            get { return _instance ?? (_instance = new WorkHistoryHandler()); }
        }

        private WorkHistoryHandler()
        {
        }

        public WorkHistory GetById(int workHistoryId, bool deepLoad = false)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                return GetById(conn, null, workHistoryId);
            }
        }

        public WorkHistory GetById(SqlConnection conn, SqlTransaction trans, int workHistoryId, bool deepLoad = false)
        {
            WorkHistory retVal = null;

            var sqlCommand = new SqlCommand(@"SELECT *
                                                  FROM WorkHistories
                                                  WHERE WorkHistoryId = @workHistoryId", conn);
            sqlCommand.Parameters.AddWithValue("@workHistoryId", workHistoryId);
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
                        retVal = new WorkHistory();

                        retVal.WorkHistoryId = (int)reader[Constants.WorkHistoriesColumns.WorkHistoryId];
                        retVal.PrimaryNamePracticeEmployer = reader[Constants.WorkHistoriesColumns.PrimaryNamePracticeEmployer] as string;
                        retVal.PrimaryContactName = reader[Constants.WorkHistoriesColumns.PrimaryContactName] as string;
                        retVal.PrimaryTelephoneNumber = reader[Constants.WorkHistoriesColumns.PrimaryTelephoneNumber] as string;
                        retVal.PrimaryFaxNumber = reader[Constants.WorkHistoriesColumns.PrimaryFaxNumber] as string;
                        retVal.PrimaryPracticeAddress = reader[Constants.WorkHistoriesColumns.PrimaryPracticeAddress] as string;
                        retVal.PrimaryCity = reader[Constants.WorkHistoriesColumns.PrimaryCity] as string;
                        retVal.PrimaryState = reader[Constants.WorkHistoriesColumns.PrimaryState] as string;
                        retVal.PrimaryZip = reader[Constants.WorkHistoriesColumns.PrimaryZip] as string;
                        retVal.PrimaryStartDate = (DateTime)reader[Constants.WorkHistoriesColumns.PrimaryStartDate];
                        retVal.PrimaryEndDate = (DateTime)reader[Constants.WorkHistoriesColumns.PrimaryEndDate];

                        retVal.SecondaryNamePracticeEmployer = reader[Constants.WorkHistoriesColumns.SecondaryNamePracticeEmployer] as string;
                        retVal.SecondaryContactName = reader[Constants.WorkHistoriesColumns.SecondaryContactName] as string;
                        retVal.SecondaryTelephoneNumber = reader[Constants.WorkHistoriesColumns.SecondaryTelephoneNumber] as string;
                        retVal.SecondaryFaxNumber = reader[Constants.WorkHistoriesColumns.SecondaryFaxNumber] as string;
                        retVal.SecondaryPracticeAddress = reader[Constants.WorkHistoriesColumns.SecondaryPracticeAddress] as string;
                        retVal.SecondaryCity = reader[Constants.WorkHistoriesColumns.SecondaryCity] as string;
                        retVal.SecondaryState = reader[Constants.WorkHistoriesColumns.SecondaryState] as string;
                        retVal.SecondaryZip = reader[Constants.WorkHistoriesColumns.SecondaryZip] as string;
                        retVal.SecondaryStartDate = (DateTime)reader[Constants.WorkHistoriesColumns.SecondaryStartDate];
                        retVal.SecondaryEndDate = (DateTime)reader[Constants.WorkHistoriesColumns.SecondaryEndDate];

                        retVal.TertiaryNamePracticeEmployer = reader[Constants.WorkHistoriesColumns.TertiaryNamePracticeEmployer] as string;
                        retVal.TertiaryContactName = reader[Constants.WorkHistoriesColumns.TertiaryContactName] as string;
                        retVal.TertiaryTelephoneNumber = reader[Constants.WorkHistoriesColumns.TertiaryTelephoneNumber] as string;
                        retVal.TertiaryFaxNumber = reader[Constants.WorkHistoriesColumns.TertiaryFaxNumber] as string;
                        retVal.TertiaryPracticeAddress = reader[Constants.WorkHistoriesColumns.TertiaryPracticeAddress] as string;
                        retVal.TertiaryCity = reader[Constants.WorkHistoriesColumns.TertiaryCity] as string;
                        retVal.TertiaryState = reader[Constants.WorkHistoriesColumns.TertiaryState] as string;
                        retVal.TertiaryZip = reader[Constants.WorkHistoriesColumns.TertiaryZip] as string;
                        retVal.TertiaryStartDate = (DateTime)reader[Constants.WorkHistoriesColumns.TertiaryStartDate];
                        retVal.TertiaryEndDate = (DateTime)reader[Constants.WorkHistoriesColumns.TertiaryEndDate];
                    }
                }
            }

            if (deepLoad && retVal != null)
            {
                retVal.Attachments = AttachmentHandler.Instance.GetReferencedAttachments(conn, trans, "WorkHistoryId", retVal.WorkHistoryId);
            }

            return retVal;
        }

        public void Update(WorkHistory history)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                Update(conn, null, history);
            }
        }

        public void Update(SqlConnection conn, SqlTransaction trans, WorkHistory history)
        {
            var sqlCommand = new SqlCommand(@"UPDATE WorkHistory
                                                SET
                                                    PrimaryNamePracticeEmployer = @primaryNamePracticeEmployer,
                                                    PrimaryContactName = @primaryContactName,
                                                    PrimaryTelephoneNumber = @primaryTelephoneNumber,
                                                    PrimaryFaxNumber = @primaryFaxNumber,
                                                    PrimaryPracticeAddress = @primaryPracticeAddress,
                                                    PrimaryCity = @primaryCity,
                                                    PrimaryState = @primaryState,
                                                    PrimaryZip = @primaryZip,
                                                    PrimaryStartDate = @primaryStartDate,
                                                    PrimaryEndDate = @primaryEndDate,

                                                    SecondaryNamePracticeEmployer = @secondaryNamePracticeEmployer,
                                                    SecondaryContactName = @secondaryContactName,
                                                    SecondaryTelephoneNumber = @secondaryTelephoneNumber,
                                                    SecondaryFaxNumber = @secondaryFaxNumber,
                                                    SecondaryPracticeAddress = @secondaryPracticeAddress,
                                                    SecondaryCity = @secondaryCity,
                                                    SecondaryState = @secondaryState,
                                                    SecondaryZip = @secondaryZip,
                                                    SecondaryStartDate = @secondaryStartDate,
                                                    SecondaryEndDate = @secondaryEndDate,

                                                    TertiaryNamePracticeEmployer = @tertiaryNamePracticeEmployer,
                                                    TertiaryContactName = @tertiaryContactName,
                                                    TertiaryTelephoneNumber = @tertiaryTelephoneNumber,
                                                    TertiaryFaxNumber = @tertiaryFaxNumber,
                                                    TertiaryPracticeAddress = @tertiaryPracticeAddress,
                                                    TertiaryCity = @tertiaryCity,
                                                    TertiaryState = @tertiaryState,
                                                    TertiaryZip = @tertiaryZip,
                                                    TertiaryStartDate = @tertiaryStartDate,
                                                    TertiaryEndDate = @tertiaryEndDate

                                                WHERE WorkHistoryId = @workHistoryId", conn);

            if (trans != null) sqlCommand.Transaction = trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@workHistoryId", history.WorkHistoryId);
            sqlCommand.Parameters.AddWithValue("@primaryNamePracticeEmployer", history.PrimaryNamePracticeEmployer);
            sqlCommand.Parameters.AddWithValue("@primaryContactName", history.PrimaryContactName);
            sqlCommand.Parameters.AddWithValue("@primaryTelephoneNumber", history.PrimaryTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@primaryFaxNumber", history.SecondaryFaxNumber);
            sqlCommand.Parameters.AddWithValue("@primaryPracticeAddress", history.SecondaryPracticeAddress);
            sqlCommand.Parameters.AddWithValue("@primaryCity", history.SecondaryCity);
            sqlCommand.Parameters.AddWithValue("@primaryState", history.PrimaryState);
            sqlCommand.Parameters.AddWithValue("@primaryZip", history.PrimaryZip);
            sqlCommand.Parameters.AddWithValue("@primaryStartDate", history.PrimaryStartDate);
            sqlCommand.Parameters.AddWithValue("@primaryEndDate", history.PrimaryEndDate);

            sqlCommand.Parameters.AddWithValue("@secondaryNamePracticeEmployer", history.SecondaryNamePracticeEmployer);
            sqlCommand.Parameters.AddWithValue("@secondaryContactName", history.SecondaryContactName);
            sqlCommand.Parameters.AddWithValue("@secondaryTelephoneNumber", history.SecondaryTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryFaxNumber", history.SecondaryFaxNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryPracticeAddress", history.SecondaryPracticeAddress);
            sqlCommand.Parameters.AddWithValue("@secondaryCity", history.SecondaryCity);
            sqlCommand.Parameters.AddWithValue("@secondaryState", history.SecondaryState);
            sqlCommand.Parameters.AddWithValue("@secondaryZip", history.SecondaryZip);
            sqlCommand.Parameters.AddWithValue("@secondaryStartDate", history.SecondaryStartDate);
            sqlCommand.Parameters.AddWithValue("@secondaryEndDate", history.SecondaryEndDate);

            sqlCommand.Parameters.AddWithValue("@tertiaryNamePracticeEmployer", history.TertiaryNamePracticeEmployer);
            sqlCommand.Parameters.AddWithValue("@tertiaryContactName", history.TertiaryContactName);
            sqlCommand.Parameters.AddWithValue("@tertiaryTelephoneNumber", history.TertiaryTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryFaxNumber", history.TertiaryFaxNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryPracticeAddress", history.TertiaryPracticeAddress);
            sqlCommand.Parameters.AddWithValue("@tertiaryCity", history.TertiaryCity);
            sqlCommand.Parameters.AddWithValue("@tertiaryState", history.TertiaryState);
            sqlCommand.Parameters.AddWithValue("@tertiaryZip", history.TertiaryZip);
            sqlCommand.Parameters.AddWithValue("@tertiaryStartDate", history.TertiaryStartDate);
            sqlCommand.Parameters.AddWithValue("@tertiaryEndDate", history.TertiaryEndDate);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            sqlCommand.ExecuteNonQuery();
        }

        public int Insert(WorkHistory history)
        {
            int retVal;

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                retVal = Insert(conn, null, history);
            }

            return retVal;
        }

        public int Insert(SqlConnection conn, SqlTransaction trans, WorkHistory history)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO WorkHistories
                                                    (PrimaryNamePracticeEmployer, PrimaryContactName, PrimaryTelephoneNumber, PrimaryFaxNumber, PrimaryPracticeAddress, PrimaryCity, PrimaryState, PrimaryZip, PrimaryStartDate, PrimaryEndDate, SecondaryNamePracticeEmployer, SecondaryContactName, SecondaryTelephoneNumber, SecondaryFaxNumber, SecondaryPracticeAddress, SecondaryCity, SecondaryState, SecondaryZip, SecondaryStartDate, SecondaryEndDate, TertiaryNamePracticeEmployer, TertiaryContactName, TertiaryTelephoneNumber, TertiaryFaxNumber, TertiaryPracticeAddress, TertiaryCity, TertiaryState, TertiaryZip, TertiaryStartDate, TertiaryEndDate)
                                                    OUTPUT INSERTED.BoardCertificationId
                                                    VALUES
                                                    (@primaryNamePracticeEmployer, @primaryContactName, @primaryTelephoneNumber, @primaryFaxNumber, @primaryPracticeAddress, @primaryCity, @primaryState, @primaryZip, @primaryStartDate, @primaryEndDate, @secondaryNamePracticeEmployer, @secondaryContactName, @secondaryTelephoneNumber, @secondaryFaxNumber, @secondaryPracticeAddress, @secondaryCity, @secondaryState, @secondaryZip, @secondaryStartDate, @secondaryEndDate, @tertiaryNamePracticeEmployer, @tertiaryContactName, @tertiaryTelephoneNumber, @tertiaryFaxNumber, @tertiaryPracticeAddress, @tertiaryCity, @tertiaryState, @tertiaryZip, @tertiaryStartDate, @tertiaryEndDate)", conn);
            if (trans != null) sqlCommand.Transaction = trans;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@primaryNamePracticeEmployer", history.PrimaryNamePracticeEmployer);
            sqlCommand.Parameters.AddWithValue("@primaryContactName", history.PrimaryContactName);
            sqlCommand.Parameters.AddWithValue("@primaryTelephoneNumber", history.PrimaryTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@primaryFaxNumber", history.SecondaryFaxNumber);
            sqlCommand.Parameters.AddWithValue("@primaryPracticeAddress", history.SecondaryPracticeAddress);
            sqlCommand.Parameters.AddWithValue("@primaryCity", history.SecondaryCity);
            sqlCommand.Parameters.AddWithValue("@primaryState", history.PrimaryState);
            sqlCommand.Parameters.AddWithValue("@primaryZip", history.PrimaryZip);
            sqlCommand.Parameters.AddWithValue("@primaryStartDate", history.PrimaryStartDate);
            sqlCommand.Parameters.AddWithValue("@primaryEndDate", history.PrimaryEndDate);

            sqlCommand.Parameters.AddWithValue("@secondaryNamePracticeEmployer", history.SecondaryNamePracticeEmployer);
            sqlCommand.Parameters.AddWithValue("@secondaryContactName", history.SecondaryContactName);
            sqlCommand.Parameters.AddWithValue("@secondaryTelephoneNumber", history.SecondaryTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryFaxNumber", history.SecondaryFaxNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryPracticeAddress", history.SecondaryPracticeAddress);
            sqlCommand.Parameters.AddWithValue("@secondaryCity", history.SecondaryCity);
            sqlCommand.Parameters.AddWithValue("@secondaryState", history.SecondaryState);
            sqlCommand.Parameters.AddWithValue("@secondaryZip", history.SecondaryZip);
            sqlCommand.Parameters.AddWithValue("@secondaryStartDate", history.SecondaryStartDate);
            sqlCommand.Parameters.AddWithValue("@secondaryEndDate", history.SecondaryEndDate);

            sqlCommand.Parameters.AddWithValue("@tertiaryNamePracticeEmployer", history.TertiaryNamePracticeEmployer);
            sqlCommand.Parameters.AddWithValue("@tertiaryContactName", history.TertiaryContactName);
            sqlCommand.Parameters.AddWithValue("@tertiaryTelephoneNumber", history.TertiaryTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryFaxNumber", history.TertiaryFaxNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryPracticeAddress", history.TertiaryPracticeAddress);
            sqlCommand.Parameters.AddWithValue("@tertiaryCity", history.TertiaryCity);
            sqlCommand.Parameters.AddWithValue("@tertiaryState", history.TertiaryState);
            sqlCommand.Parameters.AddWithValue("@tertiaryZip", history.TertiaryZip);
            sqlCommand.Parameters.AddWithValue("@tertiaryStartDate", history.TertiaryStartDate);
            sqlCommand.Parameters.AddWithValue("@tertiaryEndDate", history.TertiaryEndDate);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            return (int)sqlCommand.ExecuteScalar();
        }
    }
}