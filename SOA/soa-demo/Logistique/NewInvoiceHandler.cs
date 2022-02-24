using System.Threading.Tasks;
using Message;
using NServiceBus;
using NServiceBus.Logging;

namespace Logistique
{
    public class NewInvoiceHandler : IHandleMessages<InvoiceReady>
    {
        private ILog _logger = LogManager.GetLogger<NewInvoiceHandler>();

        public Task Handle(InvoiceReady message, IMessageHandlerContext context)
        {
            _logger.Info($"Id invoice {message.Id}, content : {message.Message}");
            return Task.CompletedTask;
        }
    }
}