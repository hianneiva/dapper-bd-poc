using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ExOutputTab
{
    /// <summary>
    /// The Individual Item of the JSON Array existing in the Log Object, returned in the payload by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class LogItem
    {
        /// <summary>
        /// TODO: Document details
        /// </summary>
        [JsonProperty("details")]
        public DetailsElement Details { get; private set; }

        /// <summary>
        /// TODO: Document executed
        /// </summary>
        [JsonProperty("executed")]
        public string Executed { get; private set; }

        /// <summary>
        /// TODO: Document executionDate
        /// </summary>
        [JsonProperty("executionDate")]
        public string ExecutionDate { get; private set; }

        /// <summary>
        /// TODO: Document executionTime
        /// </summary>
        [JsonProperty("executionTime")]
        public string ExecutionTime { get; private set; }

        /// <summary>
        /// TODO: Document message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; private set; }

        /// <summary>
        /// TODO: Document messageId
        /// </summary>
        [JsonProperty("messageId")]
        public string MessageId { get; private set; }

        /// <summary>
        /// TODO: Document process
        /// </summary>
        [JsonProperty("process")]
        public string Process { get; private set; }

        /// <summary>
        /// TODO: Document sequence
        /// </summary>
        [JsonProperty("sequence")]
        public long Sequence { get; private set; }

        /// <summary>
        /// TODO: Document success
        /// </summary>
        [JsonProperty("success")]
        public string Success { get; private set; }

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the this instance.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj) => obj is LogItem item &&
                   EqualityComparer<DetailsElement>.Default.Equals(Details, item.Details) &&
                   Executed == item.Executed &&
                   ExecutionDate == item.ExecutionDate &&
                   ExecutionTime == item.ExecutionTime &&
                   Message == item.Message &&
                   MessageId == item.MessageId &&
                   Process == item.Process &&
                   Sequence == item.Sequence &&
                   Success == item.Success;

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
		/// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Details);
            hash.Add(Executed);
            hash.Add(ExecutionDate);
            hash.Add(ExecutionTime);
            hash.Add(Message);
            hash.Add(MessageId);
            hash.Add(Process);
            hash.Add(Sequence);
            hash.Add(Success);
            return hash.ToHashCode();
        }
    }
}
