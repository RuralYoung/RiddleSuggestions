using System.ComponentModel.DataAnnotations;

namespace RiddleSuggestions.Models
{
    public class RiddleSuggestion
    {
        [Key]
        public int RiddleID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string? Hint { get; set; }
        public int Rating { get; set; }

        public IEnumerable<RiddleSuggestion>? RiddleSuggestions { get; set; }
    }
}
