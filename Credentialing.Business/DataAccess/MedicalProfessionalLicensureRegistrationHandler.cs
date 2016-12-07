using Credentialing.Entities.Data;
using System.Data.SqlClient;
namespace Credentialing.Business.DataAccess
{
    public class MedicalProfessionalLicensureRegistrationHandler
    {
        private static MedicalProfessionalLicensureRegistrationHandler _instance;

        public static MedicalProfessionalLicensureRegistrationHandler Instance
        {
            get { return _instance ?? (_instance = new MedicalProfessionalLicensureRegistrationHandler()); }
        }

        private MedicalProfessionalLicensureRegistrationHandler()
        {
        }

        public MedicalProfessionalLicensureRegistrations GetById(int medicalProfessionalLicensureId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }

        public MedicalProfessionalLicensureRegistrations GetById(SqlConnection conn, SqlTransaction trans, int medicalProfessionalLicensureId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }
    }
}