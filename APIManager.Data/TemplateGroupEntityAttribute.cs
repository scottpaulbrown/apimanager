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
    
    public partial class TemplateGroupEntityAttribute
    {
        public int TemplateGroupEntityAttributeId { get; set; }
        public string EntityAttributeTypeCode { get; set; }
        public int TemplateGroupId { get; set; }
    
        public virtual EntityAttributeType EntityAttributeType { get; set; }
        public virtual TemplateGroup TemplateGroup { get; set; }
    }
}
