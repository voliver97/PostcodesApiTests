using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Models.DTOs.FinalResponse;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Serialization;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace Models
{
    /// <summary>
    /// Experimenting with schema generation and validation
    /// </summary>
    public static class SchemaValidation
    {
        public static void ValidatePostcodeSchema()
        {
            JSchemaGenerator generator = new JSchemaGenerator();

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            };

            generator.ContractResolver = contractResolver;

            JSchema schema = generator.Generate(typeof(RandomPostcodeResponseDTO));

            Console.WriteLine(schema.ToString());
        }



    }
}
