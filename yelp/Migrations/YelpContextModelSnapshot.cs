﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using yelp.Models;

namespace yelp.Migrations
{
    [DbContext(typeof(YelpContext))]
    partial class YelpContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("yelp.Models.BusCategory", b =>
                {
                    b.Property<int>("BusCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("BusCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("yelp.Models.BusCategoryType", b =>
                {
                    b.Property<int>("BusCategoryTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("CategoryType");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("BusCategoryTypeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryTypes");
                });

            modelBuilder.Entity("yelp.Models.BusHours", b =>
                {
                    b.Property<int>("BusHoursId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AlwaysOpen");

                    b.Property<int>("BusinessId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("FriCloseTime");

                    b.Property<DateTime>("FriOpenTime");

                    b.Property<DateTime>("MonCloseTime");

                    b.Property<DateTime>("MonOpenTime");

                    b.Property<DateTime>("SatCloseTime");

                    b.Property<DateTime>("SatOpenTime");

                    b.Property<DateTime>("SunCloseTime");

                    b.Property<DateTime>("SunOpenTime");

                    b.Property<DateTime>("ThuCloseTime");

                    b.Property<DateTime>("ThuOpenTime");

                    b.Property<DateTime>("TueCloseTime");

                    b.Property<DateTime>("TueOpenTime");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<DateTime>("WedCloseTime");

                    b.Property<DateTime>("WedOpenTime");

                    b.HasKey("BusHoursId");

                    b.HasIndex("BusinessId");

                    b.ToTable("Hours");
                });

            modelBuilder.Entity("yelp.Models.Business", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<int>("CategoryId");

                    b.Property<int>("CategoryTypeId");

                    b.Property<string>("City");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("ImageLink");

                    b.Property<string>("Name");

                    b.Property<int>("Phone");

                    b.Property<string>("State");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("Website");

                    b.Property<int>("ZipCode");

                    b.HasKey("BusinessId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CategoryTypeId");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("yelp.Models.BusProperties", b =>
                {
                    b.Property<int>("BusPropertiesId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BusinessId");

                    b.Property<bool>("ByApointOnly");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<bool>("alcohol");

                    b.Property<string>("ambience");

                    b.Property<bool>("bikeparking");

                    b.Property<bool>("caters");

                    b.Property<bool>("creditcards");

                    b.Property<bool>("delivery");

                    b.Property<string>("goodforTimeOfDay");

                    b.Property<bool>("groupfriendly");

                    b.Property<bool>("kidfriendly");

                    b.Property<bool>("outdoor");

                    b.Property<string>("parkwhere");

                    b.Property<int>("price");

                    b.Property<bool>("reservations");

                    b.Property<bool>("takeout");

                    b.Property<bool>("waiter");

                    b.Property<bool>("wheelchair");

                    b.Property<bool>("wifi");

                    b.HasKey("BusPropertiesId");

                    b.HasIndex("BusinessId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("yelp.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("Rating");

                    b.Property<string>("ReviewText");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("ReviewId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("yelp.Models.ReviewImage", b =>
                {
                    b.Property<int>("ReviewImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("ImageLink");

                    b.Property<int>("ReviewId");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("ReviewImageId");

                    b.HasIndex("ReviewId");

                    b.ToTable("ReviewImages");
                });

            modelBuilder.Entity("yelp.Models.ReviewVote", b =>
                {
                    b.Property<int>("ReviewVoteId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Cool");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("Funny");

                    b.Property<int>("ReviewId");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<bool>("Useful");

                    b.Property<int>("UserId");

                    b.HasKey("ReviewVoteId");

                    b.HasIndex("ReviewId");

                    b.HasIndex("UserId");

                    b.ToTable("ReviewVotes");
                });

            modelBuilder.Entity("yelp.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Salt");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("ZipCode");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("yelp.Models.UserImage", b =>
                {
                    b.Property<int>("UserImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("ImageLink");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("UserImageId");

                    b.HasIndex("UserId");

                    b.ToTable("UserImages");
                });

            modelBuilder.Entity("yelp.Models.BusCategoryType", b =>
                {
                    b.HasOne("yelp.Models.BusCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("yelp.Models.BusHours", b =>
                {
                    b.HasOne("yelp.Models.Business", "Business")
                        .WithMany()
                        .HasForeignKey("BusinessId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("yelp.Models.Business", b =>
                {
                    b.HasOne("yelp.Models.BusCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("yelp.Models.BusCategoryType", "CategoryType")
                        .WithMany()
                        .HasForeignKey("CategoryTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("yelp.Models.BusProperties", b =>
                {
                    b.HasOne("yelp.Models.Business", "Business")
                        .WithMany()
                        .HasForeignKey("BusinessId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("yelp.Models.Review", b =>
                {
                    b.HasOne("yelp.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("yelp.Models.ReviewImage", b =>
                {
                    b.HasOne("yelp.Models.Review", "Review")
                        .WithMany()
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("yelp.Models.ReviewVote", b =>
                {
                    b.HasOne("yelp.Models.Review", "Review")
                        .WithMany()
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("yelp.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("yelp.Models.UserImage", b =>
                {
                    b.HasOne("yelp.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
