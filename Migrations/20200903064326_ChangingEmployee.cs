using Microsoft.EntityFrameworkCore.Migrations;

namespace crud.Migrations
{
    public partial class ChangingEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salario",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Salary",
                table: "Employees",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Employees");

            migrationBuilder.AddColumn<float>(
                name: "Salario",
                table: "Employees",
                type: "float",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
