﻿using Microsoft.AspNetCore.Mvc;
using RiddleSuggestions.Contexts;
using RiddleSuggestions.Models;

namespace RiddleSuggestions.Controllers
{
    [Route("api/[controller]")]
    public class RiddleSuggestionsController : Controller
    {
        private RiddleSuggestionsDbContext _context;

        public RiddleSuggestionsController( RiddleSuggestionsDbContext context )
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<RiddleSuggestion> GetRiddleSuggestions()
        {
            return _context.RiddleSuggestions;
        }

        [HttpGet("{id}")]
        public RiddleSuggestion? GetRiddleSuggestion( [FromServices] ILogger<RiddleSuggestionsController> logger, int id ) {
            logger.LogDebug("GetProduct Action Invoked");
            return _context.RiddleSuggestions.Where( r => r.RiddleID == id ).FirstOrDefault();
        }

        [HttpPost]
        public void postRiddleSuggestion( [FromBody] RiddleSuggestion riddleSuggestion )
        {
            _context.RiddleSuggestions.Add(riddleSuggestion);
            _context.SaveChanges();
        }

        [HttpPut]
        public void PutRiddleSuggestion( [FromBody] RiddleSuggestion riddleSuggestion )
        {
            _context.RiddleSuggestions.Update(riddleSuggestion);
            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void DeleteRiddleSuggestion(int id)
        {
            _context.RiddleSuggestions.Remove(new RiddleSuggestion() { RiddleID = id });
            _context.SaveChanges();
        }
    }
}
