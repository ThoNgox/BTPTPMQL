namespace DemoMVC.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string? Name { get; set; } // Cho phép null
        public int Age { get; set; }
        public string? Email { get; set; } // Cho phép null
    }
}
