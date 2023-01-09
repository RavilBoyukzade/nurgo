using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class ProductEditedt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductFuture_Products_ProductId",
                table: "ProductFuture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductFuture",
                table: "ProductFuture");

            migrationBuilder.RenameTable(
                name: "ProductFuture",
                newName: "ProductFutures");

            migrationBuilder.RenameIndex(
                name: "IX_ProductFuture_ProductId",
                table: "ProductFutures",
                newName: "IX_ProductFutures_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductFutures",
                table: "ProductFutures",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFutures_Products_ProductId",
                table: "ProductFutures",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductFutures_Products_ProductId",
                table: "ProductFutures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductFutures",
                table: "ProductFutures");

            migrationBuilder.RenameTable(
                name: "ProductFutures",
                newName: "ProductFuture");

            migrationBuilder.RenameIndex(
                name: "IX_ProductFutures_ProductId",
                table: "ProductFuture",
                newName: "IX_ProductFuture_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductFuture",
                table: "ProductFuture",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFuture_Products_ProductId",
                table: "ProductFuture",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
