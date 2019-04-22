using Claro.Models;
using Claro.Models.REST.MovieDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claro.Interface
{
    public interface IMovieService
    {
        Task<Movies> GetMovies(string category, string quantity);
        Task<MovieDetailResponse> GetMovie(string id);
    }
}
