namespace Credentialing.Entities.Data
{
    public class ProfessionalLiability
    {
        public ProfessionalLiability()
        {
        }

        public int ProfessionalLiabilityId { get; set; }

        // TODO: Add fields

        public virtual Attachment CurrentLiabilityPolicy { get; set; }
    }
}