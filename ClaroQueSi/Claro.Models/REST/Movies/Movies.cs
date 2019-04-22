using Claro.Models.REST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claro.Models
{
    public class Movies
    {
        public Entry entry { get; set; }
        public Response response { get; set; }
        public string status { get; set; }
        public string msg { get; set; }
    }
}
