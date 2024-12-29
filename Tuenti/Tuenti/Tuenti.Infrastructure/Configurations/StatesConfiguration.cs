using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuenti.Tuenti.Core.Entities;

namespace Tuenti.Infrastucture.Configurations
{
    public class StatesConfiguration : IEntityTypeConfiguration<States>
    {
        public void Configure(EntityTypeBuilder<States> builder)
        {
            // Nombre de la tabla
            builder.ToTable("States");

            // Clave primaria
            builder.HasKey(s => s.Id);

            // Configuración de propiedades
            builder.Property(s => s.Content)
                   .IsRequired() // Obligatorio
                   .HasMaxLength(500); // Longitud máxima de 500 caracteres (puedes ajustar según necesidad)

            // Relación con User (muchos a uno)
            builder.HasOne(s => s.User)
                   .WithMany(u => u.States) // Asume que User tiene ICollection<States>
                   .HasForeignKey(u=>u.UserId) // Nombre de la clave foránea
                   .OnDelete(DeleteBehavior.Cascade); // Eliminación en cascada
        }
    }
}
