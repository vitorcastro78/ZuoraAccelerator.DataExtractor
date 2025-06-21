using Service.Models;

namespace Service.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IContactsService
    {
        /// <summary>
        /// Fills the accounts table with contact data.
        /// </summary>
        /// <param name="zuoraTrackId">The Zuora track ID.</param>
        /// <param name="async">Indicates whether the operation should be asynchronous.</param>
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        void FillContactsTable(string zuoraTrackId, bool? async);
    }
}