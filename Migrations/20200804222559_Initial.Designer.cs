﻿// <auto-generated />
using BusinessPro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusinessPro.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200804222559_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BusinessPro.Models.PhoneCaller", b =>
                {
                    b.Property<int>("PhoneCallerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Information");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("PhoneCallerID");

                    b.ToTable("PhoneCallers");
                });
#pragma warning restore 612, 618
        }
    }
}
