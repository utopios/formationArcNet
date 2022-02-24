using MediatorImplementationCRM.Models;
using MediatR;

namespace MediatorImplementationCRM.Handlers.Commands
{
    public class NewCustomerCommand : IRequest<Customer>
    {
        public Customer Customer { get; set; }
    }
}