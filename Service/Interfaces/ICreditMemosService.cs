using Service.Models;

namespace Service.Interfaces
{
    public interface ICreditMemosService
    {
        void FillCreditMemoItemsTable(string zuoraTrackId, bool? async);
        void FillCreditMemoTable(string zuoraTrackId, bool? async);
    }
}