namespace ToDones.Application.Abstractions
{
    interface ITimeLogService
    {
        void StartTimer(int taskId);
        void EndTimer(int taskId);
    }
}
