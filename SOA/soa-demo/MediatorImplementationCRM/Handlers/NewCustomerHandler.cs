using System.Threading;
using System.Threading.Tasks;
using MediatorImplementationCRM.Handlers.Commands;
using MediatorImplementationCRM.Models;
using MediatorImplementationCRM.Repositories;
using MediatR;

namespace MediatorImplementationCRM.Handlers
{
    public class NewCustomerHandler : IRequestHandler<NewCustomerCommand, Customer>
    {
        private IRepository<Customer> _repository;
        public NewCustomerHandler(IRepository<Customer> repository)
        {
            _repository = repository;
        }
        public Task<Customer> Handle(NewCustomerCommand request, CancellationToken cancellationToken)
        {
            return Task.Run(() => _repository.Create(request.Customer));
        }
    }
}