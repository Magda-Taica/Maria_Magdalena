using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Maria_Magdalena.Migrations
{
    public partial class InitialMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departament",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dept = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departament", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    numemanager = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Angajat",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    numeangajat = table.Column<string>(maxLength: 30, nullable: false),
                    post = table.Column<string>(maxLength: 30, nullable: false),
                    ManagerID = table.Column<int>(nullable: false),
                    DepartamentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Angajat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Angajat_Departament_DepartamentID",
                        column: x => x.DepartamentID,
                        principalTable: "Departament",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Angajat_Manager_ManagerID",
                        column: x => x.ManagerID,
                        principalTable: "Manager",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManDept",
                columns: table => new
                {
                    ManDeptID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AngajatID = table.Column<int>(nullable: false),
                    ManagerID = table.Column<int>(nullable: false),
                    DepartamentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManDept", x => x.ManDeptID);
                    table.ForeignKey(
                        name: "FK_ManDept_Departament_DepartamentID",
                        column: x => x.DepartamentID,
                        principalTable: "Departament",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManDept_Manager_ManagerID",
                        column: x => x.ManagerID,
                        principalTable: "Manager",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Angajat_DepartamentID",
                table: "Angajat",
                column: "DepartamentID");

            migrationBuilder.CreateIndex(
                name: "IX_Angajat_ManagerID",
                table: "Angajat",
                column: "ManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_ManDept_DepartamentID",
                table: "ManDept",
                column: "DepartamentID");

            migrationBuilder.CreateIndex(
                name: "IX_ManDept_ManagerID",
                table: "ManDept",
                column: "ManagerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Angajat");

            migrationBuilder.DropTable(
                name: "ManDept");

            migrationBuilder.DropTable(
                name: "Departament");

            migrationBuilder.DropTable(
                name: "Manager");
        }
    }
}
