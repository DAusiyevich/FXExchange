using FXExchange.Data;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection().AddDbContext<ExchangeDbContext>();

using (var client = new ExchangeDbContext())
{
    client.Database.EnsureCreated();
}


