namespace Portfolio
{
    public class Education
    {
        public string Institution { get; set; } = string.Empty;
        public string Degree { get; set; } = string.Empty;
        public string FieldOfStudy { get; set; } = string.Empty;
        public int StartYear { get; set; }
        public int? EndYear { get; set; }
        public string[] Highlights { get; set; } = Array.Empty<string>();

        /// <summary>
        /// Returns a display string like "2022 – Present" or "2020 – 2024"
        /// </summary>
        public string DateRange =>
            EndYear.HasValue ? $"{StartYear} – {EndYear}" : $"{StartYear} – Present";
    }
}