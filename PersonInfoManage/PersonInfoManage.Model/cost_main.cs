namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class cost_main
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int apply_id { get; set; }

        public decimal apply_money { get; set; }

        public byte status { get; set; }

        

        [StringLength(200)]
        public string remark { get; set; }
        public DateTime apply_time { get; set; }
    }
}
