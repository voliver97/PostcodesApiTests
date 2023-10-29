using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DTOs.NestedItems;
using System.ComponentModel.DataAnnotations;

namespace Models.DTOs.FinalResponse
{
    /// <summary>
    /// DTO for a postcode response.
    /// </summary>
    public class RandomPostcodeResponseDTO
    {
        [Required]
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public int Status { get; set; }

        [Required]
        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        public PostcodeDTO Result { get; set; }
    }
}
