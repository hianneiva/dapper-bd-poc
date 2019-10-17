using Newtonsoft.Json;
using System;

namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ExOutputTab
{
    /// <summary>
    /// The Individual Item of the JSON Array existing in the Condition Object, returned in the payload by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class ConditionItem
    {
        /// <summary>
        /// TODO: Document kawrt
        /// </summary>
        [JsonProperty("kawrt")]
        public double Kawrt { get; private set; }

        /// <summary>
        /// TODO: Document kbetr
        /// </summary>
        [JsonProperty("kbetr")]
        public double Kbetr { get; private set; }

        /// <summary>
        /// TODO: Document kinak
        /// </summary>
        [JsonProperty("kinak")]
        public string Kinak { get; private set; }

        /// <summary>
        /// TODO: Document kmein
        /// </summary>
        [JsonProperty("kmein")]
        public string Kmein { get; private set; }

        /// <summary>
        /// TODO: Document kschl
        /// </summary>
        [JsonProperty("kschl")]
        public string Kschl { get; private set; }

        /// <summary>
        /// TODO: Document kwert
        /// </summary>
        [JsonProperty("kwert")]
        public double Kwert { get; private set; }

        /// <summary>
        /// TODO: Document stunr
        /// </summary>
        [JsonProperty("stunr")]
        public long Stunr { get; private set; }

        /// <summary>
        /// TODO: Document vtext
        /// </summary>
        [JsonProperty("vtext")]
        public string Vtext { get; private set; }

        /// <summary>
        /// TODO: Document waers
        /// </summary>
        [JsonProperty("waers")]
        public string Waers { get; private set; }

        /// <summary>
        /// Method for comparing Items
        /// </summary>
        public override bool Equals(object obj) => obj is ConditionItem item &&
                   Kawrt == item.Kawrt &&
                   Kbetr == item.Kbetr &&
                   Kinak == item.Kinak &&
                   Kmein == item.Kmein &&
                   Kschl == item.Kschl &&
                   Kwert == item.Kwert &&
                   Stunr == item.Stunr &&
                   Vtext == item.Vtext &&
                   Waers == item.Waers;

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Kawrt);
            hash.Add(Kbetr);
            hash.Add(Kinak);
            hash.Add(Kmein);
            hash.Add(Kschl);
            hash.Add(Kwert);
            hash.Add(Stunr);
            hash.Add(Vtext);
            hash.Add(Waers);
            return hash.ToHashCode();
        }
    }
}
