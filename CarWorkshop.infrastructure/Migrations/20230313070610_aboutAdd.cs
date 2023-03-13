using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarWorkshop.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class aboutAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Abaout",
                table: "carWorkshops",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Abaout",
                table: "carWorkshops");
        }
    }
}
