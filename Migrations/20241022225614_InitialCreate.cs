using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FXExchange.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ISO = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRate",
                columns: table => new
                {
                    SourceCurrencyId = table.Column<int>(type: "INTEGER", nullable: false),
                    DestinationCurrencyId = table.Column<int>(type: "INTEGER", nullable: false),
                    Rate = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRate", x => new { x.SourceCurrencyId, x.DestinationCurrencyId });
                    table.ForeignKey(
                        name: "FK_ExchangeRate_Currency_DestinationCurrencyId",
                        column: x => x.DestinationCurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExchangeRate_Currency_SourceCurrencyId",
                        column: x => x.SourceCurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeRate_DestinationCurrencyId",
                table: "ExchangeRate",
                column: "DestinationCurrencyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExchangeRate");

            migrationBuilder.DropTable(
                name: "Currency");
        }
    }
}
