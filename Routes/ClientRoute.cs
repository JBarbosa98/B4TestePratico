using B4TestePratico.Data;
using B4TestePratico.Models;
using B4TestePratico.Requests;
using Microsoft.EntityFrameworkCore;
using AppContext = B4TestePratico.Data.AppContext;

namespace B4TestePratico.Routes
{
    public static class ClientRoute
    {
        public static void ClientRoutes(this WebApplication app)
        {

            var route = app.MapGroup("client");

            route.MapGet("",async (AppContext context) =>
            {
                var clients = await context.Client.ToListAsync();
                return Results.Ok(clients);
            }); 

            route.MapPost("",
                async (ClientRequest req, AppContext context) => {
                    var client = new Client(req.name);
                    await context.AddAsync(client);
                    await context.SaveChangesAsync();

            });

            route.MapPut("{id:guid}",async (Guid id, ClientRequest req, AppContext context) => {
                var client = await context.Client.FirstOrDefaultAsync(x => x.IdClient == id);

                if (client == null)
                    return Results.NotFound(client);

                client.Name = req.name;

                await context.SaveChangesAsync();
                return Results.Ok(client);
            });

            route.MapDelete("{id:guid}", async (Guid id,AppContext context) =>
            {

                var client = await context.Client.FirstOrDefaultAsync(x => x.IdClient == id);

                if (client == null)
                    return Results.NotFound(client);

                client.Name = "desativado";

                await context.SaveChangesAsync();
                return Results.Ok(client);
            });
        }
    }
}
