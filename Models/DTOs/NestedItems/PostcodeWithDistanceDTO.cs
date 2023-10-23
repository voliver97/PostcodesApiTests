using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.NestedItems
{
    /// <summary>
    /// DTO for the postocde along with the distance from the given
    /// longitude and latitude.
    /// </summary>
    public class PostcodeWithDistanceDTO : PostcodeDTO
    {
        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        public decimal Distance { get; set; }
    }
}
