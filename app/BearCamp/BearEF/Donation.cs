//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace BearEF
{
    public partial class Donation
    {
        public int DonationsID { get; set; }
        public int DonorID { get; set; }
        public decimal DonationAmount { get; set; }
        public System.DateTime DonataionDate { get; set; }
        public string Comments { get; set; }
        public int DonationType { get; set; }
    
        public virtual DonationTypeID DonationTypeID { get; set; }
        public virtual Donor Donor { get; set; }
    }
    
}