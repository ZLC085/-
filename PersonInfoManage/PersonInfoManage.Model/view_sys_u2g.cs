namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class view_sys_u2g
    {
        [Key]
        [Column(Order = 0)]
        public DateTime create_time { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string gender { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string job { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime modify_time { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string name { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(32)]
        public string password { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(15)]
        public string phone { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool status { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string username { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int group_id { get; set; }

        [StringLength(100)]
        public string remark { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string group_name { get; set; }

        [StringLength(50)]
        public string org_name { get; set; }
    }
}
