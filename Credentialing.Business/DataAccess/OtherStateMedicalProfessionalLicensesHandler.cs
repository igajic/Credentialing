using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
