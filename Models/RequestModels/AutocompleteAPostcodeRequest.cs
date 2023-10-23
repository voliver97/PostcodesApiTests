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
    public class AutocompleteAPostcodeRequest : RestRequest
    {
        private static readonly string s_Url = "{partialPostcode}/autocomplete";

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AutocompleteAPostcodeRequest"/> class.
        /// </summary>
        /// <param name="partialPostcode">The partial postcode to autocomplete.
        /// </param>
        public AutocompleteAPostcodeRequest(
            string partialPostcode)
            : base(s_Url)
        {
            this.AddUrlSegment("partialPostcode", partialPostcode);
        }
    }
}
