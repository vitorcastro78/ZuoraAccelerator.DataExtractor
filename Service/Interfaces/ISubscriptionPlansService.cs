using Service.Models;

namespace Service.Interfaces
{
    public interface ISubscriptionPlansService
    {
        void FillSubscriptionPlansTable(string zuoraTrackId, bool? async);

    }
}