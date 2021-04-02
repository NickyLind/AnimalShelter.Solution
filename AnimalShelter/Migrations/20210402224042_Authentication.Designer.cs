﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20210402224042_Authentication")]
    partial class Authentication
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 9,
                            Breed = "Chocoloate Lab",
                            Description = "Spayed, needs a loving home with older childred/no children",
                            Gender = "Female",
                            Name = "Ted",
                            Type = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 2,
                            Breed = "Pug",
                            Description = "Neutered, spunky and likes a lot of attention",
                            Gender = "Male",
                            Name = "Bradley",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 3,
                            Breed = "Husky",
                            Description = "Neutered, needs a LOT of exercise",
                            Gender = "Male",
                            Name = "Ghost",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 1,
                            Breed = "Australian Shepherd",
                            Description = "BNeutered, needs to be given tasks for feel important",
                            Gender = "Male",
                            Name = "Sparky",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 9,
                            Breed = "Persian",
                            Description = "Spayed, Very shy. Better suited to a home with no/older children",
                            Gender = "Female",
                            Name = "Molly",
                            Type = "Cat"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 1,
                            Breed = "Tabby(Orange)",
                            Description = "Neutered, very active loves to play",
                            Gender = "Male",
                            Name = "Jose",
                            Type = "Cat"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 3,
                            Breed = "Great Dane",
                            Description = "Neutered, dumb sweetheart. Needs a lot of room to move around",
                            Gender = "Male",
                            Name = "Thor",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 8,
                            Age = 2,
                            Breed = "Chocoloate Lab",
                            Description = "Spayed, loves playing fetch and being active",
                            Gender = "Female",
                            Name = "Charlie",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 9,
                            Age = 2,
                            Breed = "Calico",
                            Description = "Spayed, waiting for owner pickup",
                            Gender = "Female",
                            Name = "Chloe",
                            Type = "Cat"
                        },
                        new
                        {
                            AnimalId = 10,
                            Age = 9,
                            Breed = "English Bulldog",
                            Description = "Neutered, will need surgery on knees and potentially nose",
                            Gender = "Male",
                            Name = "Rocket",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 11,
                            Age = 4,
                            Breed = "Persian",
                            Description = "Spayed, loves sleeping doesn't mind children",
                            Gender = "Female",
                            Name = "Tina Turner",
                            Type = "Cat"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}