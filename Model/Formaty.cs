//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiecKin.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Format
    {
        public Format()
        {
            this.Seanse = new HashSet<Seans>();
        }
    
        public int id_formatu { get; set; }
        public string format { get; set; }
        public string wersja_jezykowa { get; set; }
    
        public virtual ICollection<Seans> Seanse { get; set; }
    }
}
