using Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.QueryFreightResponse;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights
{
    /// <summary>
    /// The payload returned by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class QueryFreightResponseRoot
    {
        /// <summary>
        /// TODO: Document QueryFreightResponse
        /// </summary>
        [JsonProperty("QueryFreightResponse")]
        public QueryFreightResponseElement QueryFreightResponse { get; private set; }

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the this instance.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj) => obj is QueryFreightResponseRoot root &&
                   EqualityComparer<QueryFreightResponseElement>.Default.Equals(QueryFreightResponse, root.QueryFreightResponse);

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
		/// <returns>A hash code for this instance.</returns>
        public override int GetHashCode() => HashCode.Combine(QueryFreightResponse);
    }
}
