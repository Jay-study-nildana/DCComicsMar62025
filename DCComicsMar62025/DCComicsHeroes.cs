using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DCComicsMar62025
{
    public class DCComicsHeroes
    {
        private readonly ILogger<DCComicsHeroes> _logger;
        private readonly string _dcComicsJsonHeroes;

        public DCComicsHeroes(ILogger<DCComicsHeroes> logger)
        {
            _logger = logger;
            _dcComicsJsonHeroes = DCComicsData.GetDCComicsJsonHeroes();
        }

        [Function("GetDCComicsCharacters")]
        public async Task<IActionResult> GetDCComicsCharacters(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult(_dcComicsJsonHeroes);
        }
    }
}
