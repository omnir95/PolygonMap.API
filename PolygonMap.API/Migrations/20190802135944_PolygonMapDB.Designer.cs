﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PolygonMap.Data;

namespace PolygonMap.API.Migrations
{
    [DbContext(typeof(PolygonMapContext))]
    [Migration("20190802135944_PolygonMapDB")]
    partial class PolygonMapDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PolygonMap.Domain.Entities.Point", b =>
                {
                    b.Property<int>("PointID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<int>("ShapeID");

                    b.HasKey("PointID");

                    b.HasIndex("ShapeID");

                    b.ToTable("Point");

                    b.HasData(
                        new
                        {
                            PointID = 1,
                            Latitude = 31.96356f,
                            Longitude = 35.26228f,
                            ShapeID = 1
                        },
                        new
                        {
                            PointID = 2,
                            Latitude = 31.95322f,
                            Longitude = 35.2513f,
                            ShapeID = 1
                        },
                        new
                        {
                            PointID = 3,
                            Latitude = 31.95366f,
                            Longitude = 35.26966f,
                            ShapeID = 1
                        },
                        new
                        {
                            PointID = 4,
                            Latitude = 31.96074f,
                            Longitude = 35.26778f,
                            ShapeID = 2
                        },
                        new
                        {
                            PointID = 5,
                            Latitude = 31.96074f,
                            Longitude = 35.2513f,
                            ShapeID = 2
                        },
                        new
                        {
                            PointID = 6,
                            Latitude = 31.94836f,
                            Longitude = 35.2513f,
                            ShapeID = 2
                        },
                        new
                        {
                            PointID = 7,
                            Latitude = 31.94865f,
                            Longitude = 35.26778f,
                            ShapeID = 2
                        },
                        new
                        {
                            PointID = 8,
                            Latitude = 31.9485f,
                            Longitude = 35.2513f,
                            ShapeID = 3
                        },
                        new
                        {
                            PointID = 9,
                            Latitude = 31.94865f,
                            Longitude = 35.26778f,
                            ShapeID = 3
                        },
                        new
                        {
                            PointID = 10,
                            Latitude = 31.95491f,
                            Longitude = 35.26778f,
                            ShapeID = 3
                        },
                        new
                        {
                            PointID = 11,
                            Latitude = 31.96103f,
                            Longitude = 35.25954f,
                            ShapeID = 3
                        },
                        new
                        {
                            PointID = 12,
                            Latitude = 31.95477f,
                            Longitude = 35.2513f,
                            ShapeID = 3
                        },
                        new
                        {
                            PointID = 13,
                            Latitude = 31.96176f,
                            Longitude = 35.25919f,
                            ShapeID = 4
                        },
                        new
                        {
                            PointID = 14,
                            Latitude = 31.9552f,
                            Longitude = 35.26743f,
                            ShapeID = 4
                        },
                        new
                        {
                            PointID = 15,
                            Latitude = 31.94705f,
                            Longitude = 35.26795f,
                            ShapeID = 4
                        },
                        new
                        {
                            PointID = 16,
                            Latitude = 31.9402f,
                            Longitude = 35.26005f,
                            ShapeID = 4
                        },
                        new
                        {
                            PointID = 17,
                            Latitude = 31.94676f,
                            Longitude = 35.2513f,
                            ShapeID = 4
                        },
                        new
                        {
                            PointID = 18,
                            Latitude = 31.95535f,
                            Longitude = 35.25061f,
                            ShapeID = 4
                        });
                });

            modelBuilder.Entity("PolygonMap.Domain.Entities.Polygon", b =>
                {
                    b.Property<int>("PolygonID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Points");

                    b.Property<float>("RealLatitude");

                    b.Property<float>("RealLongitude");

                    b.Property<int>("ShapeID");

                    b.HasKey("PolygonID");

                    b.HasIndex("ShapeID");

                    b.ToTable("Polygon");
                });

            modelBuilder.Entity("PolygonMap.Domain.Entities.Shape", b =>
                {
                    b.Property<int>("ShapeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("FixedLatitude");

                    b.Property<float>("FixedLongitude");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ShapeID");

                    b.ToTable("Shape");

                    b.HasData(
                        new
                        {
                            ShapeID = 1,
                            FixedLatitude = 31.95229f,
                            FixedLongitude = 35.25868f,
                            Name = "Triangle"
                        },
                        new
                        {
                            ShapeID = 2,
                            FixedLatitude = 31.95229f,
                            FixedLongitude = 35.25868f,
                            Name = "Quadrilateral"
                        },
                        new
                        {
                            ShapeID = 3,
                            FixedLatitude = 31.95229f,
                            FixedLongitude = 35.25868f,
                            Name = "Pentagon"
                        },
                        new
                        {
                            ShapeID = 4,
                            FixedLatitude = 31.95229f,
                            FixedLongitude = 35.25868f,
                            Name = "Hexagon"
                        });
                });

            modelBuilder.Entity("PolygonMap.Domain.Entities.Point", b =>
                {
                    b.HasOne("PolygonMap.Domain.Entities.Shape", "Shape")
                        .WithMany("Points")
                        .HasForeignKey("ShapeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PolygonMap.Domain.Entities.Polygon", b =>
                {
                    b.HasOne("PolygonMap.Domain.Entities.Shape", "Shape")
                        .WithMany("Polygons")
                        .HasForeignKey("ShapeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
