namespace Credentialing.Business.DataAccess
{
    public class OtherStateMedicalProfessionalLicensesHandler
    {
        private static OtherStateMedicalProfessionalLicensesHandler _instance;

        public static OtherStateMedicalProfessionalLicensesHandler Instance
        {
            get { return _instance ?? (_instance = new OtherStateMedicalProfessionalLicensesHandler()); }
        }

        private OtherStateMedicalProfessionalLicensesHandler()
        {
        }
    }
}