using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TaskItem
    {
        public static List<TaskItem> TaskItems = new List<TaskItem>();

        public TaskItem(int taskId, string? taskDescription, bool isCompleted)
        {
            TaskId = taskId;
            TaskDescription = taskDescription;
            IsCompleted = isCompleted;
        }

        public int TaskId { get; set; }
        public string? TaskDescription { get; set; }
        public bool IsCompleted { get; set; }

        public static void DisplayTask()
        {
            Console.WriteLine("Tasks are;");
          //  Console.WriteLine("Tasks are\n1.Video game\n2.run\n3.MMA\n4.Party");
         // var des = TaskItems.FindAll(x =>x.TaskDescription != null);
            foreach (var item in TaskItems) 
            {
                Console.WriteLine(item.TaskId + " " + item.TaskDescription);
            
            }
        }
        public static void FilteringTask()
        {
            var completedTask = TaskItems.FindAll(x => x.IsCompleted == true);
            var notCompleted = TaskItems.FindAll(x => x.IsCompleted == false);
            if (completedTask.Count > 0)
            {
                foreach (var task in completedTask)
                {
                    Console.WriteLine("TaskName:{0}\tStatus:{1}", task.TaskDescription, task.IsCompleted);
                }
            }
            if (notCompleted.Count > 0)
            {
                foreach (var task in notCompleted)
                {
                    Console.WriteLine("TaskName:{0}\tStatus:{1}", task.TaskDescription, task.IsCompleted);
                }
            }
        }
    }
}
