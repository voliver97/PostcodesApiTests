using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DTOs.NestedItems;

namespace Models.DTOs.Response
{
    /// <summary>
    /// DTO for the bulk reverse geocoding response.
    /// </summary>
    public class BulkReverseGeocodingResponseDTO
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the result with the query.
        /// </summary>
        public BulkReverseGeocodingResultWithQueryDTO[]? Result { get; set; }
    }
}
