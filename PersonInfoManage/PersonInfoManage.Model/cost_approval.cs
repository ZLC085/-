namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class cost_approval
    {
       

        public bool? result { get; set; }

        public DateTime? time { get; set; }

        [StringLength(200)]
        public string opinion { get; set; }
        public int id { get; set; }

        public int cost_id { get; set; }

        public int approval_id { get; set; }
    }
}
