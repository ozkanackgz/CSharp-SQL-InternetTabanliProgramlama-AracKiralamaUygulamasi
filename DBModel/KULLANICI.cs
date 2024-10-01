namespace DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KULLANICI")]
    public partial class KULLANICI
    {
        public long ID { get; set; }

        [Required]
        [StringLength(20)]
        public string KULLANICIADI { get; set; }

        [Required]
        [StringLength(20)]
        public string SIFRE { get; set; }

        [Required]
        [StringLength(50)]
        public string ADSOYAD { get; set; }

        [Required]
        [StringLength(50)]
        public string EPOSTA { get; set; }
    }
}
