namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class person_basic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public person_basic()
        {
            person_file = new HashSet<person_file>();
        }

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
        [StringLength(18)]
        public string identity_number { get; set; }

        public DateTime birth_date { get; set; }

        [Required]
        [StringLength(10)]
        public string city { get; set; }

        [Required]
        [StringLength(10)]
        public string province { get; set; }

        public bool marry_status { get; set; }

        [StringLength(50)]
        public string job_status { get; set; }

        public decimal? income { get; set; }

        [StringLength(100)]
        public string temper { get; set; }

        [StringLength(100)]
        public string family { get; set; }

        [Required]
        [StringLength(20)]
        public string person_type { get; set; }

        [StringLength(20)]
        public string qq { get; set; }

        [Required]
        [StringLength(50)]
        public string address { get; set; }

        [Required]
        [StringLength(15)]
        public string phone { get; set; }

        [Required]
        [StringLength(50)]
        public string belong_place { get; set; }

        [Required]
        [StringLength(10)]
        public string nation { get; set; }

        public DateTime input_time { get; set; }

        [Required]
        [StringLength(50)]
        public string input_person { get; set; }

        public int isdel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<person_file> person_file { get; set; }
    }
}
