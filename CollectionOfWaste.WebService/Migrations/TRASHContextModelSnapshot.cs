﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TRASH.InfrastructureServices.Gateways.Database;

namespace CollectionOfWaste.WebService.Migrations
{
    [DbContext(typeof(TRASHContext))]
    partial class TRASHContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("TRASH.DomainObjects.TRASH", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Space")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeArea")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TRASHs");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Контейнерная площадка № 1987645",
                            Space = "18",
                            TypeArea = "Контейнерная площадка"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
