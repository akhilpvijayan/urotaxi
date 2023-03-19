namespace UroTaxi.XObjects.ViewModels
{
    public class CarModelsViewModel
    {
        public int carModelId { get; set; }
        public string carModel { get; set; }
        public string carType { get; set; }
        public string carImage { get; set; }
        public string fuelType { get; set; }
        public long minFare { get; set;}
        public int seats { get; set;}
    }
}
