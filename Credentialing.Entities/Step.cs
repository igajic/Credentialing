namespace Credentialing.Entities
{
    public class Step
    {
        public int StepId { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }

        public int PercentComplete { get; set; }
    }
}