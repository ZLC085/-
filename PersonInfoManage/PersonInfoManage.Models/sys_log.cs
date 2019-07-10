namespace PersonInfoManage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long timestamp { get; set; }

        [StringLength(255)]
        public string log_message { get; set; }

        [StringLength(255)]
        public string log_name { get; set; }

        [StringLength(255)]
        public string level { get; set; }

        [StringLength(255)]
        public string call_filename { get; set; }

        [StringLength(255)]
        public string call_class { get; set; }

        [StringLength(255)]
        public string call_method { get; set; }

        public long? event_id { get; set; }
    }
}
