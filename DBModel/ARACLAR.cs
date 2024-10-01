namespace DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ARACLAR")]
    public partial class ARACLAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ARACLAR()
        {
            FILO = new HashSet<FILO>();
        }

        public long ID { get; set; }

        public short KOD_REF_SINIFI { get; set; }

        [Required]
        [StringLength(50)]
        public string MARKA { get; set; }

        [Required]
        [StringLength(50)]
        public string MODEL { get; set; }

        public decimal GUNLUKFIYAT { get; set; }

        public short MODELYILI { get; set; }

        public bool EH_VITESOT { get; set; }

        [StringLength(200)]
        public string ACIKLAMA { get; set; }

        public bool EH_UYGUN { get; set; }

        public bool AKTIF { get; set; }

        public virtual REF_SINIFI REF_SINIFI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FILO> FILO { get; set; }
    }
}
