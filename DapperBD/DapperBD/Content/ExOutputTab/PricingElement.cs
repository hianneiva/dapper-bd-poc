using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ExOutputTab
{
    /// <summary>
    /// The Pricing JSON Object returned in the payload by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class PricingElement
    {
        /// <summary>
        /// TODO: Document condition
        /// </summary>
        [JsonProperty("condition")]
        public ConditionElement Condition { get; private set; }

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the this instance.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj) => obj is PricingElement element &&
                   EqualityComparer<ConditionElement>.Default.Equals(Condition, element.Condition);

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
		/// <returns>A hash code for this instance.</returns>
        public override int GetHashCode() => HashCode.Combine(Condition);
    }
}
