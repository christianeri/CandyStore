using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyStore.Migrations
{
    public partial class AddingShoppingCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Candies_CandyId",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItems",
                newName: "ShoppingCartItemsDbSet");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_CandyId",
                table: "ShoppingCartItemsDbSet",
                newName: "IX_ShoppingCartItemsDbSet_CandyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItemsDbSet",
                table: "ShoppingCartItemsDbSet",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItemsDbSet_Candies_CandyId",
                table: "ShoppingCartItemsDbSet",
                column: "CandyId",
                principalTable: "Candies",
                principalColumn: "CandyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItemsDbSet_Candies_CandyId",
                table: "ShoppingCartItemsDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItemsDbSet",
                table: "ShoppingCartItemsDbSet");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItemsDbSet",
                newName: "ShoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItemsDbSet_CandyId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_CandyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Candies_CandyId",
                table: "ShoppingCartItems",
                column: "CandyId",
                principalTable: "Candies",
                principalColumn: "CandyId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
