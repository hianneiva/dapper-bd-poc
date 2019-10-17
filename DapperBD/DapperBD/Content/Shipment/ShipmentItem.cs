using Newtonsoft.Json;
using System;

namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.Shipment
{
    /// <summary>
    /// The Individual Item of the JSON Array existing in the Shipment Object, returned in the payload by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class ShipmentItem
    {
        /// <summary>
        /// TODO: Document tknum
        /// </summary>
        [JsonProperty("tknum")]
        public string Tknum { get; private set; }

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the this instance.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj) => obj is ShipmentItem item &&
                   Tknum == item.Tknum;

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
		/// <returns>A hash code for this instance.</returns>
        public override int GetHashCode() => HashCode.Combine(Tknum);
    }
}
