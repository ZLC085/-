namespace PersonInfoManage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_log
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public long? user_id { get; set; }

        [StringLength(255)]
        public string username { get; set; }

        [StringLength(255)]
        public string operation { get; set; }

        [StringLength(12)]
        public string ip { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? create_time { get; set; }

        public virtual sys_user sys_user { get; set; }
    }
}
