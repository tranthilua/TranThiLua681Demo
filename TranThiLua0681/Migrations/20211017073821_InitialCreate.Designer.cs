// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TranThiLua0681.Data;

namespace TranThiLua0681.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211017073821_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("TranThiLua0681.Models.PersonTTL0681", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("INTEGER");

                    b.Property<string>("PersonName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("PersonId");

                    b.ToTable("PersonTTL0681");
                });
#pragma warning restore 612, 618
        }
    }
}
