namespace telecommunication_company.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sotrudniki")]
    public partial class Sotrudniki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sotrudniki()
        {
            Vipolnenie_zayavki = new HashSet<Vipolnenie_zayavki>();
        }

        [Key]
        public int ID_sotrudnika { get; set; }

        public int? ID_usera { get; set; }

        [Required]
        [StringLength(50)]
        public string Familiya { get; set; }

        [Required]
        [StringLength(50)]
        public string Imya { get; set; }

        [StringLength(50)]
        public string Otchestvo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Data_rojdeniya { get; set; }

        public int ID_doljnosti { get; set; }

        [StringLength(50)]
        public string Adres { get; set; }

        [StringLength(16)]
        public string Nomer_telefona { get; set; }

        [StringLength(50)]
        public string Pochta { get; set; }

        public int? id_pasporta { get; set; }

        public virtual Doljnost Doljnost { get; set; }

        public virtual Pasport Pasport { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vipolnenie_zayavki> Vipolnenie_zayavki { get; set; }
    }
}
