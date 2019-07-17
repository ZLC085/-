namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_dict
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string category_name { get; set; }

        public DateTime create_time { get; set; }

        public DateTime modify_time { get; set; }
    }
}
