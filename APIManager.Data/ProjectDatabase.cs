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
    
    public partial class ProjectDatabase
    {
        public int ProjectDatabaeId { get; set; }
        public int ProjectId { get; set; }
        public string EnvironmentTypeCode { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    
        public virtual EnvironmentType EnvironmentType { get; set; }
        public virtual Project Project { get; set; }
    }
}
