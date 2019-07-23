namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class view_sys_g2m
    {
        [Key]
        [Column(Order = 0)]
        public DateTime create_time { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string group_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime modify_time { get; set; }

        [StringLength(100)]
        public string remark { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int menu_id { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string menu_name { get; set; }

        public int? parent_id { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string perms { get; set; }
    }
}
