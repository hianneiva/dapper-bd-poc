using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ExOutputTab
{
    /// <summary>
    /// The Individual Item of the JSON Array existing in the Stage Object, returned in the payload by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class StageItem
    {
        /// <summary>
        /// TODO: Document cteReady
        /// </summary>
        [JsonProperty("cteReady")]
        public string CteReady { get; private set; }

        /// <summary>
        /// TODO: Document delSyst
        /// </summary>
        [JsonProperty("delSyst")]
        public string DelSyst { get; private set; }

        /// <summary>
        /// TODO: Document destCity
        /// </summary>
        [JsonProperty("destCity")]
        public string DestCity { get; private set; }

        /// <summary>
        /// TODO: Document destCountry
        /// </summary>
        [JsonProperty("destCountry")]
        public string DestCountry { get; private set; }

        /// <summary>
        /// TODO: Document destCustomer
        /// </summary>
        [JsonProperty("destCustomer")]
        public string DestCustomer { get; private set; }

        /// <summary>
        /// TODO: Document destNode
        /// </summary>
        [JsonProperty("destNode")]
        public string DestNode { get; private set; }

        /// <summary>
        /// TODO: Document destNodeDesc
        /// </summary>
        [JsonProperty("destNodeDesc")]
        public string DestNodeDesc { get; private set; }

        /// <summary>
        /// TODO: Document destPlantCode
        /// </summary>
        [JsonProperty("destPlantCode")]
        public string DestPlantCode { get; private set; }

        /// <summary>
        /// TODO: Document destPlantDesc
        /// </summary>
        [JsonProperty("destPlantDesc")]
        public string DestPlantDesc { get; private set; }

        /// <summary>
        /// TODO: Document destPostCode
        /// </summary>
        [JsonProperty("destPostCode")]
        public string DestPostCode { get; private set; }

        /// <summary>
        /// TODO: Document destShipPnt
        /// </summary>
        [JsonProperty("destShipPnt")]
        public string DestShipPnt { get; private set; }

        /// <summary>
        /// TODO: Document destShipPntDesc
        /// </summary>
        [JsonProperty("destShipPntDesc")]
        public string DestShipPntDesc { get; private set; }

        /// <summary>
        /// TODO: Document destTariff
        /// </summary>
        [JsonProperty("destTariff")]
        public string DestTariff { get; private set; }

        /// <summary>
        /// TODO: Document destVendor
        /// </summary>
        [JsonProperty("destVendor")]
        public string DestVendor { get; private set; }

        /// <summary>
        /// TODO: Document distance
        /// </summary>
        [JsonProperty("distance")]
        public double Distance { get; private set; }

        /// <summary>
        /// TODO: Document equipNumb
        /// </summary>
        [JsonProperty("equipNumb")]
        public long EquipNumb { get; private set; }

        /// <summary>
        /// TODO: Document equipType
        /// </summary>
        [JsonProperty("equipType")]
        public string EquipType { get; private set; }

        /// <summary>
        /// TODO: Document freeFreight
        /// </summary>
        [JsonProperty("freeFreight")]
        public string FreeFreight { get; private set; }

        /// <summary>
        /// TODO: Document grossValue
        /// </summary>
        [JsonProperty("grossValue")]
        public double GrossValue { get; private set; }

        /// <summary>
        /// TODO: Document grouping
        /// </summary>
        [JsonProperty("grouping")]
        public string Grouping { get; private set; }

        /// <summary>
        /// TODO: Document incoterms
        /// </summary>
        [JsonProperty("incoterms")]
        public string Incoterms { get; private set; }

        /// <summary>
        /// TODO: Document legInd
        /// </summary>
        [JsonProperty("legInd")]
        public string LegInd { get; private set; }

        /// <summary>
        /// TODO: Document legIndDesc
        /// </summary>
        [JsonProperty("legIndDesc")]
        public string LegIndDesc { get; private set; }

        /// <summary>
        /// TODO: Document loadFm
        /// </summary>
        [JsonProperty("loadFm")]
        public string LoadFm { get; private set; }

        /// <summary>
        /// TODO: Document loadType
        /// </summary>
        [JsonProperty("loadType")]
        public string LoadType { get; private set; }

        /// <summary>
        /// TODO: Document log
        /// </summary>
        [JsonProperty("log")]
        public LogElement Log { get; private set; }

        /// <summary>
        /// TODO: Document minFreight
        /// </summary>
        [JsonProperty("minFreight")]
        public string MinFreight { get; private set; }

        /// <summary>
        /// TODO: Document nfe
        /// </summary>
        [JsonProperty("nfe")]
        public NfeElement Nfe { get; private set; }

        /// <summary>
        /// TODO: Document origCity
        /// </summary>
        [JsonProperty("origCity")]
        public string OrigCity { get; private set; }

        /// <summary>
        /// TODO: Document origCountry
        /// </summary>
        [JsonProperty("origCountry")]
        public string OrigCountry { get; private set; }

        /// <summary>
        /// TODO: Document origCustomer
        /// </summary>
        [JsonProperty("origCustomer")]
        public string OrigCustomer { get; private set; }

        /// <summary>
        /// TODO: Document originTariff
        /// </summary>
        [JsonProperty("originTariff")]
        public string OriginTariff { get; private set; }

        /// <summary>
        /// TODO: Document origNode
        /// </summary>
        [JsonProperty("origNode")]
        public string OrigNode { get; private set; }

        /// <summary>
        /// TODO: Document origNodeDesc
        /// </summary>
        [JsonProperty("origNodeDesc")]
        public string OrigNodeDesc { get; private set; }

        /// <summary>
        /// TODO: Document origPlantCode
        /// </summary>
        [JsonProperty("origPlantCode")]
        public string OrigPlantCode { get; private set; }

        /// <summary>
        /// TODO: Document origPlantDesc
        /// </summary>
        [JsonProperty("origPlantDesc")]
        public string OrigPlantDesc { get; private set; }

        /// <summary>
        /// TODO: Document origPostCode
        /// </summary>
        [JsonProperty("origPostCode")]
        public string OrigPostCode { get; private set; }

        /// <summary>
        /// TODO: Document origShipPnt
        /// </summary>
        [JsonProperty("origShipPnt")]
        public string OrigShipPnt { get; private set; }

        /// <summary>
        /// TODO: Document origShipPntDesc
        /// </summary>
        [JsonProperty("origShipPntDesc")]
        public string OrigShipPntDesc { get; private set; }

        /// <summary>
        /// TODO: Document origVendor
        /// </summary>
        [JsonProperty("origVendor")]
        public string OrigVendor { get; private set; }

        /// <summary>
        /// TODO: Document palletCount
        /// </summary>
        [JsonProperty("palletCount")]
        public double PalletCount { get; private set; }

        /// <summary>
        /// TODO: Document partner
        /// </summary>
        [JsonProperty("partner")]
        public PartnerElement Partner { get; private set; }

        /// <summary>
        /// TODO: Document plant
        /// </summary>
        [JsonProperty("plant")]
        public string Plant { get; private set; }

        /// <summary>
        /// TODO: Document pricinCalcDat
        /// </summary>
        [JsonProperty("pricinCalcDat")]
        public string PricinCalcDat { get; private set; }

        /// <summary>
        /// TODO: Document pricing
        /// </summary>
        [JsonProperty("pricing")]
        public PricingElement Pricing { get; private set; }

        /// <summary>
        /// TODO: Document ses
        /// </summary>
        [JsonProperty("ses")]
        public SesElement Ses { get; private set; }

        /// <summary>
        /// TODO: Document shipProc
        /// </summary>
        [JsonProperty("shipProc")]
        public string ShipProc { get; private set; }

        /// <summary>
        /// TODO: Document stcd1
        /// </summary>
        [JsonProperty("stcd1")]
        public string Stcd1 { get; private set; }

        /// <summary>
        /// TODO: Document toll
        /// </summary>
        [JsonProperty("toll")]
        public double Toll { get; private set; }

        /// <summary>
        /// TODO: Document tsnum
        /// </summary>
        [JsonProperty("tsnum")]
        public long Tsnum { get; private set; }

        /// <summary>
        /// TODO: Document vbeln
        /// </summary>
        [JsonProperty("vbeln")]
        public string Vbeln { get; private set; }

        /// <summary>
        /// TODO: Document vp
        /// </summary>
        [JsonProperty("vp")]
        public VpElement Vp { get; private set; }

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the this instance.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj) => obj is StageItem item &&
                   CteReady == item.CteReady &&
                   DelSyst == item.DelSyst &&
                   DestCity == item.DestCity &&
                   DestCountry == item.DestCountry &&
                   DestCustomer == item.DestCustomer &&
                   DestNode == item.DestNode &&
                   DestNodeDesc == item.DestNodeDesc &&
                   DestPlantCode == item.DestPlantCode &&
                   DestPlantDesc == item.DestPlantDesc &&
                   DestPostCode == item.DestPostCode &&
                   DestShipPnt == item.DestShipPnt &&
                   DestShipPntDesc == item.DestShipPntDesc &&
                   DestTariff == item.DestTariff &&
                   DestVendor == item.DestVendor &&
                   Distance == item.Distance &&
                   EquipNumb == item.EquipNumb &&
                   EquipType == item.EquipType &&
                   FreeFreight == item.FreeFreight &&
                   GrossValue == item.GrossValue &&
                   Grouping == item.Grouping &&
                   Incoterms == item.Incoterms &&
                   LegInd == item.LegInd &&
                   LegIndDesc == item.LegIndDesc &&
                   LoadFm == item.LoadFm &&
                   LoadType == item.LoadType &&
                   EqualityComparer<LogElement>.Default.Equals(Log, item.Log) &&
                   MinFreight == item.MinFreight &&
                   EqualityComparer<NfeElement>.Default.Equals(Nfe, item.Nfe) &&
                   OrigCity == item.OrigCity &&
                   OrigCountry == item.OrigCountry &&
                   OrigCustomer == item.OrigCustomer &&
                   OriginTariff == item.OriginTariff &&
                   OrigNode == item.OrigNode &&
                   OrigNodeDesc == item.OrigNodeDesc &&
                   OrigPlantCode == item.OrigPlantCode &&
                   OrigPlantDesc == item.OrigPlantDesc &&
                   OrigPostCode == item.OrigPostCode &&
                   OrigShipPnt == item.OrigShipPnt &&
                   OrigShipPntDesc == item.OrigShipPntDesc &&
                   OrigVendor == item.OrigVendor &&
                   PalletCount == item.PalletCount &&
                   EqualityComparer<PartnerElement>.Default.Equals(Partner, item.Partner) &&
                   Plant == item.Plant &&
                   PricinCalcDat == item.PricinCalcDat &&
                   EqualityComparer<PricingElement>.Default.Equals(Pricing, item.Pricing) &&
                   EqualityComparer<SesElement>.Default.Equals(Ses, item.Ses) &&
                   ShipProc == item.ShipProc &&
                   Stcd1 == item.Stcd1 &&
                   Toll == item.Toll &&
                   Tsnum == item.Tsnum &&
                   Vbeln == item.Vbeln &&
                   EqualityComparer<VpElement>.Default.Equals(Vp, item.Vp);

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
		/// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(CteReady);
            hash.Add(DelSyst);
            hash.Add(DestCity);
            hash.Add(DestCountry);
            hash.Add(DestCustomer);
            hash.Add(DestNode);
            hash.Add(DestNodeDesc);
            hash.Add(DestPlantCode);
            hash.Add(DestPlantDesc);
            hash.Add(DestPostCode);
            hash.Add(DestShipPnt);
            hash.Add(DestShipPntDesc);
            hash.Add(DestTariff);
            hash.Add(DestVendor);
            hash.Add(Distance);
            hash.Add(EquipNumb);
            hash.Add(EquipType);
            hash.Add(FreeFreight);
            hash.Add(GrossValue);
            hash.Add(Grouping);
            hash.Add(Incoterms);
            hash.Add(LegInd);
            hash.Add(LegIndDesc);
            hash.Add(LoadFm);
            hash.Add(LoadType);
            hash.Add(Log);
            hash.Add(MinFreight);
            hash.Add(Nfe);
            hash.Add(OrigCity);
            hash.Add(OrigCountry);
            hash.Add(OrigCustomer);
            hash.Add(OriginTariff);
            hash.Add(OrigNode);
            hash.Add(OrigNodeDesc);
            hash.Add(OrigPlantCode);
            hash.Add(OrigPlantDesc);
            hash.Add(OrigPostCode);
            hash.Add(OrigShipPnt);
            hash.Add(OrigShipPntDesc);
            hash.Add(OrigVendor);
            hash.Add(PalletCount);
            hash.Add(Partner);
            hash.Add(Plant);
            hash.Add(PricinCalcDat);
            hash.Add(Pricing);
            hash.Add(Ses);
            hash.Add(ShipProc);
            hash.Add(Stcd1);
            hash.Add(Toll);
            hash.Add(Tsnum);
            hash.Add(Vbeln);
            hash.Add(Vp);
            return hash.ToHashCode();
        }
    }
}
