using Dapper.Contrib.Extensions;
using System;

namespace DapperBD
{
    internal abstract class EventHandlerData
    {
        [ExplicitKey]
        public Guid Id { get; set; }
        public int Level { get; set; }
        public string Class { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }

    [Table("[event_handler].[a_table]")]
    internal class ATable : EventHandlerData { }

    [Table("[event_handler].[log]")]
    internal class EventHandlerLog : EventHandlerData { }

    [Table("[event_handler].[tipotransportadora]")]
    internal class EventHandlerTipoTransportadora : EventHandlerData { }

    [Table("[event_handler].[tipo_transportadora]")]
    internal class EventHandlerTipoTransportadoraAlt : EventHandlerData { }

    [Table("[event_handler].[version]")]
    internal class Version
    {
        [Key]
        public Guid Id { get; set; }
        public int DbVersion { get; set; }
        public int ServiceVersion { get; set; }
        public DateTime Date { get; set; }
    }
}
