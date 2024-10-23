using FXExchange.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection().AddDbContext<ExchangeDbContext>();

using (var context = new ExchangeDbContext())
{
    //Migration step added so it would be easier to run locally
    context.Database.Migrate();
}


