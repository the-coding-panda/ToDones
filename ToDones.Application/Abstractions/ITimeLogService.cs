namespace ToDones.Application.Abstractions
{
    public interface ITimeLogService
    {
        void StartTimer(int taskId);
        void EndTimer(int tasklogId);
    }
}
