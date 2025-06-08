namespace Service.Interfaces
{
    public interface IPlansService
    {
        void FillPlansTable(string zuoraTrackId, bool async);
    }
}