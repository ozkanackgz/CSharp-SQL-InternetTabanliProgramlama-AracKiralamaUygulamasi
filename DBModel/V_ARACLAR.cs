namespace DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_ARACLAR
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short KOD_REF_SINIFI { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ARACSINIFI { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string MARKA { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string MODEL { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal GUNLUKFIYAT { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MODELYILI { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool EH_VITESOT { get; set; }

        [StringLength(200)]
        public string ACIKLAMA { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool EH_UYGUN { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(8)]
        public string VITES_ACIKLAMA { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(16)]
        public string UYGUN_ACIKLAMA { get; set; }
    }
}
