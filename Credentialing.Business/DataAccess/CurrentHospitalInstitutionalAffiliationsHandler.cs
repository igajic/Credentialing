namespace Credentialing.Business.DataAccess
{
    public class CurrentHospitalInstitutionalAffiliationsHandler
    {
        private static CurrentHospitalInstitutionalAffiliationsHandler _instance;

        public static CurrentHospitalInstitutionalAffiliationsHandler Instance
        {
            get { return _instance ?? (_instance = new CurrentHospitalInstitutionalAffiliationsHandler()); }
        }

        private CurrentHospitalInstitutionalAffiliationsHandler()
        {
        }
    }
}