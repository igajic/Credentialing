using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class PeerReferencesHandler
    {
        private static PeerReferencesHandler _instance;

        public static PeerReferencesHandler Instance
        {
            get { return _instance ?? (_instance = new PeerReferencesHandler()); }
        }

        private PeerReferencesHandler()
        {
        }

        public PeerReferences GetById(int peerReferencesId, bool deepLoad = false)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                return GetById(conn, null, peerReferencesId, deepLoad);
            }
        }

        public PeerReferences GetById(SqlConnection conn, SqlTransaction trans, int peerReferencesId, bool deepLoad = false)
        {
            PeerReferences retVal = null;

            var sqlCommand = new SqlCommand("SELECT * FROM PeerReferences WHERE PeerReferencesId = @peerReferencesId", conn);
            sqlCommand.Parameters.AddWithValue("@practiceInformationId", peerReferencesId);
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
                        retVal = new PeerReferences();

                        retVal.PeerReferencesId = (int)reader[Constants.PeerReferencesColumns.PeerReferencesId];
                        retVal.PrimaryNameReference = reader[Constants.PeerReferencesColumns.PrimaryNameReference] as string;
                        retVal.PrimarySpecialty = reader[Constants.PeerReferencesColumns.PrimarySpecialty] as string;
                        retVal.PrimaryTelephoneNumber = reader[Constants.PeerReferencesColumns.PrimaryTelephoneNumber] as string;
                        retVal.PrimaryMailingAddress = reader[Constants.PeerReferencesColumns.PrimaryMailingAddress] as string;
                        retVal.PrimaryCity = reader[Constants.PeerReferencesColumns.PrimaryCity] as string;
                        retVal.PrimaryState = reader[Constants.PeerReferencesColumns.PrimaryState] as string;
                        retVal.PrimaryZip = reader[Constants.PeerReferencesColumns.PrimaryZip] as string;

                        retVal.SecondaryNameReference = reader[Constants.PeerReferencesColumns.SecondaryNameReference] as string;
                        retVal.SecondarySpecialty = reader[Constants.PeerReferencesColumns.SecondarySpecialty] as string;
                        retVal.SecondaryTelephoneNumber = reader[Constants.PeerReferencesColumns.SecondaryTelephoneNumber] as string;
                        retVal.SecondaryMailingAddress = reader[Constants.PeerReferencesColumns.SecondaryMailingAddress] as string;
                        retVal.SecondaryCity = reader[Constants.PeerReferencesColumns.SecondaryCity] as string;
                        retVal.SecondaryState = reader[Constants.PeerReferencesColumns.SecondaryState] as string;
                        retVal.SecondaryZip = reader[Constants.PeerReferencesColumns.SecondaryZip] as string;

                        retVal.TertiaryNameReference = reader[Constants.PeerReferencesColumns.TertiaryNameReference] as string;
                        retVal.TertiarySpecialty = reader[Constants.PeerReferencesColumns.TertiarySpecialty] as string;
                        retVal.TertiaryTelephoneNumber = reader[Constants.PeerReferencesColumns.TertiaryTelephoneNumber] as string;
                        retVal.TertiaryMailingAddress = reader[Constants.PeerReferencesColumns.TertiaryMailingAddress] as string;
                        retVal.TertiaryCity = reader[Constants.PeerReferencesColumns.TertiaryCity] as string;
                        retVal.TertiaryState = reader[Constants.PeerReferencesColumns.TertiaryState] as string;
                        retVal.TertiaryZip = reader[Constants.PeerReferencesColumns.TertiaryZip] as string;

                        retVal.Completed = Convert.IsDBNull(reader[Constants.AttestationQuestionsColumns.Completed]) ? null : (bool?)reader[Constants.AttestationQuestionsColumns.Completed];
                    }
                }
            }

            return retVal;
        }

        public int Insert(PeerReferences info)
        {
            int retVal;

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                retVal = Insert(conn, null, info);
            }

            return retVal;
        }

        public int Insert(SqlConnection conn, SqlTransaction trans, PeerReferences info)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO PeerReferences
                                                    (PrimaryNameReference, PrimarySpecialty, PrimaryTelephoneNumber, PrimaryMailingAddress, PrimaryCity, PrimaryState, PrimaryZip, SecondaryNameReference, SecondarySpecialty, SecondaryTelephoneNumber, SecondaryMailingAddress, SecondaryCity, SecondaryState, SecondaryZip, TertiaryNameReference, TertiarySpecialty, TertiaryTelephoneNumber, TertiaryMailingAddress, TertiaryCity, TertiaryState, TertiaryZip, Completed)
                                                    OUTPUT INSERTED.PeerReferencesId
                                                    VALUES
                                                    (@primaryNameReference, @primarySpecialty, @primaryTelephoneNumber, @primaryMailingAddress, @primaryCity, @primaryState, @primaryZip, @secondaryNameReference, @secondarySpecialty, @secondaryTelephoneNumber, @secondaryMailingAddress, @secondaryCity, @secondaryState, @secondaryZip, @tertiaryNameReference, @tertiarySpecialty, @tertiaryTelephoneNumber, @tertiaryMailingAddress, @tertiaryCity, @tertiaryState, @tertiaryZip, @completed)", conn);
            if (trans != null) sqlCommand.Transaction = trans;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@primaryNameReference", info.PrimaryNameReference);
            sqlCommand.Parameters.AddWithValue("@primarySpecialty", info.PrimarySpecialty);
            sqlCommand.Parameters.AddWithValue("@primaryTelephoneNumber", info.PrimaryTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@primaryMailingAddress", info.PrimaryMailingAddress);
            sqlCommand.Parameters.AddWithValue("@primaryCity", info.PrimaryCity);
            sqlCommand.Parameters.AddWithValue("@primaryState", info.PrimaryState);
            sqlCommand.Parameters.AddWithValue("@primaryZip", info.PrimaryZip);

            sqlCommand.Parameters.AddWithValue("@secondaryNameReference", info.SecondaryNameReference);
            sqlCommand.Parameters.AddWithValue("@secondarySpecialty", info.SecondarySpecialty);
            sqlCommand.Parameters.AddWithValue("@secondaryTelephoneNumber", info.SecondaryTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryMailingAddress", info.SecondaryMailingAddress);
            sqlCommand.Parameters.AddWithValue("@secondaryCity", info.SecondaryCity);
            sqlCommand.Parameters.AddWithValue("@secondaryState", info.SecondaryState);
            sqlCommand.Parameters.AddWithValue("@secondaryZip", info.SecondaryZip);

            sqlCommand.Parameters.AddWithValue("@tertiaryNameReference", info.TertiaryNameReference);
            sqlCommand.Parameters.AddWithValue("@tertiarySpecialty", info.TertiarySpecialty);
            sqlCommand.Parameters.AddWithValue("@tertiaryTelephoneNumber", info.TertiaryTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryMailingAddress", info.TertiaryMailingAddress);
            sqlCommand.Parameters.AddWithValue("@tertiaryCity", info.TertiaryCity);
            sqlCommand.Parameters.AddWithValue("@tertiaryState", info.TertiaryState);
            sqlCommand.Parameters.AddWithValue("@tertiaryZip", info.TertiaryZip);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            return (int)sqlCommand.ExecuteScalar();
        }

        public void Update(PeerReferences info)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                Update(conn, null, info);
            }
        }

        public void Update(SqlConnection conn, SqlTransaction trans, PeerReferences info)
        {
            var sqlCommand = new SqlCommand(@"UPDATE PeerReferences
                                                SET
                                                    PrimaryNameReference = @primaryNameReference,
                                                    PrimarySpecialty = @primarySpecialty,
                                                    PrimaryTelephoneNumber = @primaryTelephoneNumber,
                                                    PrimaryMailingAddress = @primaryMailingAddress,
                                                    PrimaryCity = @primaryCity,
                                                    PrimaryState = @primaryState,
                                                    PrimaryZip = @primaryZip,

                                                    SecondaryNameReference = @secondaryNameReference,
                                                    SecondarySpecialty = @secondarySpecialty,
                                                    SecondaryTelephoneNumber = @secondaryTelephoneNumber,
                                                    SecondaryMailingAddress = @secondaryMailingAddress,
                                                    SecondaryCity = @secondaryCity,
                                                    SecondaryState = @secondaryState,
                                                    SecondaryZip = @secondaryZip,

                                                    TertiaryNameReference = @tertiaryNameReference,
                                                    TertiarySpecialty = @tertiarySpecialty,
                                                    TertiaryTelephoneNumber = @tertiaryTelephoneNumber,
                                                    TertiaryMailingAddress = @tertiaryMailingAddress,
                                                    TertiaryCity = @tertiaryCity,
                                                    TertiaryState = @tertiaryState,
                                                    TertiaryZip = @tertiaryZip,

                                                    Completed = @completed
                                                WHERE PeerReferencesId = @peerReferencesId", conn);

            if (trans != null) sqlCommand.Transaction = trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@peerReferencesId", info.PeerReferencesId);
            sqlCommand.Parameters.AddWithValue("@primaryNameReference", info.PrimaryNameReference);
            sqlCommand.Parameters.AddWithValue("@primarySpecialty", info.PrimarySpecialty);
            sqlCommand.Parameters.AddWithValue("@primaryTelephoneNumber", info.PrimaryTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@primaryMailingAddress", info.PrimaryMailingAddress);
            sqlCommand.Parameters.AddWithValue("@primaryCity", info.PrimaryCity);
            sqlCommand.Parameters.AddWithValue("@primaryState", info.PrimaryState);
            sqlCommand.Parameters.AddWithValue("@primaryZip", info.PrimaryZip);

            sqlCommand.Parameters.AddWithValue("@secondaryNameReference", info.SecondaryNameReference);
            sqlCommand.Parameters.AddWithValue("@secondarySpecialty", info.SecondarySpecialty);
            sqlCommand.Parameters.AddWithValue("@secondaryTelephoneNumber", info.SecondaryTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryMailingAddress", info.SecondaryMailingAddress);
            sqlCommand.Parameters.AddWithValue("@secondaryCity", info.SecondaryCity);
            sqlCommand.Parameters.AddWithValue("@secondaryState", info.SecondaryState);
            sqlCommand.Parameters.AddWithValue("@secondaryZip", info.SecondaryZip);

            sqlCommand.Parameters.AddWithValue("@tertiaryNameReference", info.TertiaryNameReference);
            sqlCommand.Parameters.AddWithValue("@tertiarySpecialty", info.TertiarySpecialty);
            sqlCommand.Parameters.AddWithValue("@tertiaryTelephoneNumber", info.TertiaryTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryMailingAddress", info.TertiaryMailingAddress);
            sqlCommand.Parameters.AddWithValue("@tertiaryCity", info.TertiaryCity);
            sqlCommand.Parameters.AddWithValue("@tertiaryState", info.TertiaryState);
            sqlCommand.Parameters.AddWithValue("@tertiaryZip", info.TertiaryZip);

            sqlCommand.Parameters.AddWithValue("@completed", info.Completed);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            sqlCommand.ExecuteNonQuery();
        }
    }
}