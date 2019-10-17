using Newtonsoft.Json;
using System;

namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ExOutputTab
{
    /// <summary>
    /// The Individual Item of the JSON Array existing in the Details Object, returned in the payload by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class DetailsItem
    {
        /// <summary>
        /// TODO: Document message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; private set; }

        /// <summary>
        /// Method for comparing Items
        /// </summary>
        public override bool Equals(object obj) => obj is DetailsItem item &&
                   Message == item.Message;

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
        public override int GetHashCode() => HashCode.Combine(Message);
    }
}
