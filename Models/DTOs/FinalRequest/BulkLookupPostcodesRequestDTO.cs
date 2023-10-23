namespace Models.DTOs.Request
{
    /// <summary>
    /// DTO for the Bulk Lookup Postcodes request body.
    /// </summary>
    public class BulkLookupPostcodesRequestDTO
    {
        /// <summary>
        /// Gets or sets the postcodes.
        /// </summary>
        public string[]? Postcodes { get; set; }
    }
}
