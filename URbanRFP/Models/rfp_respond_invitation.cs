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
    
    public partial class rfp_respond_invitation
    {
        public System.Guid inv_key { get; set; }
        public Nullable<System.Guid> inv_rfp_key { get; set; }
        public Nullable<System.Guid> inv_ct_key { get; set; }
        public string inv_first_name { get; set; }
        public string inv_last_name { get; set; }
        public string inv_full_name { get; set; }
        public string inv_email { get; set; }
        public string inv_status { get; set; }
        public Nullable<byte> inv_delete_flag { get; set; }
        public Nullable<System.DateTime> inv_add_date { get; set; }
        public string inv_add_user { get; set; }
        public Nullable<System.DateTime> inv_change_date { get; set; }
        public string inv_change_user { get; set; }
    
        public virtual co_contact co_contact { get; set; }
        public virtual rfp_request rfp_request { get; set; }
    }
}