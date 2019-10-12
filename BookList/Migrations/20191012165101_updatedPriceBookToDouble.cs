using Microsoft.EntityFrameworkCore.Migrations;

namespace BookList.Migrations
{
    public partial class updatedPriceBookToDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Books",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Books",
                nullable: true,
                oldClrType: typeof(double));
        }
    }
}
