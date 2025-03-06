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

        public DCComicsHeroes(ILogger<DCComicsHeroes> logger)
        {
            _logger = logger;
        }

        //[Function("DCComicsHeroes")]
        //public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        //{
        //    _logger.LogInformation("C# HTTP trigger function processed a request.");
        //    return new OkObjectResult("Welcome to Azure Functions!");
        //}

        [Function("GetDCComicsCharacters")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req
                )
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var dcComics = new[]
            {
            new
            {
                title = "Batman",
                real_name = "Bruce Wayne",
                abilities = new[] { "Martial arts", "Detective skills", "High intelligence", "Peak human conditioning" },
                team_affiliations = new[] { "Justice League", "Bat Family" },
                city = "Gotham City",
                publisher = "DC Comics"
            },
            new
            {
                title = "Superman",
                real_name = "Clark Kent",
                abilities = new[] { "Super strength", "Flight", "Invulnerability", "Heat vision", "X-ray vision", "Super speed" },
                team_affiliations = new[] { "Justice League", "Super Family" },
                city = "Metropolis",
                publisher = "DC Comics"
            },
            new
            {
                title = "Wonder Woman",
                real_name = "Diana Prince",
                abilities = new[] { "Super strength", "Flight", "Combat skills", "Lasso of Truth", "Indestructible bracelets" },
                team_affiliations = new[] { "Justice League", "Amazons" },
                city = "Themyscira",
                publisher = "DC Comics"
            },
            new
            {
                title = "The Flash",
                real_name = "Barry Allen",
                abilities = new[] { "Super speed", "Time travel", "Intangibility", "Electrokinesis" },
                team_affiliations = new[] { "Justice League", "Flash Family" },
                city = "Central City",
                publisher = "DC Comics"
            },
            new
            {
                title = "Aquaman",
                real_name = "Arthur Curry",
                abilities = new[] { "Super strength", "Water manipulation", "Telepathy with marine life", "Underwater breathing" },
                team_affiliations = new[] { "Justice League", "Atlanteans" },
                city = "Atlantis",
                publisher = "DC Comics"
            },
            new
            {
                title = "Green Lantern",
                real_name = "Hal Jordan",
                abilities = new[] { "Power ring", "Flight", "Energy constructs", "Force fields" },
                team_affiliations = new[] { "Justice League", "Green Lantern Corps" },
                city = "Coast City",
                publisher = "DC Comics"
            },
            new
            {
                title = "Cyborg",
                real_name = "Victor Stone",
                abilities = new[] { "Super strength", "Advanced technology", "Cybernetic enhancements", "Technopathy" },
                team_affiliations = new[] { "Justice League", "Teen Titans" },
                city = "Detroit",
                publisher = "DC Comics"
            },
            new
            {
                title = "Martian Manhunter",
                real_name = "J'onn J'onzz",
                abilities = new[] { "Shape-shifting", "Telepathy", "Super strength", "Flight", "Intangibility", "Martian vision" },
                team_affiliations = new[] { "Justice League", "Martians" },
                city = "Mars",
                publisher = "DC Comics"
            },
            new
            {
                title = "Green Arrow",
                real_name = "Oliver Queen",
                abilities = new[] { "Archery", "Martial arts", "Tactics", "High intelligence" },
                team_affiliations = new[] { "Justice League", "Team Arrow" },
                city = "Star City",
                publisher = "DC Comics"
            },
            new
            {
                title = "Shazam",
                real_name = "Billy Batson",
                abilities = new[] { "Super strength", "Flight", "Magic", "Electrokinesis", "Wisdom of Solomon" },
                team_affiliations = new[] { "Justice League", "Shazam Family" },
                city = "Fawcett City",
                publisher = "DC Comics"
            }
        };

            var json = JsonConvert.SerializeObject(dcComics);

            return new OkObjectResult(json);
        }
    }
}
