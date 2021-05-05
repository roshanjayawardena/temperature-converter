using NUnit.Framework;
using System;
using System.Threading.Tasks;
using Temprature.Commands;
using Temprature.Commands.TemperatureCreater;

namespace InsightureTest
{
    using static Testing;
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task ShouldReturnTempValues_WhenInsertIntegerValue()
        {

            try
            {
                var command = new ConvertTemperatureValueCommand()
                {

                    Temprature = 30,
                    TempratureType = TemperatureTypeEnum.Celsius
                };

                var temperatureModel = await SendAsync(command);
                Assert.AreEqual(86, ((FromCelsius)temperatureModel).Fahrenheit);
                Assert.AreEqual(303.15, ((FromCelsius)temperatureModel).Kelvin);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // for celcius 
        [Test]
        public async Task ShouldReturnTempValues_WhenInsertDecimalValue()
        {

            try
            {
                var command = new ConvertTemperatureValueCommand()
                {
                    Temprature = 30.52,
                    TempratureType = TemperatureTypeEnum.Celsius
                };
                var temperatureModel = await SendAsync(command);
                Assert.AreEqual(86.936, ((FromCelsius)temperatureModel).Fahrenheit);
                Assert.AreEqual(303.66999999999996d, ((FromCelsius)temperatureModel).Kelvin);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [Test]
        public async Task ShouldReturnTempValues_WhenInsertNegativeValue()
        {

            try
            {
                var command = new ConvertTemperatureValueCommand()
                {
                    Temprature = -30,
                    TempratureType = TemperatureTypeEnum.Celsius
                };
                var temperatureModel = await SendAsync(command);
                Assert.AreEqual(-22, ((FromCelsius)temperatureModel).Fahrenheit);
                Assert.AreEqual(243.14999999999998d, ((FromCelsius)temperatureModel).Kelvin);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [Test]
        public async Task ShouldReturnTempValues_WhenInsertZeroValue()
        {

            try
            {
                var command = new ConvertTemperatureValueCommand()
                {
                    Temprature = 0,
                    TempratureType = TemperatureTypeEnum.Celsius
                };
                var temperatureModel = await SendAsync(command);
                Assert.AreEqual(32, ((FromCelsius)temperatureModel).Fahrenheit);
                Assert.AreEqual(273.15, ((FromCelsius)temperatureModel).Kelvin);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}