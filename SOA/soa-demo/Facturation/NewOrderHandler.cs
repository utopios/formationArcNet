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
            _logger.Info($"{message.Id}, total {message.Total} euros");
            message.GetNumberProducts(UsingStock);
            message.ToExecute();
            return Task.CompletedTask;
        }

        private void UsingStock(int stock)
        {
            _logger.Warn($"Stock is {stock}");
        }
    }
}