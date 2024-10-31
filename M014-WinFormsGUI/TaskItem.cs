namespace M014_WinFormsGUI
{
    public class TaskItem
    {
        public string Title { get; }
        public string Priority { get; }

        public TaskItem(string title, string priority = "")
        {
            Title = title;
            Priority = priority;
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Priority))
            {
                return Title;
            }
            return Title + " (" + Priority + ")";
        }
    }
}
