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
            Configuration.AutoDetectChangesEnabled = true;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<PracticionerApplication> PracticionerApplications { get; set; }

        public DbSet<IdentifyingInformation> IndentifyingInformations { get; set; }

        public DbSet<PracticeInformation> PracticeInformations { get; set; }

        public DbSet<Education> Educations { get; set; }

        public DbSet<MedicalProfessionalEducation> MedicalProfessionalEducations { get; set; }

        public DbSet<Internship> Internships { get; set; }

        public DbSet<ResidenciesFellowship> ResidenciesFellowships { get; set; }

        public DbSet<BoardCertification> BoardCertifications { get; set; }

        public DbSet<OtherCertifications> OtherCertificationes { get; set; }

        public DbSet<MedicalProfessionalLicensureRegistrations> MedicalProfessionalLicensureRegistrations { get; set; }

        public DbSet<OtherStateMedicalProfessionalLicenses> OtherStateMedicalProfessionalLicenseses { get; set; }

        public DbSet<ProfessionalLiability> ProfessionalLiabilities { get; set; }

        public DbSet<CurrentHospitalInstitutionalAffiliations> CurrentHospitalInstitutionalAffiliations { get; set; }

        public DbSet<PeerReferences> PeerReferences { get; set; }

        public DbSet<WorkHistory> WorkHistories { get; set; }

        public DbSet<AttestationQuestions> AttestationQuestions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentifyingInformation>()
                .HasOptional(s => s.CitizenshipFile)
                .WithRequired(s => s.IdentifyingInformation);


            modelBuilder.Entity<ProfessionalLiability>()
                .HasOptional(s => s.CurrentLiabilityPolicy)
                .WithRequired(s => s.ProfessionalLiability);

            modelBuilder.Entity<Attachment>()
                    .HasOptional(s => s.Education)
                    .WithMany(s => s.AttachedDocuments)
                    .HasForeignKey(s => s.EducationId);

            modelBuilder.Entity<Attachment>()
                .HasOptional(s => s.MedicalProfessionalEducation)
                .WithMany(s => s.Attachments)
                .HasForeignKey(s => s.MedicalProfessionalEducationId);

            modelBuilder.Entity<Attachment>()
                .HasOptional(s => s.Internship)
                .WithMany(s => s.Attachments)
                .HasForeignKey(s => s.InternshipId);

            modelBuilder.Entity<Attachment>()
                .HasOptional(s => s.ResidenciesFellowship)
                .WithMany(s => s.Attachments)
                .HasForeignKey(s => s.ResidenciesFellowshipId);

            modelBuilder.Entity<Attachment>()
                .HasOptional(s => s.OtherCertifications)
                .WithMany(s => s.Attachments)
                .HasForeignKey(s => s.OtherCertificationsId);

            modelBuilder.Entity<Attachment>()
                .HasOptional(s => s.MedicalProfessionalLicensureRegistrations)
                .WithMany(s => s.Attachments)
                .HasForeignKey(s => s.MedicalProfessionalLicensureRegistrationsId);

            modelBuilder.Entity<Attachment>()
                .HasOptional(s => s.OtherStateMedicalProfessionalLicenses)
                .WithMany(s => s.Attachments)
                .HasForeignKey(s => s.OtherStateMedicalProfessionalLicensesId);

            modelBuilder.Entity<Attachment>()
                .HasOptional(s => s.WorkHistories)
                .WithMany(s => s.Attachments)
                .HasForeignKey(s => s.WorkHistoryId);
        }
    }
}