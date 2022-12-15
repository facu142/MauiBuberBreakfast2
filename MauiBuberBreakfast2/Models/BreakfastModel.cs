using SQLite;

namespace MauiBuberBreakfast2.Models
{
    public class BreakfastModel
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public Uri Image { get; set; }
        public List<string>Savory { get; set; }
        public List<string> Sweet { get; set; }
    }
   
}
