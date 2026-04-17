namespace ParisarUI.DTO
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string message { get; set; }
        public List<T>? Data { get; set; }
       
    }



    public class BarChartApiResponse<T>
    {
        public bool Success { get; set; }
        public string message { get; set; }
        public T? Data { get; set; }

    }
}
