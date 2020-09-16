using Blazor.IndexedDB.Framework;
using Microsoft.JSInterop;
using MyTaskIndexedDb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTaskIndexedDb.Service
{
    public class TaskDb: IndexedDb
    {
        public TaskDb(IJSRuntime jSRuntime, string name, int version) : base(jSRuntime, name, version) { }
        
        public IndexedSet<TaskModel> Tasks { get; set; }      
    }
}
