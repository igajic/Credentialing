using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class InternshipHandler
    {
        private static InternshipHandler _instance;

        public static InternshipHandler Instance
        {
            get { return _instance ?? (_instance = new InternshipHandler()); }
        }

        private InternshipHandler()
        {
        }

        public Internship GetById(int internshipId, bool deepLoad = false)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                return GetById(conn, null, internshipId, deepLoad);
            }
        }

        public Internship GetById(SqlConnection conn, SqlTransaction trans, int internshipId, bool deepLoad = false)
        {
            Internship retVal = null;

            var sqlCommand = new SqlCommand(@"SELECT *
                                                  FROM Internships
                                                  WHERE InternshipId = @internshipId", conn);
            sqlCommand.Parameters.AddWithValue("@internshipId", internshipId);
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
                        retVal = new Internship();
                        retVal.InternshipId = (int)reader[Constants.InternshipsColumns.InternshipId];
                        retVal.Institution = reader[Constants.InternshipsColumns.Institution] as string;
                        retVal.MailingAddress = reader[Constants.InternshipsColumns.MailingAddress] as string;
                        retVal.City = reader[Constants.InternshipsColumns.City] as string;
                        retVal.StateCountry = reader[Constants.InternshipsColumns.StateCountry] as string;
                        retVal.Zip = reader[Constants.InternshipsColumns.Zip] as string;
                        retVal.TypeOfInternship = reader[Constants.InternshipsColumns.TypeOfInternship] as string;
                        retVal.Specialty = reader[Constants.InternshipsColumns.Specialty] as string;
                        retVal.SpecialtyFrom = Convert.IsDBNull(reader[Constants.InternshipsColumns.SpecialtyFrom]) ? null : (DateTime?)reader[Constants.InternshipsColumns.SpecialtyFrom];
                        retVal.SpecialtyTo = Convert.IsDBNull(reader[Constants.InternshipsColumns.SpecialtyTo]) ? null : (DateTime?)reader[Constants.InternshipsColumns.SpecialtyTo];
                    }
                }
            }

            if (deepLoad && retVal != null)
            {
                retVal.Attachments = AttachmentHandler.Instance.GetReferencedAttachments("InternshipId", retVal.InternshipId);
            }

            return retVal;
        }

        public int Insert(Internship info)
        {
            int retVal;

            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                retVal = Insert(conn, null, info);
            }

            return retVal;
        }

        public int Insert(SqlConnection conn, SqlTransaction trans, Internship info)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO Internships
                                                    (Institution, ProgramDirector, MailingAddress, City, StateCountry, Zip, TypeOfInternship, Specialty, SpecialtyFrom, SpecialtyTo)
                                                    OUTPUT INSERTED.InternshipId
                                                    VALUES
                                                    (@institution, @programDirector, @mailingAddress, @city, @stateCountry, @zip, @typeOfInternship, @specialty, @specialtyFrom, @specialtyTo)", conn);
            if (trans != null) sqlCommand.Transaction = trans;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@institution", info.Institution);
            sqlCommand.Parameters.AddWithValue("@programDirector", info.ProgramDirector);
            sqlCommand.Parameters.AddWithValue("@mailingAddress", info.MailingAddress);
            sqlCommand.Parameters.AddWithValue("@city", info.City);
            sqlCommand.Parameters.AddWithValue("@stateCountry", info.StateCountry);
            sqlCommand.Parameters.AddWithValue("@zip", info.Zip);
            sqlCommand.Parameters.AddWithValue("@typeOfInternship", info.TypeOfInternship);
            sqlCommand.Parameters.AddWithValue("@specialty", info.Specialty);
            sqlCommand.Parameters.AddWithValue("@specialtyFrom", info.SpecialtyFrom);
            sqlCommand.Parameters.AddWithValue("@specialtyTo", info.SpecialtyTo);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            return (int)sqlCommand.ExecuteScalar();
        }

        public void Update(Internship info)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                Update(conn, null, info);
            }
        }

        public void Update(SqlConnection conn, SqlTransaction trans, Internship info)
        {
            var sqlCommand = new SqlCommand(@"UPDATE Internships
                                                SET
                                                    Institution = @institution,
                                                    ProgramDirector = @programDirector,
                                                    MailingAddress = @mailingAddress,
                                                    City = @city,
                                                    StateCountry = @stateCountry,
                                                    Zip = @zip,
                                                    TypeOfInternship = @typeOfInternship,
                                                    Specialty = @specialty,
                                                    SpecialtyFrom = @specialtyFrom,
                                                    SpecialtyTo = @specialtyTo
                                                WHERE InternshipId = @internshipId", conn);
            if (trans != null) sqlCommand.Transaction = trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@internshipId", info.InternshipId);
            sqlCommand.Parameters.AddWithValue("@institution", info.Institution);
            sqlCommand.Parameters.AddWithValue("@programDirector", info.ProgramDirector);
            sqlCommand.Parameters.AddWithValue("@mailingAddress", info.MailingAddress);
            sqlCommand.Parameters.AddWithValue("@city", info.City);
            sqlCommand.Parameters.AddWithValue("@stateCountry", info.StateCountry);
            sqlCommand.Parameters.AddWithValue("@zip", info.Zip);
            sqlCommand.Parameters.AddWithValue("@typeOfInternship", info.TypeOfInternship);
            sqlCommand.Parameters.AddWithValue("@specialty", info.Specialty);
            sqlCommand.Parameters.AddWithValue("@specialtyFrom", info.SpecialtyFrom);
            sqlCommand.Parameters.AddWithValue("@specialtyTo", info.SpecialtyTo);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            sqlCommand.ExecuteNonQuery();
        }
    }
}