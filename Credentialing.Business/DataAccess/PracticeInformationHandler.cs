using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using Credentialing.Entities;
using Credentialing.Entities.Data;

namespace Credentialing.Business.DataAccess
{
    public class PracticeInformationHandler
    {
        private static PracticeInformationHandler _instance;

        public static PracticeInformationHandler Instance
        {
            get { return _instance ?? new PracticeInformationHandler(); }
        }

        private PracticeInformationHandler()
        {
        }

        public PracticeInformation GetById(int id)
        {
            PracticeInformation retVal = null;
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["CredentialingDB"].ConnectionString))
            {
                var sqlCommand = new SqlCommand("SELECT * FROM Attachments WHERE AttachmentId = @attachmentId", conn);
                sqlCommand.Parameters.AddWithValue("@attachmentId", id);

                conn.Open();

                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            retVal = new PracticeInformation();

                            retVal.PracticeInformationId = (int) reader[Constants.PracticeInformationColumns.PracticeInformationId];
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
            }

            return retVal;
        }

        public int Insert(PracticeInformation practiceInformation)
        {
            return 0;
        }

        public void Update(PracticeInformationHandler practiceInformation)
        {
            // TODO: Update
        }
    }
}
