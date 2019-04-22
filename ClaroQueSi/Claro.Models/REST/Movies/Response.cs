using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claro.Models.REST
{
    public class Response
    {
        public IList<Group> groups { get; set; }
        public int total { get; set; }
    }
}
