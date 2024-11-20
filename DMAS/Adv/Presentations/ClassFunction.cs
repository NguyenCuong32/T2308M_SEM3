using System.Text.Json;
using Adv.Dtos;
using Adv.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Aptech.t2308m
{
    public class ClassFunction
    {
        private readonly ILogger<ClassFunction> _logger;
        private readonly IClassService classService;

        public ClassFunction(ILogger<ClassFunction> logger, IClassService classService)
        {
            _logger = logger;
            this.classService = classService;
        }

        [Function("GetClassFunction")]
        public IActionResult GetClassRun([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            var classes = this.classService.GetClasses();
            return new OkObjectResult(classes);
        }
        [Function("CreateClassFunction")]
        public async Task<IActionResult> CreateClassRun([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            var content = await new StreamReader(req.Body).ReadToEndAsync();
            var classDto = JsonSerializer.Deserialize<AddClassDto>(content);
            this.classService.AddClass(classDto);
            return new OkObjectResult("Add class successfull");
        }
    }
}
