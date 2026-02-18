namespace Portfolio
{
    public class Project
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Year { get; set; }
        public string[] TechStack { get; set; } = Array.Empty<string>();
        public string? ProjectUrl { get; set; }
        public string? GitHubUrl { get; set; }
    }
}