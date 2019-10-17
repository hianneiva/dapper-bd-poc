using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ExOutputTab
{
    /// <summary>
    /// The Partner JSON Object returned in the payload by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class PartnerElement
    {
        /// <summary>
        /// TODO: Document item
        /// </summary>
        [JsonProperty("item")]
        public List<PartnerItem> Item { get; private set; }

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the this instance.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj) => obj is PartnerElement element &&
                   EqualityComparer<List<PartnerItem>>.Default.Equals(Item, element.Item);

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
		/// <returns>A hash code for this instance.</returns>
        public override int GetHashCode() => HashCode.Combine(Item);
    }
}
