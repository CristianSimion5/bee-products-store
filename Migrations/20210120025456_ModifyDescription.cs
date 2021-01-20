using Microsoft.EntityFrameworkCore.Migrations;

namespace Polifloris.Migrations
{
    public partial class ModifyDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LongDescription",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "Products",
                newName: "Description");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "ShortDescription");

            migrationBuilder.AddColumn<string>(
                name: "LongDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
