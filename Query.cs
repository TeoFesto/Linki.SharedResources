using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Linki.SharedResources
{
    public class Query
    {
        [JsonProperty]
        public string applicationMessageType { get; set; }

        [JsonProperty]
        public string serializedApplicationMessage { get; set; }
    }
}
