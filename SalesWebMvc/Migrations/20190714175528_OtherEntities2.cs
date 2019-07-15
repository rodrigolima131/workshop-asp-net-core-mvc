using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class OtherEntities2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaseSalary",
                table: "SalesRecord");

            migrationBuilder.RenameColumn(
                name: "amount",
                table: "SalesRecord",
                newName: "Amount");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "SalesRecord",
                newName: "amount");

            migrationBuilder.AlterColumn<int>(
                name: "Email",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "BaseSalary",
                table: "SalesRecord",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
