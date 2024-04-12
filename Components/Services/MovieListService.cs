using System;
using System.Collections.Generic;
using System.Linq;
using MovieList.Components.Models;

namespace MovieList.Components.Services
{
    public class MovieListService : IMovieListService
    {
        private List<MovieModel> _movies;

        public MovieListService()
        {
            _movies = new List<MovieModel>
            {
                new MovieModel
                {
                    Id = 1,
                    Name = "Movie 1",
                    Description = "Description for Movie 1",
                    Genre = "Action",
                    AgeRating = 18,
                    Length = TimeSpan.FromMinutes(120),
                    ReleaseYear = 2020
                },
                new MovieModel
                {
                    Id = 2,
                    Name = "Movie 2",
                    Description = "Description for Movie 2",
                    Genre = "Comedy",
                    AgeRating = 12,
                    Length = TimeSpan.FromMinutes(90),
                    ReleaseYear = 2019
                }
            };
        }

        public List<MovieModel>? GetMovies()
        {
            return _movies;
        }

        public MovieModel? GetMovieById(int id)
        {
            return _movies.FirstOrDefault(m => m.Id == id);
        }

        public void AddMovie(MovieModel movie)
        {
            _movies.Add(movie);
        }

        public void UpdateMovie(int id, MovieModel movie)
        {
            var existingMovie = _movies.FirstOrDefault(m => m.Id == id);
            if (existingMovie != null)
            {   if (existingMovie.Name != movie.Name)
            existingMovie.Name = movie.Name;

        if (existingMovie.Description != movie.Description)
            existingMovie.Description = movie.Description;

        if (existingMovie.Genre != movie.Genre)
            existingMovie.Genre = movie.Genre;

        if (existingMovie.AgeRating != movie.AgeRating)
            existingMovie.AgeRating = movie.AgeRating;

        if (existingMovie.Length != movie.Length)
            existingMovie.Length = movie.Length;

        if (existingMovie.ReleaseYear != movie.ReleaseYear)
            existingMovie.ReleaseYear = movie.ReleaseYear;
            }
        }



        public void DeleteMovie(int id)
        {
            _movies.RemoveAll(m => m.Id == id);
        }
    }
}