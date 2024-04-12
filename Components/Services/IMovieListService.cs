using MovieList.Components.Models;
using System.Collections.Generic;

namespace MovieList.Components.Services
{
    public interface IMovieListService
    {
        List<MovieModel>? GetMovies();

        MovieModel? GetMovieById(int id);

        void AddMovie(MovieModel movie);

        void UpdateMovie(int id, MovieModel movie);

        void DeleteMovie(int id);
    }
}
