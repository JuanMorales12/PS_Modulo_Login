using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Template.AccessData.Migrations
{
    public partial class Migration001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    TipoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.TipoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Dni = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<int>(type: "int", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuarios_Tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos",
                        principalColumn: "TipoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "TipoId", "Descripcion" },
                values: new object[] { 1, "Administrador" });

            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "TipoId", "Descripcion" },
                values: new object[] { 2, "Medico" });

            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "TipoId", "Descripcion" },
                values: new object[] { 3, "Cliente" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Apellido", "Contraseña", "Correo", "Direccion", "Dni", "Nombre", "NombreUsuario", "Telefono", "TipoId" },
                values: new object[] { 10, "Perez", "1234", "juanperez@gmail.com", "Calle juan 123", 12340000, "Juan", "juan123", 42005555, 2 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Apellido", "Contraseña", "Correo", "Direccion", "Dni", "Nombre", "NombreUsuario", "Telefono", "TipoId" },
                values: new object[] { 1, "Corrales", "1234", "manuelcorrales@gmail.com", "Calle manuel 123", 12345678, "Manuel", "manuel123", 42202223, 3 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Apellido", "Contraseña", "Correo", "Direccion", "Dni", "Nombre", "NombreUsuario", "Telefono", "TipoId" },
                values: new object[] { 5, "Rensi", "1234", "camilorensi@gmail.com", "Calle camilo 123", 123456700, "Camilo", "camilo123", 42202000, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipoId",
                table: "Usuarios",
                column: "TipoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Tipos");
        }
    }
}
