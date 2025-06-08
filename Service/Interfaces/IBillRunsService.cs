using Service.Models;

namespace Service.Interfaces
{
    public interface IBillRunsService
    {
        BillRunListResponse GetBillRuns(string zuoraTrackId, bool? async);
    }
}