using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Exception thrown when a <see cref="RestSharp.RestRequest"/> is invalid.
    /// </summary>
    public class InvalidRequestException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="InvalidRequestException"/> class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public InvalidRequestException(string? message)
            : base(message)
        {
        }
    }
}
