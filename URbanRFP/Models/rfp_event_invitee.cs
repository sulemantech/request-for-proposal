//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ICMA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class rfp_event_invitee
    {
        public System.Guid int_key { get; set; }
        public Nullable<System.Guid> int_rfe_key { get; set; }
        public Nullable<System.Guid> int_ct_key { get; set; }
    
        public virtual co_contact co_contact { get; set; }
        public virtual rfp_event rfp_event { get; set; }
    }
}
