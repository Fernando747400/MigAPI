namespace APIF747.Models
{
    public class TodoItem
    {
        public long TodoItemId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsComplete { get; set; }
    }
}
