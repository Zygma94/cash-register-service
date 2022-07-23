namespace CashRegister.Models
{
    public class Task
    {
        public long TaskId { get; set; }

        public string Text { get; set; } = null!;

        public bool IsCompleted { get; set; }
    }
}