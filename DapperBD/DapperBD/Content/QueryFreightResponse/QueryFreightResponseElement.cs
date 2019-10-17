using Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ErrorReturns;
using Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ExOutputTab;
using Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.Shipment;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.QueryFreightResponse
{
    /// <summary>
    /// The QueryFreightResponse JSON Object from the payload returned by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class QueryFreightResponseElement
    {
        /// <summary>
        /// TODO: Document errorReturns
        /// </summary>
        [JsonProperty("errorReturns", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorReturnsElement ErrorReturns { get; private set; }

        /// <summary>
        /// TODO: Document exOutputTab
        /// </summary>
        [JsonProperty("exOutputTab", NullValueHandling = NullValueHandling.Ignore)]
        public ExOutputTabElement ExOutputTab { get; private set; }

        /// <summary>
        /// TODO: Document shipment
        /// </summary>
        [JsonProperty("shipment", NullValueHandling = NullValueHandling.Ignore)]
        public ShipmentElement Shipment { get; private set; }

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the this instance.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj) => obj is QueryFreightResponseElement response &&
                   EqualityComparer<ErrorReturnsElement>.Default.Equals(ErrorReturns, response.ErrorReturns) &&
                   EqualityComparer<ExOutputTabElement>.Default.Equals(ExOutputTab, response.ExOutputTab) &&
                   EqualityComparer<ShipmentElement>.Default.Equals(Shipment, response.Shipment);

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
		/// <returns>A hash code for this instance.</returns>
        public override int GetHashCode() => HashCode.Combine(ErrorReturns, ExOutputTab, Shipment);
    }
}
