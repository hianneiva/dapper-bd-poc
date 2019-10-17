using Newtonsoft.Json;

namespace DapperBD
{
    /// <summary>
    /// Class for Parsing DT JSON content sent by the SAP
    /// </summary>
    public static class Parser<T>
    {
        /// <summary>
        /// Parses a JSON Payload to a C# class.
        /// </summary>
        /// <param name="json"></param>
        /// <returns>
        /// A new DT based on the content parsed from the JSON.
        /// </returns>
        public static T FromJson(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None
            });
        }
    }
}
