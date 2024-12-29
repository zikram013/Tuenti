using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tuenti.Tuenti.Core.Entities;

namespace Tuenti.Tuenti.Infrastucture.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder) 
        {
            builder.ToTable("Users");

            builder.HasKey(u=>u.Id);

            builder.Property(u=>u.Name).IsRequired().HasMaxLength(50);

            builder.Property(u=>u.LastName).IsRequired().HasMaxLength(50);
            
            builder.Property(u=>u.SecondLastName).IsRequired().HasMaxLength(50);

            builder.Property(u=>u.UserName).IsRequired().HasMaxLength(50);

            builder.Property(u=>u.Email).IsRequired().HasMaxLength(50);

            builder.Property(u => u.PasswordHash).IsRequired();

            builder.Property(u => u.DataJoined).HasDefaultValue("GETDATE()");
            
            builder.Property(u => u.Active).HasDefaultValue(true);
            //Indice
            builder.HasIndex(u=>u.Email);

            // Relación uno-a-muchos con States
            builder.HasMany(u => u.States)
                   .WithOne(s => s.User)
                   .HasForeignKey(s => s.UserId) // Clave foránea
                   .OnDelete(DeleteBehavior.Cascade); // Eliminación en cascada

            builder.HasMany(u => u.Post)
                  .WithOne(s => s.User)
                  .HasForeignKey(s => s.UserId) // Clave foránea
                  .OnDelete(DeleteBehavior.Cascade);
        }
    }
    
}
