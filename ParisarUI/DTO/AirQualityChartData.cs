namespace ParisarUI.DTO
{
    public class AirQualityChartResponse
    {
        public List<AirQualityItem> BestPM10 { get; set; } = new();
        public List<AirQualityItem> WorstPM10 { get; set; } = new();
        public List<AirQualityItem> BestPM25 { get; set; } = new();
        public List<AirQualityItem> WorstPM25 { get; set; } = new();
    }
}
