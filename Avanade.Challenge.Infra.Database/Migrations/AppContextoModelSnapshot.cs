﻿// <auto-generated />
using Avanade.Challenge.Infra.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Avanade.Challenge.Infra.Database.Migrations
{
    [DbContext(typeof(AppContexto))]
    partial class AppContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Avanade.Challenge.Api.Infra.Database.Domain.Phrase", b =>
                {
                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.Property<string>("Expression")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("TopicId");

                    b.HasIndex("Expression")
                        .IsUnique();

                    b.ToTable("Phrases");
                });

            modelBuilder.Entity("Avanade.Challenge.Api.Infra.Database.Domain.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Descricao")
                        .IsUnique()
                        .HasFilter("[Descricao] IS NOT NULL");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("Avanade.Challenge.Api.Infra.Database.Domain.Phrase", b =>
                {
                    b.HasOne("Avanade.Challenge.Api.Infra.Database.Domain.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
