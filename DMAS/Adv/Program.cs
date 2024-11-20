using Adv.Repositories;
using Adv.Services;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

internal class Program
{
    private static void Main(string[] args)
    {
         IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        var builder = FunctionsApplication.CreateBuilder(args);
        builder.Services.AddDbContext<EduDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("EduConnect"))
        );
        builder.Services.AddSingleton<IClassRepository,ClassRepository>();
        builder.Services.AddScoped<IClassService,ClassService>();
        builder.ConfigureFunctionsWebApplication();

        // Application Insights isn't enabled by default. See https://aka.ms/AAt8mw4.
        // builder.Services
        //     .AddApplicationInsightsTelemetryWorkerService()
        //     .ConfigureFunctionsApplicationInsights();

        builder.Build().Run();
    }
}