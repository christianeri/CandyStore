﻿// <auto-generated />
using System;
using CandyStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CandyStore.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20211203132831_AddingShoppingCart")]
    partial class AddingShoppingCart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CandyStore.Models.Candy", b =>
                {
                    b.Property<int>("CandyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CandyId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Candies");

                    b.HasData(
                        new
                        {
                            CandyId = 1,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque. Tortor posuere ac ut consequat. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Lacus sed turpis tincidunt id aliquet risus feugiat in. Viverra aliquet eget sit amet tellus cras adipiscing enim eu.",
                            ImageThumbnailURL = "\\Images\\thumbnails\\chocolateCandy-small.jpg",
                            ImageURL = "\\Images\\chocolateCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Chocolate Candy",
                            Price = 4.95m
                        },
                        new
                        {
                            CandyId = 2,
                            CategoryId = 1,
                            Description = "Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Quisque egestas diam in arcu cursus. Sed viverra tellus in hac. Quis commodo odio aenean sed adipiscing diam donec adipiscing.",
                            ImageThumbnailURL = "\\Images\\thumbnails\\chocolateCandy2-small.jpg",
                            ImageURL = "\\Images\\chocolateCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Assorted Chocolate Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 3,
                            CategoryId = 1,
                            Description = "Turpis egestas pretium aenean pharetra magna ac placerat vestibulum. Sed faucibus turpis in eu mi bibendum neque egestas. At in tellus integer feugiat scelerisque. Elementum integer enim neque volutpat ac tincidunt.",
                            ImageThumbnailURL = "\\Images\\thumbnails\\chocolateCandy3-small.jpg",
                            ImageURL = "\\Images\\chocolateCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Another Chocolate Candy",
                            Price = 5.75m
                        },
                        new
                        {
                            CandyId = 4,
                            CategoryId = 2,
                            Description = "Vitae congue eu consequat ac felis donec et. Praesent semper feugiat nibh sed pulvinar proin gravida hendrerit. Vel eros donec ac odio. A lacus vestibulum sed arcu non odio euismod lacinia at. Nisl suscipit adipiscing bibendum est ultricies integer. Nec tincidunt praesent semper feugiat nibh.",
                            ImageThumbnailURL = "\\Images\\thumbnails\\fruitCandy-small.jpg",
                            ImageURL = "\\Images\\fruitCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Fruit Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 5,
                            CategoryId = 2,
                            Description = "Purus sit amet luctus venenatis lectus magna fringilla. Consectetur lorem donec massa sapien faucibus et molestie ac. Sagittis nisl rhoncus mattis rhoncus urna neque viverra.",
                            ImageThumbnailURL = "\\Images\\thumbnails\\fruitCandy2-small.jpg",
                            ImageURL = "\\Images\\fruitCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Fruit Candy",
                            Price = 7.00m
                        },
                        new
                        {
                            CandyId = 6,
                            CategoryId = 2,
                            Description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
                            ImageThumbnailURL = "\\Images\\thumbnails\\fruitCandy3-small.jpg",
                            ImageURL = "\\Images\\fruitCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Assorted Fruit Candy",
                            Price = 11.25m
                        },
                        new
                        {
                            CandyId = 7,
                            CategoryId = 3,
                            Description = "Diam sit amet nisl suscipit adipiscing bibendum est ultricies integer. Molestie at elementum eu facilisis sed odio morbi quis commodo. Odio facilisis mauris sit amet massa vitae tortor condimentum lacinia. Urna porttitor rhoncus dolor purus non enim praesent elementum facilisis.",
                            ImageThumbnailURL = "\\Images\\thumbnails\\gummyCandy-small.jpg",
                            ImageURL = "\\Images\\gummyCandy.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Gummy Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 8,
                            CategoryId = 3,
                            Description = "Posuere ac ut consequat semper viverra nam libero justo laoreet. Ultrices dui sapien eget mi proin sed libero enim. Etiam non quam lacus suspendisse faucibus interdum. Amet nisl suscipit adipiscing bibendum est ultricies integer quis.",
                            ImageThumbnailURL = "\\Images\\thumbnails\\gummyCandy2-small.jpg",
                            ImageURL = "\\Images\\gummyCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Another Assorted Gummy Candy",
                            Price = 1.95m
                        },
                        new
                        {
                            CandyId = 9,
                            CategoryId = 3,
                            Description = "Ut ornare lectus sit amet est placerat in egestas. Iaculis nunc sed augue lacus viverra vitae. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices gravida. Accumsan tortor posuere ac ut consequat semper viverra.",
                            ImageThumbnailURL = "\\Images\\thumbnails\\gummyCandy3-small.jpg",
                            ImageURL = "\\Images\\gummyCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Gummy Candy",
                            Price = 13.95m
                        },
                        new
                        {
                            CandyId = 10,
                            CategoryId = 4,
                            Description = "Vitae congue eu consequat ac felis donec et odio. Tellus orci ac auctor augue mauris augue. Feugiat sed lectus vestibulum mattis ullamcorper velit sed. Sit amet consectetur adipiscing elit pellentesque habitant morbi tristique senectus. Sed pulvinar proin gravida hendrerit lectus a.",
                            ImageThumbnailURL = "\\Images\\thumbnails\\halloweenCandy-small.jpg",
                            ImageURL = "\\Images\\halloweenCandy.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Halloween Candy",
                            Price = 1.95m
                        },
                        new
                        {
                            CandyId = 11,
                            CategoryId = 4,
                            Description = "Hac habitasse platea dictumst quisque sagittis purus sit. Dui nunc mattis enim ut. Mauris commodo quis imperdiet massa tincidunt nunc pulvinar sapien et.",
                            ImageThumbnailURL = "\\Images\\thumbnails\\halloweenCandy2-small.jpg",
                            ImageURL = "\\Images\\halloweenCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Halloween Candy",
                            Price = 12.95m
                        },
                        new
                        {
                            CandyId = 12,
                            CategoryId = 4,
                            Description = "Pulvinar neque laoreet suspendisse interdum consectetur libero id faucibus. Ultrices vitae auctor eu augue ut lectus arcu bibendum at. Vulputate eu scelerisque felis imperdiet proin fermentum.",
                            ImageThumbnailURL = "\\Images\\thumbnails\\halloweenCandy3-small.jpg",
                            ImageURL = "\\Images\\halloweenCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Halloween Candy",
                            Price = 21.95m
                        },
                        new
                        {
                            CandyId = 13,
                            CategoryId = 5,
                            Description = "Vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Arcu cursus euismod quis viverra.",
                            ImageThumbnailURL = "\\Images\\thumbnails\\hardCandy-small.jpg",
                            ImageURL = "\\Images\\hardCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Hard Candy",
                            Price = 6.95m
                        },
                        new
                        {
                            CandyId = 14,
                            CategoryId = 5,
                            Description = "Blandit massa enim nec dui nunc mattis enim ut tellus. Duis at consectetur lorem donec massa sapien faucibus et. At auctor urna nunc id cursus metus. Ut enim blandit volutpat maecenas volutpat blandit.",
                            ImageThumbnailURL = "\\Images\\thumbnails\\hardCandy2-small.jpg",
                            ImageURL = "\\Images\\hardCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Hard Candy",
                            Price = 2.95m
                        },
                        new
                        {
                            CandyId = 15,
                            CategoryId = 5,
                            Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                            ImageThumbnailURL = "\\Images\\thumbnails\\hardCandy3-small.jpg",
                            ImageURL = "\\Images\\hardCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Best Hard Candy",
                            Price = 16.95m
                        });
                });

            modelBuilder.Entity("CandyStore.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Chocolate Candy"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Fruit Candy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Gummy Candy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Halloween Candy"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Hard Candy"
                        });
                });

            modelBuilder.Entity("CandyStore.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("CandyId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("CandyId");

                    b.ToTable("ShoppingCartItemsDbSet");
                });

            modelBuilder.Entity("CandyStore.Models.Candy", b =>
                {
                    b.HasOne("CandyStore.Models.Category", "Category")
                        .WithMany("Candies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CandyStore.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("CandyStore.Models.Candy", "Candy")
                        .WithMany()
                        .HasForeignKey("CandyId");

                    b.Navigation("Candy");
                });

            modelBuilder.Entity("CandyStore.Models.Category", b =>
                {
                    b.Navigation("Candies");
                });
#pragma warning restore 612, 618
        }
    }
}