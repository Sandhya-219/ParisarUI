using System.Text.Json.Serialization;

namespace ParisarUI.DTO
{
    public class AirQualityItem
    {
        public string LocationName { get; set; } = string.Empty;

        [JsonPropertyName("pM10")]
        public decimal PM10 { get; set; }

        [JsonPropertyName("pM25")]
        public decimal PM25 { get; set; }
    }
}
