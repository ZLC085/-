namespace PersonInfoManage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_r2m
    {
        public int id { get; set; }

        public int role_id { get; set; }

        public int menu_id { get; set; }

        public virtual sys_menu sys_menu { get; set; }

        public virtual sys_role sys_role { get; set; }
    }
}
