namespace Clase26_05_ClienteHTTP.Models
{
    public class Tarea
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; } = null!;
        public bool completed { get; set; }
    }
}