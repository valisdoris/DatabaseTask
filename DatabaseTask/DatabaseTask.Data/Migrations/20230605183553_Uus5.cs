using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    public partial class Uus5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ametinimetus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimetus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KasutuselAlates = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KasutuselKuni = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ametinimetus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Isik",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perekonnanimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sugu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sünniaeg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Isikukood = table.Column<int>(type: "int", nullable: false),
                    KontaktTelefon = table.Column<int>(type: "int", nullable: false),
                    KontaktAadress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Isik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ligipääsuliik",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimetus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alguskuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lõppkuupäev = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ligipääsuliik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Puhkuseliik",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimetus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiikKasutuses = table.Column<bool>(type: "bit", nullable: false),
                    PuhkusepäevadeArv = table.Column<int>(type: "int", nullable: false),
                    MKommentaar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puhkuseliik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Riik",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimetus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Riik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Väljamakseliik",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimetus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiikKasutuses = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Väljamakseliik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TöötajaNumber = table.Column<int>(type: "int", nullable: false),
                    IsikId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LepinguNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TöösuhteAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TöösuheKehtiv = table.Column<bool>(type: "bit", nullable: false),
                    TöösuhteLõpp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TööTelefon = table.Column<int>(type: "int", nullable: false),
                    TööEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kontonumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TulumaksuvabaSumma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Isik_IsikId",
                        column: x => x.IsikId,
                        principalTable: "Isik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Firma",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegKood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiikId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kontakttelefon = table.Column<int>(type: "int", nullable: false),
                    KontaktEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Firma_Riik_RiikId",
                        column: x => x.RiikId,
                        principalTable: "Riik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Haigusleht",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Liik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaigestumiseAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HaigestumiseLõpp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Esmane_Järgenev = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haigusleht", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Haigusleht_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Koolitus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimetus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AlgusKp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LõppKp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KoolituseAndmed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Koolitus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Koolitus_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Palk",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Arvestuskuu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArvestatudSumma = table.Column<int>(type: "int", nullable: false),
                    TulumaksuvabaMin = table.Column<int>(type: "int", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KinnipeetudTm = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Väljamakse = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VäljamakseKp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kontonumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palk", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Palk_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Puhkus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PuhkuseliikId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PuhkuseAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PuhkuseLõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VäljamaksePalgaga = table.Column<bool>(type: "bit", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puhkus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Puhkus_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Puhkus_Puhkuseliik_PuhkuseliikId",
                        column: x => x.PuhkuseliikId,
                        principalTable: "Puhkuseliik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tervisekontroll",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TerviseKontrolliKP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Meditsiiniasutus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KahjulikudTegurid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tervisekontroll", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tervisekontroll_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tööleping",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Alguskuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lõppkuupäev = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KoostamiseKp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LepinguLiik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Töökoormus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TöölepinguLisaNumber = table.Column<int>(type: "int", nullable: true),
                    Töötasu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tööleping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tööleping_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TöötajaAmetinimetus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Alguskuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lõppkuupäev = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AmetinimetusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TöötajaAmetinimetus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TöötajaAmetinimetus_Ametinimetus_AmetinimetusId",
                        column: x => x.AmetinimetusId,
                        principalTable: "Ametinimetus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TöötajaAmetinimetus_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TöötajaLaps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TöötajaLaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TöötajaLaps_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TöötajaLigipääs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LigipääsuliikId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KehtivAlates = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KehtivKuni = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TöötajaLigipääs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TöötajaLigipääs_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TöötajaLigipääs_Ligipääsuliik_LigipääsuliikId",
                        column: x => x.LigipääsuliikId,
                        principalTable: "Ligipääsuliik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TöötajaPalve",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sisu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LisamiseAeg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TöötajaPalve", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TöötajaPalve_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Harukontor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirmaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegKood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kontakttelefon = table.Column<int>(type: "int", nullable: false),
                    KontaktEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harukontor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Harukontor_Firma_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vihje",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SaatmiseAeg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sisu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vihje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vihje_Firma_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tööajakava",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TöölepingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PerioodiAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PerioodiLõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TöötatudTunnid = table.Column<int>(type: "int", nullable: false),
                    Valveaeg = table.Column<int>(type: "int", nullable: false),
                    Ületunnid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tööajakava", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tööajakava_Tööleping_TöölepingId",
                        column: x => x.TöölepingId,
                        principalTable: "Tööleping",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LaenutatavEse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimetus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AsjaKood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LaenutusesAlates = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LaenutusesKuni = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HarukontorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaenutatavEse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LaenutatavEse_Harukontor_HarukontorId",
                        column: x => x.HarukontorId,
                        principalTable: "Harukontor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Osakond",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimetus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HarukontorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aktiivne = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osakond", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Osakond_Harukontor_HarukontorId",
                        column: x => x.HarukontorId,
                        principalTable: "Harukontor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PalgaarvestuseRead",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VäljamakseliikId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PalgaarvestuseSumma = table.Column<int>(type: "int", nullable: false),
                    PuhkusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HaiguslehtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PalkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TööajakavaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PalgaarvestuseRead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PalgaarvestuseRead_Haigusleht_HaiguslehtId",
                        column: x => x.HaiguslehtId,
                        principalTable: "Haigusleht",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PalgaarvestuseRead_Palk_PalkId",
                        column: x => x.PalkId,
                        principalTable: "Palk",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PalgaarvestuseRead_Puhkus_PuhkusId",
                        column: x => x.PuhkusId,
                        principalTable: "Puhkus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PalgaarvestuseRead_Tööajakava_TööajakavaId",
                        column: x => x.TööajakavaId,
                        principalTable: "Tööajakava",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PalgaarvestuseRead_Väljamakseliik_VäljamakseliikId",
                        column: x => x.VäljamakseliikId,
                        principalTable: "Väljamakseliik",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Laenutus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LaenutatavEseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LaenutuseAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LaenutuseLõpp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laenutus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laenutus_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Laenutus_LaenutatavEse_LaenutatavEseId",
                        column: x => x.LaenutatavEseId,
                        principalTable: "LaenutatavEse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Osakonnajuht",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OsakondId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JuhtAlates = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JuhtKuni = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osakonnajuht", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Osakonnajuht_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Osakonnajuht_Osakond_OsakondId",
                        column: x => x.OsakondId,
                        principalTable: "Osakond",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OsakonnaTöötaja",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OsakondId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TöötabAlates = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TöötabKuni = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OsakonnaTöötaja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OsakonnaTöötaja_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OsakonnaTöötaja_Osakond_OsakondId",
                        column: x => x.OsakondId,
                        principalTable: "Osakond",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_IsikId",
                table: "Employee",
                column: "IsikId");

            migrationBuilder.CreateIndex(
                name: "IX_Firma_RiikId",
                table: "Firma",
                column: "RiikId");

            migrationBuilder.CreateIndex(
                name: "IX_Haigusleht_EmployeeId",
                table: "Haigusleht",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Harukontor_FirmaId",
                table: "Harukontor",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Koolitus_EmployeeId",
                table: "Koolitus",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LaenutatavEse_HarukontorId",
                table: "LaenutatavEse",
                column: "HarukontorId");

            migrationBuilder.CreateIndex(
                name: "IX_Laenutus_EmployeeId",
                table: "Laenutus",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Laenutus_LaenutatavEseId",
                table: "Laenutus",
                column: "LaenutatavEseId");

            migrationBuilder.CreateIndex(
                name: "IX_Osakond_HarukontorId",
                table: "Osakond",
                column: "HarukontorId");

            migrationBuilder.CreateIndex(
                name: "IX_Osakonnajuht_EmployeeId",
                table: "Osakonnajuht",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Osakonnajuht_OsakondId",
                table: "Osakonnajuht",
                column: "OsakondId");

            migrationBuilder.CreateIndex(
                name: "IX_OsakonnaTöötaja_EmployeeId",
                table: "OsakonnaTöötaja",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OsakonnaTöötaja_OsakondId",
                table: "OsakonnaTöötaja",
                column: "OsakondId");

            migrationBuilder.CreateIndex(
                name: "IX_PalgaarvestuseRead_HaiguslehtId",
                table: "PalgaarvestuseRead",
                column: "HaiguslehtId");

            migrationBuilder.CreateIndex(
                name: "IX_PalgaarvestuseRead_PalkId",
                table: "PalgaarvestuseRead",
                column: "PalkId");

            migrationBuilder.CreateIndex(
                name: "IX_PalgaarvestuseRead_PuhkusId",
                table: "PalgaarvestuseRead",
                column: "PuhkusId");

            migrationBuilder.CreateIndex(
                name: "IX_PalgaarvestuseRead_TööajakavaId",
                table: "PalgaarvestuseRead",
                column: "TööajakavaId");

            migrationBuilder.CreateIndex(
                name: "IX_PalgaarvestuseRead_VäljamakseliikId",
                table: "PalgaarvestuseRead",
                column: "VäljamakseliikId");

            migrationBuilder.CreateIndex(
                name: "IX_Palk_EmployeeId",
                table: "Palk",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Puhkus_EmployeeId",
                table: "Puhkus",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Puhkus_PuhkuseliikId",
                table: "Puhkus",
                column: "PuhkuseliikId");

            migrationBuilder.CreateIndex(
                name: "IX_Tervisekontroll_EmployeeId",
                table: "Tervisekontroll",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tööajakava_TöölepingId",
                table: "Tööajakava",
                column: "TöölepingId");

            migrationBuilder.CreateIndex(
                name: "IX_Tööleping_EmployeeId",
                table: "Tööleping",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TöötajaAmetinimetus_AmetinimetusId",
                table: "TöötajaAmetinimetus",
                column: "AmetinimetusId");

            migrationBuilder.CreateIndex(
                name: "IX_TöötajaAmetinimetus_EmployeeId",
                table: "TöötajaAmetinimetus",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TöötajaLaps_EmployeeId",
                table: "TöötajaLaps",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TöötajaLigipääs_EmployeeId",
                table: "TöötajaLigipääs",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TöötajaLigipääs_LigipääsuliikId",
                table: "TöötajaLigipääs",
                column: "LigipääsuliikId");

            migrationBuilder.CreateIndex(
                name: "IX_TöötajaPalve_EmployeeId",
                table: "TöötajaPalve",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vihje_FirmaId",
                table: "Vihje",
                column: "FirmaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Koolitus");

            migrationBuilder.DropTable(
                name: "Laenutus");

            migrationBuilder.DropTable(
                name: "Osakonnajuht");

            migrationBuilder.DropTable(
                name: "OsakonnaTöötaja");

            migrationBuilder.DropTable(
                name: "PalgaarvestuseRead");

            migrationBuilder.DropTable(
                name: "Tervisekontroll");

            migrationBuilder.DropTable(
                name: "TöötajaAmetinimetus");

            migrationBuilder.DropTable(
                name: "TöötajaLaps");

            migrationBuilder.DropTable(
                name: "TöötajaLigipääs");

            migrationBuilder.DropTable(
                name: "TöötajaPalve");

            migrationBuilder.DropTable(
                name: "Vihje");

            migrationBuilder.DropTable(
                name: "LaenutatavEse");

            migrationBuilder.DropTable(
                name: "Osakond");

            migrationBuilder.DropTable(
                name: "Haigusleht");

            migrationBuilder.DropTable(
                name: "Palk");

            migrationBuilder.DropTable(
                name: "Puhkus");

            migrationBuilder.DropTable(
                name: "Tööajakava");

            migrationBuilder.DropTable(
                name: "Väljamakseliik");

            migrationBuilder.DropTable(
                name: "Ametinimetus");

            migrationBuilder.DropTable(
                name: "Ligipääsuliik");

            migrationBuilder.DropTable(
                name: "Harukontor");

            migrationBuilder.DropTable(
                name: "Puhkuseliik");

            migrationBuilder.DropTable(
                name: "Tööleping");

            migrationBuilder.DropTable(
                name: "Firma");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Riik");

            migrationBuilder.DropTable(
                name: "Isik");
        }
    }
}
