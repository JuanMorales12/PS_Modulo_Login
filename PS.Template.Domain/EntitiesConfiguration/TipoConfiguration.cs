using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Template.Domain.Entities;

namespace PS.Template.Domain.EntitiesConfiguration
{
    public class TipoConfiguration : IEntityTypeConfiguration<Tipo>
    {

        public void Configure(EntityTypeBuilder<Tipo> builder)
        {
            builder.HasKey(_tipo => _tipo.TipoId);
            builder.Property(_tipo => _tipo.TipoId)
                   .ValueGeneratedOnAdd();

            builder.Property(_tipo => _tipo.Descripcion)
                  .IsRequired(true)
                  .HasMaxLength(20);

            builder.HasData(
               new Tipo{ TipoId = 1, Descripcion = "Administrador" },
               new Tipo{ TipoId = 2, Descripcion = "Medico" },
               new Tipo{ TipoId = 3, Descripcion = "Cliente" }
                           );

        }

    }
}
