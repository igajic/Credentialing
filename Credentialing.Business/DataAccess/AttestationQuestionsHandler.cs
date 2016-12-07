using Credentialing.Entities.Data;
using System.Data.SqlClient;
namespace Credentialing.Business.DataAccess
{
    public class AttestationQuestionsHandler
    {
        private static AttestationQuestionsHandler _instance;

        public static AttestationQuestionsHandler Instance
        {
            get { return _instance ?? (_instance = new AttestationQuestionsHandler()); }
        }

        private AttestationQuestionsHandler()
        {
        }

        public AttestationQuestions GetById(int attestationQuestionsId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }

        public AttestationQuestions GetById(SqlConnection conn, SqlTransaction trans, int attestationQuestionsId, bool deepLoad = false)
        {
            // TODO: Implement this
            return null;
        }
    }
}