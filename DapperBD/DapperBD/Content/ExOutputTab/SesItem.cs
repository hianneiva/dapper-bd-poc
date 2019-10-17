using Newtonsoft.Json;
using System;

namespace Blive.Unilever.Dte.SharedModels.Freights.QueryFreights.ExOutputTab
{
    /// <summary>
    /// The Individual Item of the JSON Array existing in the Ses Object, returned in the payload by the Query Freight interface (SD18 Mulesoft).
    /// </summary>
    public class SesItem
    {
        /// <summary>
        /// TODO: Document acntDetStat
        /// </summary>
        [JsonProperty("acntDetStat")]
        public string AcntDetStat { get; private set; }

        /// <summary>
        /// TODO: Document aedat
        /// </summary>
        [JsonProperty("aedat")]
        public string Aedat { get; private set; }

        /// <summary>
        /// TODO: Document aufnr
        /// </summary>
        [JsonProperty("aufnr")]
        public string Aufnr { get; private set; }

        /// <summary>
        /// TODO: Document bsart
        /// </summary>
        [JsonProperty("bsart")]
        public string Bsart { get; private set; }

        /// <summary>
        /// TODO: Document calcStat
        /// </summary>
        [JsonProperty("calcStat")]
        public string CalcStat { get; private set; }

        /// <summary>
        /// TODO: Document createDate
        /// </summary>
        [JsonProperty("createDate")]
        public string CreateDate { get; private set; }

        /// <summary>
        /// TODO: Document ebeln
        /// </summary>
        [JsonProperty("ebeln")]
        public string Ebeln { get; private set; }

        /// <summary>
        /// TODO: Document erdat
        /// </summary>
        [JsonProperty("erdat")]
        public string Erdat { get; private set; }

        /// <summary>
        /// TODO: Document fknum
        /// </summary>
        [JsonProperty("fknum")]
        public string Fknum { get; private set; }

        /// <summary>
        /// TODO: Document grossValue
        /// </summary>
        [JsonProperty("grossValue")]
        public double GrossValue { get; private set; }

        /// <summary>
        /// TODO: Document kawrtCofins
        /// </summary>
        [JsonProperty("kawrtCofins")]
        public double KawrtCofins { get; private set; }

        /// <summary>
        /// TODO: Document kawrtIcms
        /// </summary>
        [JsonProperty("kawrtIcms")]
        public double KawrtIcms { get; private set; }

        /// <summary>
        /// TODO: Document kawrtIss
        /// </summary>
        [JsonProperty("kawrtIss")]
        public double KawrtIss { get; private set; }

        /// <summary>
        /// TODO: Document kawrtPis
        /// </summary>
        [JsonProperty("kawrtPis")]
        public double KawrtPis { get; private set; }

        /// <summary>
        /// TODO: Document kbetrCofinsAli
        /// </summary>
        [JsonProperty("kbetrCofinsAli")]
        public double KbetrCofinsAli { get; private set; }

        /// <summary>
        /// TODO: Document kbetrIcmsAli
        /// </summary>
        [JsonProperty("kbetrIcmsAli")]
        public double KbetrIcmsAli { get; private set; }

        /// <summary>
        /// TODO: Document kbetrIcmsExe
        /// </summary>
        [JsonProperty("kbetrIcmsExe")]
        public string KbetrIcmsExe { get; private set; }

        /// <summary>
        /// TODO: Document kbetrIssAli
        /// </summary>
        [JsonProperty("kbetrIssAli")]
        public double KbetrIssAli { get; private set; }

        /// <summary>
        /// TODO: Document kbetrPsAli
        /// </summary>
        [JsonProperty("kbetrPsAli")]
        public double KbetrPsAli { get; private set; }

        /// <summary>
        /// TODO: Document knttp
        /// </summary>
        [JsonProperty("knttp")]
        public string Knttp { get; private set; }

        /// <summary>
        /// TODO: Document kostl
        /// </summary>
        [JsonProperty("kostl")]
        public string Kostl { get; private set; }

        /// <summary>
        /// TODO: Document ktext1
        /// </summary>
        [JsonProperty("ktext1")]
        public string Ktext1 { get; private set; }

        /// <summary>
        /// TODO: Document kwertCofinsVal
        /// </summary>
        [JsonProperty("kwertCofinsVal")]
        public double KwertCofinsVal { get; private set; }

        /// <summary>
        /// TODO: Document kwertIcmsPre
        /// </summary>
        [JsonProperty("kwertIcmsPre")]
        public double KwertIcmsPre { get; private set; }

        /// <summary>
        /// TODO: Document kwertIcmsSt
        /// </summary>
        [JsonProperty("kwertIcmsSt")]
        public double KwertIcmsSt { get; private set; }

        /// <summary>
        /// TODO: Document kwertIcmsVal
        /// </summary>
        [JsonProperty("kwertIcmsVal")]
        public double KwertIcmsVal { get; private set; }

        /// <summary>
        /// TODO: Document kwertIssVal
        /// </summary>
        [JsonProperty("kwertIssVal")]
        public double KwertIssVal { get; private set; }

        /// <summary>
        /// TODO: Document kwertPisVal
        /// </summary>
        [JsonProperty("kwertPisVal")]
        public double KwertPisVal { get; private set; }

        /// <summary>
        /// TODO: Document lblni
        /// </summary>
        [JsonProperty("lblni")]
        public string Lblni { get; private set; }

        /// <summary>
        /// TODO: Document mwskz
        /// </summary>
        [JsonProperty("mwskz")]
        public string Mwskz { get; private set; }

        /// <summary>
        /// TODO: Document netValue
        /// </summary>
        [JsonProperty("netValue")]
        public double NetValue { get; private set; }

        /// <summary>
        /// TODO: Document sakto
        /// </summary>
        [JsonProperty("sakto")]
        public string Sakto { get; private set; }

        /// <summary>
        /// TODO: Document transferStat
        /// </summary>
        [JsonProperty("transferStat")]
        public string TransferStat { get; private set; }

        /// <summary>
        /// TODO: Document waers
        /// </summary>
        [JsonProperty("waers")]
        public string Waers { get; private set; }

        /// <summary>
        /// TODO: Document werks
        /// </summary>
        [JsonProperty("werks")]
        public string Werks { get; private set; }

        /// <summary>
        /// TODO: Document zbasered
        /// </summary>
        [JsonProperty("zbasered")]
        public double Zbasered { get; private set; }

        /// <summary>
        /// TODO: Document zcust
        /// </summary>
        [JsonProperty("zcust")]
        public string Zcust { get; private set; }

        /// <summary>
        /// TODO: Document zsimpleop
        /// </summary>
        [JsonProperty("zsimpleop")]
        public string Zsimpleop { get; private set; }

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the this instance.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj) => obj is SesItem item &&
                   AcntDetStat == item.AcntDetStat &&
                   Aedat == item.Aedat &&
                   Aufnr == item.Aufnr &&
                   Bsart == item.Bsart &&
                   CalcStat == item.CalcStat &&
                   CreateDate == item.CreateDate &&
                   Ebeln == item.Ebeln &&
                   Erdat == item.Erdat &&
                   Fknum == item.Fknum &&
                   GrossValue == item.GrossValue &&
                   KawrtCofins == item.KawrtCofins &&
                   KawrtIcms == item.KawrtIcms &&
                   KawrtIss == item.KawrtIss &&
                   KawrtPis == item.KawrtPis &&
                   KbetrCofinsAli == item.KbetrCofinsAli &&
                   KbetrIcmsAli == item.KbetrIcmsAli &&
                   KbetrIcmsExe == item.KbetrIcmsExe &&
                   KbetrIssAli == item.KbetrIssAli &&
                   KbetrPsAli == item.KbetrPsAli &&
                   Knttp == item.Knttp &&
                   Kostl == item.Kostl &&
                   Ktext1 == item.Ktext1 &&
                   KwertCofinsVal == item.KwertCofinsVal &&
                   KwertIcmsPre == item.KwertIcmsPre &&
                   KwertIcmsSt == item.KwertIcmsSt &&
                   KwertIcmsVal == item.KwertIcmsVal &&
                   KwertIssVal == item.KwertIssVal &&
                   KwertPisVal == item.KwertPisVal &&
                   Lblni == item.Lblni &&
                   Mwskz == item.Mwskz &&
                   NetValue == item.NetValue &&
                   Sakto == item.Sakto &&
                   TransferStat == item.TransferStat &&
                   Waers == item.Waers &&
                   Werks == item.Werks &&
                   Zbasered == item.Zbasered &&
                   Zcust == item.Zcust &&
                   Zsimpleop == item.Zsimpleop;

        /// <summary>
        /// Combines the hash code for multiple values into a single hash code.
        /// </summary>
		/// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(AcntDetStat);
            hash.Add(Aedat);
            hash.Add(Aufnr);
            hash.Add(Bsart);
            hash.Add(CalcStat);
            hash.Add(CreateDate);
            hash.Add(Ebeln);
            hash.Add(Erdat);
            hash.Add(Fknum);
            hash.Add(GrossValue);
            hash.Add(KawrtCofins);
            hash.Add(KawrtIcms);
            hash.Add(KawrtIss);
            hash.Add(KawrtPis);
            hash.Add(KbetrCofinsAli);
            hash.Add(KbetrIcmsAli);
            hash.Add(KbetrIcmsExe);
            hash.Add(KbetrIssAli);
            hash.Add(KbetrPsAli);
            hash.Add(Knttp);
            hash.Add(Kostl);
            hash.Add(Ktext1);
            hash.Add(KwertCofinsVal);
            hash.Add(KwertIcmsPre);
            hash.Add(KwertIcmsSt);
            hash.Add(KwertIcmsVal);
            hash.Add(KwertIssVal);
            hash.Add(KwertPisVal);
            hash.Add(Lblni);
            hash.Add(Mwskz);
            hash.Add(NetValue);
            hash.Add(Sakto);
            hash.Add(TransferStat);
            hash.Add(Waers);
            hash.Add(Werks);
            hash.Add(Zbasered);
            hash.Add(Zcust);
            hash.Add(Zsimpleop);
            return hash.ToHashCode();
        }
    }
}
