using System;
using System.Threading.Tasks;
using Message;
using NServiceBus;
using NServiceBus.Logging;

namespace Facturation
{
    public class NewOrderHandler : IHandleMessages<NewOrder>
    {
        private ILog _logger = LogManager.GetLogger<NewOrderHandler>();
        public Task Handle(NewOrder message, IMessageHandlerContext context)
        {
            Random r = new Random();
            _logger.Info($"{message.Id}, total {message.Total} euros");
            message.GetNumberProducts(UsingStock);
            InvoiceReady invoice = new InvoiceReady()
            {
                Id = r.Next(1000),
                Message = Guid.NewGuid().ToString()
            };
            //message.RunEvent();
            return context.Send(invoice);
        }

        private void UsingStock(int stock)
        {
            _logger.Warn($"Stock is {stock}");
        }
    }
}