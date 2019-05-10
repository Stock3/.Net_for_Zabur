using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab_4.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hire",
                columns: table => new
                {
                    HireId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullNameClient = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    ClientCode = table.Column<string>(type: "varchar(10)", nullable: true),
                    ClientAddress = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    ClientPhone = table.Column<string>(type: "varchar(10)", nullable: false),
                    NameGoods = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    DescriptionGoods = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    PriceGoods = table.Column<int>(type: "int", nullable: false),
                    DateIssue = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateReturn = table.Column<DateTime>(type: "datetime", nullable: false),
                    PriceHireOnDay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hire", x => x.HireId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hire");
        }
    }
}
