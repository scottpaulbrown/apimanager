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
    
    public partial class EntityAttributeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EntityAttributeType()
        {
            this.TemplateEntityAttributes = new HashSet<TemplateEntityAttribute>();
            this.TemplateGroupEntityAttributes = new HashSet<TemplateGroupEntityAttribute>();
        }
    
        public string EntityAttributeTypeCode { get; set; }
        public string EntityAttributeTypeName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemplateEntityAttribute> TemplateEntityAttributes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemplateGroupEntityAttribute> TemplateGroupEntityAttributes { get; set; }
    }
}
