using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatorImplementationCRM.Handlers.Queries;
using MediatorImplementationCRM.Models;
using MediatorImplementationCRM.Repositories;
using MediatR;

namespace MediatorImplementationCRM.Handlers
{
    public class GetCutomersHandler : IRequestHandler<GetCustomersQuery, List<Customer>>
    {
        private IRepository<Customer> _repository;

        public GetCutomersHandler(IRepository<Customer> repository)
        {
            _repository = repository;
        }
        public Task<List<Customer>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() => _repository.FindAllBy(c => c.FirstName.Contains(request.Name)));
        }
    }
}