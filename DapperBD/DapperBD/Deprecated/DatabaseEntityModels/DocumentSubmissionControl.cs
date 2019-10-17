using Dapper.Contrib.Extensions;
using System;

namespace DapperBD.DatabaseEntityModels
{
    [Table("[dbo].[document_submission_control]")]
    internal class DocumentSubmissionControl
    {
        [ExplicitKey]
        public Guid Id_Document_Submission_Control { get; set; }
        public Guid Id_Freights { get; set; }
        public int Document_Type { get; set; }
        public int Order_Number { get; set; }
        public int Status_Number { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Submitted_At { get; set; }
        public int Id_Broker { get; set; }
    }
}
