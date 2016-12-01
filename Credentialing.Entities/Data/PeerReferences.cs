namespace Credentialing.Entities.Data
{
    public class PeerReferences
    {
        public PeerReferences()
        {
        }

        public int PeerReferencesId { get; set; }

        // primary
        public string PrimaryNameReference { get; set; }

        public string PrimarySpecialty { get; set; }

        public string PrimaryTelephoneNumber { get; set; }

        public string PrimaryMailingAddress { get; set; }

        public string PrimaryCity { get; set; }

        public string PrimaryState { get; set; }

        public string PrimaryZip { get; set; }

        // secondary
        public string SecondaryNameReference { get; set; }

        public string SecondarySpecialty { get; set; }

        public string SecondaryTelephoneNumber { get; set; }

        public string SecondaryMailingAddress { get; set; }

        public string SecondaryCity { get; set; }

        public string SecondaryState { get; set; }

        public string SecondaryZip { get; set; }

        // tertiary
        public string TertiaryNameReference { get; set; }

        public string TertiarySpecialty { get; set; }

        public string TertiaryTelephoneNumber { get; set; }

        public string TertiaryMailingAddress { get; set; }

        public string TertiaryCity { get; set; }

        public string TertiaryState { get; set; }

        public string TertiaryZip { get; set; }
    }
}