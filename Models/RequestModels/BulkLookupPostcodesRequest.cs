using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DTOs.Request;
using RestSharp;

namespace Models.RequestModels
{
    /// <summary>
    /// Models the Bulk Lookup Postcodes request.
    /// </summary>
    public class BulkLookupPostcodesRequest : RestRequest
    {
        private static readonly string s_Url = "postcodes";

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BulkLookupPostcodesRequest"/> class.
        /// </summary>
        /// <param name="bulkLookupPostcodeRequestDTO">DTO for the Bulk
        /// Lookup Postcodes request payalod.</param>
        public BulkLookupPostcodesRequest(
            BulkLookupPostcodesRequestDTO bulkLookupPostcodeRequestDTO)
            : base(s_Url, Method.Post)
        {
            this.AddBody(bulkLookupPostcodeRequestDTO);
        }
    }
}
