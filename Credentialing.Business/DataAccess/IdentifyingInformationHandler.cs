using Credentialing.Entities;
using Credentialing.Entities.Data;
using Credentialing.Entities.Enums;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class IdentifyingInformationHandler
    {
        private static IdentifyingInformationHandler _instance;

        public static IdentifyingInformationHandler Instance
        {
            get { return _instance ?? (_instance = new IdentifyingInformationHandler()); }
        }

        private IdentifyingInformationHandler()
        {
        }

        public IdentifyingInformation GetById(int id, bool deepLoad = false)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                return GetById(conn, null, id, deepLoad);
            }
        }

        public IdentifyingInformation GetById(SqlConnection conn, SqlTransaction trans, int id, bool deepLoad = false)
        {
            IdentifyingInformation retVal = null;

            var sqlCommand = new SqlCommand(@"SELECT *
                                                  FROM IdentifyingInformations
                                                  WHERE IdentifyingInformationId = @identifyingInformationId", conn);
            sqlCommand.Parameters.AddWithValue("@identifyingInformationId", id);
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
                        retVal = new IdentifyingInformation();

                        retVal.IdentifyingInformationId = (int)reader[Constants.IdentifyingInformationColumns.IdentifyingInformationId];
                        retVal.LastName = reader[Constants.IdentifyingInformationColumns.LastName] as string;
                        retVal.FirstName = reader[Constants.IdentifyingInformationColumns.FirstName] as string;
                        retVal.MiddleName = reader[Constants.IdentifyingInformationColumns.MiddleName] as string;
                        retVal.OtherKnownNames = reader[Constants.IdentifyingInformationColumns.OtherKnownNames] as string;
                        retVal.HomeMailingAddress = reader[Constants.IdentifyingInformationColumns.HomeMailingAddress] as string;
                        retVal.City = reader[Constants.IdentifyingInformationColumns.City] as string;
                        retVal.State = reader[Constants.IdentifyingInformationColumns.State] as string;
                        retVal.Zip = reader[Constants.IdentifyingInformationColumns.Zip] as string;
                        retVal.HomeTelephoneNumber = reader[Constants.IdentifyingInformationColumns.HomeTelephoneNumber] as string;
                        retVal.HomeFaxNumber = reader[Constants.IdentifyingInformationColumns.HomeFaxNumber] as string;
                        retVal.EmailAddress = reader[Constants.IdentifyingInformationColumns.EmailAddress] as string;
                        retVal.PagerNumber = reader[Constants.IdentifyingInformationColumns.PagerNumber] as string;
                        retVal.BirthDate = Convert.IsDBNull(reader[Constants.IdentifyingInformationColumns.BirthDate]) ? null : (DateTime?)reader[Constants.IdentifyingInformationColumns.BirthDate];
                        retVal.BirthPlace = reader[Constants.IdentifyingInformationColumns.BirthPlace] as string;
                        retVal.AttachmentId = reader[Constants.IdentifyingInformationColumns.AttachmentId] as int?;
                        retVal.SocialSecurityNumber = reader[Constants.IdentifyingInformationColumns.SocialSecurityNumber] as string;
                        retVal.Gender = Convert.IsDBNull(reader[Constants.IdentifyingInformationColumns.Gender]) ? null : (Gender?)(int?)reader[Constants.IdentifyingInformationColumns.Gender];
                        retVal.Specialty = reader[Constants.IdentifyingInformationColumns.Specialty] as string;
                        retVal.RaceEthnicity = reader[Constants.IdentifyingInformationColumns.RaceEthnicity] as string;
                        retVal.Subspecialties = reader[Constants.IdentifyingInformationColumns.Subspecialties] as string;

                        retVal.Completed = Convert.IsDBNull(reader[Constants.AttestationQuestionsColumns.Completed]) ? null : (bool?)reader[Constants.AttestationQuestionsColumns.Completed];
                    }
                }
            }

            if (deepLoad && retVal != null)
            {
                if (retVal.AttachmentId.HasValue)
                {
                    retVal.Attachment = AttachmentHandler.Instance.GetById(conn, trans, retVal.AttachmentId.Value);
                }
            }
            return retVal;
        }

        public int Insert(IdentifyingInformation info)
        {
            int retVal;

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                retVal = Insert(conn, null, info);
            }

            return retVal;
        }

        public int Insert(SqlConnection conn, SqlTransaction trans, IdentifyingInformation info)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO IdentifyingInformations
                                                    (LastName, FirstName, MiddleName, OtherKnownNames, HomeMailingAddress, City, State, Zip, HomeTelephoneNumber, HomeFaxNumber, EmailAddress, PagerNumber, BirthDate, BirthPlace, SocialSecurityNumber, Gender, Specialty, RaceEthnicity, Subspecialties, AttachmentId, Completed)
                                                    OUTPUT INSERTED.IdentifyingInformationId
                                                    VALUES
                                                    (@lastName, @firstName, @middleName, @otherKnownNames, @homeMailingAddress, @city, @state, @zip, @homeTelephoneNumber, @homeFaxNumber, @emailAddress, @pagerNumber, @birthDate, @birthPlace, @socialSecurityNumber, @gender, @specialty, @raceEthnicity, @subspecialties, @attachmentId, @completed)", conn);
            if (trans != null) sqlCommand.Transaction = trans;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@lastName", info.LastName);
            sqlCommand.Parameters.AddWithValue("@firstName", info.FirstName);
            sqlCommand.Parameters.AddWithValue("@middleName", info.MiddleName);
            sqlCommand.Parameters.AddWithValue("@otherKnownNames", info.OtherKnownNames);
            sqlCommand.Parameters.AddWithValue("@homeMailingAddress", info.HomeMailingAddress);
            sqlCommand.Parameters.AddWithValue("@city", info.City);
            sqlCommand.Parameters.AddWithValue("@state", info.State);
            sqlCommand.Parameters.AddWithValue("@zip", info.Zip);
            sqlCommand.Parameters.AddWithValue("@homeTelephoneNumber", info.HomeTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@homeFaxNumber", info.HomeFaxNumber);
            sqlCommand.Parameters.AddWithValue("@emailAddress", info.EmailAddress);
            sqlCommand.Parameters.AddWithValue("@pagerNumber", info.PagerNumber);
            sqlCommand.Parameters.AddWithValue("@birthDate", info.BirthDate);
            sqlCommand.Parameters.AddWithValue("@birthPlace", info.BirthPlace);
            sqlCommand.Parameters.AddWithValue("@socialSecurityNumber", info.SocialSecurityNumber);
            sqlCommand.Parameters.AddWithValue("@gender", info.Gender);
            sqlCommand.Parameters.AddWithValue("@specialty", info.Specialty);
            sqlCommand.Parameters.AddWithValue("@raceEthnicity", info.RaceEthnicity);
            sqlCommand.Parameters.AddWithValue("@subspecialties", info.Subspecialties);
            sqlCommand.Parameters.AddWithValue("@attachmentId", info.AttachmentId);
            sqlCommand.Parameters.AddWithValue("@completed", info.Completed);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            return (int)sqlCommand.ExecuteScalar();
        }

        public void Update(IdentifyingInformation info)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                Update(conn, null, info);
            }
        }

        public void Update(SqlConnection conn, SqlTransaction trans, IdentifyingInformation info)
        {
            var sqlCommand = new SqlCommand(@"UPDATE IdentifyingInformations
                                                    SET LastName = @lastName,
                                                        FirstName = @firstName,
                                                        MiddleName = @middleName,
                                                        OtherKnownNames = @otherKnownNames,
                                                        HomeMailingAddress = @homeMailingAddress,
                                                        City = @city,
                                                        State = @state,
                                                        Zip = @zip,
                                                        HomeTelephoneNumber = @homeTelephoneNumber,
                                                        HomeFaxNumber = @homeFaxNumber,
                                                        EmailAddress = @emailAddress,
                                                        PagerNumber = @pagerNumber,
                                                        BirthDate = @birthDate,
                                                        BirthPlace = @birthPlace,
                                                        SocialSecurityNumber = @socialSecurityNumber,
                                                        Gender = @gender,
                                                        Specialty = @specialty,
                                                        RaceEthnicity = @raceEthnicity,
                                                        Subspecialties = @subspecialties,
                                                        AttachmentId = @attachmentId,
                                                        Completed = @completed
                                                    WHERE IdentifyingInformationId = @identifyingInformationId
                                                    ", conn);

            if (trans != null) sqlCommand.Transaction = trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@identifyingInformationId", info.IdentifyingInformationId);
            sqlCommand.Parameters.AddWithValue("@lastName", info.LastName);
            sqlCommand.Parameters.AddWithValue("@firstName", info.FirstName);
            sqlCommand.Parameters.AddWithValue("@middleName", info.MiddleName);
            sqlCommand.Parameters.AddWithValue("@otherKnownNames", info.OtherKnownNames);
            sqlCommand.Parameters.AddWithValue("@homeMailingAddress", info.HomeMailingAddress);
            sqlCommand.Parameters.AddWithValue("@city", info.City);
            sqlCommand.Parameters.AddWithValue("@state", info.State);
            sqlCommand.Parameters.AddWithValue("@zip", info.Zip);
            sqlCommand.Parameters.AddWithValue("@homeTelephoneNumber", info.HomeTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@homeFaxNumber", info.HomeFaxNumber);
            sqlCommand.Parameters.AddWithValue("@emailAddress", info.EmailAddress);
            sqlCommand.Parameters.AddWithValue("@pagerNumber", info.PagerNumber);
            sqlCommand.Parameters.AddWithValue("@birthDate", info.BirthDate);
            sqlCommand.Parameters.AddWithValue("@birthPlace", info.BirthPlace);
            sqlCommand.Parameters.AddWithValue("@socialSecurityNumber", info.SocialSecurityNumber);
            sqlCommand.Parameters.AddWithValue("@gender", info.Gender);
            sqlCommand.Parameters.AddWithValue("@specialty", info.Specialty);
            sqlCommand.Parameters.AddWithValue("@raceEthnicity", info.RaceEthnicity);
            sqlCommand.Parameters.AddWithValue("@subspecialties", info.Subspecialties);
            sqlCommand.Parameters.AddWithValue("@attachmentId", info.AttachmentId);
            sqlCommand.Parameters.AddWithValue("@completed", info.Completed);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            sqlCommand.ExecuteNonQuery();
        }
    }
}