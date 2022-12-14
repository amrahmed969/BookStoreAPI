// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1_API.Data;

#nullable disable

namespace _1_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220801032726_seedinddata3")]
    partial class seedinddata3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1_API.Data.Models.Books", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CoverUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateRead")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<int?>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CoverUrl = "https...",
                            DateAdded = new DateTime(2022, 8, 2, 5, 27, 26, 608, DateTimeKind.Local).AddTicks(1279),
                            DateRead = new DateTime(2022, 8, 1, 5, 27, 26, 608, DateTimeKind.Local).AddTicks(1293),
                            Description = "firstdiscription",
                            Genre = "comedy",
                            IsRead = true,
                            Rate = 6,
                            Title = "firstbook"
                        },
                        new
                        {
                            ID = 2,
                            CoverUrl = "https...",
                            DateAdded = new DateTime(2022, 8, 2, 5, 27, 26, 608, DateTimeKind.Local).AddTicks(1300),
                            DateRead = new DateTime(2022, 8, 1, 5, 27, 26, 608, DateTimeKind.Local).AddTicks(1300),
                            Description = "firstdiscription",
                            Genre = "comedy",
                            IsRead = true,
                            Rate = 6,
                            Title = "secondbook"
                        },
                        new
                        {
                            ID = 3,
                            CoverUrl = "https...",
                            DateAdded = new DateTime(2022, 8, 2, 5, 27, 26, 608, DateTimeKind.Local).AddTicks(1302),
                            DateRead = new DateTime(2022, 8, 1, 5, 27, 26, 608, DateTimeKind.Local).AddTicks(1303),
                            Description = "Thirdiscription",
                            Genre = "action",
                            IsRead = true,
                            Rate = 4,
                            Title = "Thirdbook"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
