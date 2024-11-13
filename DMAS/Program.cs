using DMAS;
using Microsoft.Azure.Functions.Worker;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices(services => {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
        services.AddDbContext<AppDbContext>(options=>options.UseSqlServer(configuration.GetConnectionString("EduGreenConnection")));
    })
    .Build();

host.Run();