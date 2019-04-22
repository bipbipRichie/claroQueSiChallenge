using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claro.Models.REST
{
    public class Entry
    {
        public string quantity { get; set; }
        public string order_way { get; set; }
        public string order_id { get; set; }
        public string level_id { get; set; }
        public string from { get; set; }
        public string node_id { get; set; }
        public string format { get; set; }
        public string region { get; set; }
        public string HKS { get; set; }
        public string device_manufacturer { get; set; }
        public string device_id { get; set; }
        public string device_type { get; set; }
        public string device_model { get; set; }
        public string device_category { get; set; }
        public string api_version { get; set; }
        public string authpn { get; set; }
        public string authpt { get; set; }
    }
}
