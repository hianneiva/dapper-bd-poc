using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ExOutputTab
{
    /// <summary>
    /// The Details JSON Object returned in the payload by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class DetailsElement
    {
        /// <summary>
        /// TODO: Document item
        /// </summary>
        [JsonProperty("item")]
        public List<DetailsItem> Item { get; private set; }

        /// <summary>
        /// Method for comparing StageElement
        /// </summary>
        public override bool Equals(object obj) => obj is DetailsElement element &&
                   EqualityComparer<List<DetailsItem>>.Default.Equals(Item, element.Item);

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
        public override int GetHashCode() => HashCode.Combine(Item);
    }
}
