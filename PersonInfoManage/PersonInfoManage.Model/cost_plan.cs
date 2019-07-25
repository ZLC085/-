namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class cost_plan
    {
        public int id { get; set; }

        public int cost_type_id { get; set; }

        public decimal money { get; set; }

        public DateTime start_time { get; set; }

        public DateTime end_time { get; set; }
    }
}
