//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Turnir
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rasporedi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rasporedi()
        {
            this.Rezultati = new HashSet<Rezultati>();
        }
    
        public int Id { get; set; }
        public Nullable<int> EkipeIdDomacin { get; set; }
        public Nullable<int> EkipeIdGost { get; set; }
        public string Vrijeme { get; set; }
        public Nullable<int> GoloviDomacin { get; set; }
        public Nullable<int> GoloviGost { get; set; }
        public Nullable<int> GrupeId { get; set; }
        public string Odigrano { get; set; }
        public Nullable<int> ažurirano { get; set; }
    
        public virtual Ekipe Ekipe { get; set; }
        public virtual Ekipe Ekipe1 { get; set; }
        public virtual Grupe Grupe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezultati> Rezultati { get; set; }
    }
}
