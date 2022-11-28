using Microsoft.AspNetCore.Server.IIS.Core;
using System.Runtime.Serialization;

namespace TodoApp.Model
{
    public class TodoItem
    {
        public static List<TodoItem> list = new List<TodoItem>();
        public static int idg = 0;
        public int id;
        public string title;
        public string desc;
        
        public TodoItem(string title, string desc)
        {
            this.title = title;
            this.desc = desc;
            id = idg;
            idg++;
        }
    }
}
