// <auto-generated />
using Maria_Magdalena.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Maria_Magdalena.Migrations
{
    [DbContext(typeof(Maria_MagdalenaContext))]
    partial class Maria_MagdalenaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Maria_Magdalena.Models.Angajat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartamentID");

                    b.Property<int>("ManagerID");

                    b.Property<string>("numeangajat")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("post")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("ID");

                    b.HasIndex("DepartamentID");

                    b.HasIndex("ManagerID");

                    b.ToTable("Angajat");
                });

            modelBuilder.Entity("Maria_Magdalena.Models.Departament", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dept")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("ID");

                    b.ToTable("Departament");
                });

            modelBuilder.Entity("Maria_Magdalena.Models.Manager", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("numemanager")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("ID");

                    b.ToTable("Manager");
                });

            modelBuilder.Entity("Maria_Magdalena.Models.ManDept", b =>
                {
                    b.Property<int>("ManDeptID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AngajatID");

                    b.Property<int>("DepartamentID");

                    b.Property<int>("ManagerID");

                    b.HasKey("ManDeptID");

                    b.HasIndex("DepartamentID");

                    b.HasIndex("ManagerID");

                    b.ToTable("ManDept");
                });

            modelBuilder.Entity("Maria_Magdalena.Models.Angajat", b =>
                {
                    b.HasOne("Maria_Magdalena.Models.Departament", "Departament")
                        .WithMany("Angajat")
                        .HasForeignKey("DepartamentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Maria_Magdalena.Models.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Maria_Magdalena.Models.ManDept", b =>
                {
                    b.HasOne("Maria_Magdalena.Models.Departament", "Departament")
                        .WithMany()
                        .HasForeignKey("DepartamentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Maria_Magdalena.Models.Manager", "Manager")
                        .WithMany("ManDept")
                        .HasForeignKey("ManagerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
