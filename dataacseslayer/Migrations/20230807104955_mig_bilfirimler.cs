using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataacseslayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_bilfirimler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_writers_writeryazarID1",
                table: "blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_comments_blogs_blogID",
                table: "comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_blogs",
                table: "blogs");

            migrationBuilder.DropIndex(
                name: "IX_blogs_writeryazarID1",
                table: "blogs");

            migrationBuilder.DropColumn(
                name: "writeryazarID1",
                table: "blogs");

            migrationBuilder.AlterColumn<int>(
                name: "blogID",
                table: "blogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "writeryazarID",
                table: "blogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_blogs",
                table: "blogs",
                column: "blogID");

            migrationBuilder.CreateTable(
                name: "bildirimlers",
                columns: table => new
                {
                    bildirimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bildirimtype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bildirimsenbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bildirimdetayları = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bildirimstatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bildirimlers", x => x.bildirimID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_blogs_writeryazarID",
                table: "blogs",
                column: "writeryazarID");

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_writers_writeryazarID",
                table: "blogs",
                column: "writeryazarID",
                principalTable: "writers",
                principalColumn: "yazarID",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_blogs_writers_writeryazarID",
                table: "blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_comments_blogs_blogID",
                table: "comments");

            migrationBuilder.DropTable(
                name: "bildirimlers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_blogs",
                table: "blogs");

            migrationBuilder.DropIndex(
                name: "IX_blogs_writeryazarID",
                table: "blogs");

            migrationBuilder.AlterColumn<int>(
                name: "writeryazarID",
                table: "blogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "blogID",
                table: "blogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "writeryazarID1",
                table: "blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_blogs",
                table: "blogs",
                column: "writeryazarID");

            migrationBuilder.CreateIndex(
                name: "IX_blogs_writeryazarID1",
                table: "blogs",
                column: "writeryazarID1");

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_writers_writeryazarID1",
                table: "blogs",
                column: "writeryazarID1",
                principalTable: "writers",
                principalColumn: "yazarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_blogs_blogID",
                table: "comments",
                column: "blogID",
                principalTable: "blogs",
                principalColumn: "writeryazarID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
