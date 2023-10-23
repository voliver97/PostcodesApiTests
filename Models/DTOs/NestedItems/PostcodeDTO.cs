namespace Models.DTOs.NestedItems
{
    /// <summary>
    /// DTO for postcodes.
    /// </summary>
    public class PostcodeDTO
    {
        /// <summary>
        /// Gets or sets the postcode.
        /// </summary>
        public string? Postcode { get; set; }

        /// <summary>
        /// Gets or sets the quality.
        /// </summary>
        public int Quality { get; set; }

        /// <summary>
        /// Gets or sets the eastings.
        /// </summary>
        public int Eastings { get; set; }

        /// <summary>
        /// Gets or sets northings.
        /// </summary>
        public int Northings { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        public string? Country { get; set; }

        /// <summary>
        /// Gets or sets the nhs ha.
        /// </summary>
        public string? NhsHa { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        public decimal Longitude { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        public decimal Latitude { get; set; }

        /// <summary>
        /// Gets or sets the European Electorial Region.
        /// </summary>
        public string? EuropeanElectoralRegion { get; set; }

        /// <summary>
        /// Gets or sets the Primary Care Trust.
        /// </summary>
        public string? PrimaryCareTrust { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        public string? Region { get; set; }

        /// <summary>
        /// Gets or sets the LSOA.
        /// </summary>
        public string? Lsoa { get; set; }

        /// <summary>
        /// Gets or sets the MSOA.
        /// </summary>
        public string? Msoa { get; set; }

        /// <summary>
        /// Gets or sets the incode.
        /// </summary>
        public string? Incode { get; set; }

        /// <summary>
        /// Gets or sets the outcode.
        /// </summary>
        public string? Outcode { get; set; }

        /// <summary>
        /// Gets or sets the parliamentry constituency.
        /// </summary>
        public string? ParliamentaryConstituency { get; set; }

        /// <summary>
        /// Gets or sets the admin district.
        /// </summary>
        public string? AdminDistrict { get; set; }

        /// <summary>
        /// Gets or sets the parish.
        /// </summary>
        public string? Parish { get; set; }

        /// <summary>
        /// Gets or sets the admin county.
        /// </summary>
        public string? AdminCounty { get; set; }

        /// <summary>
        /// Gets or sets the date of introduction.
        /// </summary>
        public string? DateOfIntroduction { get; set; }

        /// <summary>
        /// Gets or sets the admin ward.
        /// </summary>
        public string? AdminWard { get; set; }

        /// <summary>
        /// Gets or sets the CED.
        /// </summary>
        public string? Ced { get; set; }

        /// <summary>
        /// Gets or sets the CCG.
        /// </summary>
        public string? Ccg { get; set; }

        /// <summary>
        /// Gets or sets the NUTS.
        /// </summary>
        public string? Nuts { get; set; }

        /// <summary>
        /// Gets or sets the PFA.
        /// </summary>
        public string? Pfa { get; set; }

        /// <summary>
        /// Gets or sets the codes.
        /// </summary>
        public CodesDTO? Codes { get; set; }
    }
}
