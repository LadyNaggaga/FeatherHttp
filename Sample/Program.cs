
using System;
using FeatherHttp;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

class Program
{
    static async Task Main(string[] args)
    {
        var app = HttpApplication.Create();

        var routes = app.Router();

        routes.MapGet("/", async context =>
        {
            await context.Response.WriteAsync("Hello World");
        });

        var server = await app.StartServerAsync("http://localhost:3000");

        Console.WriteLine($"Listening on {string.Join(", ", server.Addresses)}");
        Console.ReadLine();
    }
}
