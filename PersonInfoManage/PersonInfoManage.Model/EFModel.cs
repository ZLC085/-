namespace PersonInfoManage.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFModel : DbContext
    {
        public EFModel()
            : base("name=EFModel")
        {
        }

        public virtual DbSet<cost_detail> cost_detail { get; set; }
        public virtual DbSet<cost_main> cost_main { get; set; }
        public virtual DbSet<cost_plan> cost_plan { get; set; }
        public virtual DbSet<log_sys> log_sys { get; set; }
        public virtual DbSet<log_user> log_user { get; set; }
        public virtual DbSet<person_basic> person_basic { get; set; }
        public virtual DbSet<person_file> person_file { get; set; }
        public virtual DbSet<sys_dict> sys_dict { get; set; }
        public virtual DbSet<sys_g2m> sys_g2m { get; set; }
        public virtual DbSet<sys_group> sys_group { get; set; }
        public virtual DbSet<sys_menu> sys_menu { get; set; }
        public virtual DbSet<sys_u2g> sys_u2g { get; set; }
        public virtual DbSet<sys_user> sys_user { get; set; }
        public virtual DbSet<business> businesses { get; set; }
        public virtual DbSet<view_cost_main_detail> view_cost_main_detail { get; set; }
        public virtual DbSet<view_log_user> view_log_user { get; set; }
        public virtual DbSet<view_sys_g2m> view_sys_g2m { get; set; }
        public virtual DbSet<view_sys_u2g> view_sys_u2g { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            

        }
    }
}
