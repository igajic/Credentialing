using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
