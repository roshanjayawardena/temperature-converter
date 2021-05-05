namespace Temprature.Commands.TemperatureCreater
{
    public class FromFahrenheit : ITemperatureConverter
    {
        public double Celsius { get; set; }
        public double Kelvin { get; set; }

        public void ConvertTemperature(double tempValue)
        {
            Celsius = (tempValue - 32) / 1.8;
            Kelvin = (tempValue - 32) / 1.8 + 273.15;
        }
    }
}
