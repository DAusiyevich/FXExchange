using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FXExchange.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO ""Currency"" (""ISO"", ""Name"") VALUES
                    ('EUR', 'Euro'),
                    ('USD', 'Amerikanske dollar'),
                    ('GBP', 'Britiske pund'),
                    ('SEK', 'Svenske kroner'),
                    ('NOK', 'Norske kroner'),
                    ('CHF', 'Schweiziske franc'),
                    ('JPY', 'Japanske yen'),
                    ('DKK', 'Danish kroner')
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
