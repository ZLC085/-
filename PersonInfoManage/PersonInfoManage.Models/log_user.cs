namespace PersonInfoManage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class log_user
    {
        public int id { get; set; }

        public int user_id { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(10)]
        public string operation { get; set; }

        [Required]
        [StringLength(15)]
        public string ip { get; set; }

        public DateTime create_time { get; set; }

        public virtual sys_user sys_user { get; set; }
    }
}
