

using System;
using NServiceBus;

namespace Message
{
    public class NewOrder : ICommand
    {
        private int id;
        private decimal total;
        //public event Action ToExecute;
        
        public decimal Total
        {
            get => total;
            set => total = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }


        public void GetNumberProducts(Action<int> ActionNumberProducts)
        {
            Random r = new Random();
            ActionNumberProducts(r.Next(1000));
        }

        public void RunEvent()
        {
            //ToExecute?.Invoke();
        }
    }
}