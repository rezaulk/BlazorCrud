using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorCrud.Server.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Designation = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Location = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
