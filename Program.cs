using Phone_Management_System.Contracts;
using Phone_Management_System.Models;

namespace Phone_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] urls = Console.ReadLine().Split(' ');

            // basePhone using for callings could be Stationary or Smartphone 
            ICallable basePhone = new StationaryPhone();
            // modernPhone must be able to browse sites - must be of type Smartphone
            IBrowsable modernPhone = new Smartphone();

            // Calling each numbers
            foreach (var phoneNumber in phoneNumbers)
            {
                Console.WriteLine(basePhone.Call(phoneNumber));
            }

            // Browsing each sites
            foreach (string url in urls)
            {
                Console.WriteLine(modernPhone?.Browse(url));
            }
        }
    }
}
