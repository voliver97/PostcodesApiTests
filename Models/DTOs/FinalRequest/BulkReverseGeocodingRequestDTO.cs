using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DTOs.NestedItems;

namespace Models.DTOs.Request
{
    /// <summary>
    /// DTO for the Bulk Reverse Geocoding request.
    /// </summary>
    public class BulkReverseGeocodingRequestDTO
    {
        /// <summary>
        /// Gets or sets the geolocations.
        /// </summary>
        public GeolocationsDTO[]? Geolocations { get; set; }
    }
}
