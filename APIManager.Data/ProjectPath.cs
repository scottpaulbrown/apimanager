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
    
    public partial class ProjectPath
    {
        public int ProjectPathId { get; set; }
        public int ProjectId { get; set; }
        public string PathTypeCode { get; set; }
        public string Path { get; set; }
    
        public virtual PathType PathType { get; set; }
        public virtual Project Project { get; set; }
    }
}
