using System.Collections.Generic;

namespace Credentialing.Entities.Data
{
    public class AttestationQuestions
    {
        public AttestationQuestions()
        {
        }

        public int AttestationQuestionsId { get; set; }

        public bool? QuestionA { get; set; }

        public bool? QuestionB { get; set; }

        public bool? QuestionC { get; set; }

        public bool? QuestionD { get; set; }

        public bool? QuestionE { get; set; }

        public bool? QuestionF { get; set; }

        public bool? QuestionG { get; set; }

        public bool? QuestionH { get; set; }

        public bool? QuestionI { get; set; }

        public bool? QuestionJ { get; set; }

        public bool? QuestionK { get; set; }

        public bool? QuestionL { get; set; }

        public bool? QuestionM { get; set; }

        public virtual ICollection<Attachment> AdditionalSheets { get; set; }

        public virtual int PercentComplete
        {
            get
            {
                var tmp = QuestionA.HasValue ? 1 : 0;
                tmp += QuestionB.HasValue ? 1 : 0;
                tmp += QuestionC.HasValue ? 1 : 0;
                tmp += QuestionD.HasValue ? 1 : 0;
                tmp += QuestionE.HasValue ? 1 : 0;
                tmp += QuestionF.HasValue ? 1 : 0;
                tmp += QuestionG.HasValue ? 1 : 0;
                tmp += QuestionH.HasValue ? 1 : 0;
                tmp += QuestionI.HasValue ? 1 : 0;
                tmp += QuestionJ.HasValue ? 1 : 0;
                tmp += QuestionK.HasValue ? 1 : 0;
                tmp += QuestionL.HasValue ? 1 : 0;
                tmp += QuestionM.HasValue ? 1 : 0;

                return 100*tmp/13;
            }
        }
    }
}