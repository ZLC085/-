namespace PersonInfoManage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cost_manage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cost_manage()
        {
            cost_detail = new HashSet<cost_detail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long cost_id { get; set; }

        [StringLength(255)]
        public string applicant { get; set; }

        [StringLength(255)]
        public string approver { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? apply_time { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? approval_time { get; set; }

        public decimal? apply_money { get; set; }

        public decimal? approval_money { get; set; }

        public byte? status { get; set; }

        [StringLength(255)]
        public string remark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cost_detail> cost_detail { get; set; }
    }
}
