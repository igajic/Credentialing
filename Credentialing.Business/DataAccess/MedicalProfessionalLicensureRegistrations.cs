namespace Credentialing.Business.DataAccess
{
    public class MedicalProfessionalLicensureRegistrations
    {
        private static MedicalProfessionalLicensureRegistrations _instance;

        public static MedicalProfessionalLicensureRegistrations Instance
        {
            get { return _instance ?? (_instance = new MedicalProfessionalLicensureRegistrations()); }
        }

        private MedicalProfessionalLicensureRegistrations()
        {
        }
    }
}