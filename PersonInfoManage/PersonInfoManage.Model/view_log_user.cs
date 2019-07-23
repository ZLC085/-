namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class view_log_user
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int user_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string username { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string operation { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(15)]
        public string ip { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime create_time { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Expr2 { get; set; }
    }
}
