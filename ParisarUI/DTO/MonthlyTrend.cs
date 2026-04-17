using ParisarUI.DTO;
using System.Text.Json.Serialization;

namespace ParisarUI.DTO
{
    public class MonthlyTrend
    {
        public int Year { get; set; }

        public int MonthNumber { get; set; }

        public string Month { get; set; } = string.Empty;

        [JsonPropertyName("pM10")]
        public decimal PM10 { get; set; }

        [JsonPropertyName("pM25")]
        public decimal PM25 { get; set; }
    }
}
