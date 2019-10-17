using Newtonsoft.Json;
using System;
namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ErrorReturns
{
    /// <summary>
    /// The Individual Item of the JSON Array existing in the ErrorReturns Object, returned in the payload by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class ErrorReturnsItem
    {
        /// <summary>
        /// TODO: Document field
        /// </summary>
        [JsonProperty("field")]
        public string Field { get; private set; }

        /// <summary>
        /// TODO: Document id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// TODO: Document logMsgNo
        /// </summary>
        [JsonProperty("logMsgNo")]
        public long LogMsgNo { get; private set; }

        /// <summary>
        /// TODO: Document logNo
        /// </summary>
        [JsonProperty("logNo")]
        public string LogNo { get; private set; }

        /// <summary>
        /// TODO: Document message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; private set; }

        /// <summary>
        /// TODO: Document messageV1
        /// </summary>
        [JsonProperty("messageV1")]
        public string MessageV1 { get; private set; }

        /// <summary>
        /// TODO: Document messageV2
        /// </summary>
        [JsonProperty("messageV2")]
        public string MessageV2 { get; private set; }

        /// <summary>
        /// TODO: Document messageV3
        /// </summary>
        [JsonProperty("messageV3")]
        public string MessageV3 { get; private set; }

        /// <summary>
        /// TODO: Document messageV4
        /// </summary>
        [JsonProperty("messageV4")]
        public string MessageV4 { get; private set; }

        /// <summary>
        /// TODO: Document number
        /// </summary>
        [JsonProperty("number")]
        public long Number { get; private set; }

        /// <summary>
        /// TODO: Document parameter
        /// </summary>
        [JsonProperty("parameter")]
        public string Parameter { get; private set; }

        /// <summary>
        /// TODO: Document row
        /// </summary>
        [JsonProperty("row")]
        public long Row { get; private set; }

        /// <summary>
        /// TODO: Document system
        /// </summary>
        [JsonProperty("system")]
        public string System { get; private set; }

        /// <summary>
        /// TODO: Document type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// Method for comparing Items
        /// </summary>
        public override bool Equals(object obj) => obj is ErrorReturnsItem item &&
                   Field == item.Field &&
                   Id == item.Id &&
                   LogMsgNo == item.LogMsgNo &&
                   LogNo == item.LogNo &&
                   Message == item.Message &&
                   MessageV1 == item.MessageV1 &&
                   MessageV2 == item.MessageV2 &&
                   MessageV3 == item.MessageV3 &&
                   MessageV4 == item.MessageV4 &&
                   Number == item.Number &&
                   Parameter == item.Parameter &&
                   Row == item.Row &&
                   System == item.System &&
                   Type == item.Type;

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Field);
            hash.Add(Id);
            hash.Add(LogMsgNo);
            hash.Add(LogNo);
            hash.Add(Message);
            hash.Add(MessageV1);
            hash.Add(MessageV2);
            hash.Add(MessageV3);
            hash.Add(MessageV4);
            hash.Add(Number);
            hash.Add(Parameter);
            hash.Add(Row);
            hash.Add(System);
            hash.Add(Type);
            return hash.ToHashCode();
        }
    }
}
