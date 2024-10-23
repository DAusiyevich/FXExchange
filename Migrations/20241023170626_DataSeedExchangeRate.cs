using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FXExchange.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedExchangeRate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO ""ExchangeRate"" (""SourceCurrencyId"", ""DestinationCurrencyId"", ""Rate"") VALUES
                    ((SELECT ""Id"" FROM ""Currency"" WHERE ""ISO"" = 'EUR'), (SELECT ""Id"" FROM ""Currency"" WHERE ""ISO"" = 'DKK'), 7.4394),
                    ((SELECT ""Id"" FROM ""Currency"" WHERE ""ISO"" = 'USD'), (SELECT ""Id"" FROM ""Currency"" WHERE ""ISO"" = 'DKK'), 6.6311),
                    ((SELECT ""Id"" FROM ""Currency"" WHERE ""ISO"" = 'GBP'), (SELECT ""Id"" FROM ""Currency"" WHERE ""ISO"" = 'DKK'), 8.5285),
                    ((SELECT ""Id"" FROM ""Currency"" WHERE ""ISO"" = 'SEK'), (SELECT ""Id"" FROM ""Currency"" WHERE ""ISO"" = 'DKK'), 0.7610),
                    ((SELECT ""Id"" FROM ""Currency"" WHERE ""ISO"" = 'NOK'), (SELECT ""Id"" FROM ""Currency"" WHERE ""ISO"" = 'DKK'), 0.7840),
                    ((SELECT ""Id"" FROM ""Currency"" WHERE ""ISO"" = 'CHF'), (SELECT ""Id"" FROM ""Currency"" WHERE ""ISO"" = 'DKK'), 6.8358),
                    ((SELECT ""Id"" FROM ""Currency"" WHERE ""ISO"" = 'JPY'), (SELECT ""Id"" FROM ""Currency"" WHERE ""ISO"" = 'DKK'), 0.05974)
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
