using Credentialing.Entities.Data;
using System.Data.SqlClient;

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

        public CurrentHospitalInstitutionalAffiliations GetById(int currentHospitalInstitutionalAffiliationsId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }

        public CurrentHospitalInstitutionalAffiliations GetById(SqlConnection conn, SqlTransaction trans, int currentHospitalInstitutionalAffiliationsId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }
    }
}