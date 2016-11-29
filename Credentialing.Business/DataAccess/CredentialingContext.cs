using Credentialing.Entities.Data;
using Credentialing.Entities.Steps;
using System.Data.Entity;

namespace Credentialing.Business.DataAccess
{
    public class CredentialingContext : DbContext
    {
        public CredentialingContext()
            : base("name=CredentialingDB")
        {
        }

        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<Education> Educations { get; set; }

        public DbSet<IdentifyingInformation> IndentifyingInformations { get; set; }

        public DbSet<PracticeInformation> PracticeInformations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentifyingInformation>()
                .HasOptional(s => s.CitizenshipFile)
                .WithRequired(s => s.IdentifyingInformation);
        }
    }
}