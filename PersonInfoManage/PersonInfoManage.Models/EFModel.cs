namespace PersonInfoManage.Models
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

        public virtual DbSet<basic_info> basic_info { get; set; }
        public virtual DbSet<cost_detail> cost_detail { get; set; }
        public virtual DbSet<cost_manage> cost_manage { get; set; }
        public virtual DbSet<cost_planning> cost_planning { get; set; }
        public virtual DbSet<data_dict_name> data_dict_name { get; set; }
        public virtual DbSet<related_files> related_files { get; set; }
        public virtual DbSet<sys_log> sys_log { get; set; }
        public virtual DbSet<sys_menu> sys_menu { get; set; }
        public virtual DbSet<sys_role> sys_role { get; set; }
        public virtual DbSet<sys_role_menu> sys_role_menu { get; set; }
        public virtual DbSet<sys_user> sys_user { get; set; }
        public virtual DbSet<sys_user_role> sys_user_role { get; set; }
        public virtual DbSet<user_log> user_log { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<basic_info>()
                .Property(e => e.birth_date)
                .HasPrecision(0);

            modelBuilder.Entity<cost_manage>()
                .Property(e => e.apply_time)
                .HasPrecision(0);

            modelBuilder.Entity<cost_manage>()
                .Property(e => e.approval_time)
                .HasPrecision(0);

            modelBuilder.Entity<cost_manage>()
                .Property(e => e.apply_money)
                .HasPrecision(10, 0);

            modelBuilder.Entity<cost_manage>()
                .Property(e => e.approval_money)
                .HasPrecision(10, 0);

            modelBuilder.Entity<cost_planning>()
                .Property(e => e.cost)
                .HasPrecision(38, 0);

            modelBuilder.Entity<cost_planning>()
                .Property(e => e.start_date)
                .HasPrecision(0);

            modelBuilder.Entity<cost_planning>()
                .Property(e => e.end_date)
                .HasPrecision(0);

            modelBuilder.Entity<data_dict_name>()
                .Property(e => e.create_time)
                .HasPrecision(0);

            modelBuilder.Entity<data_dict_name>()
                .Property(e => e.modified_time)
                .HasPrecision(0);

            modelBuilder.Entity<related_files>()
                .Property(e => e.create_time)
                .HasPrecision(0);

            modelBuilder.Entity<related_files>()
                .Property(e => e.modified_time)
                .HasPrecision(0);

            modelBuilder.Entity<sys_menu>()
                .Property(e => e.create_time)
                .HasPrecision(0);

            modelBuilder.Entity<sys_menu>()
                .Property(e => e.modified_time)
                .HasPrecision(0);

            modelBuilder.Entity<sys_role>()
                .Property(e => e.create_time)
                .HasPrecision(0);

            modelBuilder.Entity<sys_role>()
                .Property(e => e.modified_time)
                .HasPrecision(0);

            modelBuilder.Entity<sys_user>()
                .Property(e => e.create_time)
                .HasPrecision(0);

            modelBuilder.Entity<sys_user>()
                .Property(e => e.modified_time)
                .HasPrecision(0);

            modelBuilder.Entity<user_log>()
                .Property(e => e.create_time)
                .HasPrecision(0);
        }
    }
}
