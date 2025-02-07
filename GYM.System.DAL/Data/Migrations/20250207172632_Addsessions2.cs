using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYM.System.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class Addsessions2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adminId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sessions_Admin_adminId",
                        column: x => x.adminId,
                        principalTable: "Admin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookingSeessions",
                columns: table => new
                {
                    receptionistId = table.Column<int>(type: "int", nullable: false),
                    playerId = table.Column<int>(type: "int", nullable: false),
                    subscriptionId = table.Column<int>(type: "int", nullable: false),
                    Sessionsid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingSeessions", x => new { x.playerId, x.subscriptionId, x.receptionistId });
                    table.ForeignKey(
                        name: "FK_BookingSeessions_Player_playerId",
                        column: x => x.playerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingSeessions_Receptionist_receptionistId",
                        column: x => x.receptionistId,
                        principalTable: "Receptionist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingSeessions_Sessions_Sessionsid",
                        column: x => x.Sessionsid,
                        principalTable: "Sessions",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_BookingSeessions_Subscription_subscriptionId",
                        column: x => x.subscriptionId,
                        principalTable: "Subscription",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingSeessions_receptionistId",
                table: "BookingSeessions",
                column: "receptionistId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingSeessions_Sessionsid",
                table: "BookingSeessions",
                column: "Sessionsid");

            migrationBuilder.CreateIndex(
                name: "IX_BookingSeessions_subscriptionId",
                table: "BookingSeessions",
                column: "subscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_adminId",
                table: "Sessions",
                column: "adminId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingSeessions");

            migrationBuilder.DropTable(
                name: "Sessions");
        }
    }
}
