namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sys_menu()
        {
            sys_g2m = new HashSet<sys_g2m>();
        }

        public int id { get; set; }

        public int? parent_id { get; set; }

        [Required]
        [StringLength(50)]
        public string menu_name { get; set; }

        [Required]
        [StringLength(50)]
        public string perms { get; set; }

        public DateTime create_time { get; set; }

        public DateTime modify_time { get; set; }
    }
}
