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
    }
}