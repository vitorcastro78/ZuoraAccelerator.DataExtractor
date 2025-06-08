using Service.Models;

namespace Service.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentMethodsService
    {

        /// <summary>
        /// Retrieves a list of payment methods associated with a specific Zuora track ID.
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        void GetPaymentMethods(string zuoraTrackId, bool? async);
    }
}