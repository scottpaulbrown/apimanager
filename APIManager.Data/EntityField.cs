//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIManager.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class EntityField
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EntityField()
        {
            this.ChildLinks = new HashSet<EntityLink>();
            this.ParentLinks = new HashSet<EntityLink>();
            this.FieldChanges = new HashSet<FieldChange>();
        }
    
        public int EntityFieldId { get; set; }
        public int EntityId { get; set; }
        public string FieldName { get; set; }
        public string Datatype { get; set; }
        public Nullable<int> Scale { get; set; }
        public Nullable<int> MaxLength { get; set; }
        public bool IsRequired { get; set; }
        public bool IsSearchField { get; set; }
        public bool IsContainsSearch { get; set; }
        public bool IsKey { get; set; }
        public bool IsIdentity { get; set; }
        public string StatusCode { get; set; }
        public bool IsDTO { get; set; }
        public string InitialValue { get; set; }
    
        public virtual Entity Entity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntityLink> ChildLinks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntityLink> ParentLinks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FieldChange> FieldChanges { get; set; }
    }
}