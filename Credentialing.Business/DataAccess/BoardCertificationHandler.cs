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
    }
}