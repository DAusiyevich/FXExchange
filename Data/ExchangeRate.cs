namespace FXExchange.Data
{
    public class ExchangeRate
    {
        public int SourceCurrencyId { get; set; }
        public int DestinationCurrencyId { get; set; }
        public decimal Rate { get; set; }
    }
}
