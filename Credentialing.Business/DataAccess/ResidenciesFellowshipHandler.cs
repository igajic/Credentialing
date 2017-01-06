using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class ResidenciesFellowshipHandler
    {
        private static ResidenciesFellowshipHandler _instance;

        public static ResidenciesFellowshipHandler Instance
        {
            get { return _instance ?? (_instance = new ResidenciesFellowshipHandler()); }
        }

        private ResidenciesFellowshipHandler()
        {
        }

        public ResidenciesFellowship GetById(int residenciesFellowshipId, bool deepLoad = false)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                return GetById(conn, null, residenciesFellowshipId, deepLoad);
            }
        }

        public ResidenciesFellowship GetById(SqlConnection conn, SqlTransaction trans, int residenciesFellowshipId, bool deepLoad = false)
        {
            ResidenciesFellowship retVal = null;

            var sqlCommand = new SqlCommand(@"SELECT *
                                                  FROM ResidenciesFellowships
                                                  WHERE ResidenciesFellowshipId = @residenciesFellowshipId", conn);
            sqlCommand.Parameters.AddWithValue("@residenciesFellowshipId", residenciesFellowshipId);
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
                        retVal = new ResidenciesFellowship();

                        retVal.ResidenciesFellowshipId = (int)reader[Constants.ResidenciesFellowshipsColumns.ResidenciesFellowshipId];
                        retVal.PrimaryInstitution = reader[Constants.ResidenciesFellowshipsColumns.PrimaryInstitution] as string;
                        retVal.PrimaryProgramDirector = reader[Constants.ResidenciesFellowshipsColumns.PrimaryProgramDirector] as string;
                        retVal.PrimaryMailingAddress = reader[Constants.ResidenciesFellowshipsColumns.PrimaryMailingAddress] as string;
                        retVal.PrimaryCity = reader[Constants.ResidenciesFellowshipsColumns.PrimaryCity] as string;
                        retVal.PrimaryState = reader[Constants.ResidenciesFellowshipsColumns.PrimaryState] as string;
                        retVal.PrimaryZip = reader[Constants.ResidenciesFellowshipsColumns.PrimaryZip] as string;
                        retVal.PrimaryTypeTraining = reader[Constants.ResidenciesFellowshipsColumns.PrimaryTypeTraining] as string;
                        retVal.PrimarySpecialty = reader[Constants.ResidenciesFellowshipsColumns.PrimarySpecialty] as string;
                        retVal.PrimaryFrom = Convert.IsDBNull(reader[Constants.ResidenciesFellowshipsColumns.PrimaryFrom]) ? null : (DateTime?)reader[Constants.ResidenciesFellowshipsColumns.PrimaryFrom];
                        retVal.PrimaryTo = Convert.IsDBNull(reader[Constants.ResidenciesFellowshipsColumns.PrimaryTo]) ? null : (DateTime?)reader[Constants.ResidenciesFellowshipsColumns.PrimaryTo];
                        retVal.PrimaryCompleted = Convert.IsDBNull(reader[Constants.ResidenciesFellowshipsColumns.PrimaryCompleted]) ? null : (bool?)reader[Constants.ResidenciesFellowshipsColumns.PrimaryCompleted];

                        retVal.SecondaryInstitution = reader[Constants.ResidenciesFellowshipsColumns.SecondaryInstitution] as string;
                        retVal.SecondaryProgramDirector = reader[Constants.ResidenciesFellowshipsColumns.SecondaryProgramDirector] as string;
                        retVal.SecondaryMailingAddress = reader[Constants.ResidenciesFellowshipsColumns.SecondaryMailingAddress] as string;
                        retVal.SecondaryCity = reader[Constants.ResidenciesFellowshipsColumns.SecondaryCity] as string;
                        retVal.SecondaryState = reader[Constants.ResidenciesFellowshipsColumns.SecondaryState] as string;
                        retVal.SecondaryZip = reader[Constants.ResidenciesFellowshipsColumns.SecondaryZip] as string;
                        retVal.SecondaryTypeTraining = reader[Constants.ResidenciesFellowshipsColumns.SecondaryTypeTraining] as string;
                        retVal.SecondarySpecialty = reader[Constants.ResidenciesFellowshipsColumns.SecondarySpecialty] as string;
                        retVal.SecondaryFrom = Convert.IsDBNull(reader[Constants.ResidenciesFellowshipsColumns.SecondaryFrom]) ? null : (DateTime?)reader[Constants.ResidenciesFellowshipsColumns.SecondaryFrom];
                        retVal.SecondaryTo = Convert.IsDBNull(reader[Constants.ResidenciesFellowshipsColumns.SecondaryTo]) ? null : (DateTime?)reader[Constants.ResidenciesFellowshipsColumns.SecondaryTo];
                        retVal.SecondaryCompleted = Convert.IsDBNull(reader[Constants.ResidenciesFellowshipsColumns.SecondaryCompleted]) ? null : (bool?)reader[Constants.ResidenciesFellowshipsColumns.SecondaryCompleted];

                        retVal.TertiaryInstitution = reader[Constants.ResidenciesFellowshipsColumns.TertiaryInstitution] as string;
                        retVal.TertiaryProgramDirector = reader[Constants.ResidenciesFellowshipsColumns.TertiaryProgramDirector] as string;
                        retVal.TertiaryMailingAddress = reader[Constants.ResidenciesFellowshipsColumns.TertiaryMailingAddress] as string;
                        retVal.TertiaryCity = reader[Constants.ResidenciesFellowshipsColumns.TertiaryCity] as string;
                        retVal.TertiaryState = reader[Constants.ResidenciesFellowshipsColumns.TertiaryState] as string;
                        retVal.TertiaryZip = reader[Constants.ResidenciesFellowshipsColumns.TertiaryZip] as string;
                        retVal.TertiaryTypeTraining = reader[Constants.ResidenciesFellowshipsColumns.TertiaryTypeTraining] as string;
                        retVal.TertiarySpecialty = reader[Constants.ResidenciesFellowshipsColumns.TertiarySpecialty] as string;
                        retVal.TertiaryFrom = Convert.IsDBNull(reader[Constants.ResidenciesFellowshipsColumns.TertiaryFrom]) ? null : (DateTime?)reader[Constants.ResidenciesFellowshipsColumns.TertiaryFrom];
                        retVal.TertiaryTo = Convert.IsDBNull(reader[Constants.ResidenciesFellowshipsColumns.TertiaryTo]) ? null : (DateTime?)reader[Constants.ResidenciesFellowshipsColumns.TertiaryTo];
                        retVal.TertiaryCompleted = Convert.IsDBNull(reader[Constants.ResidenciesFellowshipsColumns.TertiaryCompleted]) ? null: (bool?)reader[Constants.ResidenciesFellowshipsColumns.TertiaryCompleted];

                        retVal.Completed = Convert.IsDBNull(reader[Constants.AttestationQuestionsColumns.Completed]) ? null : (bool?)reader[Constants.AttestationQuestionsColumns.Completed];
                    }
                }
            }

            if (deepLoad && retVal != null)
            {
                retVal.Attachments = AttachmentHandler.Instance.GetReferencedAttachments(conn, trans, "ResidenciesFellowshipId", retVal.ResidenciesFellowshipId);
            }

            return retVal;
        }

        public int Insert(ResidenciesFellowship residencies)
        {
            int retVal;

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                retVal = Insert(conn, null, residencies);
            }

            return retVal;
        }

        public int Insert(SqlConnection conn, SqlTransaction trans, ResidenciesFellowship residencies)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO ResidenciesFellowships
                                                    (PrimaryInstitution, PrimaryProgramDirector, PrimaryMailingAddress, PrimaryCity, PrimaryState, PrimaryZip, PrimaryTypeTraining, PrimarySpecialty, PrimaryFrom, PrimaryTo, PrimaryCompleted, SecondaryInstitution, SecondaryProgramDirector, SecondaryMailingAddress, SecondaryCity, SecondaryState, SecondaryZip, SecondaryTypeTraining, SecondarySpecialty, SecondaryFrom, SecondaryTo, SecondaryCompleted, TertiaryInstitution, TertiaryProgramDirector, TertiaryMailingAddress, TertiaryCity, TertiaryState, TertiaryZip, TertiaryTypeTraining, TertiarySpecialty, TertiaryFrom, TertiaryTo, TertiaryCompleted, Completed)
                                                    OUTPUT INSERTED.ResidenciesFellowshipId
                                                    VALUES
                                                    (@primaryInstitution, @primaryProgramDirector, @primaryMailingAddress, @primaryCity, @primaryState, @primaryZip, @primaryTypeTraining, @primarySpecialty, @primaryFrom, @primaryTo, @primaryCompleted, @secondaryInstitution, @secondaryProgramDirector, @secondaryMailingAddress, @secondaryCity, @secondaryState, @secondaryZip, @secondaryTypeTraining, @secondarySpecialty, @secondaryFrom, @secondaryTo, @secondaryCompleted, @tertiaryInstitution, @tertiaryProgramDirector, @tertiaryMailingAddress, @tertiaryCity, @tertiaryState, @tertiaryZip, @tertiaryTypeTraining, @tertiarySpecialty, @tertiaryFrom, @tertiaryTo, @tertiaryCompleted, @completed)", conn);
            if (trans != null) sqlCommand.Transaction = trans;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@primaryInstitution", residencies.PrimaryInstitution);
            sqlCommand.Parameters.AddWithValue("@primaryProgramDirector", residencies.PrimaryProgramDirector);
            sqlCommand.Parameters.AddWithValue("@primaryMailingAddress", residencies.PrimaryMailingAddress);
            sqlCommand.Parameters.AddWithValue("@primaryCity", residencies.PrimaryCity);
            sqlCommand.Parameters.AddWithValue("@primaryState", residencies.PrimaryState);
            sqlCommand.Parameters.AddWithValue("@primaryZip", residencies.PrimaryZip);
            sqlCommand.Parameters.AddWithValue("@primaryTypeTraining", residencies.PrimaryTypeTraining);
            sqlCommand.Parameters.AddWithValue("@primarySpecialty", residencies.PrimarySpecialty);
            sqlCommand.Parameters.AddWithValue("@primaryFrom", residencies.PrimaryFrom);
            sqlCommand.Parameters.AddWithValue("@primaryTo", residencies.PrimaryTo);
            sqlCommand.Parameters.AddWithValue("@primaryCompleted", residencies.PrimaryCompleted);

            sqlCommand.Parameters.AddWithValue("@secondaryInstitution", residencies.SecondaryInstitution);
            sqlCommand.Parameters.AddWithValue("@secondaryProgramDirector", residencies.SecondaryProgramDirector);
            sqlCommand.Parameters.AddWithValue("@secondaryMailingAddress", residencies.SecondaryMailingAddress);
            sqlCommand.Parameters.AddWithValue("@secondaryCity", residencies.SecondaryCity);
            sqlCommand.Parameters.AddWithValue("@secondaryState", residencies.SecondaryState);
            sqlCommand.Parameters.AddWithValue("@secondaryZip", residencies.SecondaryZip);
            sqlCommand.Parameters.AddWithValue("@secondaryTypeTraining", residencies.SecondaryTypeTraining);
            sqlCommand.Parameters.AddWithValue("@secondarySpecialty", residencies.SecondarySpecialty);
            sqlCommand.Parameters.AddWithValue("@secondaryFrom", residencies.SecondaryFrom);
            sqlCommand.Parameters.AddWithValue("@secondaryTo", residencies.SecondaryTo);
            sqlCommand.Parameters.AddWithValue("@secondaryCompleted", residencies.SecondaryCompleted);

            sqlCommand.Parameters.AddWithValue("@tertiaryInstitution", residencies.TertiaryInstitution);
            sqlCommand.Parameters.AddWithValue("@tertiaryProgramDirector", residencies.TertiaryProgramDirector);
            sqlCommand.Parameters.AddWithValue("@tertiaryMailingAddress", residencies.TertiaryMailingAddress);
            sqlCommand.Parameters.AddWithValue("@tertiaryCity", residencies.TertiaryCity);
            sqlCommand.Parameters.AddWithValue("@tertiaryState", residencies.TertiaryState);
            sqlCommand.Parameters.AddWithValue("@tertiaryZip", residencies.TertiaryZip);
            sqlCommand.Parameters.AddWithValue("@tertiaryTypeTraining", residencies.TertiaryTypeTraining);
            sqlCommand.Parameters.AddWithValue("@tertiarySpecialty", residencies.TertiarySpecialty);
            sqlCommand.Parameters.AddWithValue("@tertiaryFrom", residencies.TertiaryFrom);
            sqlCommand.Parameters.AddWithValue("@tertiaryTo", residencies.TertiaryTo);
            sqlCommand.Parameters.AddWithValue("@tertiaryCompleted", residencies.TertiaryCompleted);

            sqlCommand.Parameters.AddWithValue("@completed", residencies.Completed);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            return (int)sqlCommand.ExecuteScalar();
        }

        public void Update(ResidenciesFellowship residencies)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                Update(conn, null, residencies);
            }
        }

        public void Update(SqlConnection conn, SqlTransaction trans, ResidenciesFellowship residencies)
        {
            var sqlCommand = new SqlCommand(@"UPDATE ResidenciesFellowships
                                                SET
                                                    PrimaryInstitution = @primaryInstitution,
                                                    PrimaryProgramDirector = @primaryProgramDirector,
                                                    PrimaryMailingAddress = @primaryMailingAddress,
                                                    PrimaryCity = @primaryCity,
                                                    PrimaryState = @primaryState,
                                                    PrimaryZip = @primaryZip,
                                                    PrimaryTypeTraining = @primaryTypeTraining,
                                                    PrimarySpecialty = @primarySpecialty,
                                                    PrimaryFrom = @primaryFrom,
                                                    PrimaryTo = @primaryTo,
                                                    PrimaryCompleted = @primaryCompleted,

                                                    SecondaryInstitution = @secondaryInstitution,
                                                    SecondaryProgramDirector = @secondaryProgramDirector,
                                                    SecondaryMailingAddress = @secondaryMailingAddress,
                                                    SecondaryCity = @secondaryCity,
                                                    SecondaryState = @secondaryState,
                                                    SecondaryZip = @secondaryZip,
                                                    SecondaryTypeTraining = @secondaryTypeTraining,
                                                    SecondarySpecialty = @secondarySpecialty,
                                                    SecondaryFrom = @secondaryFrom,
                                                    SecondaryTo = @secondaryTo,
                                                    SecondaryCompleted = @secondaryCompleted,

                                                    TertiaryInstitution = @tertiaryInstitution,
                                                    TertiaryProgramDirector = @tertiaryProgramDirector,
                                                    TertiaryMailingAddress = @tertiaryMailingAddress,
                                                    TertiaryCity = @tertiaryCity,
                                                    TertiaryState = @tertiaryState,
                                                    TertiaryZip = @tertiaryZip,
                                                    TertiaryTypeTraining = @tertiaryTypeTraining,
                                                    TertiarySpecialty =@tertiarySpecialty ,
                                                    TertiaryFrom = @tertiaryFrom,
                                                    TertiaryTo = @tertiaryTo,
                                                    TertiaryCompleted = @tertiaryCompleted,

                                                    Completed = @completed
                                                WHERE residenciesFellowshipId = @residenciesFellowshipId", conn);

            if (trans != null) sqlCommand.Transaction = trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@residenciesFellowshipId", residencies.ResidenciesFellowshipId);
            sqlCommand.Parameters.AddWithValue("@primaryInstitution", residencies.PrimaryInstitution);
            sqlCommand.Parameters.AddWithValue("@primaryProgramDirector", residencies.PrimaryProgramDirector);
            sqlCommand.Parameters.AddWithValue("@primaryMailingAddress", residencies.PrimaryMailingAddress);
            sqlCommand.Parameters.AddWithValue("@primaryCity", residencies.PrimaryCity);
            sqlCommand.Parameters.AddWithValue("@primaryState", residencies.PrimaryState);
            sqlCommand.Parameters.AddWithValue("@primaryZip", residencies.PrimaryZip);
            sqlCommand.Parameters.AddWithValue("@primaryTypeTraining", residencies.PrimaryTypeTraining);
            sqlCommand.Parameters.AddWithValue("@primarySpecialty", residencies.PrimarySpecialty);
            sqlCommand.Parameters.AddWithValue("@primaryFrom", residencies.PrimaryFrom);
            sqlCommand.Parameters.AddWithValue("@primaryTo", residencies.PrimaryTo);
            sqlCommand.Parameters.AddWithValue("@primaryCompleted", residencies.PrimaryCompleted);
            sqlCommand.Parameters.AddWithValue("@secondaryInstitution", residencies.SecondaryInstitution);
            sqlCommand.Parameters.AddWithValue("@secondaryProgramDirector", residencies.SecondaryProgramDirector);
            sqlCommand.Parameters.AddWithValue("@secondaryMailingAddress", residencies.SecondaryMailingAddress);
            sqlCommand.Parameters.AddWithValue("@secondaryCity", residencies.SecondaryCity);
            sqlCommand.Parameters.AddWithValue("@secondaryState", residencies.SecondaryState);
            sqlCommand.Parameters.AddWithValue("@secondaryZip", residencies.SecondaryZip);
            sqlCommand.Parameters.AddWithValue("@secondaryTypeTraining", residencies.SecondaryTypeTraining);
            sqlCommand.Parameters.AddWithValue("@secondarySpecialty", residencies.SecondarySpecialty);
            sqlCommand.Parameters.AddWithValue("@secondaryFrom", residencies.SecondaryFrom);
            sqlCommand.Parameters.AddWithValue("@secondaryTo", residencies.SecondaryTo);
            sqlCommand.Parameters.AddWithValue("@secondaryCompleted", residencies.SecondaryCompleted);
            sqlCommand.Parameters.AddWithValue("@tertiaryInstitution", residencies.TertiaryInstitution);
            sqlCommand.Parameters.AddWithValue("@tertiaryProgramDirector", residencies.TertiaryProgramDirector);
            sqlCommand.Parameters.AddWithValue("@tertiaryMailingAddress", residencies.TertiaryMailingAddress);
            sqlCommand.Parameters.AddWithValue("@tertiaryCity", residencies.TertiaryCity);
            sqlCommand.Parameters.AddWithValue("@tertiaryState", residencies.TertiaryState);
            sqlCommand.Parameters.AddWithValue("@tertiaryZip", residencies.TertiaryZip);
            sqlCommand.Parameters.AddWithValue("@tertiaryTypeTraining", residencies.TertiaryTypeTraining);
            sqlCommand.Parameters.AddWithValue("@tertiarySpecialty", residencies.TertiarySpecialty);
            sqlCommand.Parameters.AddWithValue("@tertiaryFrom", residencies.TertiaryFrom);
            sqlCommand.Parameters.AddWithValue("@tertiaryTo", residencies.TertiaryTo);
            sqlCommand.Parameters.AddWithValue("@tertiaryCompleted", residencies.TertiaryCompleted);
            sqlCommand.Parameters.AddWithValue("@completed", residencies.Completed);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            sqlCommand.ExecuteNonQuery();
        }
    }
}