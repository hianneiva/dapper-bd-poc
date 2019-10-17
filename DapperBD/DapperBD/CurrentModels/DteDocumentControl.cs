using System;

namespace DapperBD.CurrentModels
{
    /// <summary>
    /// Keep the information regarding the document submission process.
    /// </summary>
    [Orm(Name = "document_submission_control", IdName = "id_document_submission_control")]
    public class DteDocumentControl : BaseEntity
    {
        /// <summary>
        /// DteDocument status used to control submission process.
        /// </summary>
        public enum DteDocumentStatus : int
        {
            /// <summary>
            /// The document has not been created yet.
            /// </summary>
            Pending = 0,
            /// <summary>
            /// The document was created. (Initial state).
            /// </summary>
            Created = 1,
            /// <summary>
            /// The document was issued by the Broker successfully.
            /// </summary>
            Submitted = 2,
            /// <summary>
            /// The document could not be issued by the Broker.
            /// </summary>            
            Failed = 99
        }

        /// <summary>
        /// The Freights related id.
        /// </summary>
        [Orm(Name = "id_freights")]
        public Guid FreightsId { get; set; }

        /// <summary>
        /// The type of the document.
        /// </summary>
        [Orm(Name = "document_type")]
        public int DocType { get; set; }

        /// <summary>
        /// The order the document should be sent submited.
        /// </summary>
        [Orm(Name = "order_number")]
        public int Order { get; set; }

        /// <summary>
        /// The current submission status of the document.
        /// </summary>
        [Orm(Name = "status_number")]
        public DteDocumentStatus Status { get; set; }

        /// <summary>
        /// Constructor.
        /// Creates a new DteDocumentControl with Status as DteDocumentStatus.Pending.
        /// </summary>
        /// <param name="freightsId">The Freights related id.</param>
        /// <param name="documentType">The type of the document.</param>
        /// <param name="order">The order the document should be sent submited.</param>
        public DteDocumentControl(Guid freightsId, int documentType, int order)
        {
            FreightsId = freightsId;
            DocType = documentType;
            Order = order;
            Status = DteDocumentStatus.Pending;
        }

        /// <summary>
        /// Constructor.
        /// Creates a new DteDocumentControl without parameters. Used for Reflection related operations.
        /// </summary>
        public DteDocumentControl()
        {
            Status = DteDocumentStatus.Pending;
        }
    }
}
