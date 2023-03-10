// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission_6_conmansp.Models;

namespace Mission_6_conmansp.Migrations
{
    [DbContext(typeof(MovieEntryContext))]
    [Migration("20230213223547_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission_6_conmansp.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("FormID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("FormID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            FormID = 1,
                            Category = "Action/Adventure",
                            Director = "Joss Whedon",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "The Avengers",
                            Year = 2012
                        },
                        new
                        {
                            FormID = 2,
                            Category = "Action/Adventure",
                            Director = "Tim Burton",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Batman",
                            Year = 1989
                        },
                        new
                        {
                            FormID = 3,
                            Category = "Action/Adventure",
                            Director = "Christopher Nolan",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Batman Begins",
                            Year = 2005
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
