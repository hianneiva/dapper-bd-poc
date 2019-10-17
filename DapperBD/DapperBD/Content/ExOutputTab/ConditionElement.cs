using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ExOutputTab
{
    /// <summary>
    /// The Condition JSON Object returned in the payload by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class ConditionElement
    {
        /// <summary>
        /// TODO: Document item
        /// </summary>
        [JsonProperty("item")]
        public List<ConditionItem> Item { get; private set; }

        /// <summary>
        /// Method for comparing ConditionElement
        /// </summary>
        public override bool Equals(object obj) => obj is ConditionElement element &&
                   EqualityComparer<List<ConditionItem>>.Default.Equals(Item, element.Item);

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
        public override int GetHashCode() => HashCode.Combine(Item);
    }
}
