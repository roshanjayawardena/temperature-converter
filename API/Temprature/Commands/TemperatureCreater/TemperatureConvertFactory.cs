namespace Temprature.Commands.TemperatureCreater
{
    public class TemperatureConvertFactory
    {
        public static ITemperatureConverter GetTemperatureDetails(TemperatureTypeEnum tempType)
        {
            ITemperatureConverter tempDetails = null;
            if (tempType == TemperatureTypeEnum.Celsius)
            {
                tempDetails = new FromCelsius();
            }
            else if (tempType == TemperatureTypeEnum.Fahrenheit)
            {
                tempDetails = new FromFahrenheit();
            }
            else if (tempType == TemperatureTypeEnum.Kelvin)
            {
                tempDetails = new FromKelvin();
            }
            return tempDetails;
        }
    }
}
