using Service.Models;

namespace Service.Interfaces
{
    public interface IDebitMemosService
    {
        DebitMemoItemListResponse GetDebitMemoItems(string zuoraTrackId, bool? async);
        DebitMemoListResponse GetDebitMemos(string zuoraTrackId, bool? async);
    }
}