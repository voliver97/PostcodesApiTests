namespace Models.DTOs.NestedItems
{
    /// <summary>
    /// DTO for geolocations.
    /// </summary>
    public class GeolocationsDTO
    {
        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        public decimal Longitude { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        public decimal Latitude { get; set; }

        /// <summary>
        /// Gets or sets the radius.
        /// </summary>
        public decimal Radius { get; set; }

        /// <summary>
        /// Gets or sets the limit.
        /// </summary>
        public int Limit { get; set; }
    }
}
