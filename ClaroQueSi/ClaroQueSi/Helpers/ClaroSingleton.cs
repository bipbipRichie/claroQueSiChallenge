using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaroQueSi.Helpers
{
    public static class ClaroSingleton
    {
        private static string _selectedMovieId { get; set; }
        

        public static void SetId(string id)
        {
            _selectedMovieId = id;
        }

        public static string GetId()
        {
            return _selectedMovieId;
        }

    }
}
