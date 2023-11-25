﻿// <auto-generated />
using Api.Data.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(PodContext))]
    partial class PodContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Api.Model.Marca", b =>
                {
                    b.Property<string>("IdMarca")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("IdMarca");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("Api.Model.Pod", b =>
                {
                    b.Property<int>("IdPod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IdMarca")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MarcaIdMarca")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Preco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Puffs")
                        .HasColumnType("int");

                    b.Property<string>("Sabor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdPod");

                    b.HasIndex("MarcaIdMarca");

                    b.ToTable("Pods");
                });

            modelBuilder.Entity("Api.Model.Pod", b =>
                {
                    b.HasOne("Api.Model.Marca", "Marca")
                        .WithMany("Pods")
                        .HasForeignKey("MarcaIdMarca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("Api.Model.Marca", b =>
                {
                    b.Navigation("Pods");
                });
#pragma warning restore 612, 618
        }
    }
}
