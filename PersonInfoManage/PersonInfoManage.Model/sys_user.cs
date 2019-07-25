namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class sys_user
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(32)]
        public string password { get; set; }

        [Required]
        [StringLength(1)]
        public string gender { get; set; }

        [Required]
        [StringLength(20)]
        public string job { get; set; }

        public int? org_id { get; set; }

        [Required]
        [StringLength(15)]
        public string phone { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public bool status { get; set; }

        public DateTime create_time { get; set; }

        public DateTime modify_time { get; set; }
    }
}
