namespace NovelAIPromptBuilder.Models
{
    internal class Tag
    {
        public Guid Id { get; set; }
        public string Word { get; set; } = string.Empty;
        public string Translated { get; set; } = string.Empty;
        public int EmphasisLevel { get; set; } = 0;

        public Tag()
        {
            Id = Guid.NewGuid();
        }
    }
}