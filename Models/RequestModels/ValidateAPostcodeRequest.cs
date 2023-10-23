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
    public class ValidateAPostcodeRequest : RestRequest
    {
        private static readonly string s_Url = "{postcode}/validate";

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ValidateAPostcodeRequest"/> class.
        /// </summary>
        /// <param name="postcode">The postcode to validate.</param>
        public ValidateAPostcodeRequest(
            string postcode)
            : base(s_Url)
        {
            this.AddUrlSegment("postcode", postcode);
        }
    }
}
