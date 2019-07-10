namespace PersonInfoManage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_user_role
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public long? user_id { get; set; }

        public long? role_id { get; set; }

        public virtual sys_role sys_role { get; set; }

        public virtual sys_user sys_user { get; set; }
    }
}
