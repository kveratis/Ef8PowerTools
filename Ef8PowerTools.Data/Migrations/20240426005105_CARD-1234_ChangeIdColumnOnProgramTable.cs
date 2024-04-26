using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ef8PowerTools.Data.Migrations
{
    /// <inheritdoc />
    public partial class CARD1234_ChangeIdColumnOnProgramTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProgramID",
                table: "Programs",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Programs",
                newName: "ProgramID");
        }
    }
}
