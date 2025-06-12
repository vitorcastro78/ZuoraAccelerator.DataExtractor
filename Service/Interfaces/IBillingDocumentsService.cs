using Service.Models;

namespace Service.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBillingDocumentsService
    {

        /// <summary>
        /// List billing documents
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        void GetBillingDocuments(string zuoraTrackId, bool? async);

    }
}