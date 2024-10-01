namespace DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FILO")]
    public partial class FILO
    {
        public long ID { get; set; }

        public long ID_ARACLAR { get; set; }

        public DateTime BASTARIHI { get; set; }

        public DateTime BITTARIHI { get; set; }

        [Required]
        [StringLength(50)]
        public string KONUMBAS { get; set; }

        [Required]
        [StringLength(50)]
        public string KONUMBIT { get; set; }

        public long TCNO_MUSTERILER { get; set; }

        public decimal FIYAT { get; set; }

        public bool AKTIF { get; set; }

        public virtual ARACLAR ARACLAR { get; set; }

        public virtual MUSTERILER MUSTERILER { get; set; }
    }
}
