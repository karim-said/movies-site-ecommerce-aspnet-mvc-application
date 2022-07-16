
namespace MoveisSite.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }

    }
}
