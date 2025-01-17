namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class bns_person
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string former_name { get; set; }

        [Required]
        [StringLength(1)]
        public string gender { get; set; }

        [Required]
        [StringLength(10)]
        public string nation { get; set; }

        public int user_id { get; set; }

        [Required]
        [StringLength(18)]
        public string identity_number { get; set; }

        public DateTime birth_date { get; set; }

        [Required]
        [StringLength(50)]
        public string native_place { get; set; }

        public bool marry_status { get; set; }

        [StringLength(50)]
        public string job_status { get; set; }

        public decimal? income { get; set; }

        [StringLength(100)]
        public string temper { get; set; }

        [StringLength(100)]
        public string family { get; set; }

        public int person_type_id { get; set; }

        [StringLength(20)]
        public string qq { get; set; }

        [Required]
        [StringLength(50)]
        public string address { get; set; }

        [Required]
        [StringLength(15)]
        public string phone { get; set; }

        public int belong_place_id { get; set; }

        public DateTime input_time { get; set; }

        public int isdel { get; set; }
    }
}
