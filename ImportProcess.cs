//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestService
{
    using System;
    using System.Collections.Generic;
    
    public partial class ImportProcess
    {
        public System.Guid ProcessId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.Guid> OperatorId { get; set; }
        public Nullable<System.Guid> OperatotLocationId { get; set; }
        public Nullable<int> FileId { get; set; }
        public string FilePath { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<System.DateTime> DateProcessed { get; set; }
        public string ErrorDescription { get; set; }
    
        public virtual ImportFileName ImportFileName { get; set; }
        public virtual Operator Operator { get; set; }
        public virtual Operators_Locations Operators_Locations { get; set; }
        public virtual ImportStatu ImportStatu { get; set; }
    }
}