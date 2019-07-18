namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("business")]
    public partial class business
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int person_id { get; set; }

        [Column("event")]
        [StringLength(50)]
        public string _event { get; set; }

        [StringLength(50)]
        public string location { get; set; }

        public DateTime? time { get; set; }

        [StringLength(200)]
        public string remark { get; set; }

        public virtual person_basic person_basic { get; set; }
    }
}
