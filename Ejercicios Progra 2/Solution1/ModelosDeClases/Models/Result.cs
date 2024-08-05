using System;
using System.Text.Json.Serialization;

namespace ModelosDeClases.Models
{
    public class Result
    {
        public int ResultId { get; set; }
        public int RaceId { get; set; }

        [JsonIgnore]  // Ignora esta propiedad durante la deserialización
        public Race? Race { get; set; }

        public int DriverId { get; set; }

        [JsonIgnore]  // Ignora esta propiedad durante la deserialización
        public Driver? Driver { get; set; }

        public int Position { get; set; }
        public int Points { get; set; }
        public string FasttestLapTime { get; set; }

        [JsonConstructor]
        public Result(int resultId, int raceId, int driverId, int position, int points, string fasttestLapTime)
        {
            ResultId = resultId;
            RaceId = raceId;
            DriverId = driverId;
            Position = position;
            Points = points;
            FasttestLapTime = fasttestLapTime;
        }
        // Constructor sin parámetros necesario para la deserialización
        public Result() { }
    }
}
