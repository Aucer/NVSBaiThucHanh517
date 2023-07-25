using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstWeb.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Dog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Animals",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DogAge",
                table: "Animals",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DogID",
                table: "Animals",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "DogAge",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "DogID",
                table: "Animals");
        }
    }
}
