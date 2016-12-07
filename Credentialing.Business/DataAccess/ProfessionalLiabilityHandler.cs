using Credentialing.Entities.Data;
using System.Data.SqlClient;
namespace Credentialing.Business.DataAccess
{
    public class ProfessionalLiabilityHandler
    {
        private static ProfessionalLiabilityHandler _instance;

        public static ProfessionalLiabilityHandler Instance
        {
            get { return _instance ?? (_instance = new ProfessionalLiabilityHandler()); }
        }

        private ProfessionalLiabilityHandler()
        {
        }

        public ProfessionalLiability GetById(int professionalLiabilityId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }

        public ProfessionalLiability GetById(SqlConnection conn, SqlTransaction trans, int professionalLiabilityId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }
    }
}