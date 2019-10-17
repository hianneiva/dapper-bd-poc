using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ErrorReturns
{
    /// <summary>
    /// The ErrorReturns JSON Object returned in the payload by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class ErrorReturnsElement
    {
        /// <summary>
        /// TODO: Document item
        /// </summary>
        [JsonProperty("item")]
        public List<ErrorReturnsItem> Item { get; private set; }

        /// <summary>
        /// Method for comparing ErrorReturnsElement
        /// </summary>
        public override bool Equals(object obj) => obj is ErrorReturnsElement element &&
                   EqualityComparer<List<ErrorReturnsItem>>.Default.Equals(Item, element.Item);

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
        public override int GetHashCode() => HashCode.Combine(Item);
    }
}
