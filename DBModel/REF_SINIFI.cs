namespace DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class REF_SINIFI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REF_SINIFI()
        {
            ARACLAR = new HashSet<ARACLAR>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short KOD { get; set; }

        [Required]
        [StringLength(50)]
        public string ARACSINIFI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARACLAR> ARACLAR { get; set; }
    }
}
