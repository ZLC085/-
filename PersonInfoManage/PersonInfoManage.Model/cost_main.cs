namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cost_main
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cost_main()
        {
            cost_detail = new HashSet<cost_detail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string applicant { get; set; }

        [StringLength(50)]
        public string approver { get; set; }

        public DateTime apply_time { get; set; }

        public DateTime? approval_time { get; set; }

        public decimal apply_money { get; set; }

        public decimal? approval_money { get; set; }

        public byte status { get; set; }

        [StringLength(200)]
        public string remark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cost_detail> cost_detail { get; set; }
    }
}
