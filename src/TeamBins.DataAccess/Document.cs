//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeamBins.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Document
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public string FileAlias { get; set; }
        public int ParentID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedByID { get; set; }
    
        public virtual Issue Issue { get; set; }
        public virtual User Author { get; set; }
    }
}
