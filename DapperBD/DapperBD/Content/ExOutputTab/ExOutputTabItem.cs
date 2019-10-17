using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ExOutputTab
{
    /// <summary>
    /// The Individual Item of the JSON Array existing in the ExOutputTab Object, returned in the payload by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class ExOutputTabItem
    {
        /// <summary>
        /// TODO: Document carrCode
        /// </summary>
        [JsonProperty("carrCode")]
        public string CarrCode { get; private set; }

        /// <summary>
        /// TODO: Document driverId
        /// </summary>
        [JsonProperty("driverId")]
        public string DriverId { get; private set; }

        /// <summary>
        /// TODO: Document eDocsCTE
        /// </summary>
        [JsonProperty("eDocsCTE")]
        public string EDocsCte { get; private set; }

        /// <summary>
        /// TODO: Document globalStat
        /// </summary>
        [JsonProperty("globalStat")]
        public string GlobalStat { get; private set; }

        /// <summary>
        /// TODO: Document oneCTE
        /// </summary>
        [JsonProperty("oneCTE")]
        public long OneCte { get; private set; }

        /// <summary>
        /// TODO: Document shtyp
        /// </summary>
        [JsonProperty("shtyp")]
        public string Shtyp { get; private set; }

        /// <summary>
        /// TODO: Document stage
        /// </summary>
        [JsonProperty("stage")]
        public StageElement Stage { get; private set; }

        /// <summary>
        /// TODO: Document tknum
        /// </summary>
        [JsonProperty("tknum")]
        public string Tknum { get; private set; }

        /// <summary>
        /// TODO: Document tpp
        /// </summary>
        [JsonProperty("tpp")]
        public string Tpp { get; private set; }

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the this instance.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj) => obj is ExOutputTabItem item &&
                   CarrCode == item.CarrCode &&
                   DriverId == item.DriverId &&
                   EDocsCte == item.EDocsCte &&
                   GlobalStat == item.GlobalStat &&
                   OneCte == item.OneCte &&
                   Shtyp == item.Shtyp &&
                   EqualityComparer<StageElement>.Default.Equals(Stage, item.Stage) &&
                   Tknum == item.Tknum &&
                   Tpp == item.Tpp;

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
		/// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(CarrCode);
            hash.Add(DriverId);
            hash.Add(EDocsCte);
            hash.Add(GlobalStat);
            hash.Add(OneCte);
            hash.Add(Shtyp);
            hash.Add(Stage);
            hash.Add(Tknum);
            hash.Add(Tpp);
            return hash.ToHashCode();
        }
    }
}
