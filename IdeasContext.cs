namespace CodeFirstIdeasDatabase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class IdeasContext : DbContext
    {
        public IdeasContext()
            : base("name=IdeasContext")
        {
        }

        public virtual DbSet<endorse> endorses { get; set; }
        public virtual DbSet<idea> ideas { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<userkey> userkeys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<endorse>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<idea>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<userkey>()
                .Property(e => e.keyname)
                .IsUnicode(false);
        }
    }
}
