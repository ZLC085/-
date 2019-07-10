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
            sys_role_menu = new HashSet<sys_role_menu>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long menu_id { get; set; }

        public long? parent_id { get; set; }

        [StringLength(255)]
        public string menu_name { get; set; }

        [StringLength(255)]
        public string perms { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? create_time { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? modified_time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_role_menu> sys_role_menu { get; set; }
    }
}
