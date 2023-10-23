using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Models.RequestModels
{
    /// <summary>
    /// Models the Get A Random Postcodes request.
    /// </summary>
    public class GetARandomPostcodeRequest : RestRequest
    {
        /// <summary>
        /// The endpoint URL.
        /// </summary>
        private static readonly string s_Url = "random/postcodes";

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="GetARandomPostcodeRequest"/> class.
        /// </summary>
        public GetARandomPostcodeRequest()
            : base(s_Url)
        {
        }
    }
}
