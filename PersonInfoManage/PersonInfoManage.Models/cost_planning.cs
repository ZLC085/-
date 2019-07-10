namespace PersonInfoManage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cost_planning
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long cost_id { get; set; }

        [StringLength(255)]
        public string cost_type { get; set; }

        public decimal? cost { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_date { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? end_date { get; set; }
    }
}
