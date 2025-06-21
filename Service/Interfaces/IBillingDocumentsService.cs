using Service.Models;

namespace Service.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBillingDocumentsService
    {



        /// <summary>
        /// Retrieves a list of billing documents based on the specified Zuora tracking ID.
        /// </summary>
        /// <remarks>Use this method to retrieve billing documents associated with a specific Zuora
        /// tracking ID. Ensure that the tracking ID is valid and corresponds to an existing request in Zuora.</remarks>
        /// <param name="zuoraTrackId">The unique tracking ID associated with the request in Zuora. This parameter cannot be null or empty.</param>
        /// <param name="async">A boolean value indicating whether the operation should be performed asynchronously.  If <see
        /// langword="true"/>, the operation is performed asynchronously; otherwise, it is performed synchronously.</param>
        /// <returns>A <see cref="BillingDocumentListResponse"/> object containing the list of billing documents. If no documents
        /// are found, the response may contain an empty list.</returns>
        BillingDocumentListResponse GetBillingDocuments(string zuoraTrackId, bool? async);

    }
}