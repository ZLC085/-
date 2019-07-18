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
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<business> businesses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<person_basic>()
                .HasMany(e => e.businesses)
                .WithRequired(e => e.person_basic)
                .HasForeignKey(e => e.person_id)
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

            modelBuilder.Entity<sys_group>()
                .Property(e => e.group_name)
                .IsUnicode(false);

            modelBuilder.Entity<sys_group>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<sys_group>()
                .HasMany(e => e.sys_g2m)
                .WithRequired(e => e.sys_group)
                .HasForeignKey(e => e.group_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sys_group>()
                .HasMany(e => e.sys_u2g)
                .WithRequired(e => e.sys_group)
                .HasForeignKey(e => e.group_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sys_menu>()
                .Property(e => e.menu_name)
                .IsUnicode(false);

            modelBuilder.Entity<sys_menu>()
                .Property(e => e.perms)
                .IsUnicode(false);

            modelBuilder.Entity<sys_menu>()
                .HasMany(e => e.sys_g2m)
                .WithRequired(e => e.sys_menu)
                .HasForeignKey(e => e.menu_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sys_user>()
                .HasMany(e => e.log_user)
                .WithRequired(e => e.sys_user)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sys_user>()
                .HasMany(e => e.sys_u2g)
                .WithRequired(e => e.sys_user)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<business>()
                .Property(e => e._event)
                .IsUnicode(false);

            modelBuilder.Entity<business>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<business>()
                .Property(e => e.remark)
                .IsUnicode(false);
        }
    }
}
