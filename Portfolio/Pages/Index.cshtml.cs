using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio;

namespace Portfolio.Pages
{
    public class IndexModel : PageModel
    {
        public Project[] Projects { get; set; } = default!;
        public Skill[] Skills { get; set; } = default!;
        public Education[] Educations { get; set; } = default!;

        // Contact form fields bound to the POST request
        [BindProperty]
        public string ContactName { get; set; } = string.Empty;

        [BindProperty]
        public string ContactEmail { get; set; } = string.Empty;

        [BindProperty]
        public string ContactMessage { get; set; } = string.Empty;

        public bool FormSubmitted { get; set; } = false;

        public void OnGet()
        {
            LoadPageData();
        }

        public IActionResult OnPost()
        {
            LoadPageData();

            if (string.IsNullOrWhiteSpace(ContactName) ||
                string.IsNullOrWhiteSpace(ContactEmail) ||
                string.IsNullOrWhiteSpace(ContactMessage))
            {
                ModelState.AddModelError(string.Empty, "All fields are required.");
                return Page();
            }

            // TODO: In production, send an email or save to a database here.
            // For now we just flag success so the page can show a confirmation.
            FormSubmitted = true;

            // Clear form fields after successful submission
            ContactName = string.Empty;
            ContactEmail = string.Empty;
            ContactMessage = string.Empty;

            return Page();
        }

        private void LoadPageData()
        {
            Projects = new Project[]
            {
                new Project
                {
                    Title       = "Genesis Engine",
                    Description = "An AI-native game engine where inference runs as physics. Features NPC Soul Schemas, consequence propagation, player legacy systems, and background world simulation — all powered by local LLM inference.",
                    Year        = 2025,
                    TechStack   = new[] { "Rust", "Python", "SGLang", "Qwen3-8B" },
                    GitHubUrl   = null  // Not yet public
                },
                new Project
                {
                    Title       = "Ascendant's Tower",
                    Description = "An infinite roguelite tower defense MMO built on the Genesis Engine. NPCs don't respawn, every player action has permanent consequences, and the world evolves autonomously.",
                    Year        = 2025,
                    TechStack   = new[] { "Rust", "Unreal Engine", "Genesis Engine" },
                    GitHubUrl   = null  // Not yet public
                },
                new Project
                {
                    Title       = "Atmospheric Harvester",
                    Description = "A dynamic resource management and farming game powered by real-time weather data. Harvest energy, water, and biomass on a floating sky-island with weather pulled from NWS and Open-Meteo APIs.",
                    Year        = 2025,
                    TechStack   = new[] { "Python", "Pygame-CE", "aiohttp", "NWS API", "Open-Meteo" },
                    GitHubUrl   = "https://github.com/feotro23/Atmospheric-Harvester"
                }
            };

            Skills = new Skill[]
            {
                new Skill { Name = "C# / .NET",                  Category = "Languages",      ProficiencyLevel = 2 },
                new Skill { Name = "Python",                      Category = "Languages",      ProficiencyLevel = 4 },
                new Skill { Name = "Rust",                        Category = "Languages",      ProficiencyLevel = 3 },
                new Skill { Name = "JavaScript",                  Category = "Languages",      ProficiencyLevel = 1 },
                new Skill { Name = "HTML / CSS",                  Category = "Frontend",       ProficiencyLevel = 2 },
                new Skill { Name = "SQL",                         Category = "Data",           ProficiencyLevel = 2 },
                new Skill { Name = "Git / GitHub",                Category = "Tools",          ProficiencyLevel = 4 },
                new Skill { Name = "Pygame",                      Category = "Frameworks",     ProficiencyLevel = 3 },
                new Skill { Name = "ASP.NET Core",                Category = "Frameworks",     ProficiencyLevel = 2 },
                new Skill { Name = "AI Integration (SGLang/LLMs)",Category = "AI / ML",        ProficiencyLevel = 2 }
            };

            Educations = new Education[]
            {
                new Education
                {
                    Institution  = "Minneapolis College",
                    Degree       = "Android Mobile Developer",
                    FieldOfStudy = "Information Technology",
                    StartYear    = 2025,
                    EndYear      = null,
                    Highlights   = new[]
                    {
                        "Systems Analysis & Design",
                        "Software Development",
                        "Cloud Technologies"
                    }
                }
            };
        }
    }
}