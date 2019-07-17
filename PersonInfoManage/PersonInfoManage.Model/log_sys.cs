namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class log_sys
    {
        public int id { get; set; }

        public DateTime create_time { get; set; }

        [Required]
        [StringLength(500)]
        public string log_message { get; set; }
    }
}
