//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcKutuphaneYonetim.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TableHareket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TableHareket()
        {
            this.TableCezalar = new HashSet<TableCezalar>();
        }
    
        public int ID { get; set; }
        public Nullable<int> KITAP { get; set; }
        public Nullable<int> UYE { get; set; }
        public Nullable<int> PERSONEL { get; set; }
        public Nullable<System.DateTime> ALISTARIH { get; set; }
        public Nullable<System.DateTime> IADETARIH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TableCezalar> TableCezalar { get; set; }
        public virtual TableKitap TableKitap { get; set; }
        public virtual TablePersonel TablePersonel { get; set; }
        public virtual TableUyeler TableUyeler { get; set; }
    }
}
