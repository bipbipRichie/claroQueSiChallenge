using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Claro.Models;
using Claro.Models.REST.MovieDetail;

namespace Claro.Interface
{
    public class MovieService : IMovieService
    {
        private HttpClient FClient;
        private string apiUrl = "services/content/";
        private string clientUri = "http://mfwkmobilewindows-api.clarovideo.net/";

        private HttpClient Init()
        {
            var aClient = new HttpClient();

            try
            {

                aClient.BaseAddress = new Uri(clientUri);
                aClient.DefaultRequestHeaders.Accept.Clear();
                aClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                aClient.Timeout = new TimeSpan(0, 1, 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return aClient;
        }

        public async Task<Movies> GetMovies(string category, string quantity)
        {
            var r = new Movies();
            FClient = Init();

            try
            {
                var jsonResponse = await FClient.GetAsync($"{apiUrl}list?quantity={quantity}&order_way=DESC&order_id=200&level_id=GPS&from=0&node_id=43864&format=json&region=mexico&HKS=51bja77u5hro762k3l57a9rld5&device_manufacturer=windows&device_id=windows&device_type=windows&device_model=w10&device_category=tablet&api_version=v5.85&authpn=lagash&authpt=4F8227G1cW0s0az&format=json");
                jsonResponse.EnsureSuccessStatusCode(); // Throw on error code.
                r = await jsonResponse.Content.ReadAsAsync<Movies>();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return r;
        }

        public async Task<MovieDetailResponse> GetMovie(string id)
        {
            var r = new MovieDetailResponse();
            FClient = Init();

            try
            {
                var jsonResponse = await FClient.GetAsync($"{apiUrl}data?group_id={id}&HKS=51bja77u5hro762k3l57a9rld5&device_manufacturer=windows&device_id=windows&device_type=windows&device_model=w10&device_category=tablet&api_version=v5.85&authpn=lagash&authpt=4F8227G1cW0s0az&format=json&region=mexico");
                jsonResponse.EnsureSuccessStatusCode(); // Throw on error code.
                r = await jsonResponse.Content.ReadAsAsync<MovieDetailResponse>();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return r;
        }
    }
}
