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
    }
}