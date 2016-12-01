using System.Collections.Generic;

namespace Credentialing.Entities.Data
{
    public class AttestationQuestions
    {
        public AttestationQuestions()
        {
        }

        public int AttestationQuestionsId { get; set; }

        // TODO Add fields

        public virtual ICollection<Attachment> AdditionalSheets { get; set; }
    }
}