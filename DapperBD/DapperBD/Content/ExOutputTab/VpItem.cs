using Newtonsoft.Json;
using System;

namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ExOutputTab
{
    /// <summary>
    /// The Individual Item of the JSON Array existing in the Vp Object, returned in the payload by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class VpItem
    {
        /// <summary>
        /// TODO: Document bTrainAxles
        /// </summary>
        [JsonProperty("bTrainAxles")]
        public long BTrainAxles { get; private set; }

        /// <summary>
        /// TODO: Document bTrainPlate
        /// </summary>
        [JsonProperty("bTrainPlate")]
        public string BTrainPlate { get; private set; }

        /// <summary>
        /// TODO: Document bTrainufId
        /// </summary>
        [JsonProperty("bTrainufId")]
        public string BTrainufId { get; private set; }

        /// <summary>
        /// TODO: Document expectedAxles
        /// </summary>
        [JsonProperty("expectedAxles")]
        public long ExpectedAxles { get; private set; }

        /// <summary>
        /// TODO: Document expTollValue
        /// </summary>
        [JsonProperty("expTollValue")]
        public string ExpTollValue { get; private set; }

        /// <summary>
        /// TODO: Document occurrenceNum
        /// </summary>
        [JsonProperty("occurrenceNum")]
        public string OccurrenceNum { get; private set; }

        /// <summary>
        /// TODO: Document realTollValue
        /// </summary>
        [JsonProperty("realTollValue")]
        public double RealTollValue { get; private set; }

        /// <summary>
        /// TODO: Document receiptNumber
        /// </summary>
        [JsonProperty("receiptNumber")]
        public string ReceiptNumber { get; private set; }

        /// <summary>
        /// TODO: Document tagStatus
        /// </summary>
        [JsonProperty("tagStatus")]
        public long TagStatus { get; private set; }

        /// <summary>
        /// TODO: Document tollVendor
        /// </summary>
        [JsonProperty("tollVendor")]
        public string TollVendor { get; private set; }

        /// <summary>
        /// TODO: Document totalAxles
        /// </summary>
        [JsonProperty("totalAxles")]
        public long TotalAxles { get; private set; }

        /// <summary>
        /// TODO: Document trailerAxles
        /// </summary>
        [JsonProperty("trailerAxles")]
        public long TrailerAxles { get; private set; }

        /// <summary>
        /// TODO: Document trailerPlate
        /// </summary>
        [JsonProperty("trailerPlate")]
        public string TrailerPlate { get; private set; }

        /// <summary>
        /// TODO: Document trailerUFId
        /// </summary>
        [JsonProperty("trailerUFId")]
        public string TrailerUfId { get; private set; }

        /// <summary>
        /// TODO: Document truckAxles
        /// </summary>
        [JsonProperty("truckAxles")]
        public long TruckAxles { get; private set; }

        /// <summary>
        /// TODO: Document truckPlate
        /// </summary>
        [JsonProperty("truckPlate")]
        public string TruckPlate { get; private set; }

        /// <summary>
        /// TODO: Document truckUFId
        /// </summary>
        [JsonProperty("truckUFId")]
        public string TruckUfId { get; private set; }

        /// <summary>
        /// TODO: Document vpStatus
        /// </summary>
        [JsonProperty("vpStatus")]
        public long VpStatus { get; private set; }

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the this instance.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj) => obj is VpItem item &&
                   BTrainAxles == item.BTrainAxles &&
                   BTrainPlate == item.BTrainPlate &&
                   BTrainufId == item.BTrainufId &&
                   ExpectedAxles == item.ExpectedAxles &&
                   ExpTollValue == item.ExpTollValue &&
                   OccurrenceNum == item.OccurrenceNum &&
                   RealTollValue == item.RealTollValue &&
                   ReceiptNumber == item.ReceiptNumber &&
                   TagStatus == item.TagStatus &&
                   TollVendor == item.TollVendor &&
                   TotalAxles == item.TotalAxles &&
                   TrailerAxles == item.TrailerAxles &&
                   TrailerPlate == item.TrailerPlate &&
                   TrailerUfId == item.TrailerUfId &&
                   TruckAxles == item.TruckAxles &&
                   TruckPlate == item.TruckPlate &&
                   TruckUfId == item.TruckUfId &&
                   VpStatus == item.VpStatus;

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
		/// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(BTrainAxles);
            hash.Add(BTrainPlate);
            hash.Add(BTrainufId);
            hash.Add(ExpectedAxles);
            hash.Add(ExpTollValue);
            hash.Add(OccurrenceNum);
            hash.Add(RealTollValue);
            hash.Add(ReceiptNumber);
            hash.Add(TagStatus);
            hash.Add(TollVendor);
            hash.Add(TotalAxles);
            hash.Add(TrailerAxles);
            hash.Add(TrailerPlate);
            hash.Add(TrailerUfId);
            hash.Add(TruckAxles);
            hash.Add(TruckPlate);
            hash.Add(TruckUfId);
            hash.Add(VpStatus);
            return hash.ToHashCode();
        }
    }
}
