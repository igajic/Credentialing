using Credentialing.Entities.Data;
using System.Data.SqlClient;
namespace Credentialing.Business.DataAccess
{
    public class BoardCertificationHandler
    {
        private static BoardCertificationHandler _instance;

        public static BoardCertificationHandler Instance
        {
            get { return _instance ?? (_instance = new BoardCertificationHandler()); }
        }

        private BoardCertificationHandler()
        {
        }

        public BoardCertification GetById(int boardCertificationId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }

        public BoardCertification GetById(SqlConnection conn, SqlTransaction trans, int boardCertificationId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }
    }
}