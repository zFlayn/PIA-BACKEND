// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiCasino;

#nullable disable

namespace WebApiCasino.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PremioRifa", b =>
                {
                    b.Property<int>("PremiosId")
                        .HasColumnType("int");

                    b.Property<int>("RifasId")
                        .HasColumnType("int");

                    b.HasKey("PremiosId", "RifasId");

                    b.HasIndex("RifasId");

                    b.ToTable("PremioRifa");
                });

            modelBuilder.Entity("WebApiCasino.Entidades.Carta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cartas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CartaId = 1,
                            Nombre = "El Gallo "
                        },
                        new
                        {
                            Id = 2,
                            CartaId = 2,
                            Nombre = "El Diablo "
                        },
                        new
                        {
                            Id = 3,
                            CartaId = 3,
                            Nombre = "La Dama "
                        },
                        new
                        {
                            Id = 4,
                            CartaId = 4,
                            Nombre = "El Catrin "
                        },
                        new
                        {
                            Id = 5,
                            CartaId = 5,
                            Nombre = "El Paraguas "
                        },
                        new
                        {
                            Id = 6,
                            CartaId = 6,
                            Nombre = "La Sirena "
                        },
                        new
                        {
                            Id = 7,
                            CartaId = 7,
                            Nombre = "La Escalera "
                        },
                        new
                        {
                            Id = 8,
                            CartaId = 8,
                            Nombre = "La Botella "
                        },
                        new
                        {
                            Id = 9,
                            CartaId = 9,
                            Nombre = "El Barril "
                        },
                        new
                        {
                            Id = 10,
                            CartaId = 10,
                            Nombre = "El Arbol "
                        },
                        new
                        {
                            Id = 11,
                            CartaId = 11,
                            Nombre = "El Melon "
                        },
                        new
                        {
                            Id = 12,
                            CartaId = 12,
                            Nombre = "El Valiente "
                        },
                        new
                        {
                            Id = 13,
                            CartaId = 13,
                            Nombre = "El Gorrito "
                        },
                        new
                        {
                            Id = 14,
                            CartaId = 14,
                            Nombre = "La Muerte "
                        },
                        new
                        {
                            Id = 15,
                            CartaId = 15,
                            Nombre = "La Pera "
                        },
                        new
                        {
                            Id = 16,
                            CartaId = 16,
                            Nombre = "La Bandera "
                        },
                        new
                        {
                            Id = 17,
                            CartaId = 17,
                            Nombre = "El Bandolon "
                        },
                        new
                        {
                            Id = 18,
                            CartaId = 18,
                            Nombre = "El Violoncello "
                        },
                        new
                        {
                            Id = 19,
                            CartaId = 19,
                            Nombre = "La Garza "
                        },
                        new
                        {
                            Id = 20,
                            CartaId = 20,
                            Nombre = "El Pajaro "
                        },
                        new
                        {
                            Id = 21,
                            CartaId = 21,
                            Nombre = "La Mano "
                        },
                        new
                        {
                            Id = 22,
                            CartaId = 22,
                            Nombre = "La Bota "
                        },
                        new
                        {
                            Id = 23,
                            CartaId = 23,
                            Nombre = "La Luna "
                        },
                        new
                        {
                            Id = 24,
                            CartaId = 24,
                            Nombre = "El Cotorro "
                        },
                        new
                        {
                            Id = 25,
                            CartaId = 25,
                            Nombre = "El Borracho "
                        },
                        new
                        {
                            Id = 26,
                            CartaId = 26,
                            Nombre = "El Negrito "
                        },
                        new
                        {
                            Id = 27,
                            CartaId = 27,
                            Nombre = "El Corazon "
                        },
                        new
                        {
                            Id = 28,
                            CartaId = 28,
                            Nombre = "La Sandia "
                        },
                        new
                        {
                            Id = 29,
                            CartaId = 29,
                            Nombre = "El Tambor "
                        },
                        new
                        {
                            Id = 30,
                            CartaId = 30,
                            Nombre = "El Camaron "
                        },
                        new
                        {
                            Id = 31,
                            CartaId = 31,
                            Nombre = "Las Jaras "
                        },
                        new
                        {
                            Id = 32,
                            CartaId = 32,
                            Nombre = "El Musico "
                        },
                        new
                        {
                            Id = 33,
                            CartaId = 33,
                            Nombre = "La Araña "
                        },
                        new
                        {
                            Id = 34,
                            CartaId = 34,
                            Nombre = "El Soldado "
                        },
                        new
                        {
                            Id = 35,
                            CartaId = 35,
                            Nombre = "La Estrella "
                        },
                        new
                        {
                            Id = 36,
                            CartaId = 36,
                            Nombre = "El Cazo "
                        },
                        new
                        {
                            Id = 37,
                            CartaId = 37,
                            Nombre = "El Mundo "
                        },
                        new
                        {
                            Id = 38,
                            CartaId = 38,
                            Nombre = "El Apache "
                        },
                        new
                        {
                            Id = 39,
                            CartaId = 39,
                            Nombre = "El Nopal "
                        },
                        new
                        {
                            Id = 40,
                            CartaId = 40,
                            Nombre = "El Alacran "
                        },
                        new
                        {
                            Id = 41,
                            CartaId = 41,
                            Nombre = "La Rosa "
                        },
                        new
                        {
                            Id = 42,
                            CartaId = 42,
                            Nombre = "La Calavera "
                        },
                        new
                        {
                            Id = 43,
                            CartaId = 43,
                            Nombre = "La Campana "
                        },
                        new
                        {
                            Id = 44,
                            CartaId = 44,
                            Nombre = "El Cantarito "
                        },
                        new
                        {
                            Id = 45,
                            CartaId = 45,
                            Nombre = "El Venado "
                        },
                        new
                        {
                            Id = 46,
                            CartaId = 46,
                            Nombre = "El Sol "
                        },
                        new
                        {
                            Id = 47,
                            CartaId = 47,
                            Nombre = "La Corona "
                        },
                        new
                        {
                            Id = 48,
                            CartaId = 48,
                            Nombre = "La Chalupa "
                        },
                        new
                        {
                            Id = 49,
                            CartaId = 49,
                            Nombre = "El Pino "
                        },
                        new
                        {
                            Id = 50,
                            CartaId = 50,
                            Nombre = "El Pescado "
                        },
                        new
                        {
                            Id = 51,
                            CartaId = 51,
                            Nombre = "La Palma "
                        },
                        new
                        {
                            Id = 52,
                            CartaId = 52,
                            Nombre = "La Maceta "
                        },
                        new
                        {
                            Id = 53,
                            CartaId = 53,
                            Nombre = "El Arpa "
                        },
                        new
                        {
                            Id = 54,
                            CartaId = 54,
                            Nombre = "El Rana "
                        });
                });

            modelBuilder.Entity("WebApiCasino.Entidades.Premio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Lugar")
                        .HasColumnType("int");

                    b.Property<string>("Recompensa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Premios");
                });

            modelBuilder.Entity("WebApiCasino.Entidades.Rifa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rifas");
                });

            modelBuilder.Entity("WebApiCasino.Entidades.RifaParticipante", b =>
                {
                    b.Property<int>("RifaParticipanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RifaParticipanteId"), 1L, 1);

                    b.Property<int>("CartaRefId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ParticipanteRefId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RifaNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RifaRefId")
                        .HasColumnType("int");

                    b.HasKey("RifaParticipanteId");

                    b.HasIndex("CartaRefId");

                    b.HasIndex("ParticipanteRefId");

                    b.HasIndex("RifaRefId");

                    b.ToTable("RifaParticipantes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PremioRifa", b =>
                {
                    b.HasOne("WebApiCasino.Entidades.Premio", null)
                        .WithMany()
                        .HasForeignKey("PremiosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiCasino.Entidades.Rifa", null)
                        .WithMany()
                        .HasForeignKey("RifasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiCasino.Entidades.RifaParticipante", b =>
                {
                    b.HasOne("WebApiCasino.Entidades.Carta", "Carta")
                        .WithMany()
                        .HasForeignKey("CartaRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Participante")
                        .WithMany()
                        .HasForeignKey("ParticipanteRefId");

                    b.HasOne("WebApiCasino.Entidades.Rifa", "Rifa")
                        .WithMany("RifaParticipantes")
                        .HasForeignKey("RifaRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carta");

                    b.Navigation("Participante");

                    b.Navigation("Rifa");
                });

            modelBuilder.Entity("WebApiCasino.Entidades.Rifa", b =>
                {
                    b.Navigation("RifaParticipantes");
                });
#pragma warning restore 612, 618
        }
    }
}
