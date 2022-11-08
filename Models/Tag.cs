using System.Diagnostics;
namespace NovelAIPromptBuilder.Models
{
    internal class Tag
    {
        public Guid Id { get; set; }
        public bool Enabled { get; set; } = true;
        public string? Word { get; set; } = string.Empty;
        public string Translated { get; set; } = string.Empty;
        public int StrengthLevel { get; set; } = 0;

        public Tag()
        {
            Id = Guid.NewGuid();
            Enabled = true;
        }
    }
}