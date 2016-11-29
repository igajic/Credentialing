using Credentialing.Entities.Steps;

namespace Credentialing.Entities.Data
{
    public class Attachment
    {
        public Attachment()
        {
        }

        public int AttachmentId { get; set; }

        public string FileName { get; set; }

        public byte[] Content { get; set; }

        public virtual IdentifyingInformation IdentifyingInformation { get; set; }

        //public virtual Education Education { get; set; }
    }
}