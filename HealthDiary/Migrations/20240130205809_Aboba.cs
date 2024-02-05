using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthDiary.Migrations
{
    /// <inheritdoc />
    public partial class Aboba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhysicalHealthProfiles_User_UserID",
                table: "PhysicalHealthProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhysicalHealthProfiles",
                table: "PhysicalHealthProfiles");

            migrationBuilder.RenameTable(
                name: "PhysicalHealthProfiles",
                newName: "PhysicalProfiles");

            migrationBuilder.RenameIndex(
                name: "IX_PhysicalHealthProfiles_UserID",
                table: "PhysicalProfiles",
                newName: "IX_PhysicalProfiles_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhysicalProfiles",
                table: "PhysicalProfiles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhysicalProfiles_User_UserID",
                table: "PhysicalProfiles",
                column: "UserID",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhysicalProfiles_User_UserID",
                table: "PhysicalProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhysicalProfiles",
                table: "PhysicalProfiles");

            migrationBuilder.RenameTable(
                name: "PhysicalProfiles",
                newName: "PhysicalHealthProfiles");

            migrationBuilder.RenameIndex(
                name: "IX_PhysicalProfiles_UserID",
                table: "PhysicalHealthProfiles",
                newName: "IX_PhysicalHealthProfiles_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhysicalHealthProfiles",
                table: "PhysicalHealthProfiles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhysicalHealthProfiles_User_UserID",
                table: "PhysicalHealthProfiles",
                column: "UserID",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
