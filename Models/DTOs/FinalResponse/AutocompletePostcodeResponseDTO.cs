using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.FinalResponse
{
    /// <summary>
    /// DTO for the autocomplete postcode response.
    /// </summary>
    public class AutocompletePostcodeResponseDTO
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        public string[]? Result { get; set; }
    }
}
