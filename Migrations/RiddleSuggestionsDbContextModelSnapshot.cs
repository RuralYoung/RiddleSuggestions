﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RiddleSuggestions.Contexts;

#nullable disable

namespace RiddleSuggestions.Migrations
{
    [DbContext(typeof(RiddleSuggestionsDbContext))]
    partial class RiddleSuggestionsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RiddleSuggestions.Models.RiddleSuggestion", b =>
                {
                    b.Property<int>("RiddleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RiddleID"), 1L, 1);

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int?>("RiddleSuggestionRiddleID")
                        .HasColumnType("int");

                    b.HasKey("RiddleID");

                    b.HasIndex("RiddleSuggestionRiddleID");

                    b.ToTable("RiddleSuggestions");
                });

            modelBuilder.Entity("RiddleSuggestions.Models.RiddleSuggestion", b =>
                {
                    b.HasOne("RiddleSuggestions.Models.RiddleSuggestion", null)
                        .WithMany("RiddleSuggestions")
                        .HasForeignKey("RiddleSuggestionRiddleID");
                });

            modelBuilder.Entity("RiddleSuggestions.Models.RiddleSuggestion", b =>
                {
                    b.Navigation("RiddleSuggestions");
                });
#pragma warning restore 612, 618
        }
    }
}
