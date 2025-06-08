using Service.Models;

namespace Service.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IQueryRunsService
    {

        /// <summary>
        /// Retrieves a QueryRun by its ID and Zuora track ID.
        /// </summary>
        /// <param name="queryRunId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        QueryRun GetQueryRun(string queryRunId, string zuoraTrackId, bool? async);

    }
}