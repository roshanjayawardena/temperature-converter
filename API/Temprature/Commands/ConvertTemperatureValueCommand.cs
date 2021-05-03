using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;


namespace Temprature.Commands
{
    public class ConvertTemperatureValueCommand : IRequest<TemperatureModel>
    {
        public double Temprature { get; set; }
        public TemperatureTypeEnum TempratureType { get; set; }
        public class Handler : IRequestHandler<ConvertTemperatureValueCommand, TemperatureModel>
        {         

            public async Task<TemperatureModel> Handle(ConvertTemperatureValueCommand request, CancellationToken cancellationToken)
            {

                var tempModel = new TemperatureModel();
                var tempValue = request.Temprature;

                switch (request.TempratureType.ToString())
                {
                    case "Celsius":
                        {
                            tempModel.Fahrenheit = tempValue * 1.8 + 32;
                            tempModel.Kelvin = tempValue + 273.15;
                            break;
                        }
                    case "Fahrenheit":
                        {
                            tempModel.Celsius = (tempValue - 32) / 1.8;
                            tempModel.Kelvin = (tempValue - 32) / 1.8 + 273.15;
                            break;
                        }
                    case "Kelvin":
                        {
                            tempModel.Celsius = tempValue - 273.15;
                            tempModel.Fahrenheit = (tempValue - 273.15) * 1.8 + 32;
                            break;
                        }
                }

                return tempModel;
            }
        }
    }
}
