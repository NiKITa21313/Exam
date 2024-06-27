namespace telecommunication_company.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pasport")]
    public partial class Pasport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pasport()
        {
            Sotrudniki = new HashSet<Sotrudniki>();
        }

        [Key]
        public int id_pasporta { get; set; }

        public int? seriya { get; set; }

        public int? nomer { get; set; }

        [StringLength(100)]
        public string Vydan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sotrudniki> Sotrudniki { get; set; }
    }
}
