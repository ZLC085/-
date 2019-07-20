namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class person_file
    {
        public int id { get; set; }

        public int person_id { get; set; }

        [Required]
        [StringLength(100)]
        public string filename { get; set; }

        [Required]
        public byte[] file { get; set; }

        [Required]
        [StringLength(50)]
        public string filetype { get; set; }

        public DateTime create_time { get; set; }

        public DateTime modify_time { get; set; }

        public virtual person_basic person_basic { get; set; }
    }
}
