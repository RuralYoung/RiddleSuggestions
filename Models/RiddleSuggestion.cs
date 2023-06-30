namespace RiddleSuggestions.Models
{
    public class RiddleSuggestion
    {
        public int RiddleID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string? Hint { get; set; }
        public int Rating { get; set; }
    }
}
