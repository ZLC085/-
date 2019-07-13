namespace PersonInfoManage.Models
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
            sys_r2m = new HashSet<sys_r2m>();
        }

        public int id { get; set; }

        public int? parent_id { get; set; }

        [Required]
        [StringLength(10)]
        public string menu_name { get; set; }

        [Required]
        [StringLength(10)]
        public string perms { get; set; }

        public DateTime create_time { get; set; }

        public DateTime modify_time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_r2m> sys_r2m { get; set; }
    }
}
