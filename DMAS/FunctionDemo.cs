using DMAS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FPTAptech.T2308M
{
    public class FunctionDemo
    {
        private readonly ILogger<FunctionDemo> _logger;
        private readonly AppDbContext appDbContext;

        public FunctionDemo(ILogger<FunctionDemo> logger,AppDbContext appDbContext)
        {
            _logger = logger;
            this.appDbContext = appDbContext;
        }

        [Function("FunctionDemo")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post",Route ="demo/{id:int?}")] HttpRequest req,int id)
        {
            var request = req.Body;
            System.Console.WriteLine($"Id {id}");
            System.Console.WriteLine($"Body {request}");
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            var classes = this.appDbContext.Classes.ToList();
            foreach (var c in classes)
            {
                System.Console.WriteLine(c.ClassName);
            }
            return new OkObjectResult(classes);
        }
    }
}
