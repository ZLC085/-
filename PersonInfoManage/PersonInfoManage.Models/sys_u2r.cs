namespace PersonInfoManage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_u2r
    {
        public int id { get; set; }

        public int user_id { get; set; }

        public int role_id { get; set; }

        public virtual sys_role sys_role { get; set; }

        public virtual sys_user sys_user { get; set; }
    }
}
