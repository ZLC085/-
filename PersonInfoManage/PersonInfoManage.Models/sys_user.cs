namespace PersonInfoManage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sys_user()
        {
            sys_user_role = new HashSet<sys_user_role>();
            user_log = new HashSet<user_log>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long user_id { get; set; }

        [StringLength(255)]
        public string username { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [StringLength(5)]
        public string gender { get; set; }

        [StringLength(255)]
        public string job { get; set; }

        [StringLength(10)]
        public string phone { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        public byte? status { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? create_time { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? modified_time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_user_role> sys_user_role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_log> user_log { get; set; }
    }
}
