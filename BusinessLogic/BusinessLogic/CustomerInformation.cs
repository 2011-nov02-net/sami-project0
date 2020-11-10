using System;

namespace BusinessLogic
{
    public class CustomerName
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }

        public CustomerName(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public string getCustomerName()
        {
            return $"{_firstName} {_lastName}";
        }

    }
}
