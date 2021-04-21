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
    
    public partial class rfp_event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rfp_event()
        {
            this.rfp_event_invitee = new HashSet<rfp_event_invitee>();
        }
    
        public System.Guid rfe_key { get; set; }
        public Nullable<System.Guid> rfe_rfp_key { get; set; }
        public Nullable<System.Guid> rfe_ct_key { get; set; }
        public Nullable<long> rfe_id { get; set; }
        public string rfe_name { get; set; }
        public string rfe_description { get; set; }
        public Nullable<System.DateTime> rfe_start_date { get; set; }
        public Nullable<System.DateTime> rfe_end_date { get; set; }
        public Nullable<byte> rfe_delete_flag { get; set; }
        public Nullable<System.DateTime> rfe_add_date { get; set; }
        public string rfe_add_user { get; set; }
        public Nullable<System.DateTime> rfe_change_date { get; set; }
        public string rfe_change_user { get; set; }
    
        public virtual co_contact co_contact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rfp_event_invitee> rfp_event_invitee { get; set; }
        public virtual rfp_request rfp_request { get; set; }
    }
}