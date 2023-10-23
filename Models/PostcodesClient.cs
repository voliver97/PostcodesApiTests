using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace Models
{
    /// <summary>
    /// Wrapper class for a <see cref="RestClient"/> for the Postcodes API.
    /// </summary>
    public class PostcodesClient
    {
        /// <summary>
        /// The client to use to send requests to the API.
        /// </summary>
        private readonly RestClient? _Client;

        /// <summary>
        /// The contract resolver for snake case naming strategy. Postcodes
        /// uses snake case naming.
        /// </summary>
        private DefaultContractResolver _ContractResolver =
            new DefaultContractResolver
        {
            NamingStrategy = new SnakeCaseNamingStrategy()
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PostcodesClient"/>
        /// class.
        /// </summary>
        public PostcodesClient()
        {
            _Client = new RestClient(
                "api.postcodes.io/",
                configureSerialization: s => s.UseNewtonsoftJson(
                    new JsonSerializerSettings
                    {
                        ContractResolver = _ContractResolver
                    }));
        }

        /// <summary>
        /// Disposes of the <see cref="RestClient"/> object.
        /// </summary>
        public void Dispose()
        {
            _Client!.Dispose();
        }

        /// <summary>
        /// Sends a request to the API.
        /// </summary>
        /// <typeparam name="T">The response DTO.</typeparam>
        /// <param name="request">The request to send.</param>
        /// <param name="expectedStatusCode">
        /// Expected status code of the response.
        /// </param>
        /// <returns>The response data.</returns>
        public T SendRequest<T>(
            RestRequest request,
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
        {
            RestResponse<T> response = _Client!.Execute<T>(request);

            if (response.StatusCode != expectedStatusCode)
            {
                var message =
                    $"Response status code not as expected. Expected " +
                    $"{expectedStatusCode} but got {response.StatusCode}.";
                throw new InvalidRequestException(message);
            }

            return response.Data ??
                throw new InvalidRequestException("Response data was null.");
        }
    }
}
