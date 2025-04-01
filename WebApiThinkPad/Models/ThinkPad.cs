namespace WebApiThinkPad.Models
{
    public class ThinkPad
    {
        public int Id { get; set; }
        public required string Model { get; set; }
        public required decimal Price { get; set; }
        public required int ReleaseYear {  get; set; }
    }
}
