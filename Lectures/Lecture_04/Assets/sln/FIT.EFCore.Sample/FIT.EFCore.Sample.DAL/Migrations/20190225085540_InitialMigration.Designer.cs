﻿// <auto-generated />
using System;
using FIT.EFCore.Sample.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FIT.EFCore.Sample.DAL.Migrations
{
    [DbContext(typeof(TodosDbContext))]
    [Migration("20190225085540_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FIT.EFCore.Sample.DAL.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("FIT.EFCore.Sample.DAL.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("FIT.EFCore.Sample.DAL.Entities.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssignedPersonId");

                    b.Property<int?>("GroupId");

                    b.Property<bool>("IsDone");

                    b.Property<string>("Task");

                    b.HasKey("Id");

                    b.HasIndex("AssignedPersonId");

                    b.HasIndex("GroupId");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("FIT.EFCore.Sample.DAL.Entities.Todo", b =>
                {
                    b.HasOne("FIT.EFCore.Sample.DAL.Entities.Person", "AssignedPerson")
                        .WithMany()
                        .HasForeignKey("AssignedPersonId");

                    b.HasOne("FIT.EFCore.Sample.DAL.Entities.Group", "Group")
                        .WithMany("Todos")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
