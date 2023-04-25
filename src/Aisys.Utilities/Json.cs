using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aisys.Utilities
{
    public class Json
    {
        public JArray ParseJson(string json)
        {
            if (json == null)
                return new JArray { "JSON Empty" };

            var parsed = JsonConvert.DeserializeObject<JArray>(json);
            return parsed;
        }
    }
}