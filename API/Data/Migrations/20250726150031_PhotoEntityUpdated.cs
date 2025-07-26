using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class PhotoEntityUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Members_MmberId",
                table: "Photos");

            migrationBuilder.RenameColumn(
                name: "MmberId",
                table: "Photos",
                newName: "MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_MmberId",
                table: "Photos",
                newName: "IX_Photos_MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Members_MemberId",
                table: "Photos",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Members_MemberId",
                table: "Photos");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "Photos",
                newName: "MmberId");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_MemberId",
                table: "Photos",
                newName: "IX_Photos_MmberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Members_MmberId",
                table: "Photos",
                column: "MmberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
