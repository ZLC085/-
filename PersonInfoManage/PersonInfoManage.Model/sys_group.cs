namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sys_group()
        {
            sys_g2m = new HashSet<sys_g2m>();
            sys_u2g = new HashSet<sys_u2g>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string group_name { get; set; }

        [StringLength(100)]
        public string remark { get; set; }

        public DateTime create_time { get; set; }

        public DateTime modify_time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_g2m> sys_g2m { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_u2g> sys_u2g { get; set; }
    }
}
