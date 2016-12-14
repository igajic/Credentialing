namespace Credentialing.Entities
{
    public static class Constants
    {
        public const string ConnectionStringName = "CredentialingDB";

        public static class RequestParameters
        {
            public const string AttachmentId = "attachmentId";
        }

        public static class AttachmentColumns
        {
            public const string AttachmentId = "AttachmentId";
            public const string FileName = "FileName";
            public const string Content = "Content";
            public const string EducationId = "EducationId";
            public const string MedicalProfessionalEducationId = "MedicalProfessionalEducationId";
            public const string InternshipId = "InternshipId";
            public const string ResidenciesFellowshipId = "ResidenciesFellowshipId";
            public const string OtherCertificationsId = "OtherCertificationsId";
            public const string MedicalProfessionalLicensureRegistrationsId = "MedicalProfessionalLicensureRegistrationsId";
            public const string OtherStateMedicalProfessionalLicensesId = "OtherStateMedicalProfessionalLicensesId";
            public const string WorkHistoryId = "WorkHistoryId";
            public const string AttestationQuestionsId = "AttestationQuestionsId";
        }

        public static class IdentifyingInformationColumns
        {
            public const string IdentifyingInformationId = "IdentifyingInformationId";
            public const string LastName = "LastName";
            public const string FirstName = "FirstName";
            public const string MiddleName = "MiddleName";
            public const string OtherKnownNames = "OtherKnownNames";
            public const string HomeMailingAddress = "HomeMailingAddress";
            public const string City = "City";
            public const string State = "State";
            public const string Zip = "Zip";
            public const string HomeTelephoneNumber = "HomeTelephoneNumber";
            public const string HomeFaxNumber = "HomeFaxNumber";
            public const string EmailAddress = "EmailAddress";
            public const string PagerNumber = "PagerNumber";
            public const string BirthDate = "BirthDate";
            public const string BirthPlace = "BirthPlace";
            public const string SocialSecurityNumber = "SocialSecurityNumber";
            public const string Gender = "Gender";
            public const string Specialty = "Specialty";
            public const string RaceEthnicity = "RaceEthnicity";
            public const string Subspecialties = "Subspecialties";
            public const string AttachmentId = "AttachmentId";
            public const string Completed = "Completed";
        }

        public static class PracticionerApplicationColumns
        {
            public const string PracticionerApplicationId = "PracticionerApplicationId";
            public const string UserId = "UserId";
            public const string AttestationQuestionsId = "AttestationQuestionsId";
            public const string BoardCertificationId = "BoardCertificationId";
            public const string CurrentHospitalInstitutionalAffiliationsId = "CurrentHospitalInstitutionalAffiliationsId";
            public const string EducationId = "EducationId";
            public const string IdentifyingInformationId = "IdentifyingInformationId";
            public const string InternshipId = "InternshipId";
            public const string MedicalProfessionalEducationId = "MedicalProfessionalEducationId";
            public const string MedicalProfessionalLicensureRegistrationsId = "MedicalProfessionalLicensureRegistrationsId";
            public const string OtherCertificationsId = "OtherCertificationsId";
            public const string OtherStateMedicalProfessionalLicensesId = "OtherStateMedicalProfessionalLicensesId";
            public const string PeerReferencesId = "PeerReferencesId";
            public const string PracticeInformationId = "PracticeInformationId";
            public const string ProfessionalLiabilityId = "ProfessionalLiabilityId";
            public const string ResidenciesFellowshipId = "ResidenciesFellowshipId";
            public const string WorkHistoryId = "WorkHistoryId";
            public const string Completed = "Completed";
        }

        public static class EducationColumns
        {
            public const string EducationId = "EducationId";
            public const string CollegeUniverityName = "CollegeUniverityName";
            public const string DegreeReceived = "DegreeReceived";
            public const string DateGraduation = "DateGraduation";
            public const string MailingAddress = "MailingAddress";
            public const string MailingCity = "MailingCity";
            public const string MailingState = "MailingState";
            public const string MailingZip = "MailingZip";
            public const string Completed = "Completed";
        }

        public static class PracticeInformationColumns
        {
            public const string PracticeInformationId = "PracticeInformationId";
            public const string PracticeName = "PracticeName";
            public const string DepartmentName = "DepartmentName";
            public const string PrimaryOfficeStreetAddress = "PrimaryOfficeStreetAddress";
            public const string PrimaryOfficeCityStateZip = "PrimaryOfficeCityStateZip";
            public const string PrimaryOfficeTelephoneNumber = "PrimaryOfficeTelephoneNumber";
            public const string PrimaryOfficeFaxNumber = "PrimaryOfficeFaxNumber";
            public const string PrimaryOfficeManagerAdministrator = "PrimaryOfficeManagerAdministrator";
            public const string PrimaryOfficeManagerAdministratorTelephoneNumber = "PrimaryOfficeManagerAdministratorTelephoneNumber";
            public const string PrimaryOfficeManagerAdministratorFaxNumber = "PrimaryOfficeManagerAdministratorFaxNumber";
            public const string PrimaryOfficeNameAffiliatedWithTaxIdNumber = "PrimaryOfficeNameAffiliatedWithTaxIdNumber";
            public const string PrimaryOfficeFederalTaxIdNumber = "PrimaryOfficeFederalTaxIdNumber";
            public const string SecondaryOfficeStreetAddress = "SecondaryOfficeStreetAddress";
            public const string SecondaryOfficeCity = "SecondaryOfficeCity";
            public const string SecondaryOfficeState = "SecondaryOfficeState";
            public const string SecondaryOfficeZip = "SecondaryOfficeZip";
            public const string SecondaryOfficeManagerAdministrator = "SecondaryOfficeManagerAdministrator";
            public const string SecondaryOfficeManagerAdministratorTelephoneNumber = "SecondaryOfficeManagerAdministratorTelephoneNumber";
            public const string SecondaryOfficeManagerAdministratorFaxNumber = "SecondaryOfficeManagerAdministratorFaxNumber";
            public const string SecondaryOfficeNameAffiliatedWithTaxIdNumber = "SecondaryOfficeNameAffiliatedWithTaxIdNumber";
            public const string SecondaryOfficeFederalTaxIdNumber = "SecondaryOfficeFederalTaxIdNumber";
            public const string TertiaryOfficeStreetAddress = "TertiaryOfficeStreetAddress";
            public const string TertiaryOfficeCity = "TertiaryOfficeCity";
            public const string TertiaryOfficeState = "TertiaryOfficeState";
            public const string TertiaryOfficeZip = "TertiaryOfficeZip";
            public const string TertiaryOfficeManagerAdministrator = "TertiaryOfficeManagerAdministrator";
            public const string TertiaryOfficeManagerAdministratorTelephoneNumber = "TertiaryOfficeManagerAdministratorTelephoneNumber";
            public const string TertiaryOfficeManagerAdministratorFaxNumber = "TertiaryOfficeManagerAdministratorFaxNumber";
            public const string TertiaryOfficeNameAffiliatedWithTaxIdNumber = "TertiaryOfficeNameAffiliatedWithTaxIdNumber";
            public const string TertiaryOfficeFederalTaxIdNumber = "TertiaryOfficeFederalTaxIdNumber";
            public const string Completed = "Completed";
        }

        public static class MedicalProfessionalEducationColumns
        {
            public const string MedicalProfessionalEducationId = "MedicalProfessionalEducationId";
            public const string PrimaryMedicalProfessionalSchool = "PrimaryMedicalProfessionalSchool";
            public const string PrimaryDegreeReceived = "PrimaryDegreeReceived";
            public const string PrimaryDateOfGraduation = "PrimaryDateOfGraduation";
            public const string PrimaryMailingAddress = "PrimaryMailingAddress";
            public const string PrimaryCity = "PrimaryCity";
            public const string PrimaryStateCountry = "PrimaryStateCountry";
            public const string PrimaryZip = "PrimaryZip";
            public const string SecondaryMedicalProfessionalSchool = "SecondaryMedicalProfessionalSchool";
            public const string SecondaryDegreeReceived = "SecondaryDegreeReceived";
            public const string SecondaryDateOfGraduation = "SecondaryDateOfGraduation";
            public const string SecondaryMailingAddress = "SecondaryMailingAddress";
            public const string SecondaryCity = "SecondaryCity";
            public const string SecondaryStateCountry = "SecondaryStateCountry";
            public const string SecondaryZip = "SecondaryZip";
            public const string Completed = "Completed";
        }

        public static class AttestationQuestionsColumns
        {
            public const string AttestationQuestionsId = "AttestationQuestionsId";
            public const string QuestionA = "QuestionA";
            public const string QuestionB = "QuestionB";
            public const string QuestionC = "QuestionC";
            public const string QuestionD = "QuestionD";
            public const string QuestionE = "QuestionE";
            public const string QuestionF = "QuestionF";
            public const string QuestionG = "QuestionG";
            public const string QuestionH = "QuestionH";
            public const string QuestionI = "QuestionI";
            public const string QuestionJ = "QuestionJ";
            public const string QuestionK = "QuestionK";
            public const string QuestionL = "QuestionL";
            public const string QuestionM = "QuestionM";
            public const string Completed = "Completed";
        }

        public static class BoardCertificationColumns
        {
            public const string BoardCertificationId = "BoardCertificationId";
            public const string PrimaryNameIssuingBoard = "PrimaryNameIssuingBoard";
            public const string PrimarySpecialty = "PrimarySpecialty";
            public const string PrimaryDateCertifiedRecertified = "PrimaryDateCertifiedRecertified";
            public const string PrimaryExpirationDate = "PrimaryExpirationDate";
            public const string SecondaryNameIssuingBoard = "SecondaryNameIssuingBoard";
            public const string SecondarySpecialty = "SecondarySpecialty";
            public const string SecondaryDateCertifiedRecertified = "SecondaryDateCertifiedRecertified";
            public const string SecondaryExpirationDate = "SecondaryExpirationDate";
            public const string TertiaryNameIssuingBoard = "TertiaryNameIssuingBoard";
            public const string TertiarySpecialty = "TertiarySpecialty";
            public const string TertiaryDateCertifiedRecertified = "TertiaryDateCertifiedRecertified";
            public const string TertiaryExpirationDate = "TertiaryExpirationDate";
            public const string AdditionalBoards = "AdditionalBoards";
            public const string AdditionalListBoardsDates = "AdditionalListBoardsDates";
            public const string Attachment_AttachmentId = "Attachment_AttachmentId";
            public const string Completed = "Completed";
        }

        public static class CurrentHospitalInstitutionalAffiliationsColumns
        {
            public const string CurrentHospitalInstitutionalAffiliationsId = "CurrentHospitalInstitutionalAffiliationsId";
            public const string CurrentPrimaryAdmittingHospital = "CurrentPrimaryAdmittingHospital";
            public const string CurrentPrimaryCity = "CurrentPrimaryCity";
            public const string CurrentPrimaryState = "CurrentPrimaryState";
            public const string CurrentPrimaryZip = "CurrentPrimaryZip";
            public const string CurrentPrimaryDepartmentStatus = "CurrentPrimaryDepartmentStatus";
            public const string CurrentPrimaryAppointmentDate = "CurrentPrimaryAppointmentDate";
            public const string CurrentSecondaryAdmittingHospital = "CurrentSecondaryAdmittingHospital";
            public const string CurrentSecondaryCity = "CurrentSecondaryCity";
            public const string CurrentSecondaryState = "CurrentSecondaryState";
            public const string CurrentSecondaryZip = "CurrentSecondaryZip";
            public const string CurrentSecondaryDepartmentStatus = "CurrentSecondaryDepartmentStatus";
            public const string CurrentSecondaryAppointmentDate = "CurrentSecondaryAppointmentDate";
            public const string CurrentTertiaryAdmittingHospital = "CurrentTertiaryAdmittingHospital";
            public const string CurrentTertiaryCity = "CurrentTertiaryCity";
            public const string CurrentTertiaryState = "CurrentTertiaryState";
            public const string CurrentTertiaryZip = "CurrentTertiaryZip";
            public const string CurrentTertiaryDepartmentStatus = "CurrentTertiaryDepartmentStatus";
            public const string CurrentTertiaryAppointmentDate = "CurrentTertiaryAppointmentDate";
            public const string PreviousPrimaryAdmittingHospital = "PreviousPrimaryAdmittingHospital";
            public const string PreviousPrimaryCity = "PreviousPrimaryCity";
            public const string PreviousPrimaryState = "PreviousPrimaryState";
            public const string PreviousPrimaryZip = "PreviousPrimaryZip";
            public const string PreviousPrimaryDepartmentStatus = "PreviousPrimaryDepartmentStatus";
            public const string PreviousPrimaryAppointmentDate = "PreviousPrimaryAppointmentDate";
            public const string PreviousSecondaryAdmittingHospital = "PreviousSecondaryAdmittingHospital";
            public const string PreviousSecondaryCity = "PreviousSecondaryCity";
            public const string PreviousSecondaryState = "PreviousSecondaryState";
            public const string PreviousSecondaryZip = "PreviousSecondaryZip";
            public const string PreviousSecondaryDepartmentStatus = "PreviousSecondaryDepartmentStatus";
            public const string PreviousSecondaryAppointmentDate = "PreviousSecondaryAppointmentDate";
            public const string PreviousTertiaryAdmittingHospital = "PreviousTertiaryAdmittingHospital";
            public const string PreviousTertiaryCity = "PreviousTertiaryCity";
            public const string PreviousTertiaryState = "PreviousTertiaryState";
            public const string PreviousTertiaryZip = "PreviousTertiaryZip";
            public const string PreviousTertiaryDepartmentStatus = "PreviousTertiaryDepartmentStatus";
            public const string PreviousTertiaryAppointmentDate = "PreviousTertiaryAppointmentDate";
            public const string Completed = "Completed";
        }

        public static class OtherCertificationsColumns
        {
            public const string OtherCertificationsId = "OtherCertificationsId";
            public const string PrimaryType = "PrimaryType";
            public const string PrimaryNumber = "PrimaryNumber";
            public const string PrimaryDate = "PrimaryDate";
            public const string SecondaryType = "SecondaryType";
            public const string SecondaryNumber = "SecondaryNumber";
            public const string SecondaryDate = "SecondaryDate";
            public const string Completed = "Completed";
        }

        public static class OtherStateMedicalProfessionalLicensesColumns
        {
            public const string OtherStateMedicalProfessionalLicensesId = "OtherStateMedicalProfessionalLicensesId";
            public const string PrimaryState = "PrimaryState";
            public const string PrimaryLicenseNumber = "PrimaryLicenseNumber";
            public const string PrimaryExpirationDate = "PrimaryExpirationDate";
            public const string PrimaryLastExpirationDate = "PrimaryLastExpirationDate";
            public const string SecondaryState = "SecondaryState";
            public const string SecondaryLicenseNumber = "SecondaryLicenseNumber";
            public const string SecondaryExpirationDate = "SecondaryExpirationDate";
            public const string SecondaryLastExpirationDate = "SecondaryLastExpirationDate";
            public const string TertiaryState = "TertiaryState";
            public const string TertiaryLicenseNumber = "TertiaryLicenseNumber";
            public const string TertiaryExpirationDate = "TertiaryExpirationDate";
            public const string TertiaryLastExpirationDate = "TertiaryLastExpirationDate";
            public const string Completed = "Completed";
        }

        public static class MedicalProfessionalLicensureRegistrationsColumns
        {
            public const string MedicalProfessionalLicensureRegistrationsId = "MedicalProfessionalLicensureRegistrationsId";
            public const string PrimaryStateMedicalLicenseNumber = "PrimaryStateMedicalLicenseNumber";
            public const string PrimaryStateMedicalLicenseIssueDate = "PrimaryStateMedicalLicenseIssueDate";
            public const string PrimaryStateMedicalLicenseExpirationDate = "PrimaryStateMedicalLicenseExpirationDate";
            public const string DrugAdministrationNumber = "DrugAdministrationNumber";
            public const string DrugAdministrationExpirationDate = "DrugAdministrationExpirationDate";
            public const string StateControlledSubstancesCertificate = "StateControlledSubstancesCertificate";
            public const string StateControlledSubstancesCertificateExpirationDate = "StateControlledSubstancesCertificateExpirationDate";
            public const string ECFMGNumber = "ECFMGNumber";
            public const string ECFMGNumberIssueDate = "ECFMGNumberIssueDate";
            public const string MedicareNationalPhysicianIdentifier = "MedicareNationalPhysicianIdentifier";
            public const string MedicaidNumber = "MedicaidNumber";
            public const string Completed = "Completed";
        }

        public static class MedicalProfessionalEducationsColumns
        {
            public const string MedicalProfessionalEducationId = "MedicalProfessionalEducationId";
            public const string PrimaryMedicalProfessionalSchool = "PrimaryMedicalProfessionalSchool";
            public const string PrimaryDegreeReceived = "PrimaryDegreeReceived";
            public const string PrimaryDateOfGraduation = "PrimaryDateOfGraduation";
            public const string PrimaryMailingAddress = "PrimaryMailingAddress";
            public const string PrimaryCity = "PrimaryCity";
            public const string PrimaryStateCountry = "PrimaryStateCountry";
            public const string PrimaryZip = "PrimaryZip";
            public const string SecondaryMedicalProfessionalSchool = "SecondaryMedicalProfessionalSchool";
            public const string SecondaryDegreeReceived = "SecondaryDegreeReceived";
            public const string SecondaryDateOfGraduation = "SecondaryDateOfGraduation";
            public const string SecondaryMailingAddress = "SecondaryMailingAddress";
            public const string SecondaryCity = "SecondaryCity";
            public const string SecondaryStateCountry = "SecondaryStateCountry";
            public const string SecondaryZip = "SecondaryZip";
            public const string Completed = "Completed";
        }

        public static class InternshipsColumns
        {
            public const string InternshipId = "InternshipId";
            public const string Institution = "Institution";
            public const string ProgramDirector = "ProgramDirector";
            public const string MailingAddress = "MailingAddress";
            public const string City = "City";
            public const string StateCountry = "StateCountry";
            public const string Zip = "Zip";
            public const string TypeOfInternship = "TypeOfInternship";
            public const string Specialty = "Specialty";
            public const string SpecialtyFrom = "SpecialtyFrom";
            public const string SpecialtyTo = "SpecialtyTo";
            public const string Completed = "Completed";
        }

        public static class WorkHistoriesColumns
        {
            public const string WorkHistoryId = "WorkHistoryId";
            public const string PrimaryNamePracticeEmployer = "PrimaryNamePracticeEmployer";
            public const string PrimaryContactName = "PrimaryContactName";
            public const string PrimaryTelephoneNumber = "PrimaryTelephoneNumber";
            public const string PrimaryFaxNumber = "PrimaryFaxNumber";
            public const string PrimaryPracticeAddress = "PrimaryPracticeAddress";
            public const string PrimaryCity = "PrimaryCity";
            public const string PrimaryState = "PrimaryState";
            public const string PrimaryZip = "PrimaryZip";
            public const string PrimaryStartDate = "PrimaryStartDate";
            public const string PrimaryEndDate = "PrimaryEndDate";
            public const string SecondaryNamePracticeEmployer = "SecondaryNamePracticeEmployer";
            public const string SecondaryContactName = "SecondaryContactName";
            public const string SecondaryTelephoneNumber = "SecondaryTelephoneNumber";
            public const string SecondaryFaxNumber = "SecondaryFaxNumber";
            public const string SecondaryPracticeAddress = "SecondaryPracticeAddress";
            public const string SecondaryCity = "SecondaryCity";
            public const string SecondaryState = "SecondaryState";
            public const string SecondaryZip = "SecondaryZip";
            public const string SecondaryStartDate = "SecondaryStartDate";
            public const string SecondaryEndDate = "SecondaryEndDate";
            public const string TertiaryNamePracticeEmployer = "TertiaryNamePracticeEmployer";
            public const string TertiaryContactName = "TertiaryContactName";
            public const string TertiaryTelephoneNumber = "TertiaryTelephoneNumber";
            public const string TertiaryFaxNumber = "TertiaryFaxNumber";
            public const string TertiaryPracticeAddress = "TertiaryPracticeAddress";
            public const string TertiaryCity = "TertiaryCity";
            public const string TertiaryState = "TertiaryState";
            public const string TertiaryZip = "TertiaryZip";
            public const string TertiaryStartDate = "TertiaryStartDate";
            public const string TertiaryEndDate = "TertiaryEndDate";
            public const string Completed = "Completed";
        }

        public static class PeerReferencesColumns
        {
            public const string PeerReferencesId = "PeerReferencesId";
            public const string PrimaryNameReference = "PrimaryNameReference";
            public const string PrimarySpecialty = "PrimarySpecialty";
            public const string PrimaryTelephoneNumber = "PrimaryTelephoneNumber";
            public const string PrimaryMailingAddress = "PrimaryMailingAddress";
            public const string PrimaryCity = "PrimaryCity";
            public const string PrimaryState = "PrimaryState";
            public const string PrimaryZip = "PrimaryZip";
            public const string SecondaryNameReference = "SecondaryNameReference";
            public const string SecondarySpecialty = "SecondarySpecialty";
            public const string SecondaryTelephoneNumber = "SecondaryTelephoneNumber";
            public const string SecondaryMailingAddress = "SecondaryMailingAddress";
            public const string SecondaryCity = "SecondaryCity";
            public const string SecondaryState = "SecondaryState";
            public const string SecondaryZip = "SecondaryZip";
            public const string TertiaryNameReference = "TertiaryNameReference";
            public const string TertiarySpecialty = "TertiarySpecialty";
            public const string TertiaryTelephoneNumber = "TertiaryTelephoneNumber";
            public const string TertiaryMailingAddress = "TertiaryMailingAddress";
            public const string TertiaryCity = "TertiaryCity";
            public const string TertiaryState = "TertiaryState";
            public const string TertiaryZip = "TertiaryZip";
            public const string Completed = "Completed";
        }

        public static class ResidenciesFellowshipsColumns
        {
            public const string ResidenciesFellowshipId = "ResidenciesFellowshipId";
            public const string PrimaryInstitution = "PrimaryInstitution";
            public const string PrimaryProgramDirector = "PrimaryProgramDirector";
            public const string PrimaryMailingAddress = "PrimaryMailingAddress";
            public const string PrimaryCity = "PrimaryCity";
            public const string PrimaryState = "PrimaryState";
            public const string PrimaryZip = "PrimaryZip";
            public const string PrimaryTypeTraining = "PrimaryTypeTraining";
            public const string PrimarySpecialty = "PrimarySpecialty";
            public const string PrimaryFrom = "PrimaryFrom";
            public const string PrimaryTo = "PrimaryTo";
            public const string PrimaryCompleted = "PrimaryCompleted";
            public const string SecondaryInstitution = "SecondaryInstitution";
            public const string SecondaryProgramDirector = "SecondaryProgramDirector";
            public const string SecondaryMailingAddress = "SecondaryMailingAddress";
            public const string SecondaryCity = "SecondaryCity";
            public const string SecondaryState = "SecondaryState";
            public const string SecondaryZip = "SecondaryZip";
            public const string SecondaryTypeTraining = "SecondaryTypeTraining";
            public const string SecondarySpecialty = "SecondarySpecialty";
            public const string SecondaryFrom = "SecondaryFrom";
            public const string SecondaryTo = "SecondaryTo";
            public const string SecondaryCompleted = "SecondaryCompleted";
            public const string TertiaryInstitution = "TertiaryInstitution";
            public const string TertiaryProgramDirector = "TertiaryProgramDirector";
            public const string TertiaryMailingAddress = "TertiaryMailingAddress";
            public const string TertiaryCity = "TertiaryCity";
            public const string TertiaryState = "TertiaryState";
            public const string TertiaryZip = "TertiaryZip";
            public const string TertiaryTypeTraining = "TertiaryTypeTraining";
            public const string TertiarySpecialty = "TertiarySpecialty";
            public const string TertiaryFrom = "TertiaryFrom";
            public const string TertiaryTo = "TertiaryTo";
            public const string TertiaryCompleted = "TertiaryCompleted";
            public const string Completed = "Completed";
        }

        public static class ProfessionalLiabilities
        {
            public const string ProfessionalLiabilityId = "ProfessionalLiabilityId";
            public const string CurrentInsuranceCarrier = "CurrentInsuranceCarrier";
            public const string CurrentPolicyNumber = "CurrentPolicyNumber";
            public const string InitialEffectiverDate = "InitialEffectiverDate";
            public const string CurrentMailingAddress = "CurrentMailingAddress";
            public const string CurrentCity = "CurrentCity";
            public const string CurrentState = "CurrentState";
            public const string CurrentZip = "CurrentZip";
            public const string CurrentPerClaimAmount = "CurrentPerClaimAmount";
            public const string CurrentAggregateAmount = "CurrentAggregateAmount";
            public const string CurrentExpirationDate = "CurrentExpirationDate";
            public const string FirstPolicyCarrierName = "FirstPolicyCarrierName";
            public const string FirstPolicyNumber = "FirstPolicyNumber";
            public const string FirstFromDate = "FirstFromDate";
            public const string FirstToDate = "FirstToDate";
            public const string FirstMailingAddress = "FirstMailingAddress";
            public const string FirstCity = "FirstCity";
            public const string FirstState = "FirstState";
            public const string FirstZip = "FirstZip";
            public const string SecondPolicyCarrierName = "SecondPolicyCarrierName";
            public const string SecondPolicyNumber = "SecondPolicyNumber";
            public const string SecondFromDate = "SecondFromDate";
            public const string SecondToDate = "SecondToDate";
            public const string SecondMailingAddress = "SecondMailingAddress";
            public const string SecondCity = "SecondCity";
            public const string SecondState = "SecondState";
            public const string SecondZip = "SecondZip";
            public const string ThirdPolicyCarrierName = "ThirdPolicyCarrierName";
            public const string ThirdPolicyNumber = "ThirdPolicyNumber";
            public const string ThirdFromDate = "ThirdFromDate";
            public const string ThirdToDate = "ThirdToDate";
            public const string ThirdMailingAddress = "ThirdMailingAddress";
            public const string ThirdCity = "ThirdCity";
            public const string ThirdState = "ThirdState";
            public const string ThirdZip = "ThirdZip";
            public const string FourthPolicyCarrierName = "FourthPolicyCarrierName";
            public const string FourthPolicyNumber = "FourthPolicyNumber";
            public const string FourthFromDate = "FourthFromDate";
            public const string FourthToDate = "FourthToDate";
            public const string FourthMailingAddress = "FourthMailingAddress";
            public const string FourthCity = "FourthCity";
            public const string FourthState = "FourthState";
            public const string FourthZip = "FourthZip";
            public const string Completed = "Completed";
        }
    }
}