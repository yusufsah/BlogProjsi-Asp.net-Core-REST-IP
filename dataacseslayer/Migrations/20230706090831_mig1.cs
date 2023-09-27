using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataacseslayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "abouts",
                columns: table => new
                {
                    aboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aboutdetails1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aboutdetails2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abouts", x => x.aboutID);
                });

            ///


            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    blogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blogküçükresim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blogbüyükresim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blogcontent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    creatdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.blogID);
                });

            ///


            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    commentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    commentuserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    commenttitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    commentcontent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    commentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commentstatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.commentID);
                });


            //


            migrationBuilder.CreateTable(
                name: "cotacts",
                columns: table => new
                {
                    contactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contactusername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactedate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    contactstatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cotacts", x => x.contactID);
                });



            //


            migrationBuilder.CreateTable(
                name: "katagoris",
                columns: table => new
                {
                    katagoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    katagoriName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    katagoriDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    katagoristatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_katagoris", x => x.katagoriID);
                });



            //



            migrationBuilder.CreateTable(
                name: "writers",
                columns: table => new
                {
                    yazarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yazarName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    writerabout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    writeriamge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    writerstatuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    writermail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    writerpassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_writers", x => x.yazarID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "abouts");

            migrationBuilder.DropTable(
                name: "blogs");

            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "cotacts");

            migrationBuilder.DropTable(
                name: "katagoris");

            migrationBuilder.DropTable(
                name: "writers");
        }
    }
}
