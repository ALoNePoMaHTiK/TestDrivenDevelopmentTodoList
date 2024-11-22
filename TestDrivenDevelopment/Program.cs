namespace TestDrivenDevelopment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class ToDoListManager
    {
        private List<ToDoListItem> ToDoList = new List<ToDoListItem> ();

        public void AddToDoListItem(string taskName)
        {
            ToDoList.Add(new ToDoListItem(taskName));
        }
        
        public List<ToDoListItem> GetToDoList()
        {
            return ToDoList;
        }

        public class ToDoListItem
        {
            public ToDoListItem(string taskName)
            {
                Name = taskName;
            }
            public string Name { get; set; } = "Задача";
            public bool IsCompleted { get; set; } = false;
        }
    }
}
