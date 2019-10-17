using Dapper.Contrib.Extensions;
using System;

namespace DapperBD.DatabaseEntityModels
{
    [Table("[dbo].[freight_event]")]
    internal class FreightEvent
    {
        [ExplicitKey]
        public Guid Id_Freights_Log { get; set; }
        public Guid Id_Freights { get; set; }
        public int Id_Freights_Event_Type { get; set; }
        public DateTime Created_At { get; set; }
        public string Notes { get; set; }
    }
}
