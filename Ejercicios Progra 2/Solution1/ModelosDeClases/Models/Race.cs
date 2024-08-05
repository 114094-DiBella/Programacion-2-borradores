
namespace ModelosDeClases.Models
{
    public class Race
    {
        public int RaceId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Circuits Circuits { get; set; }
        public int CircuitsId { get; set; }


        public Race(int id, string? name, DateTime date, int circuitId, Circuits circuits)
        {
            this.RaceId = id;
            Name = name;
            this.Date = date;
            this.CircuitsId = circuitId;
            Circuits = circuits;
        }

        public Race()
        {
        }
    }
}