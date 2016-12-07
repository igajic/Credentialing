using Credentialing.Entities.Data;
using System.Data.SqlClient;
namespace Credentialing.Business.DataAccess
{
    public class ResidenciesFellowshipHandler
    {
        private static ResidenciesFellowshipHandler _instance;

        public static ResidenciesFellowshipHandler Instance
        {
            get { return _instance ?? (_instance = new ResidenciesFellowshipHandler()); }
        }

        private ResidenciesFellowshipHandler()
        {
        }

        public ResidenciesFellowship GetById(int residenciesFellowshipId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }

        public ResidenciesFellowship GetById(SqlConnection conn, SqlTransaction trans, int residenciesFellowshipId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }
    }
}