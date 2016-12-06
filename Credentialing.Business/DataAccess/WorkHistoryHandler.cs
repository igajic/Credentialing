namespace Credentialing.Business.DataAccess
{
    public class WorkHistoryHandler
    {
        private static WorkHistoryHandler _instance;

        public static WorkHistoryHandler Instance
        {
            get { return _instance ?? (_instance = new WorkHistoryHandler()); }
        }

        private WorkHistoryHandler()
        {
        }
    }
}