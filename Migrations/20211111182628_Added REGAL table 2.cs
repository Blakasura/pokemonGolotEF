using Microsoft.EntityFrameworkCore.Migrations;

namespace pokemonGolot.Migrations
{
    public partial class AddedREGALtable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enviats_Jugadors_jugador_enviatnom_jugador",
                table: "Enviats");

            migrationBuilder.DropForeignKey(
                name: "FK_Enviats_Regals_regalid_jugador_regalid_pokeparada",
                table: "Enviats");

            migrationBuilder.DropIndex(
                name: "IX_Enviats_jugador_enviatnom_jugador",
                table: "Enviats");

            migrationBuilder.DropIndex(
                name: "IX_Enviats_regalid_jugador_regalid_pokeparada",
                table: "Enviats");

            migrationBuilder.DropColumn(
                name: "jugador_enviatnom_jugador",
                table: "Enviats");

            migrationBuilder.DropColumn(
                name: "regalid_jugador",
                table: "Enviats");

            migrationBuilder.DropColumn(
                name: "regalid_pokeparada",
                table: "Enviats");

            migrationBuilder.CreateIndex(
                name: "IX_Enviats_id_jugador_enviat",
                table: "Enviats",
                column: "id_jugador_enviat");

            migrationBuilder.CreateIndex(
                name: "IX_Enviats_id_regal_jugador_id_regal_pokeparada",
                table: "Enviats",
                columns: new[] { "id_regal_jugador", "id_regal_pokeparada" });

            migrationBuilder.AddForeignKey(
                name: "FK_Enviats_Jugadors_id_jugador_enviat",
                table: "Enviats",
                column: "id_jugador_enviat",
                principalTable: "Jugadors",
                principalColumn: "nom_jugador",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enviats_Regals_id_regal_jugador_id_regal_pokeparada",
                table: "Enviats",
                columns: new[] { "id_regal_jugador", "id_regal_pokeparada" },
                principalTable: "Regals",
                principalColumns: new[] { "id_jugador", "id_pokeparada" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enviats_Jugadors_id_jugador_enviat",
                table: "Enviats");

            migrationBuilder.DropForeignKey(
                name: "FK_Enviats_Regals_id_regal_jugador_id_regal_pokeparada",
                table: "Enviats");

            migrationBuilder.DropIndex(
                name: "IX_Enviats_id_jugador_enviat",
                table: "Enviats");

            migrationBuilder.DropIndex(
                name: "IX_Enviats_id_regal_jugador_id_regal_pokeparada",
                table: "Enviats");

            migrationBuilder.AddColumn<string>(
                name: "jugador_enviatnom_jugador",
                table: "Enviats",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "regalid_jugador",
                table: "Enviats",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "regalid_pokeparada",
                table: "Enviats",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enviats_jugador_enviatnom_jugador",
                table: "Enviats",
                column: "jugador_enviatnom_jugador");

            migrationBuilder.CreateIndex(
                name: "IX_Enviats_regalid_jugador_regalid_pokeparada",
                table: "Enviats",
                columns: new[] { "regalid_jugador", "regalid_pokeparada" });

            migrationBuilder.AddForeignKey(
                name: "FK_Enviats_Jugadors_jugador_enviatnom_jugador",
                table: "Enviats",
                column: "jugador_enviatnom_jugador",
                principalTable: "Jugadors",
                principalColumn: "nom_jugador",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enviats_Regals_regalid_jugador_regalid_pokeparada",
                table: "Enviats",
                columns: new[] { "regalid_jugador", "regalid_pokeparada" },
                principalTable: "Regals",
                principalColumns: new[] { "id_jugador", "id_pokeparada" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
