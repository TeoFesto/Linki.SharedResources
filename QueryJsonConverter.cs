using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Linki.SharedResources
{
    public static class QueryJsonConverter
    {
        public static string SerializeQueryMessage(QueryMessage queryMesage)
        {
            string type = queryMesage.GetType().AssemblyQualifiedName;
            string serializedQueryMessage = JsonConvert.SerializeObject(queryMesage);
            Query query = new Query();
            query.applicationMessageType = type;
            query.serializedApplicationMessage = serializedQueryMessage;
            string jsonQuery = JsonConvert.SerializeObject(query);
            return jsonQuery;
        }

        public static QueryMessage DeserializeQuery(string jsonQuery)
        {
            Query query = JsonConvert.DeserializeObject<Query>(jsonQuery);
            Type type = Type.GetType(query.applicationMessageType);
            object appMessage = JsonConvert.DeserializeObject(query.serializedApplicationMessage, type);
            if (appMessage is QueryMessage queryMessage)
                return queryMessage;
            else
                throw new Exception("DeserializeQueryException");
        }


    }
}
