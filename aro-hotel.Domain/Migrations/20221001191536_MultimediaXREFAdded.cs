using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aro_hotel.Domain.Migrations
{
    public partial class MultimediaXREFAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Multimedias_Hotels_HotelId",
                table: "Multimedias");

            migrationBuilder.DropForeignKey(
                name: "FK_Multimedias_Rooms_RoomId",
                table: "Multimedias");

            migrationBuilder.DropIndex(
                name: "IX_Multimedias_HotelId",
                table: "Multimedias");

            migrationBuilder.DropIndex(
                name: "IX_Multimedias_RoomId",
                table: "Multimedias");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "Multimedias");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Multimedias");

            migrationBuilder.CreateTable(
                name: "HotelMultimediaXREF",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    MultimediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelMultimediaXREF", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelMultimediaXREF_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HotelMultimediaXREF_Multimedias_MultimediaId",
                        column: x => x.MultimediaId,
                        principalTable: "Multimedias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoomMultimediaXREF",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    MultimediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomMultimediaXREF", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomMultimediaXREF_Multimedias_MultimediaId",
                        column: x => x.MultimediaId,
                        principalTable: "Multimedias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RoomMultimediaXREF_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelMultimediaXREF_HotelId",
                table: "HotelMultimediaXREF",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelMultimediaXREF_MultimediaId",
                table: "HotelMultimediaXREF",
                column: "MultimediaId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomMultimediaXREF_MultimediaId",
                table: "RoomMultimediaXREF",
                column: "MultimediaId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomMultimediaXREF_RoomId",
                table: "RoomMultimediaXREF",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelMultimediaXREF");

            migrationBuilder.DropTable(
                name: "RoomMultimediaXREF");

            migrationBuilder.AddColumn<int>(
                name: "HotelId",
                table: "Multimedias",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Multimedias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Multimedias_HotelId",
                table: "Multimedias",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Multimedias_RoomId",
                table: "Multimedias",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Multimedias_Hotels_HotelId",
                table: "Multimedias",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Multimedias_Rooms_RoomId",
                table: "Multimedias",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }
    }
}
