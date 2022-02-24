using System.Collections.Generic;
using MediatorImplementationCRM.Models;
using MediatR;

namespace MediatorImplementationCRM.Handlers.Queries
{
    public class GetCustomersQuery : IRequest<List<Customer>>
    {
        public string Name { get; set; }
    }
}