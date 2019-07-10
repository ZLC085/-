namespace PersonInfoManage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class basic_info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public basic_info()
        {
            related_files = new HashSet<related_files>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long person_id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string former_name { get; set; }

        [Required]
        [StringLength(1)]
        public string gender { get; set; }

        [Required]
        [StringLength(18)]
        public string identity_number { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime birth_date { get; set; }

        [Required]
        [StringLength(255)]
        public string birth_place { get; set; }

        [Required]
        [StringLength(5)]
        public string marry_status { get; set; }

        [Required]
        [StringLength(255)]
        public string job_status { get; set; }

        public long income { get; set; }

        [Required]
        [StringLength(255)]
        public string temper { get; set; }

        [Required]
        [StringLength(255)]
        public string family { get; set; }

        [Required]
        [StringLength(255)]
        public string type { get; set; }

        [Required]
        [StringLength(255)]
        public string qq { get; set; }

        [Required]
        [StringLength(255)]
        public string address { get; set; }

        [Required]
        [StringLength(255)]
        public string phone { get; set; }

        [Required]
        [StringLength(255)]
        public string belong_place { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<related_files> related_files { get; set; }
    }
}
