using System.Collections.Generic;

namespace Credentialing.Entities.Data
{
    public class WorkHistory
    {
        public WorkHistory()
        {
        }

        public int WorkHistoryId { get; set; }

        // TODO: Add fields

        public ICollection<Attachment> Attachments { get; set; }
    }
}