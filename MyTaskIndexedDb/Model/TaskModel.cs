using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTaskIndexedDb.Model
{
    public class TaskModel
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string TaskName { get; set; }

        [MaxLength(100)]
        public string IsDone { get; set; } = "0";
    }
}
