namespace Service.Interfaces
{
    public interface IInvoicesService
    {
        void FillInvoicesItemsTable(string zuoraTrackId, bool async);
        void FillInvoicesTable(string zuoraTrackId, bool async);
    }
}