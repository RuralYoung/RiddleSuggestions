using RiddleSuggestions.Models;
using Microsoft.EntityFrameworkCore;

namespace RiddleSuggestions.Contexts
{
    public class RiddleSuggestionsDbContext : DbContext
    {
        public RiddleSuggestionsDbContext(DbContextOptions<RiddleSuggestionsDbContext> options)
            : base(options) { }

        public DbSet<RiddleSuggestion> RiddleSuggestions => Set<RiddleSuggestion>();
    }
}
