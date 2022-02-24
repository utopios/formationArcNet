using NServiceBus;

namespace Message
{
    public class InvoiceReady : ICommand
    {
        private int id;
        private string message;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Message
        {
            get => message;
            set => message = value;
        }
    }
}