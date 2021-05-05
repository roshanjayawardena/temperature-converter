using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Temprature.Commands.TemperatureCreater;

namespace Temprature.Commands
{
    public class ConvertTemperatureValueCommand : IRequest<ITemperatureConverter>
    {
        public double Temprature { get; set; }
        public TemperatureTypeEnum TempratureType { get; set; }
        public class Handler : IRequestHandler<ConvertTemperatureValueCommand, ITemperatureConverter>
        {

            public async Task<ITemperatureConverter> Handle(ConvertTemperatureValueCommand request, CancellationToken cancellationToken)
            {
                ITemperatureConverter tempConverter = TemperatureConvertFactory.GetTemperatureDetails(request.TempratureType);
                tempConverter.ConvertTemperature(request.Temprature);
                return tempConverter;
            }
        }
    }
}
