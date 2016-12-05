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
    }
}