namespace дз9.Pages
{
    public interface ITaskService
    {
        List<UserTask> GetAllTasks();
        void CreateTask(string title, string? description);
    }
}

