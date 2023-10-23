namespace Models.DTOs.NestedItems
{
    /// <summary>
    /// DTO for the Bulk Lookup Postcode result with the original query.
    /// </summary>
    public class PostcodesWithQueryDTO
    {
        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        public string? Query { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        public PostcodeDTO[]? Result { get; set; }
    }
}
