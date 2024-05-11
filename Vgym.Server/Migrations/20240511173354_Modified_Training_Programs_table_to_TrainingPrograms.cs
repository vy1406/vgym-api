using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vgym.Server.Migrations
{
    /// <inheritdoc />
    public partial class Modified_Training_Programs_table_to_TrainingPrograms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Training_Programs",
                table: "Training_Programs");

            migrationBuilder.RenameTable(
                name: "Training_Programs",
                newName: "TrainingPrograms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingPrograms",
                table: "TrainingPrograms",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingPrograms",
                table: "TrainingPrograms");

            migrationBuilder.RenameTable(
                name: "TrainingPrograms",
                newName: "Training_Programs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Training_Programs",
                table: "Training_Programs",
                column: "Id");
        }
    }
}
