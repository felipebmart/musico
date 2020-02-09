﻿namespace Musico.Services.Models
{
    using Newtonsoft.Json.Linq;

    public class GraphQLQuery
    {
        public string OperationName { get; set; }

        public string NamedQuery { get; set; }

        public string Query { get; set; }

        public JObject Variables { get; set; }
    }
}
