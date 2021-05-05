namespace Temprature.Commands.TemperatureCreater
{
    public class FromKelvin: ITemperatureConverter
    {
        public double Celsius { get; set; }
        public double Fahrenheit { get; set; }
        public void ConvertTemperature(double tempValue)
        {
            Celsius = tempValue - 273.15;
            Fahrenheit = (tempValue - 273.15) * 1.8 + 32;
        }
    }
}
