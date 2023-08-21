using HeloFlix.Models;

namespace HeloFlix.Interfaces;

public interface IMovieRepository : IRepository<Movie>
{
    List<Movie> ReadAllDetailed();

    Movie ReadByIdDetailed(int id);
}