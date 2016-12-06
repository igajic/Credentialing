namespace Credentialing.Business.DataAccess
{
    public class ResidenciesFellowshipHandler
    {
        private static ResidenciesFellowshipHandler _instance;

        public static ResidenciesFellowshipHandler Instance
        {
            get { return _instance ?? (_instance = new ResidenciesFellowshipHandler()); }
        }

        private ResidenciesFellowshipHandler()
        {
        }
    }
}