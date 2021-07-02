using Microsoft.EntityFrameworkCore;
using Practice.Architecture.Models.Entities;

namespace Practice.Architecture.Persistence.Context
{
    public partial class PracticeContext : DbContext
    {
        public PracticeContext()
        {

        }

        public PracticeContext(DbContextOptions<PracticeContext> options) : base(options)
        {

        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                .HasColumnType("int")
                .IsRequired()
                .UseIdentityColumn(1, 1);

                entity.Property(e => e.Name)
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(50);

                entity.Property(e => e.LastName)
                .HasColumnType("varchar")
                .IsRequired()
                .HasMaxLength(50);

                entity.Property(e => e.Tel)
                .HasColumnType("varchar")
                .HasMaxLength(10);
                
                entity.Property(e => e.Email)
                .HasColumnType("varchar")
                .HasMaxLength(40);
                
                entity.Property(e => e.Adress)
                .HasColumnType("varchar")
                .HasMaxLength(50);

                entity.Property(e => e.BirthDate)
                .HasColumnType("date")
                .HasMaxLength(50);

            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                .IsRequired()
                .HasColumnType("int")
                .UseIdentityColumn(1, 1);

                entity.Property(e => e.Rol)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

                entity.Property(e => e.Salary)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("varchar");
                
                entity.Property(e => e.IdUser)
                .IsRequired()
                .HasColumnType("int");

                entity.HasOne(e => e.User)
                .WithMany(u => u.Employes)
                .HasForeignKey(e => e.IdUser);

            });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
