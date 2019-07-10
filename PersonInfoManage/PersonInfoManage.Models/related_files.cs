namespace PersonInfoManage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class related_files
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long file_id { get; set; }

        public long? person_id { get; set; }

        [StringLength(255)]
        public string filename { get; set; }

        [StringLength(255)]
        public string filepath { get; set; }

        [StringLength(5)]
        public string filetype { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? create_time { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? modified_time { get; set; }

        public virtual basic_info basic_info { get; set; }
    }
}
