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
    
    public partial class product_x_request
    {
        public System.Guid pxp_key { get; set; }
        public Nullable<System.Guid> pxp_rfp_key { get; set; }
        public Nullable<System.Guid> pxp_prd_key { get; set; }
        public Nullable<byte> pxp_delete_flag { get; set; }
        public Nullable<System.DateTime> pxp_add_date { get; set; }
        public string pxp_add_user { get; set; }
        public Nullable<System.DateTime> pxp_change_date { get; set; }
        public string pxp_change_user { get; set; }
    
        public virtual rfp_product rfp_product { get; set; }
        public virtual rfp_request rfp_request { get; set; }
    }
}