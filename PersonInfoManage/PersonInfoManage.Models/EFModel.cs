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

        public virtual DbSet<cost_detail> cost_detail { get; set; }
        public virtual DbSet<cost_main> cost_main { get; set; }
        public virtual DbSet<cost_plan> cost_plan { get; set; }
        public virtual DbSet<log_sys> log_sys { get; set; }
        public virtual DbSet<log_user> log_user { get; set; }
        public virtual DbSet<person_basic> person_basic { get; set; }
        public virtual DbSet<person_file> person_file { get; set; }
        public virtual DbSet<sys_dict> sys_dict { get; set; }
        public virtual DbSet<sys_menu> sys_menu { get; set; }
        public virtual DbSet<sys_r2m> sys_r2m { get; set; }
        public virtual DbSet<sys_role> sys_role { get; set; }
        public virtual DbSet<sys_u2r> sys_u2r { get; set; }
        public virtual DbSet<sys_user> sys_user { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cost_detail>()
                .Property(e => e.cost_type)
                .IsUnicode(false);

            modelBuilder.Entity<cost_main>()
                .HasMany(e => e.cost_detail)
                .WithRequired(e => e.cost_main)
                .HasForeignKey(e => e.cost_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<person_basic>()
                .HasMany(e => e.person_file)
                .WithRequired(e => e.person_basic)
                .HasForeignKey(e => e.person_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<person_file>()
                .Property(e => e.filetype)
                .IsUnicode(false);

            modelBuilder.Entity<sys_dict>()
                .Property(e => e.category_name)
                .IsUnicode(false);

            modelBuilder.Entity<sys_menu>()
                .Property(e => e.menu_name)
                .IsUnicode(false);

            modelBuilder.Entity<sys_menu>()
                .Property(e => e.perms)
                .IsUnicode(false);

            modelBuilder.Entity<sys_menu>()
                .HasMany(e => e.sys_r2m)
                .WithRequired(e => e.sys_menu)
                .HasForeignKey(e => e.menu_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sys_role>()
                .Property(e => e.role_name)
                .IsUnicode(false);

            modelBuilder.Entity<sys_role>()
                .Property(e => e.role_sign)
                .IsUnicode(false);

            modelBuilder.Entity<sys_role>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<sys_role>()
                .HasMany(e => e.sys_r2m)
                .WithRequired(e => e.sys_role)
                .HasForeignKey(e => e.role_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sys_role>()
                .HasMany(e => e.sys_u2r)
                .WithRequired(e => e.sys_role)
                .HasForeignKey(e => e.role_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sys_user>()
                .HasMany(e => e.log_user)
                .WithRequired(e => e.sys_user)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sys_user>()
                .HasMany(e => e.sys_u2r)
                .WithRequired(e => e.sys_user)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);
        }
    }
}
