namespace DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MUSTERILER")]
    public partial class MUSTERILER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MUSTERILER()
        {
            FILO = new HashSet<FILO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TCNO { get; set; }

        [Required]
        [StringLength(50)]
        public string AD { get; set; }

        [Required]
        [StringLength(50)]
        public string SOYAD { get; set; }

        [Required]
        [StringLength(50)]
        public string EPOSTA { get; set; }

        public short YAS { get; set; }

        public bool AKTIF { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FILO> FILO { get; set; }
    }
}
