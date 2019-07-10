namespace PersonInfoManage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cost_detail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public long? cost_id { get; set; }

        [StringLength(255)]
        public string type { get; set; }

        [StringLength(255)]
        public string money { get; set; }

        public virtual cost_manage cost_manage { get; set; }
    }
}
