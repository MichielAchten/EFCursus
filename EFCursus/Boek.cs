//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFCursus
{
    using System;
    using System.Collections.Generic;
    
    public partial class Boek
    {
        public Boek()
        {
            this.BoekenCursussen = new HashSet<BoekCursus>();
        }
    
        public int BoekNr { get; set; }
        public string ISBNNr { get; set; }
        public string Titel { get; set; }
    
        public virtual ICollection<BoekCursus> BoekenCursussen { get; set; }
    }
}