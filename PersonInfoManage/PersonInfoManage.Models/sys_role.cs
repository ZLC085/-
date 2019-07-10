namespace PersonInfoManage.Models
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
            sys_role_menu = new HashSet<sys_role_menu>();
            sys_user_role = new HashSet<sys_user_role>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long role_id { get; set; }

        [StringLength(255)]
        public string role_name { get; set; }

        [StringLength(255)]
        public string role_sign { get; set; }

        [StringLength(255)]
        public string remark { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? create_time { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? modified_time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_role_menu> sys_role_menu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_user_role> sys_user_role { get; set; }
    }
}
