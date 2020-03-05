using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetEmploi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Batiment",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batiment", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Groupe",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groupe", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TypeSeance",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Intitule = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeSeance", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(nullable: true),
                    Intitule = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Salle",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true),
                    BatimentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salle", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Salle_Batiment_BatimentID",
                        column: x => x.BatimentID,
                        principalTable: "Batiment",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seance",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jour = table.Column<DateTime>(nullable: false),
                    HeureDebut = table.Column<DateTime>(nullable: false),
                    Duree = table.Column<int>(nullable: false),
                    UEID = table.Column<int>(nullable: false),
                    TypeSeanceID = table.Column<int>(nullable: false),
                    SalleID = table.Column<int>(nullable: false),
                    GroupeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seance", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Seance_Groupe_GroupeID",
                        column: x => x.GroupeID,
                        principalTable: "Groupe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seance_Salle_SalleID",
                        column: x => x.SalleID,
                        principalTable: "Salle",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seance_TypeSeance_TypeSeanceID",
                        column: x => x.TypeSeanceID,
                        principalTable: "TypeSeance",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seance_UE_UEID",
                        column: x => x.UEID,
                        principalTable: "UE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Salle_BatimentID",
                table: "Salle",
                column: "BatimentID");

            migrationBuilder.CreateIndex(
                name: "IX_Seance_GroupeID",
                table: "Seance",
                column: "GroupeID");

            migrationBuilder.CreateIndex(
                name: "IX_Seance_SalleID",
                table: "Seance",
                column: "SalleID");

            migrationBuilder.CreateIndex(
                name: "IX_Seance_TypeSeanceID",
                table: "Seance",
                column: "TypeSeanceID");

            migrationBuilder.CreateIndex(
                name: "IX_Seance_UEID",
                table: "Seance",
                column: "UEID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seance");

            migrationBuilder.DropTable(
                name: "Groupe");

            migrationBuilder.DropTable(
                name: "Salle");

            migrationBuilder.DropTable(
                name: "TypeSeance");

            migrationBuilder.DropTable(
                name: "UE");

            migrationBuilder.DropTable(
                name: "Batiment");
        }
    }
}
