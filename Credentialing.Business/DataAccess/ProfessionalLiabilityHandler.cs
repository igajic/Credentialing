namespace Credentialing.Business.DataAccess
{
    public class ProfessionalLiabilityHandler
    {
        private static ProfessionalLiabilityHandler _instance;

        public static ProfessionalLiabilityHandler Instance
        {
            get { return _instance ?? (_instance = new ProfessionalLiabilityHandler()); }
        }

        private ProfessionalLiabilityHandler()
        {
        }
    }
}