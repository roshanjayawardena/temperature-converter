namespace Temprature.Commands.TemperatureCreater
{
    public class FromCelsius : ITemperatureConverter
    {
        public double Fahrenheit { get; set; }
        public double Kelvin { get; set; }
        public void ConvertTemperature(double tempValue)
        {
            Fahrenheit = tempValue * 1.8 + 32;
            Kelvin = tempValue + 273.15;
        }
    }
}
