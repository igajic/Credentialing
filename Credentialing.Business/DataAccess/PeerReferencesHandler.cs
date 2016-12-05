using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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