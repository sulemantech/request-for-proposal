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
    
    public partial class rfp_request
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rfp_request()
        {
            this.co_favourite = new HashSet<co_favourite>();
            this.co_page_view = new HashSet<co_page_view>();
            this.contact_x_RACI = new HashSet<contact_x_RACI>();
            this.contact_x_request = new HashSet<contact_x_request>();
            this.product_x_request = new HashSet<product_x_request>();
            this.rfp_attachment = new HashSet<rfp_attachment>();
            this.rfp_event = new HashSet<rfp_event>();
            this.rfp_page = new HashSet<rfp_page>();
            this.rfp_respond_invitation = new HashSet<rfp_respond_invitation>();
            this.rfp_response = new HashSet<rfp_response>();
            this.rfp_score_rules = new HashSet<rfp_score_rules>();
            this.rfp_task = new HashSet<rfp_task>();
            this.rfp_validation_reference = new HashSet<rfp_validation_reference>();
            this.score_x_request = new HashSet<score_x_request>();
        }
    
        public System.Guid rfp_key { get; set; }
        public Nullable<System.Guid> rfp_org_key { get; set; }
        public Nullable<System.Guid> rfp_prd_key { get; set; }
        public Nullable<long> rfp_id { get; set; }
        public string rfp_name { get; set; }
        public string rfp_summary { get; set; }
        public string rfp_background { get; set; }
        public string rfp_bid_number_in_LG { get; set; }
        public Nullable<System.DateTime> rfp_pre_proposal_meeting_date { get; set; }
        public string rfp_pre_proposal_meeting_location { get; set; }
        public string rfp_submission_instructions { get; set; }
        public Nullable<int> rfp_type { get; set; }
        public Nullable<int> rfp_subtype { get; set; }
        public string rfp_solo_multiple_sources { get; set; }
        public Nullable<System.DateTime> rfp_issue_date { get; set; }
        public Nullable<System.DateTime> rfp_question_deadline { get; set; }
        public Nullable<System.DateTime> rfp_question_answer_deadline { get; set; }
        public Nullable<System.DateTime> rfp_vendor_meeting_date { get; set; }
        public Nullable<System.DateTime> rfp_close_date { get; set; }
        public Nullable<System.DateTime> rfp_scoring_date { get; set; }
        public Nullable<System.DateTime> rfp_vendor_post_submission_meeting_date { get; set; }
        public Nullable<System.DateTime> rfp_decision_date { get; set; }
        public Nullable<System.DateTime> rfp_award_date { get; set; }
        public Nullable<System.DateTime> rfp_validation_date { get; set; }
        public string rfp_scope_of_work { get; set; }
        public string rfp_sow_introduction { get; set; }
        public string rfp_sow_solution_requirements { get; set; }
        public string rfp_sow_project_timeline { get; set; }
        public string rfp_sow_cost { get; set; }
        public string rfp_skills { get; set; }
        public Nullable<decimal> rfp_budget { get; set; }
        public Nullable<decimal> rfp_awarded { get; set; }
        public string rfp_department { get; set; }
        public Nullable<decimal> rfp_view_count { get; set; }
        public Nullable<byte> rfp_delete_flag { get; set; }
        public Nullable<System.DateTime> rfp_add_date { get; set; }
        public string rfp_add_user { get; set; }
        public Nullable<System.DateTime> rfp_change_date { get; set; }
        public string rfp_change_user { get; set; }
        public string rfp_questionnaire { get; set; }
        public string rfp_evaluation_process { get; set; }
        public string rfp_evaluation_criteria { get; set; }
        public string rfp_terms_conditions { get; set; }
        public string rfp_date_notes { get; set; }
        public Nullable<bool> rfp_published { get; set; }
        public Nullable<bool> scoring_completed { get; set; }
        public byte rfp_progress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_favourite> co_favourite { get; set; }
        public virtual co_organization co_organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_page_view> co_page_view { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contact_x_RACI> contact_x_RACI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contact_x_request> contact_x_request { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product_x_request> product_x_request { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rfp_attachment> rfp_attachment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rfp_event> rfp_event { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rfp_page> rfp_page { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rfp_respond_invitation> rfp_respond_invitation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rfp_response> rfp_response { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rfp_score_rules> rfp_score_rules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rfp_task> rfp_task { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rfp_validation_reference> rfp_validation_reference { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<score_x_request> score_x_request { get; set; }
    }
}