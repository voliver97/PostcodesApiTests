using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.FinalResponse
{
    /// <summary>
    /// DTO for the validate postcode response.
    /// </summary>
    public class ValidatePostcodeResponseDTO
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the postcode supplied is
        /// valid.
        /// </summary>
        public bool Result { get; set; }
    }
}
