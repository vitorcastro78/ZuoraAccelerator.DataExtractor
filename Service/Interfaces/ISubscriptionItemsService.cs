using Service.Models;

namespace Service.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISubscriptionItemsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        void FillSubscriptionItemsTable(string zuoraTrackId, bool async);


    }
}