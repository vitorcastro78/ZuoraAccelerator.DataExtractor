using Service.Models;

namespace Service.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBillingDocumentsService
    {
        void FillBillingDocumentsTable(string zuoraTrackId, bool? async);

    }
}