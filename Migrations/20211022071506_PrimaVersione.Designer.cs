// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using curzi.lorenzo._5h.PrimaWeb.Models;

namespace curzi.lorenzo._5h.PrimaWeb.Migrations
{
    [DbContext(typeof(PersoneContext))]
    [Migration("20211022071506_PrimaVersione")]
    partial class PrimaVersione
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("curzi.lorenzo._5h.PrimaWeb.Models.Persona", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cognome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Persone");
                });
#pragma warning restore 612, 618
        }
    }
}
