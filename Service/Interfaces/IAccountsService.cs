using Service.Models;

namespace Service.Interfaces
{
    /// <summary>
    /// Interface for managing account operations in the Zuora API.
    /// Provides methods for creating, retrieving, updating, and deleting accounts.
    /// </summary>
    public interface IAccountsService
    {
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        void FillAccountsTable(string zuoraTrackId, bool? async);

    }
}