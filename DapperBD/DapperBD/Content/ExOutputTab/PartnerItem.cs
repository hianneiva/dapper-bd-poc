using Newtonsoft.Json;
using System;

namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ExOutputTab
{
    /// <summary>
    /// The Individual Item of the JSON Array existing in the Partner Object, returned in the payload by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class PartnerItem
    {
        /// <summary>
        /// TODO: Document atwrt
        /// </summary>
        [JsonProperty("atwrt")]
        public string Atwrt { get; private set; }

        /// <summary>
        /// TODO: Document city1
        /// </summary>
        [JsonProperty("city1")]
        public string City1 { get; private set; }

        /// <summary>
        /// TODO: Document city2
        /// </summary>
        [JsonProperty("city2")]
        public string City2 { get; private set; }

        /// <summary>
        /// TODO: Document country
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; private set; }

        /// <summary>
        /// TODO: Document countryName
        /// </summary>
        [JsonProperty("countryName")]
        public string CountryName { get; private set; }

        /// <summary>
        /// TODO: Document houseNum1
        /// </summary>
        [JsonProperty("houseNum1")]
        public string HouseNum1 { get; private set; }

        /// <summary>
        /// TODO: Document name1
        /// </summary>
        [JsonProperty("name1")]
        public string Name1 { get; private set; }

        /// <summary>
        /// TODO: Document parvw
        /// </summary>
        [JsonProperty("parvw")]
        public string Parvw { get; private set; }

        /// <summary>
        /// TODO: Document postCode1
        /// </summary>
        [JsonProperty("postCode1")]
        public string PostCode1 { get; private set; }

        /// <summary>
        /// TODO: Document region
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; private set; }

        /// <summary>
        /// TODO: Document stcd1
        /// </summary>
        [JsonProperty("stcd1")]
        public string Stcd1 { get; private set; }

        /// <summary>
        /// TODO: Document stcd2
        /// </summary>
        [JsonProperty("stcd2")]
        public string Stcd2 { get; private set; }

        /// <summary>
        /// TODO: Document stcd3
        /// </summary>
        [JsonProperty("stcd3")]
        public string Stcd3 { get; private set; }

        /// <summary>
        /// TODO: Document street
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; private set; }

        /// <summary>
        /// TODO: Document strSuppl1
        /// </summary>
        [JsonProperty("strSuppl1")]
        public string StrSuppl1 { get; private set; }

        /// <summary>
        /// TODO: Document telNumber
        /// </summary>
        [JsonProperty("telNumber")]
        public string TelNumber { get; private set; }

        /// <summary>
        /// TODO: Document zdestCityCode
        /// </summary>
        [JsonProperty("zdestCityCode")]
        public string ZdestCityCode { get; private set; }

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the this instance.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj) => obj is PartnerItem item &&
                   Atwrt == item.Atwrt &&
                   City1 == item.City1 &&
                   City2 == item.City2 &&
                   Country == item.Country &&
                   CountryName == item.CountryName &&
                   HouseNum1 == item.HouseNum1 &&
                   Name1 == item.Name1 &&
                   Parvw == item.Parvw &&
                   PostCode1 == item.PostCode1 &&
                   Region == item.Region &&
                   Stcd1 == item.Stcd1 &&
                   Stcd2 == item.Stcd2 &&
                   Stcd3 == item.Stcd3 &&
                   Street == item.Street &&
                   StrSuppl1 == item.StrSuppl1 &&
                   TelNumber == item.TelNumber &&
                   ZdestCityCode == item.ZdestCityCode;

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
		/// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Atwrt);
            hash.Add(City1);
            hash.Add(City2);
            hash.Add(Country);
            hash.Add(CountryName);
            hash.Add(HouseNum1);
            hash.Add(Name1);
            hash.Add(Parvw);
            hash.Add(PostCode1);
            hash.Add(Region);
            hash.Add(Stcd1);
            hash.Add(Stcd2);
            hash.Add(Stcd3);
            hash.Add(Street);
            hash.Add(StrSuppl1);
            hash.Add(TelNumber);
            hash.Add(ZdestCityCode);
            return hash.ToHashCode();
        }
    }
}
