namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class View_CostMainDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string applicant { get; set; }

        [StringLength(50)]
        public string approver { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime apply_time { get; set; }

        public DateTime? approval_time { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal apply_money { get; set; }

        public decimal? approval_money { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte status { get; set; }

        [StringLength(200)]
        public string remark { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string cost_type { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal money { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int detailId { get; set; }
    }
}
