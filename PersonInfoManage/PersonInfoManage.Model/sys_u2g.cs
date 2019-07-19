namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_u2g
    {
        public int id { get; set; }

        public int user_id { get; set; }

        public int group_id { get; set; }

        public virtual sys_group sys_group { get; set; }

        public virtual sys_user sys_user { get; set; }
    }
}