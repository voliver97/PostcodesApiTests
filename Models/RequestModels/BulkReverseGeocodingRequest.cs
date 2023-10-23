using Models.DTOs.Request;
using RestSharp;

namespace Models.RequestModels
{
    /// <summary>
    /// MOdels the Bulk Reverse Geocoding request.
    /// </summary>
    public class BulkReverseGeocodingRequest : RestRequest
    {
        private static readonly string s_Url = "postcodes";

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BulkReverseGeocodingRequest"/> class.
        /// </summary>
        /// <param name="bulkReverseGeocodingRequestDTO">The request payload
        /// DTO.</param>
        public BulkReverseGeocodingRequest(
            BulkReverseGeocodingRequestDTO bulkReverseGeocodingRequestDTO)
            : base(s_Url, Method.Post)
        {
            this.AddBody(bulkReverseGeocodingRequestDTO);
        }
    }
}
