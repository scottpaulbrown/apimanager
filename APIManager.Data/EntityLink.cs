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
    
    public partial class EntityLink
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EntityLink()
        {
            this.LinkChanges = new HashSet<LinkChange>();
        }
    
        public int EntityLinkId { get; set; }
        public int PrimaryKeyFieldId { get; set; }
        public int ForeignKeyFieldId { get; set; }
        public string LinkTypeCode { get; set; }
        public string StatusCode { get; set; }
    
        public virtual EntityField PrimaryKeyField { get; set; }
        public virtual EntityField ForeignKeyField { get; set; }
        public virtual LinkType LinkType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LinkChange> LinkChanges { get; set; }
    }
}
