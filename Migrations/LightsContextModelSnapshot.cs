﻿// <auto-generated />
using System;
using Lights.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace NeuralinkLightsDemo.Migrations
{
    [DbContext(typeof(LightsContext))]
    partial class LightsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lights.Data.Entities.Light", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlgorithmParameter1");

                    b.Property<string>("AlgorithmParameter2");

                    b.Property<string>("AlgorithmParameter3");

                    b.Property<string>("AlgorithmParameter4");

                    b.Property<DateTime>("Datetime");

                    b.Property<int>("Number");

                    b.Property<string>("Pattern");

                    b.Property<int>("Setting1");

                    b.Property<int>("Setting2");

                    b.Property<int>("Setting3");

                    b.HasKey("Id");

                    b.ToTable("Lights");
                });
#pragma warning restore 612, 618
        }
    }
}
