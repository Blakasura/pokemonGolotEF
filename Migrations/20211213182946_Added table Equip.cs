using Microsoft.EntityFrameworkCore.Migrations;

namespace pokemonGolot.Migrations
{
    public partial class AddedtableEquip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gimnasos_Equip_equipnom_equip",
                table: "Gimnasos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jugadors_Equip_equipnom_equip",
                table: "Jugadors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equip",
                table: "Equip");

            migrationBuilder.RenameTable(
                name: "Equip",
                newName: "Equips");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equips",
                table: "Equips",
                column: "nom_equip");

            migrationBuilder.AddForeignKey(
                name: "FK_Gimnasos_Equips_equipnom_equip",
                table: "Gimnasos",
                column: "equipnom_equip",
                principalTable: "Equips",
                principalColumn: "nom_equip",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jugadors_Equips_equipnom_equip",
                table: "Jugadors",
                column: "equipnom_equip",
                principalTable: "Equips",
                principalColumn: "nom_equip",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gimnasos_Equips_equipnom_equip",
                table: "Gimnasos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jugadors_Equips_equipnom_equip",
                table: "Jugadors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equips",
                table: "Equips");

            migrationBuilder.RenameTable(
                name: "Equips",
                newName: "Equip");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equip",
                table: "Equip",
                column: "nom_equip");

            migrationBuilder.AddForeignKey(
                name: "FK_Gimnasos_Equip_equipnom_equip",
                table: "Gimnasos",
                column: "equipnom_equip",
                principalTable: "Equip",
                principalColumn: "nom_equip",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jugadors_Equip_equipnom_equip",
                table: "Jugadors",
                column: "equipnom_equip",
                principalTable: "Equip",
                principalColumn: "nom_equip",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
