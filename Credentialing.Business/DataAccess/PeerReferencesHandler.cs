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
    }
}