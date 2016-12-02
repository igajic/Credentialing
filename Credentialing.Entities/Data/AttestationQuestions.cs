using System.Collections.Generic;

namespace Credentialing.Entities.Data
{
    public class AttestationQuestions
    {
        public AttestationQuestions()
        {
        }

        public int AttestationQuestionsId { get; set; }

        public bool QuestionA { get; set; }

        public bool QuestionB { get; set; }

        public bool QuestionC { get; set; }

        public bool QuestionD { get; set; }

        public bool QuestionE { get; set; }

        public bool QuestionF { get; set; }

        public bool QuestionG { get; set; }

        public bool QuestionH { get; set; }

        public bool QuestionI { get; set; }

        public bool QuestionJ { get; set; }

        public bool QuestionK { get; set; }

        public bool QuestionL { get; set; }

        public bool QuestionM { get; set; }

        public virtual ICollection<Attachment> AdditionalSheets { get; set; }
    }
}