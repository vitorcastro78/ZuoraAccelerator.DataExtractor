using Service.Models;

namespace Service.Interfaces
{
    public interface ICreditMemosService
    {
        CreditMemoItemListResponse GetCreditMemoItems(string zuoraTrackId, bool? async);
        CreditMemoListResponse GetCreditMemos(string zuoraTrackId, bool? async);
    }
}