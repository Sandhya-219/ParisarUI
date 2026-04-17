using ParisarUI.DTO;

namespace ParisarUI.DTO
{
    public class MonthlyTrendResponse
    {
        public bool Success { get; set; }

        public string Message { get; set; } = string.Empty;

        public List<MonthlyTrend> Data { get; set; } = new();
    }
}
