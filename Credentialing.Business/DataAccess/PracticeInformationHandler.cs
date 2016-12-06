using Credentialing.Entities;
using Credentialing.Entities.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class PracticeInformationHandler
    {
        private static PracticeInformationHandler _instance;

        public static PracticeInformationHandler Instance
        {
            get { return _instance ?? (_instance = new PracticeInformationHandler()); }
        }

        private PracticeInformationHandler()
        {
        }

        public PracticeInformation GetById(int id, bool deepLoad = false)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
            {
                return GetById(conn, id, deepLoad);
            }
        }

        public PracticeInformation GetById(SqlConnection conn, int id, bool deepLoad = false)
        {
            PracticeInformation retVal = null;

            var sqlCommand = new SqlCommand("SELECT * FROM PracticeInformations WHERE PracticeInformationId = @practiceInformationId", conn);
            sqlCommand.Parameters.AddWithValue("@practiceInformationId", id);

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
                        retVal = new PracticeInformation();

                        retVal.PracticeInformationId = (int)reader[Constants.PracticeInformationColumns.PracticeInformationId];
                        retVal.PracticeName = reader[Constants.PracticeInformationColumns.PracticeName] as string;
                        retVal.DepartmentName = reader[Constants.PracticeInformationColumns.DepartmentName] as string;
                        retVal.PrimaryOfficeStreetAddress = reader[Constants.PracticeInformationColumns.PrimaryOfficeStreetAddress] as string;
                        retVal.PrimaryOfficeCityStateZip = reader[Constants.PracticeInformationColumns.PrimaryOfficeCityStateZip] as string;
                        retVal.PrimaryOfficeTelephoneNumber = reader[Constants.PracticeInformationColumns.PrimaryOfficeTelephoneNumber] as string;
                        retVal.PrimaryOfficeFaxNumber = reader[Constants.PracticeInformationColumns.PrimaryOfficeFaxNumber] as string;
                        retVal.PrimaryOfficeManagerAdministrator = reader[Constants.PracticeInformationColumns.PrimaryOfficeManagerAdministrator] as string;
                        retVal.PrimaryOfficeManagerAdministratorTelephoneNumber = reader[Constants.PracticeInformationColumns.PrimaryOfficeManagerAdministratorTelephoneNumber] as string;
                        retVal.PrimaryOfficeManagerAdministratorFaxNumber = reader[Constants.PracticeInformationColumns.PrimaryOfficeManagerAdministratorFaxNumber] as string;
                        retVal.PrimaryOfficeNameAffiliatedWithTaxIdNumber = reader[Constants.PracticeInformationColumns.PrimaryOfficeNameAffiliatedWithTaxIdNumber] as string;
                        retVal.PrimaryOfficeFederalTaxIdNumber = reader[Constants.PracticeInformationColumns.PrimaryOfficeFederalTaxIdNumber] as string;

                        retVal.SecondaryOfficeStreetAddress = reader[Constants.PracticeInformationColumns.SecondaryOfficeStreetAddress] as string;
                        retVal.SecondaryOfficeCity = reader[Constants.PracticeInformationColumns.SecondaryOfficeCity] as string;
                        retVal.SecondaryOfficeState = reader[Constants.PracticeInformationColumns.SecondaryOfficeState] as string;
                        retVal.SecondaryOfficeZip = reader[Constants.PracticeInformationColumns.SecondaryOfficeZip] as string;
                        retVal.SecondaryOfficeManagerAdministrator = reader[Constants.PracticeInformationColumns.SecondaryOfficeManagerAdministrator] as string;
                        retVal.SecondaryOfficeManagerAdministratorTelephoneNumber = reader[Constants.PracticeInformationColumns.SecondaryOfficeManagerAdministratorTelephoneNumber] as string;
                        retVal.SecondaryOfficeManagerAdministratorFaxNumber = reader[Constants.PracticeInformationColumns.SecondaryOfficeManagerAdministratorFaxNumber] as string;
                        retVal.SecondaryOfficeNameAffiliatedWithTaxIdNumber = reader[Constants.PracticeInformationColumns.SecondaryOfficeNameAffiliatedWithTaxIdNumber] as string;
                        retVal.SecondaryOfficeFederalTaxIdNumber = reader[Constants.PracticeInformationColumns.SecondaryOfficeFederalTaxIdNumber] as string;

                        retVal.TertiaryOfficeStreetAddress = reader[Constants.PracticeInformationColumns.TertiaryOfficeStreetAddress] as string;
                        retVal.TertiaryOfficeCity = reader[Constants.PracticeInformationColumns.TertiaryOfficeCity] as string;
                        retVal.TertiaryOfficeState = reader[Constants.PracticeInformationColumns.TertiaryOfficeState] as string;
                        retVal.TertiaryOfficeZip = reader[Constants.PracticeInformationColumns.TertiaryOfficeZip] as string;
                        retVal.TertiaryOfficeTelephoneNumber = reader[Constants.PracticeInformationColumns.TertiaryOfficeTelephoneNumber] as string;
                        retVal.TertiaryOfficeFaxNumber = reader[Constants.PracticeInformationColumns.TertiaryOfficeFaxNumber] as string;
                        retVal.TertiaryOfficeManagerAdministrator = reader[Constants.PracticeInformationColumns.TertiaryOfficeManagerAdministrator] as string;
                        retVal.TertiaryOfficeManagerAdministratorTelephoneNumber = reader[Constants.PracticeInformationColumns.TertiaryOfficeManagerAdministratorTelephoneNumber] as string;
                        retVal.TertiaryOfficeManagerAdministratorFaxNumber = reader[Constants.PracticeInformationColumns.TertiaryOfficeManagerAdministratorFaxNumber] as string;
                        retVal.TertiaryOfficeNameAffiliatedWithTaxIdNumber = reader[Constants.PracticeInformationColumns.TertiaryOfficeNameAffiliatedWithTaxIdNumber] as string;
                        retVal.TertiaryOfficeFederalTaxIdNumber = reader[Constants.PracticeInformationColumns.TertiaryOfficeFederalTaxIdNumber] as string;
                    }
                }
            }
            return retVal;
        }

        public int Insert(SqlConnection conn, PracticeInformation practiceInformation)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO PracticeInformations
                                                    (PracticeName, DepartmentName, PrimaryOfficeStreetAddress, PrimaryOfficeCityStateZip, PrimaryOfficeTelephoneNumber, PrimaryOfficeFaxNumber, PrimaryOfficeManagerAdministrator, PrimaryOfficeManagerAdministratorTelephoneNumber, PrimaryOfficeManagerAdministratorFaxNumber, PrimaryOfficeNameAffiliatedWithTaxIdNumber, PrimaryOfficeFederalTaxIdNumber, SecondaryOfficeStreetAddress, SecondaryOfficeCity, SecondaryOfficeState, SecondaryOfficeZip, SecondaryOfficeManagerAdministrator, SecondaryOfficeManagerAdministratorTelephoneNumber, SecondaryOfficeManagerAdministratorFaxNumber, SecondaryOfficeNameAffiliatedWithTaxIdNumber,SecondaryOfficeFederalTaxIdNumber, TertiaryOfficeStreetAddress, TertiaryOfficeCity, TertiaryOfficeState, TertiaryOfficeZip, TertiaryOfficeTelephoneNumber, TertiaryOfficeFaxNumber, TertiaryOfficeManagerAdministrator, TertiaryOfficeManagerAdministratorTelephoneNumber, TertiaryOfficeManagerAdministratorFaxNumber, TertiaryOfficeNameAffiliatedWithTaxIdNumber, TertiaryOfficeFederalTaxIdNumber)
                                                    OUTPUT INSERTED.PracticeInformationId
                                                    VALUES
                                                    (@practiceName, @departmentName, @primaryOfficeStreetAddress, @primaryOfficeCityStateZip, @primaryOfficeTelephoneNumber, @primaryOfficeFaxNumber, @primaryOfficeManagerAdministrator, @primaryOfficeManagerAdministratorTelephoneNumber, @primaryOfficeManagerAdministratorFaxNumber, @primaryOfficeNameAffiliatedWithTaxIdNumber, @primaryOfficeFederalTaxIdNumber, @secondaryOfficeStreetAddress, @secondaryOfficeCity, @secondaryOfficeState, @secondaryOfficeZip, @secondaryOfficeManagerAdministrator, @secondaryOfficeManagerAdministratorTelephoneNumber, @secondaryOfficeManagerAdministratorFaxNumber, @secondaryOfficeNameAffiliatedWithTaxIdNumber, @secondaryOfficeFederalTaxIdNumber, @tertiaryOfficeStreetAddress, @tertiaryOfficeCity, @tertiaryOfficeState, @tertiaryOfficeZip, @tertiaryOfficeTelephoneNumber, @tertiaryOfficeFaxNumber, @tertiaryOfficeManagerAdministrator, @tertiaryOfficeManagerAdministratorTelephoneNumber, @tertiaryOfficeManagerAdministratorFaxNumber, @tertiaryOfficeNameAffiliatedWithTaxIdNumber, @tertiaryOfficeFederalTaxIdNumber)", conn);

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@practiceName", practiceInformation.PracticeName);
            sqlCommand.Parameters.AddWithValue("@departmentName", practiceInformation.DepartmentName);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeStreetAddress", practiceInformation.PrimaryOfficeStreetAddress);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeCityStateZip", practiceInformation.PrimaryOfficeCityStateZip);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeTelephoneNumber", practiceInformation.PrimaryOfficeTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeFaxNumber", practiceInformation.PrimaryOfficeFaxNumber);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeManagerAdministrator", practiceInformation.PrimaryOfficeManagerAdministrator);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeManagerAdministratorTelephoneNumber", practiceInformation.PrimaryOfficeManagerAdministratorTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeManagerAdministratorFaxNumber", practiceInformation.PrimaryOfficeManagerAdministratorFaxNumber);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeNameAffiliatedWithTaxIdNumber", practiceInformation.PrimaryOfficeNameAffiliatedWithTaxIdNumber);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeFederalTaxIdNumber", practiceInformation.PrimaryOfficeFederalTaxIdNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeStreetAddress", practiceInformation.SecondaryOfficeStreetAddress);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeCity", practiceInformation.SecondaryOfficeCity);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeState", practiceInformation.SecondaryOfficeState);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeZip", practiceInformation.SecondaryOfficeZip);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeManagerAdministrator", practiceInformation.SecondaryOfficeManagerAdministrator);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeManagerAdministratorTelephoneNumber", practiceInformation.SecondaryOfficeManagerAdministratorTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeManagerAdministratorFaxNumber", practiceInformation.SecondaryOfficeManagerAdministratorFaxNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeNameAffiliatedWithTaxIdNumber", practiceInformation.SecondaryOfficeNameAffiliatedWithTaxIdNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeFederalTaxIdNumber", practiceInformation.SecondaryOfficeFederalTaxIdNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeStreetAddress", practiceInformation.TertiaryOfficeStreetAddress);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeCity", practiceInformation.TertiaryOfficeCity);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeState", practiceInformation.TertiaryOfficeState);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeZip", practiceInformation.TertiaryOfficeZip);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeTelephoneNumber", practiceInformation.TertiaryOfficeTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeFaxNumber", practiceInformation.TertiaryOfficeFaxNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeManagerAdministrator", practiceInformation.TertiaryOfficeManagerAdministrator);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeManagerAdministratorTelephoneNumber", practiceInformation.TertiaryOfficeManagerAdministratorTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeManagerAdministratorFaxNumber", practiceInformation.TertiaryOfficeManagerAdministratorFaxNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeNameAffiliatedWithTaxIdNumber", practiceInformation.TertiaryOfficeNameAffiliatedWithTaxIdNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeFederalTaxIdNumber", practiceInformation.TertiaryOfficeNameAffiliatedWithTaxIdNumber);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            return (int)sqlCommand.ExecuteScalar();
        }

        public int Insert(PracticeInformation practiceInformation)
        {
            int retVal;
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
            {
                retVal = Insert(conn, practiceInformation);
            }

            return retVal;
        }

        public void Update(SqlConnection conn, PracticeInformation practiceInformation)
        {
            var sqlCommand = new SqlCommand(@"UPDATE PracticeInformations
                                                    SET
                                                        PracticeName = @practiceName,
                                                        DepartmentName = @departmentName,
                                                        PrimaryOfficeStreetAddress = @primaryOfficeStreetAddress,
                                                        PrimaryOfficeCityStateZip = @primaryOfficeCityStateZip,
                                                        PrimaryOfficeTelephoneNumber = @primaryOfficeTelephoneNumber,
                                                        PrimaryOfficeFaxNumber = @primaryOfficeFaxNumber,
                                                        PrimaryOfficeManagerAdministrator = @primaryOfficeManagerAdministrator,
                                                        PrimaryOfficeManagerAdministratorTelephoneNumber = @primaryOfficeManagerAdministratorTelephoneNumber,
                                                        PrimaryOfficeManagerAdministratorFaxNumber = @primaryOfficeManagerAdministratorFaxNumber,
                                                        PrimaryOfficeNameAffiliatedWithTaxIdNumber = @primaryOfficeNameAffiliatedWithTaxIdNumber,
                                                        PrimaryOfficeFederalTaxIdNumber = @primaryOfficeFederalTaxIdNumber,

                                                        SecondaryOfficeStreetAddress = @secondaryOfficeStreetAddress,
                                                        SecondaryOfficeCity = @secondaryOfficeCity,
                                                        SecondaryOfficeState = @secondaryOfficeState,
                                                        SecondaryOfficeZip = @secondaryOfficeZip,
                                                        SecondaryOfficeManagerAdministrator = @secondaryOfficeManagerAdministrator,
                                                        SecondaryOfficeManagerAdministratorTelephoneNumber = @secondaryOfficeManagerAdministratorTelephoneNumber,
                                                        SecondaryOfficeManagerAdministratorFaxNumber = @secondaryOfficeManagerAdministratorFaxNumber,
                                                        SecondaryOfficeNameAffiliatedWithTaxIdNumber = @secondaryOfficeNameAffiliatedWithTaxIdNumber,
                                                        SecondaryOfficeFederalTaxIdNumber = @secondaryOfficeFederalTaxIdNumber,

                                                        TertiaryOfficeStreetAddress = @tertiaryOfficeStreetAddress,
                                                        TertiaryOfficeCity = @tertiaryOfficeCity,
                                                        TertiaryOfficeState = @tertiaryOfficeState,
                                                        TertiaryOfficeZip = @tertiaryOfficeZip,
                                                        TertiaryOfficeTelephoneNumber = @tertiaryOfficeTelephoneNumber,
                                                        TertiaryOfficeFaxNumber = @tertiaryOfficeFaxNumber,
                                                        TertiaryOfficeManagerAdministrator = @tertiaryOfficeManagerAdministrator,
                                                        TertiaryOfficeManagerAdministratorTelephoneNumber = @tertiaryOfficeManagerAdministratorTelephoneNumber,
                                                        TertiaryOfficeManagerAdministratorFaxNumber = @tertiaryOfficeManagerAdministratorFaxNumber,
                                                        TertiaryOfficeNameAffiliatedWithTaxIdNumber = @tertiaryOfficeNameAffiliatedWithTaxIdNumber,
                                                        TertiaryOfficeFederalTaxIdNumber = @tertiaryOfficeFederalTaxIdNumber
                                                    WHERE PracticeInformationId = @practiceInformationId
                                                    ", conn);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            sqlCommand.Parameters.AddWithValue("@practiceInformationId", practiceInformation.PracticeInformationId);
            sqlCommand.Parameters.AddWithValue("@practiceName", practiceInformation.PracticeName);
            sqlCommand.Parameters.AddWithValue("@departmentName", practiceInformation.DepartmentName);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeStreetAddress", practiceInformation.PrimaryOfficeStreetAddress);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeCityStateZip", practiceInformation.PrimaryOfficeCityStateZip);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeTelephoneNumber", practiceInformation.PrimaryOfficeTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeFaxNumber", practiceInformation.PrimaryOfficeFaxNumber);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeManagerAdministrator", practiceInformation.PrimaryOfficeManagerAdministrator);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeManagerAdministratorTelephoneNumber", practiceInformation.PrimaryOfficeManagerAdministratorTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeManagerAdministratorFaxNumber", practiceInformation.PrimaryOfficeManagerAdministratorFaxNumber);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeNameAffiliatedWithTaxIdNumber", practiceInformation.PrimaryOfficeNameAffiliatedWithTaxIdNumber);
            sqlCommand.Parameters.AddWithValue("@primaryOfficeFederalTaxIdNumber", practiceInformation.PrimaryOfficeFederalTaxIdNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeStreetAddress", practiceInformation.SecondaryOfficeStreetAddress);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeCity", practiceInformation.SecondaryOfficeCity);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeState", practiceInformation.SecondaryOfficeState);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeZip", practiceInformation.SecondaryOfficeZip);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeManagerAdministrator", practiceInformation.SecondaryOfficeManagerAdministrator);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeManagerAdministratorTelephoneNumber", practiceInformation.SecondaryOfficeManagerAdministratorTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeManagerAdministratorFaxNumber", practiceInformation.SecondaryOfficeManagerAdministratorFaxNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeNameAffiliatedWithTaxIdNumber", practiceInformation.SecondaryOfficeNameAffiliatedWithTaxIdNumber);
            sqlCommand.Parameters.AddWithValue("@secondaryOfficeFederalTaxIdNumber", practiceInformation.SecondaryOfficeFederalTaxIdNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeStreetAddress", practiceInformation.TertiaryOfficeStreetAddress);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeCity", practiceInformation.TertiaryOfficeCity);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeState", practiceInformation.TertiaryOfficeState);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeZip", practiceInformation.TertiaryOfficeZip);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeTelephoneNumber", practiceInformation.TertiaryOfficeTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeFaxNumber", practiceInformation.TertiaryOfficeFaxNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeManagerAdministrator", practiceInformation.TertiaryOfficeManagerAdministrator);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeManagerAdministratorTelephoneNumber", practiceInformation.TertiaryOfficeManagerAdministratorTelephoneNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeManagerAdministratorFaxNumber", practiceInformation.TertiaryOfficeManagerAdministratorFaxNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeNameAffiliatedWithTaxIdNumber", practiceInformation.TertiaryOfficeNameAffiliatedWithTaxIdNumber);
            sqlCommand.Parameters.AddWithValue("@tertiaryOfficeFederalTaxIdNumber", practiceInformation.TertiaryOfficeNameAffiliatedWithTaxIdNumber);

            foreach (SqlParameter parameter in sqlCommand.Parameters.Cast<SqlParameter>().Where(parameter => parameter.Value == null))
            {
                parameter.Value = DBNull.Value;
            }

            sqlCommand.ExecuteNonQuery();
        }

        public void Update(PracticeInformation practiceInformation)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
            {
                Update(conn, practiceInformation);
            }
        }
    }
}