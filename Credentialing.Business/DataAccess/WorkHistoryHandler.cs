using Credentialing.Entities.Data;
using System.Data.SqlClient;
namespace Credentialing.Business.DataAccess
{
    public class WorkHistoryHandler
    {
        private static WorkHistoryHandler _instance;

        public static WorkHistoryHandler Instance
        {
            get { return _instance ?? (_instance = new WorkHistoryHandler()); }
        }

        private WorkHistoryHandler()
        {
        }

        public WorkHistory GetById(int workHistoryId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }

        public WorkHistory GetById(SqlConnection conn, SqlTransaction trans, int workHistoryId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }
    }
}