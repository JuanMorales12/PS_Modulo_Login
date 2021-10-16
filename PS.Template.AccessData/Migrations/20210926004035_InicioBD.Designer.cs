﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PS.Template.AccessData;

namespace PS.Template.AccessData.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20210926004035_InicioBD")]
    partial class InicioBD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PS.Template.Domain.Entities.Tipo", b =>
                {
                    b.Property<int>("TipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("TipoId");

                    b.ToTable("Tipos");

                    b.HasData(
                        new
                        {
                            TipoId = 1,
                            Descripcion = "Administrador"
                        },
                        new
                        {
                            TipoId = 2,
                            Descripcion = "Medico"
                        },
                        new
                        {
                            TipoId = 3,
                            Descripcion = "Cliente"
                        });
                });

            modelBuilder.Entity("PS.Template.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Contraseña")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Dni")
                        .HasMaxLength(8)
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Telefono")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<int>("TipoId")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId");

                    b.HasIndex("TipoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("PS.Template.Domain.Entities.Usuario", b =>
                {
                    b.HasOne("PS.Template.Domain.Entities.Tipo", "Tipos")
                        .WithMany("Usuarios")
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipos");
                });

            modelBuilder.Entity("PS.Template.Domain.Entities.Tipo", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
