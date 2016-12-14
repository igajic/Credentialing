namespace Credentialing.Entities.Data
{
    public class PracticeInformation
    {
        public PracticeInformation()
        {
            
        }

        public int PracticeInformationId { get; set; }

        public string PracticeName { get; set; }

        public string DepartmentName { get; set; }

        public bool? Completed { get; set; }

        #region [Primary office]

        public string PrimaryOfficeStreetAddress { get; set; }

        public string PrimaryOfficeCityStateZip { get; set; }

        public string PrimaryOfficeTelephoneNumber { get; set; }

        public string PrimaryOfficeFaxNumber { get; set; }

        public string PrimaryOfficeManagerAdministrator { get; set; }

        public string PrimaryOfficeManagerAdministratorTelephoneNumber { get; set; }

        public string PrimaryOfficeManagerAdministratorFaxNumber { get; set; }

        public string PrimaryOfficeNameAffiliatedWithTaxIdNumber { get; set; }

        public string PrimaryOfficeFederalTaxIdNumber { get; set; }

        #endregion [Primary office]

        #region [Secondary office]

        public string SecondaryOfficeStreetAddress { get; set; }

        public string SecondaryOfficeCity { get; set; }

        public string SecondaryOfficeState { get; set; }

        public string SecondaryOfficeZip { get; set; }

        public string SecondaryOfficeManagerAdministrator { get; set; }

        public string SecondaryOfficeManagerAdministratorTelephoneNumber { get; set; }

        public string SecondaryOfficeManagerAdministratorFaxNumber { get; set; }

        public string SecondaryOfficeNameAffiliatedWithTaxIdNumber { get; set; }

        public string SecondaryOfficeFederalTaxIdNumber { get; set; }

        #endregion [Secondary office]

        #region [Tertiary office]

        public string TertiaryOfficeStreetAddress { get; set; }

        public string TertiaryOfficeCity { get; set; }

        public string TertiaryOfficeState { get; set; }

        public string TertiaryOfficeZip { get; set; }
        
        public string TertiaryOfficeManagerAdministrator { get; set; }

        public string TertiaryOfficeManagerAdministratorTelephoneNumber { get; set; }

        public string TertiaryOfficeManagerAdministratorFaxNumber { get; set; }

        public string TertiaryOfficeNameAffiliatedWithTaxIdNumber { get; set; }

        public string TertiaryOfficeFederalTaxIdNumber { get; set; }

        #endregion [Tertiary office]

        public int PercentComplete
        {
            get
            {
                if (Completed ?? false) return 100;

                var tmp = PracticeName.IsCompleted();
                tmp += DepartmentName.IsCompleted();
                tmp += PrimaryOfficeStreetAddress.IsCompleted();
                tmp += PrimaryOfficeCityStateZip.IsCompleted();
                tmp += PrimaryOfficeTelephoneNumber.IsCompleted();
                tmp += PrimaryOfficeFaxNumber.IsCompleted();
                tmp += PrimaryOfficeManagerAdministrator.IsCompleted();
                tmp += PrimaryOfficeManagerAdministratorTelephoneNumber.IsCompleted();
                tmp += PrimaryOfficeManagerAdministratorFaxNumber.IsCompleted();
                tmp += PrimaryOfficeNameAffiliatedWithTaxIdNumber.IsCompleted();
                tmp += PrimaryOfficeFederalTaxIdNumber.IsCompleted();
                tmp += SecondaryOfficeStreetAddress.IsCompleted();
                tmp += SecondaryOfficeCity.IsCompleted();
                tmp += SecondaryOfficeState.IsCompleted();
                tmp += SecondaryOfficeZip.IsCompleted();
                tmp += SecondaryOfficeManagerAdministrator.IsCompleted();
                tmp += SecondaryOfficeManagerAdministratorTelephoneNumber.IsCompleted();
                tmp += SecondaryOfficeManagerAdministratorFaxNumber.IsCompleted();
                tmp += SecondaryOfficeNameAffiliatedWithTaxIdNumber.IsCompleted();
                tmp += SecondaryOfficeFederalTaxIdNumber.IsCompleted();
                tmp += TertiaryOfficeStreetAddress.IsCompleted();
                tmp += TertiaryOfficeCity.IsCompleted();
                tmp += TertiaryOfficeState.IsCompleted();
                tmp += TertiaryOfficeZip.IsCompleted();
                tmp += TertiaryOfficeManagerAdministrator.IsCompleted();
                tmp += TertiaryOfficeManagerAdministratorTelephoneNumber.IsCompleted();
                tmp += TertiaryOfficeManagerAdministratorFaxNumber.IsCompleted();
                tmp += TertiaryOfficeNameAffiliatedWithTaxIdNumber.IsCompleted();
                tmp += TertiaryOfficeFederalTaxIdNumber.IsCompleted();

                return 100*tmp/29;
            }
        }
    }
}