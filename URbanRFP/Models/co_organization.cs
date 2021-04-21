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
    
    public partial class co_organization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public co_organization()
        {
            this.address_x_organization = new HashSet<address_x_organization>();
            this.co_favourite = new HashSet<co_favourite>();
            this.contact_x_organization = new HashSet<contact_x_organization>();
            this.rfp_attachment = new HashSet<rfp_attachment>();
            this.rfp_page = new HashSet<rfp_page>();
            this.rfp_request = new HashSet<rfp_request>();
            this.rfp_response = new HashSet<rfp_response>();
            this.rfp_timeline_org_template = new HashSet<rfp_timeline_org_template>();
            this.rfp_validation_reference = new HashSet<rfp_validation_reference>();
            this.rfp_vendor_allowance = new HashSet<rfp_vendor_allowance>();
        }
    
        public System.Guid org_key { get; set; }
        public Nullable<long> org_id { get; set; }
        public string org_legal_name { get; set; }
        public string org_description { get; set; }
        public string org_specialities { get; set; }
        public Nullable<byte> org_vendor_flag { get; set; }
        public Nullable<System.DateTime> org_date_created { get; set; }
        public string org_timezone { get; set; }
        public string org_entity_type { get; set; }
        public Nullable<byte> org_special_type_flag { get; set; }
        public Nullable<byte> org_qualified_LG_flag { get; set; }
        public string org_federal_tax_id { get; set; }
        public string org_website { get; set; }
        public Nullable<decimal> org_ann_revenue { get; set; }
        public Nullable<int> org_vendor_number_of_employees { get; set; }
        public Nullable<int> org_LG_population_range { get; set; }
        public Nullable<System.DateTime> org_add_date { get; set; }
        public string org_add_user { get; set; }
        public Nullable<System.DateTime> org_change_date { get; set; }
        public string org_change_user { get; set; }
        public Nullable<byte> org_delete_flag { get; set; }
        public string org_domain { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<address_x_organization> address_x_organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_favourite> co_favourite { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contact_x_organization> contact_x_organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rfp_attachment> rfp_attachment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rfp_page> rfp_page { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rfp_request> rfp_request { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rfp_response> rfp_response { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rfp_timeline_org_template> rfp_timeline_org_template { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rfp_validation_reference> rfp_validation_reference { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rfp_vendor_allowance> rfp_vendor_allowance { get; set; }
    }
}