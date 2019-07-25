namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class bns_event
    {
        public int id { get; set; }

        public int? t2p_id { get; set; }

        [Column("event")]
        [StringLength(50)]
        public string _event { get; set; }

        [StringLength(50)]
        public string location { get; set; }

        public DateTime? time { get; set; }

        [StringLength(200)]
        public string remark { get; set; }
    }
}
