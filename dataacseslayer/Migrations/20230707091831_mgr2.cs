using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataacseslayer.Migrations
{
    /// <inheritdoc />
    public partial class mgr2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "katagoriID",
                table: "blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_blogs_katagoriID",
                table: "blogs",
                column: "katagoriID");

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_katagoris_katagoriID",
                table: "blogs",
                column: "katagoriID",
                principalTable: "katagoris",
                principalColumn: "katagoriID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_katagoris_katagoriID",
                table: "blogs");

            migrationBuilder.DropIndex(
                name: "IX_blogs_katagoriID",
                table: "blogs");

            migrationBuilder.DropColumn(
                name: "katagoriID",
                table: "blogs");
        }
    }
}
