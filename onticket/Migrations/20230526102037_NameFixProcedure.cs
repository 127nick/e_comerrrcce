using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace onticket.Migrations
{
    /// <inheritdoc />
    public partial class NameFixProcedure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movies_produsers_produserId",
                table: "movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_produsers",
                table: "produsers");

            migrationBuilder.RenameTable(
                name: "produsers",
                newName: "produserss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_produserss",
                table: "produserss",
                column: "IdproduserId");

            migrationBuilder.AddForeignKey(
                name: "FK_movies_produserss_produserId",
                table: "movies",
                column: "produserId",
                principalTable: "produserss",
                principalColumn: "IdproduserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movies_produserss_produserId",
                table: "movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_produserss",
                table: "produserss");

            migrationBuilder.RenameTable(
                name: "produserss",
                newName: "produsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_produsers",
                table: "produsers",
                column: "IdproduserId");

            migrationBuilder.AddForeignKey(
                name: "FK_movies_produsers_produserId",
                table: "movies",
                column: "produserId",
                principalTable: "produsers",
                principalColumn: "IdproduserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
