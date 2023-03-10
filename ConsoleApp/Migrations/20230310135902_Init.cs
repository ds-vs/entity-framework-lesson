using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Departments",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        Name = table.Column<string>(type: "text", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Departments", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Hobbies",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        Name = table.Column<string>(type: "text", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Hobbies", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Persons",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        Name = table.Column<string>(type: "text", nullable: true),
            //        Surname = table.Column<string>(type: "text", nullable: true),
            //        DepartmentId = table.Column<int>(type: "integer", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Persons", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Persons_Departments_DepartmentId",
            //            column: x => x.DepartmentId,
            //            principalTable: "Departments",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Addresses",
            //    columns: table => new
            //    {
            //        PersonId = table.Column<int>(type: "integer", nullable: false),
            //        Street = table.Column<string>(type: "text", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Addresses", x => x.PersonId);
            //        table.ForeignKey(
            //            name: "FK_Addresses_Persons_PersonId",
            //            column: x => x.PersonId,
            //            principalTable: "Persons",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "HobbyPerson",
            //    columns: table => new
            //    {
            //        HobbiesId = table.Column<int>(type: "integer", nullable: false),
            //        PersonsId = table.Column<int>(type: "integer", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_HobbyPerson", x => new { x.HobbiesId, x.PersonsId });
            //        table.ForeignKey(
            //            name: "FK_HobbyPerson_Hobbies_HobbiesId",
            //            column: x => x.HobbiesId,
            //            principalTable: "Hobbies",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_HobbyPerson_Persons_PersonsId",
            //            column: x => x.PersonsId,
            //            principalTable: "Persons",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_HobbyPerson_PersonsId",
            //    table: "HobbyPerson",
            //    column: "PersonsId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Persons_DepartmentId",
            //    table: "Persons",
            //    column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Addresses");

            //migrationBuilder.DropTable(
            //    name: "HobbyPerson");

            //migrationBuilder.DropTable(
            //    name: "Hobbies");

            //migrationBuilder.DropTable(
            //    name: "Persons");

            //migrationBuilder.DropTable(
            //    name: "Departments");
        }
    }
}
