using System.Collections.Concurrent;
using System.Diagnostics;

namespace HelloYou
{

    public class Program
    {

        static void Main(string[] args)
        {
            var customer = new Customer();
            var store = new Store();

            customer.Id = 1;
            customer.Name = "Job";

            store.StoreName = "Walmart";
            store.StoreId = 73034;

            Console.WriteLine("The customer {0} wuth ID {1} purchased the item from store name {2} with store ID {3}", customer.Name, customer.Id, store.StoreName, store.StoreId);

        }
    }
}