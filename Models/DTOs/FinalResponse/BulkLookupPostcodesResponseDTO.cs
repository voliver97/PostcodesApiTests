using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DTOs.NestedItems;

namespace Models.DTOs.FinalResponse
{
    /// <summary>
    /// DTO for bulk the Bulk Lookup Postcodes response.
    /// </summary>
    public class BulkLookupPostcodesResponseDTO
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        public PostcodesWithQueryDTO[]? Result { get; set; }
    }
}
