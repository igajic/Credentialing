using Credentialing.Entities.Data;
using System.Data.SqlClient;

namespace Credentialing.Business.DataAccess
{
    public class OtherCertificationsHandler
    {
        private static OtherCertificationsHandler _instance;

        public static OtherCertificationsHandler Instance
        {
            get { return _instance ?? (_instance = new OtherCertificationsHandler()); }
        }

        private OtherCertificationsHandler()
        {
        }

        public OtherCertifications GetById(int otherCertificationsId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }

        public OtherCertifications GetById(SqlConnection conn, SqlTransaction trans, int otherCertificationsId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }
    }
}