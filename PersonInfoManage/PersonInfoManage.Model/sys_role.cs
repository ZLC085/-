namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_role
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sys_role()
        {
            sys_r2m = new HashSet<sys_r2m>();
            sys_u2r = new HashSet<sys_u2r>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string role_name { get; set; }

        [Required]
        [StringLength(10)]
        public string role_sign { get; set; }

        [StringLength(100)]
        public string remark { get; set; }

        public DateTime create_time { get; set; }

        public DateTime modify_time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_r2m> sys_r2m { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_u2r> sys_u2r { get; set; }
    }
}
