using Dapper.Contrib.Extensions;
using System;

namespace DapperBD.DatabaseEntityModels
{
    [Table("[dbo].[freight]")]
    internal class Freight
    {
        [ExplicitKey]
        public Guid Id_Freights { get; set; }
        public string Shipment_Number { get; set; }
        public string Payload { get; set; }
        public DateTime Insert_Date { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Last_Updated_At { get; set; }
        public DateTime Ready_At { get; set; }
    }
}
