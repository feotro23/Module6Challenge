namespace Portfolio
{
    public class Skill
    {
        private int _proficiencyLevel;

        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;

        public int ProficiencyLevel
        {
            get => _proficiencyLevel;
            set
            {
                if (value < 1) _proficiencyLevel = 1;
                else if (value > 5) _proficiencyLevel = 5;
                else _proficiencyLevel = value;
            }
        }

        /// <summary>
        /// Returns a CSS width percentage for use in progress bars.
        /// </summary>
        public int ProficiencyPercent => ProficiencyLevel * 20;
    }
}