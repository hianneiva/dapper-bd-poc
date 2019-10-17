using Newtonsoft.Json;
using System;

namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ExOutputTab
{
    /// <summary>
    /// The Individual Item of the JSON Array existing in the Pod Object, returned in the payload by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class PodItem
    {
        /// <summary>
        /// TODO: Document defPodDate
        /// </summary>
        [JsonProperty("defPodDate")]
        public string DefPodDate { get; private set; }

        /// <summary>
        /// TODO: Document defPodDoc
        /// </summary>
        [JsonProperty("defPodDoc")]
        public string DefPodDoc { get; private set; }

        /// <summary>
        /// TODO: Document defPodDocType
        /// </summary>
        [JsonProperty("defPodDocType")]
        public string DefPodDocType { get; private set; }

        /// <summary>
        /// TODO: Document defPodTime
        /// </summary>
        [JsonProperty("defPodTime")]
        public string DefPodTime { get; private set; }

        /// <summary>
        /// TODO: Document tempPodDate
        /// </summary>
        [JsonProperty("tempPodDate")]
        public string TempPodDate { get; private set; }

        /// <summary>
        /// TODO: Document tempPodDoc
        /// </summary>
        [JsonProperty("tempPodDoc")]
        public string TempPodDoc { get; private set; }

        /// <summary>
        /// TODO: Document tempPodDocType
        /// </summary>
        [JsonProperty("tempPodDocType")]
        public string TempPodDocType { get; private set; }

        /// <summary>
        /// TODO: Document tempPodTime
        /// </summary>
        [JsonProperty("tempPodTime")]
        public string TempPodTime { get; private set; }

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the this instance.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj) => obj is PodItem item &&
                   DefPodDate == item.DefPodDate &&
                   DefPodDoc == item.DefPodDoc &&
                   DefPodDocType == item.DefPodDocType &&
                   DefPodTime == item.DefPodTime &&
                   TempPodDate == item.TempPodDate &&
                   TempPodDoc == item.TempPodDoc &&
                   TempPodDocType == item.TempPodDocType &&
                   TempPodTime == item.TempPodTime;

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
		/// <returns>A hash code for this instance.</returns>
        public override int GetHashCode() => HashCode.Combine(DefPodDate, DefPodDoc, DefPodDocType, DefPodTime, TempPodDate, TempPodDoc, TempPodDocType, TempPodTime);
    }
}
