using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.WebAPi.Migrations
{
    public partial class required : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provincias_Paises_PaisId",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "NombreProv",
                table: "Provincias");

            migrationBuilder.AlterColumn<int>(
                name: "PaisId",
                table: "Provincias",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodProv",
                table: "Provincias",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomProv",
                table: "Provincias",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Provincias_Paises_PaisId",
                table: "Provincias",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provincias_Paises_PaisId",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "CodProv",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "NomProv",
                table: "Provincias");

            migrationBuilder.AlterColumn<int>(
                name: "PaisId",
                table: "Provincias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Provincias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NombreProv",
                table: "Provincias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Provincias_Paises_PaisId",
                table: "Provincias",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
