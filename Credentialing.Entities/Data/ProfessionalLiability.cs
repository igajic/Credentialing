using System;

namespace Credentialing.Entities.Data
{
    public class ProfessionalLiability
    {
        public ProfessionalLiability()
        {
        }

        public int ProfessionalLiabilityId { get; set; }

        public string CurrentInsuranceCarrier { get; set; }

        public string CurrentPolicyNumber { get; set; }

        public DateTime InitialEffectiverDate { get; set; }

        public string CurrentMailingAddress { get; set; }

        public string CurrentCity { get; set; }

        public string CurrentState { get; set; }

        public string CurrentZip { get; set; }

        public decimal CurrentPerClaimAmount { get; set; }

        public decimal CurrentAggregateAmount { get; set; }

        public DateTime CurrentExpirationDate { get; set; }

        // Previous liability carriers

        // firstUpda
        public string FirstPolicyCarrierName { get; set; }

        public string FirstPolicyNumber { get; set; }

        public DateTime FirstFromDate { get; set; }

        public DateTime FirstToDate { get; set; }

        public string FirstMailingAddress { get; set; }

        public string FirstCity { get; set; }

        public string FirstState { get; set; }

        public string FirstZip { get; set; }

        // second
        public string SecondPolicyCarrierName { get; set; }

        public string SecondPolicyNumber { get; set; }

        public DateTime SecondFromDate { get; set; }

        public DateTime SecondToDate { get; set; }

        public string SecondMailingAddress { get; set; }

        public string SecondCity { get; set; }

        public string SecondState { get; set; }

        public string SecondZip { get; set; }

        // third
        public string ThirdPolicyCarrierName { get; set; }

        public string ThirdPolicyNumber { get; set; }

        public DateTime ThirdFromDate { get; set; }

        public DateTime ThirdToDate { get; set; }

        public string ThirdMailingAddress { get; set; }

        public string ThirdCity { get; set; }

        public string ThirdState { get; set; }

        public string ThirdZip { get; set; }

        // fourth
        public string FourthPolicyCarrierName { get; set; }

        public string FourthPolicyNumber { get; set; }

        public DateTime FourthFromDate { get; set; }

        public DateTime FourthToDate { get; set; }

        public string FourthMailingAddress { get; set; }

        public string FourthCity { get; set; }

        public string FourthState { get; set; }

        public string FourthZip { get; set; }

        // reference fields
        public virtual Attachment CurrentLiabilityPolicy { get; set; }
    }
}