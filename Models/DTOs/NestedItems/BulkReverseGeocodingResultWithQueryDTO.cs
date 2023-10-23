namespace Models.DTOs.NestedItems
{
    /// <summary>
    /// Gets or sets the result with the query.
    /// </summary>
    public class BulkReverseGeocodingResultWithQueryDTO
    {
        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        public GeolocationsDTO? Query { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        public PostcodeWithDistanceDTO[]? Result { get; set; }
    }
}
