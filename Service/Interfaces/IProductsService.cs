using Service.Models;

namespace Service.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductsService
    {
        /// <summary>
        /// Fill Products Table
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        void FillProductsTable(string zuoraTrackId, bool? async);

    }
}