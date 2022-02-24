namespace MediatorImplementationCRM.Models
{
    public class Customer
    {
        private int id;
        private string firstName;
        private string lastName;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }
    }
}