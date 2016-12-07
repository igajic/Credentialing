using Credentialing.Entities.Data;
using System.Data.SqlClient;

namespace Credentialing.Business.DataAccess
{
    public class OtherStateMedicalProfessionalLicensesHandler
    {
        private static OtherStateMedicalProfessionalLicensesHandler _instance;

        public static OtherStateMedicalProfessionalLicensesHandler Instance
        {
            get { return _instance ?? (_instance = new OtherStateMedicalProfessionalLicensesHandler()); }
        }

        private OtherStateMedicalProfessionalLicensesHandler()
        {
        }

        public OtherStateMedicalProfessionalLicenses GetById(int otherStateMedicalProfessionalLicensesId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }

        public OtherStateMedicalProfessionalLicenses GetById(SqlConnection conn, SqlTransaction trans, int otherStateMedicalProfessionalLicensesId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }
    }
}