using Credentialing.Entities.Data;
using System.Data.SqlClient;

namespace Credentialing.Business.DataAccess
{
    public class InternshipHandler
    {
        private static InternshipHandler _instance;

        public static InternshipHandler Instance
        {
            get { return _instance ?? (_instance = new InternshipHandler()); }
        }

        private InternshipHandler()
        {
        }

        public Internship GetById(int internshipId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }

        public Internship GetById(SqlConnection conn, SqlTransaction trans, int internshipId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }
    }
}