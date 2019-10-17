using Dapper.Contrib.Extensions;
using System;

namespace DapperBD.DatabaseEntityModels
{
    [Table("[dbo].[document_submission_control_event]")]
    internal class DocumentSubmissionControlEvent
    {
        [ExplicitKey]
        public Guid Id_Document_Submission_Control_Event { get; set; }
        public Guid Id_Document_Event_Type { get; set; }
        public Guid Id_Document_Submission_Control { get; set; }
        public Guid Id_Freights { get; set; }
        public Guid Id_Document { get; set; }
        public DateTime Created_At { get; set; }
        public string Notes { get; set; }
    }
}
