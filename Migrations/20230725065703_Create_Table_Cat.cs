using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstWeb.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Cat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CatCategory",
                table: "Animals",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CatID",
                table: "Animals",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatCategory",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "CatID",
                table: "Animals");
        }
    }
}
