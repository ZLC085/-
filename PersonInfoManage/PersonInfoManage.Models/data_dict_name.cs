namespace PersonInfoManage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class data_dict_name
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long category_id { get; set; }

        [StringLength(255)]
        public string category_name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? create_time { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? modified_time { get; set; }
    }
}
