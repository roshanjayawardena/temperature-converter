using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Temprature.Queries
{
    public class GetTemperatureValuesQuery : IRequest<TemperatureModel>
    {
       
        public class Handler : IRequestHandler<GetTemperatureValuesQuery, TemperatureModel>
        {
           
            public Handler()
            {
               
            }

            public async Task<TemperatureModel> Handle(GetTemperatureValuesQuery request, CancellationToken cancellationToken)
            {

                         
            }
        }
    }
}
