using Credentialing.Entities;
using Credentialing.Entities.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Credentialing.Business.DataAccess
{
    public class PeerReferencesHandler
    {
        private static PeerReferencesHandler _instance;

        public static PeerReferencesHandler Instance
        {
            get { return _instance ?? (_instance = new PeerReferencesHandler()); }
        }

        private PeerReferencesHandler()
        {
        }

        public PeerReferences GetById(int peerReferencesId, bool deepLoad = false)
        {
            using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings[Constants.ConnectionStringName].ConnectionString))
            {
                return GetById(conn, null, peerReferencesId, deepLoad);
            }
        }

        public PeerReferences GetById(SqlConnection conn, SqlTransaction trans, int peerReferencesId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }
    }
}