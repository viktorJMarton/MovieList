using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace MovieList.Components.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public int AgeRating { get; set; }
        public TimeSpan Length { get; set; }
        public int ReleaseYear { get; set; }



    }
}
