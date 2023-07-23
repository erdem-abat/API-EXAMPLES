using Microsoft.AspNetCore.Mvc;

namespace Dispose.Models
{
    public class Customer : IDisposable
    {
        public Customer customer;
        public int Id { get; set; }
        public int TelNo { get; set; }
        public int count = 1;
        public void Add()
        {
            customer = new Customer
            {
                Id = 1,
                TelNo = 2235235
            };
        }
        public Customer Get(int id)
        {
            if (customer.Id == id)
            {
                return customer;
            }

            return null;
        }
        public void Dispose()
        {
            customer.Dispose();
        }
    }
}
