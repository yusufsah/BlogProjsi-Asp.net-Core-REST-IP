﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dataacseslayer.concreat;

#nullable disable

namespace dataacseslayer.Migrations
{
    [DbContext(typeof(context))]
    [Migration("20230707092945_mgr3")]
    partial class mgr3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("entity.conti.about", b =>
                {
                    b.Property<int>("aboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("aboutID"));

                    b.Property<string>("aboutdetails1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutdetails2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("aboutID");

                    b.ToTable("abouts");
                });

            modelBuilder.Entity("entity.conti.blog", b =>
                {
                    b.Property<int>("blogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("blogID"));

                    b.Property<string>("blogbüyükresim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blogcontent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blogküçükresim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("creatdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("katagoriID")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("blogID");

                    b.HasIndex("katagoriID");

                    b.ToTable("blogs");
                });

            modelBuilder.Entity("entity.conti.comment", b =>
                {
                    b.Property<int>("commentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("commentID"));

                    b.Property<int>("blogID")
                        .HasColumnType("int");

                    b.Property<DateTime>("commentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("commentcontent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("commentstatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("commenttitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("commentuserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("commentID");

                    b.HasIndex("blogID");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("entity.conti.cotact", b =>
                {
                    b.Property<int>("contactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("contactID"));

                    b.Property<DateTime>("contactedate")
                        .HasColumnType("datetime2");

                    b.Property<string>("contactitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("contactstatus")
                        .HasColumnType("bit");

                    b.Property<string>("contactusername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("contactID");

                    b.ToTable("cotacts");
                });

            modelBuilder.Entity("entity.conti.katagori", b =>
                {
                    b.Property<int>("katagoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("katagoriID"));

                    b.Property<string>("katagoriDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("katagoriName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("katagoristatus")
                        .HasColumnType("bit");

                    b.HasKey("katagoriID");

                    b.ToTable("katagoris");
                });

            modelBuilder.Entity("entity.conti.writer", b =>
                {
                    b.Property<int>("yazarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("yazarID"));

                    b.Property<string>("writerabout")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writeriamge")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writermail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writerpassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writerstatuc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("yazarName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("yazarID");

                    b.ToTable("writers");
                });

            modelBuilder.Entity("entity.conti.blog", b =>
                {
                    b.HasOne("entity.conti.katagori", "katagorı")
                        .WithMany("Blogs")
                        .HasForeignKey("katagoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("katagorı");
                });

            modelBuilder.Entity("entity.conti.comment", b =>
                {
                    b.HasOne("entity.conti.blog", "blogs")
                        .WithMany("comments")
                        .HasForeignKey("blogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("blogs");
                });

            modelBuilder.Entity("entity.conti.blog", b =>
                {
                    b.Navigation("comments");
                });

            modelBuilder.Entity("entity.conti.katagori", b =>
                {
                    b.Navigation("Blogs");
                });
#pragma warning restore 612, 618
        }
    }
}
