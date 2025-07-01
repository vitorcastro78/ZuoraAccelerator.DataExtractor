using Service.Models;

namespace Service.Interfaces
{
    public interface IDebitMemosService
    {
        void FillDebitMemoTable(string zuoraTrackId, bool? async);

        void FillDebitMemoItemsTable(string zuoraTrackId, bool? async);
    }
}