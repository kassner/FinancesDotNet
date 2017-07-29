using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FinancesDotNet.Models;

namespace FinancesDotNet.Migrations
{
    [DbContext(typeof(FinancesDotNetContext))]
    partial class FinancesDotNetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinancesDotNet.Models.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("FinancesDotNet.Models.Payee", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Name");

                b.HasKey("ID");

                b.ToTable("Payee");
            });
        }
    }
}
