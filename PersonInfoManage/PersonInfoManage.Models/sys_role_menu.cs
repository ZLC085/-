namespace PersonInfoManage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_role_menu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public long? role_id { get; set; }

        public long? menu_id { get; set; }

        public virtual sys_menu sys_menu { get; set; }

        public virtual sys_role sys_role { get; set; }
    }
}
