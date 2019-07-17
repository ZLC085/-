namespace PersonInfoManage.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_g2m
    {
        public int id { get; set; }

        public int group_id { get; set; }

        public int menu_id { get; set; }

        public virtual sys_menu sys_menu { get; set; }

        public virtual sys_group sys_group { get; set; }
    }
}
