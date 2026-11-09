using System.ComponentModel.DataAnnotations;

namespace BlogWithEf.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required] public string Title { get; set; }
        [Required] public string Body { get; set; }
        [Required] public string Author { get; set; }
        public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    }
}