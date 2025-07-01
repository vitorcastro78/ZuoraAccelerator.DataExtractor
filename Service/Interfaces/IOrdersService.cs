using Service.Models;

namespace Service.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrdersService
    {

        void FillOrdersTable(string zuoraTrackId, bool? async);

      
    }
}