using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wattsup.DAL.Migrations
{
    /// <inheritdoc />
    public partial class tweaking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meters_Stores_ShopId",
                table: "Meters");

            migrationBuilder.RenameColumn(
                name: "ShopId",
                table: "Meters",
                newName: "StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Meters_ShopId",
                table: "Meters",
                newName: "IX_Meters_StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meters_Stores_StoreId",
                table: "Meters",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meters_Stores_StoreId",
                table: "Meters");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "Meters",
                newName: "ShopId");

            migrationBuilder.RenameIndex(
                name: "IX_Meters_StoreId",
                table: "Meters",
                newName: "IX_Meters_ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meters_Stores_ShopId",
                table: "Meters",
                column: "ShopId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
