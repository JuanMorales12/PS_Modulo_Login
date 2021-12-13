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
            builder.HasKey(usu => usu.UsuarioId);
            builder.Property(usu => usu.UsuarioId)
                   .ValueGeneratedOnAdd();

            builder.Property(usu => usu.TipoId)
                   .IsRequired(true);
            //.HasMaxLength(1);

            builder.HasOne(_tipo => _tipo.Tipos).WithMany(usu => usu.Usuarios);

            builder.Property(usu => usu.Nombre)
                   .IsRequired(true)
                   .HasMaxLength(50);

            builder.Property(usu => usu.NombreUsuario)
                   .IsRequired(true)
                   .HasMaxLength(30);

            builder.Property(usu => usu.Apellido)
                   .IsRequired(true)
                   .HasMaxLength(50);

            builder.Property(usu => usu.Dni)
                   .IsRequired(true)
                   .HasMaxLength(8);

            builder.Property(usu => usu.Telefono)
                   .IsRequired(true)
                   .HasMaxLength(15);

            builder.Property(usu => usu.Correo)
                   .IsRequired(true)
                   .HasMaxLength(50);

            builder.Property(usu => usu.Contraseña)
                   .IsRequired(true)
                   .HasMaxLength(10);

            builder.Property(usu => usu.Direccion)
                   .IsRequired(true)
                   .HasMaxLength(50);

            builder.HasData(
                       new Usuario
                       {
                           UsuarioId = 1,
                           TipoId = 3, //Paciente
                           Nombre = "Manuel",
                           Apellido = "Corrales",
                           NombreUsuario = "manuel123",
                           Contraseña = "1234",
                           Dni = 12345678,
                           Correo = "manuelcorrales@gmail.com",
                           Direccion = "Calle manuel 123",
                           Telefono = 42202223 //es int - cambiar ??
                       },
                       new Usuario
                       {
                           UsuarioId = 5,
                           TipoId = 3, //Paciente
                           Nombre = "Camilo",
                           Apellido = "Rensi",
                           NombreUsuario = "camilo123",
                           Contraseña ="1234",
                           Dni = 123456700,
                           Correo = "camilorensi@gmail.com",
                           Direccion = "Calle camilo 123",
                           Telefono = 42202000 //es int - cambiar ??
                       },
                       new Usuario
                       {
                           UsuarioId = 10,
                           TipoId = 2, //Medico
                           Nombre = "Juan",
                           Apellido = "Perez",
                           NombreUsuario = "juan123",
                           Contraseña = "1234",
                           Dni = 12340000,
                           Correo = "juanperez@gmail.com",
                           Direccion = "Calle juan 123",
                           Telefono = 42005555 // es int - cambiar ??
                       });
        }
    }
}
