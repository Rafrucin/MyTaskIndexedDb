using MyTaskIndexedDb.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTaskIndexedDb.Service
{
    public interface ITaskService
    {
        Task AddTaskAsync(TaskModel model);
        Task DeleteTaskAsync(TaskModel model);
        Task EditTaskAsync(TaskModel model);
        Task<List<TaskModel>> GetTasksAsync();
    }
}