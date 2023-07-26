using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstWeb.Migrations
{
    /// <inheritdoc />
    public partial class create_table_FacultyID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FaculName",
                table: "Faculty",
                newName: "FacultyName");

            migrationBuilder.RenameColumn(
                name: "FaculID",
                table: "Faculty",
                newName: "FacultyID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FacultyName",
                table: "Faculty",
                newName: "FaculName");

            migrationBuilder.RenameColumn(
                name: "FacultyID",
                table: "Faculty",
                newName: "FaculID");
        }
    }
}
