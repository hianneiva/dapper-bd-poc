using Newtonsoft.Json;
using System;

namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ExOutputTab
{
    /// <summary>
    /// The Individual Item of the JSON Array existing in the Nfe Object, returned in the payload by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class NfeItem
    {
        /// <summary>
        /// TODO: Document atwrt
        /// </summary>
        [JsonProperty("atwrt")]
        public string Atwrt { get; private set; }

        /// <summary>
        /// TODO: Document atwrtIs
        /// </summary>
        [JsonProperty("atwrtIs")]
        public string AtwrtIs { get; private set; }

        /// <summary>
        /// TODO: Document brgew
        /// </summary>
        [JsonProperty("brgew")]
        public double Brgew { get; private set; }

        /// <summary>
        /// TODO: Document city1
        /// </summary>
        [JsonProperty("city1")]
        public string City1 { get; private set; }

        /// <summary>
        /// TODO: Document city1Is
        /// </summary>
        [JsonProperty("city1Is")]
        public string City1Is { get; private set; }

        /// <summary>
        /// TODO: Document city2
        /// </summary>
        [JsonProperty("city2")]
        public string City2 { get; private set; }

        /// <summary>
        /// TODO: Document city2Is
        /// </summary>
        [JsonProperty("city2Is")]
        public string City2Is { get; private set; }

        /// <summary>
        /// TODO: Document cnpjTake
        /// </summary>
        [JsonProperty("cnpjTake")]
        public string CnpjTake { get; private set; }

        /// <summary>
        /// TODO: Document costRel
        /// </summary>
        [JsonProperty("costRel")]
        public string CostRel { get; private set; }

        /// <summary>
        /// TODO: Document country
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; private set; }

        /// <summary>
        /// TODO: Document countryIs
        /// </summary>
        [JsonProperty("countryIs")]
        public string CountryIs { get; private set; }

        /// <summary>
        /// TODO: Document countryName
        /// </summary>
        [JsonProperty("countryName")]
        public string CountryName { get; private set; }

        /// <summary>
        /// TODO: Document countryNameIs
        /// </summary>
        [JsonProperty("countryNameIs")]
        public string CountryNameIs { get; private set; }

        /// <summary>
        /// TODO: Document docDate
        /// </summary>
        [JsonProperty("docDate")]
        public string DocDate { get; private set; }

        /// <summary>
        /// TODO: Document houseNum1
        /// </summary>
        [JsonProperty("houseNum1")]
        public string HouseNum1 { get; private set; }

        /// <summary>
        /// TODO: Document houseNum1Is
        /// </summary>
        [JsonProperty("houseNum1Is")]
        public string HouseNum1Is { get; private set; }

        /// <summary>
        /// TODO: Document inbDocNum
        /// </summary>
        [JsonProperty("inbDocNum")]
        public string InbDocNum { get; private set; }

        /// <summary>
        /// TODO: Document inco1
        /// </summary>
        [JsonProperty("inco1")]
        public string Inco1 { get; private set; }

        /// <summary>
        /// TODO: Document menge
        /// </summary>
        [JsonProperty("menge")]
        public double Menge { get; private set; }

        /// <summary>
        /// TODO: Document message1
        /// </summary>
        [JsonProperty("message1")]
        public string Message1 { get; private set; }

        /// <summary>
        /// TODO: Document message2
        /// </summary>
        [JsonProperty("message2")]
        public Message2Element Message2 { get; private set; }

        /// <summary>
        /// TODO: Document name1
        /// </summary>
        [JsonProperty("name1")]
        public string Name1 { get; private set; }

        /// <summary>
        /// TODO: Document name1Is
        /// </summary>
        [JsonProperty("name1Is")]
        public string Name1Is { get; private set; }

        /// <summary>
        /// TODO: Document nFeNum
        /// </summary>
        [JsonProperty("nFeNum")]
        public string NFeNum { get; private set; }

        /// <summary>
        /// TODO: Document nfeTotal
        /// </summary>
        [JsonProperty("nfeTotal")]
        public double NfeTotal { get; private set; }

        /// <summary>
        /// TODO: Document pod
        /// </summary>
        [JsonProperty("pod")]
        public PodElement Pod { get; private set; }

        /// <summary>
        /// TODO: Document postCode1
        /// </summary>
        [JsonProperty("postCode1")]
        public string PostCode1 { get; private set; }

        /// <summary>
        /// TODO: Document postCode1Is
        /// </summary>
        [JsonProperty("postCode1Is")]
        public string PostCode1Is { get; private set; }

        /// <summary>
        /// TODO: Document region
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; private set; }

        /// <summary>
        /// TODO: Document regionIs
        /// </summary>
        [JsonProperty("regionIs")]
        public string RegionIs { get; private set; }

        /// <summary>
        /// TODO: Document series
        /// </summary>
        [JsonProperty("series")]
        public string Series { get; private set; }

        /// <summary>
        /// TODO: Document shpunt
        /// </summary>
        [JsonProperty("shpunt")]
        public string Shpunt { get; private set; }

        /// <summary>
        /// TODO: Document stcd1
        /// </summary>
        [JsonProperty("stcd1")]
        public string Stcd1 { get; private set; }

        /// <summary>
        /// TODO: Document stcd1Is
        /// </summary>
        [JsonProperty("stcd1Is")]
        public string Stcd1Is { get; private set; }

        /// <summary>
        /// TODO: Document stcd2
        /// </summary>
        [JsonProperty("stcd2")]
        public string Stcd2 { get; private set; }

        /// <summary>
        /// TODO: Document stcd2Is
        /// </summary>
        [JsonProperty("stcd2Is")]
        public string Stcd2Is { get; private set; }

        /// <summary>
        /// TODO: Document stcd3
        /// </summary>
        [JsonProperty("stcd3")]
        public string Stcd3 { get; private set; }

        /// <summary>
        /// TODO: Document stcd3Is
        /// </summary>
        [JsonProperty("stcd3Is")]
        public string Stcd3Is { get; private set; }

        /// <summary>
        /// TODO: Document street
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; private set; }

        /// <summary>
        /// TODO: Document streetIs
        /// </summary>
        [JsonProperty("streetIs")]
        public string StreetIs { get; private set; }

        /// <summary>
        /// TODO: Document strSuppl1
        /// </summary>
        [JsonProperty("strSuppl1")]
        public string StrSuppl1 { get; private set; }

        /// <summary>
        /// TODO: Document strSuppl1Is
        /// </summary>
        [JsonProperty("strSuppl1Is")]
        public string StrSuppl1Is { get; private set; }

        /// <summary>
        /// TODO: Document telNumber
        /// </summary>
        [JsonProperty("telNumber")]
        public string TelNumber { get; private set; }

        /// <summary>
        /// TODO: Document telNumberIs
        /// </summary>
        [JsonProperty("telNumberIs")]
        public string TelNumberIs { get; private set; }

        /// <summary>
        /// TODO: Document vbeln
        /// </summary>
        [JsonProperty("vbeln")]
        public string Vbeln { get; private set; }

        /// <summary>
        /// TODO: Document zdestCityCode
        /// </summary>
        [JsonProperty("zdestCityCode")]
        public string ZdestCityCode { get; private set; }

        /// <summary>
        /// TODO: Document zdestCityCodeIs
        /// </summary>
        [JsonProperty("zDestCityCodeIs")]
        public string ZDestCityCodeIs { get; private set; }

        /// <summary>
        /// TODO: Document zField
        /// </summary>
        [JsonProperty("zField")]
        public string ZField { get; private set; }

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the this instance.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj) => obj is NfeItem item &&
                   Atwrt == item.Atwrt &&
                   AtwrtIs == item.AtwrtIs &&
                   Brgew == item.Brgew &&
                   City1 == item.City1 &&
                   City1Is == item.City1Is &&
                   City2 == item.City2 &&
                   City2Is == item.City2Is &&
                   CnpjTake == item.CnpjTake &&
                   CostRel == item.CostRel &&
                   Country == item.Country &&
                   CountryIs == item.CountryIs &&
                   CountryName == item.CountryName &&
                   CountryNameIs == item.CountryNameIs &&
                   DocDate == item.DocDate &&
                   HouseNum1 == item.HouseNum1 &&
                   HouseNum1Is == item.HouseNum1Is &&
                   InbDocNum == item.InbDocNum &&
                   Inco1 == item.Inco1 &&
                   Menge == item.Menge &&
                   Message1 == item.Message1 &&
                   System.Collections.Generic.EqualityComparer<Message2Element>.Default.Equals(Message2, item.Message2) &&
                   Name1 == item.Name1 &&
                   Name1Is == item.Name1Is &&
                   NFeNum == item.NFeNum &&
                   NfeTotal == item.NfeTotal &&
                   System.Collections.Generic.EqualityComparer<PodElement>.Default.Equals(Pod, item.Pod) &&
                   PostCode1 == item.PostCode1 &&
                   PostCode1Is == item.PostCode1Is &&
                   Region == item.Region &&
                   RegionIs == item.RegionIs &&
                   Series == item.Series &&
                   Shpunt == item.Shpunt &&
                   Stcd1 == item.Stcd1 &&
                   Stcd1Is == item.Stcd1Is &&
                   Stcd2 == item.Stcd2 &&
                   Stcd2Is == item.Stcd2Is &&
                   Stcd3 == item.Stcd3 &&
                   Stcd3Is == item.Stcd3Is &&
                   Street == item.Street &&
                   StreetIs == item.StreetIs &&
                   StrSuppl1 == item.StrSuppl1 &&
                   StrSuppl1Is == item.StrSuppl1Is &&
                   TelNumber == item.TelNumber &&
                   TelNumberIs == item.TelNumberIs &&
                   Vbeln == item.Vbeln &&
                   ZdestCityCode == item.ZdestCityCode &&
                   ZDestCityCodeIs == item.ZDestCityCodeIs &&
                   ZField == item.ZField;

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
		/// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Atwrt);
            hash.Add(AtwrtIs);
            hash.Add(Brgew);
            hash.Add(City1);
            hash.Add(City1Is);
            hash.Add(City2);
            hash.Add(City2Is);
            hash.Add(CnpjTake);
            hash.Add(CostRel);
            hash.Add(Country);
            hash.Add(CountryIs);
            hash.Add(CountryName);
            hash.Add(CountryNameIs);
            hash.Add(DocDate);
            hash.Add(HouseNum1);
            hash.Add(HouseNum1Is);
            hash.Add(InbDocNum);
            hash.Add(Inco1);
            hash.Add(Menge);
            hash.Add(Message1);
            hash.Add(Message2);
            hash.Add(Name1);
            hash.Add(Name1Is);
            hash.Add(NFeNum);
            hash.Add(NfeTotal);
            hash.Add(Pod);
            hash.Add(PostCode1);
            hash.Add(PostCode1Is);
            hash.Add(Region);
            hash.Add(RegionIs);
            hash.Add(Series);
            hash.Add(Shpunt);
            hash.Add(Stcd1);
            hash.Add(Stcd1Is);
            hash.Add(Stcd2);
            hash.Add(Stcd2Is);
            hash.Add(Stcd3);
            hash.Add(Stcd3Is);
            hash.Add(Street);
            hash.Add(StreetIs);
            hash.Add(StrSuppl1);
            hash.Add(StrSuppl1Is);
            hash.Add(TelNumber);
            hash.Add(TelNumberIs);
            hash.Add(Vbeln);
            hash.Add(ZdestCityCode);
            hash.Add(ZDestCityCodeIs);
            hash.Add(ZField);
            return hash.ToHashCode();
        }
    }
}
