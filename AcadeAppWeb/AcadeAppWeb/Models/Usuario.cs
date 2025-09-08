namespace AcadeAppWeb.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Username { get; set; } // Must match API
        public string? Email { get; set; }
        public string? Senha { get; set; }
    }
}
