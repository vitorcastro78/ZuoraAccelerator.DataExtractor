namespace Service.Interfaces
{
    public interface ISubscriptionsService
    {
        void FillSubscriptionsTable(string zuoraTrackId, bool async);
    }
}