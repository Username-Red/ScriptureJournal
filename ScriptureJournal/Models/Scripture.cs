using System.ComponentModel.DataAnnotations;

namespace ScriptureJournal.Models
{
    public class Scripture
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }
        public string? Entry { get; set; }
        
    }
}
