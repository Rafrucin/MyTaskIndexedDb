using Blazor.IndexedDB.Framework;
using MyTaskIndexedDb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTaskIndexedDb.Service
{
    public class TaskService : ITaskService
    {
        private readonly IIndexedDbFactory _indexedDbFactory;

        public TaskService(IIndexedDbFactory indexedDbFactory)
        {
            _indexedDbFactory = indexedDbFactory;
        }

        public async Task DeleteTaskAsync(TaskModel model)
        {
            using var db = await this._indexedDbFactory.Create<TaskDb>();
            db.Tasks.Remove(model);
            await db.SaveChanges();
        }

        public async Task AddTaskAsync(TaskModel model)
        {
            using var db = await this._indexedDbFactory.Create<TaskDb>();
            db.Tasks.Add(model);
            await db.SaveChanges();
        }

        public async Task EditTaskAsync(TaskModel model)
        {
            if (model.Id != 0)
            {
                using (var db = await this._indexedDbFactory.Create<TaskDb>())
                {
                    var editedTask = db.Tasks.Single(x => x.Id == model.Id);
                    editedTask.IsDone = model.IsDone;
                    await db.SaveChanges();
                }
            }
        }

        public async Task<List<TaskModel>> GetTasksAsync()
        {
            using var db = await _indexedDbFactory.Create<TaskDb>();

            var result = db.Tasks.ToList();
            return result;
        }
    }
}
