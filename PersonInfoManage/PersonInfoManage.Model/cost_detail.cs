namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class cost_detail
    {
        public int id { get; set; }

        public int cost_id { get; set; }

        public int cost_type { get; set; }

        [Required]
        [StringLength(50)]
        public string cost_type_name { get; set; }

        public decimal money { get; set; }
    }
}
