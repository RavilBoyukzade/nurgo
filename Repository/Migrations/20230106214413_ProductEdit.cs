using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class ProductEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BodyStyle",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Engine",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FuelType",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Killometer",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Marka",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Transmissiya",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "İnteryer",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BodyStyle",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Engine",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FuelType",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Killometer",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Marka",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Transmissiya",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "İnteryer",
                table: "Products");
        }
    }
}
