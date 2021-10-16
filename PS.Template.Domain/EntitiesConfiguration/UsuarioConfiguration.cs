using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Template.Domain.Entities;


namespace PS.Template.Domain.EntitiesConfiguration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(usu=> usu.UsuarioId);
            builder.Property(usu=> usu.UsuarioId)
                   .ValueGeneratedOnAdd();

            builder.Property(usu => usu.TipoId)
                   .IsRequired(true);
                   //.HasMaxLength(1);

            builder.HasOne(_tipo => _tipo.Tipos).WithMany(usu => usu.Usuarios);

            builder.Property(usu=> usu.Nombre)
                   .IsRequired(true)
                   .HasMaxLength(50);

            builder.Property(usu => usu.NombreUsuario)
                   .IsRequired(true)
                   .HasMaxLength(30);

            builder.Property(usu=> usu.Apellido)
                   .IsRequired(true)
                   .HasMaxLength(50);

            builder.Property(usu=> usu.Dni)
                   .IsRequired(true)
                   .HasMaxLength(8);

            builder.Property(usu => usu.Telefono)
                   .IsRequired(true)
                   .HasMaxLength(15);

            builder.Property(usu=> usu.Correo)
                   .IsRequired(true)
                   .HasMaxLength(50);

            builder.Property(usu=> usu.Contraseña)
                   .IsRequired(true)
                   .HasMaxLength(10);
        }
    }
}
