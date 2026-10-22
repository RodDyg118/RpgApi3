using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "TB_PERSONAGENS",
                newName: "usuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PERSONAGENS_UsuarioId",
                table: "TB_PERSONAGENS",
                newName: "IX_TB_PERSONAGENS_usuarioId");

            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "UsuarioId", "Vitorias", "usuarioId" },
                values: new object[] { 0, 0, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "UsuarioId", "Vitorias", "usuarioId" },
                values: new object[] { 0, 0, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "UsuarioId", "Vitorias", "usuarioId" },
                values: new object[] { 0, 0, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "UsuarioId", "Vitorias", "usuarioId" },
                values: new object[] { 0, 0, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "UsuarioId", "Vitorias", "usuarioId" },
                values: new object[] { 0, 0, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "UsuarioId", "Vitorias", "usuarioId" },
                values: new object[] { 0, 0, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "UsuarioId", "Vitorias", "usuarioId" },
                values: new object[] { 0, 0, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 131, 6, 209, 39, 19, 227, 202, 53, 34, 225, 113, 189, 180, 210, 240, 238, 11, 7, 114, 117, 246, 120, 52, 22, 8, 72, 1, 197, 206, 44, 43, 16, 73, 219, 242, 170, 55, 138, 227, 48, 44, 254, 13, 218, 193, 182, 43, 98, 26, 55, 193, 181, 118, 220, 157, 187, 201, 221, 2, 233, 151, 104, 114, 202 }, new byte[] { 109, 151, 174, 228, 74, 96, 103, 3, 175, 203, 179, 248, 70, 56, 160, 156, 100, 223, 43, 141, 219, 220, 214, 203, 89, 73, 127, 33, 80, 190, 118, 126, 43, 135, 242, 112, 82, 7, 161, 85, 214, 247, 131, 189, 148, 164, 162, 20, 64, 19, 247, 101, 69, 211, 199, 146, 129, 239, 187, 37, 142, 143, 42, 128, 49, 44, 105, 36, 56, 107, 107, 227, 64, 199, 202, 140, 98, 178, 215, 47, 157, 147, 79, 42, 12, 213, 154, 170, 53, 79, 157, 71, 207, 205, 168, 137, 23, 118, 109, 178, 210, 76, 58, 234, 224, 129, 221, 142, 133, 115, 237, 57, 167, 5, 247, 223, 230, 185, 77, 140, 244, 94, 108, 100, 17, 222, 52, 127 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_UsuarioId",
                table: "TB_PERSONAGENS",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId",
                table: "TB_PERSONAGENS",
                column: "UsuarioId",
                principalTable: "TB_USUARIOS",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIOS_usuarioId",
                table: "TB_PERSONAGENS",
                column: "usuarioId",
                principalTable: "TB_USUARIOS",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIOS_usuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropIndex(
                name: "IX_TB_PERSONAGENS_UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.RenameColumn(
                name: "usuarioId",
                table: "TB_PERSONAGENS",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PERSONAGENS_usuarioId",
                table: "TB_PERSONAGENS",
                newName: "IX_TB_PERSONAGENS_UsuarioId");

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                column: "UsuarioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                column: "UsuarioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                column: "UsuarioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                column: "UsuarioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                column: "UsuarioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                column: "UsuarioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                column: "UsuarioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 93, 248, 68, 245, 116, 162, 90, 0, 137, 152, 10, 226, 102, 237, 241, 229, 201, 229, 75, 164, 86, 223, 134, 191, 147, 195, 22, 21, 75, 167, 241, 250, 134, 7, 183, 45, 48, 98, 235, 34, 83, 194, 85, 44, 12, 65, 6, 48, 82, 135, 18, 73, 98, 179, 151, 118, 180, 55, 165, 225, 77, 7, 7, 165 }, new byte[] { 7, 180, 89, 64, 218, 0, 227, 78, 203, 13, 254, 141, 129, 54, 85, 130, 11, 111, 231, 77, 112, 228, 238, 232, 17, 233, 198, 168, 133, 11, 252, 83, 81, 108, 85, 165, 204, 20, 58, 191, 219, 56, 91, 153, 246, 118, 139, 12, 115, 56, 187, 76, 143, 252, 25, 110, 149, 49, 123, 252, 44, 69, 136, 170, 68, 10, 245, 44, 140, 217, 59, 12, 210, 131, 192, 45, 202, 95, 20, 163, 30, 28, 77, 187, 152, 207, 104, 32, 33, 127, 98, 249, 209, 85, 92, 152, 2, 75, 7, 209, 128, 4, 73, 102, 145, 16, 5, 182, 142, 175, 161, 17, 84, 17, 226, 77, 64, 221, 127, 12, 50, 233, 209, 100, 138, 190, 56, 151 } });

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId",
                table: "TB_PERSONAGENS",
                column: "UsuarioId",
                principalTable: "TB_USUARIOS",
                principalColumn: "Id");
        }
    }
}
