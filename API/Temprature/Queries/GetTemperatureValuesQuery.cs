using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Temprature.Queries
{
     public class GetTemperatureValuesQuery : IRequest<TemperatureModel>
    {
        public string TempValue { get; set; }
        public TemperatureTypeEnum Type { get; set; }
        public class Handler : IRequestHandler<GetTemperatureValuesQuery, TemperatureModel>
        {
           
            public Handler()
            {
               
            }

            public async Task<TemperatureModel> Handle(GetTemperatureValuesQuery request, CancellationToken cancellationToken)
            {

                var tempModel = new TemperatureModel();
                var tempValue = Convert.ToDouble(request.TempValue);
               
                    switch (request.Type.ToString())
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
