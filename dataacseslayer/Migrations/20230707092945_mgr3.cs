using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataacseslayer.Migrations
{
    /// <inheritdoc />
    public partial class mgr3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "blogID",
                table: "comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_comments_blogID",
                table: "comments",
                column: "blogID");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_blogs_blogID",
                table: "comments",
                column: "blogID",
                principalTable: "blogs",
                principalColumn: "blogID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_blogs_blogID",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_comments_blogID",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "blogID",
                table: "comments");
        }
    }
}
