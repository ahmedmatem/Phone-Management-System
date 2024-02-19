using Phone_Management_System.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Management_System.Models
{
    public class Smartphone : Phone, IBrowsable
    {
        private const string InvalidUrlErrorMessage = "Invalid URL!";

        public string Browse(string url)
        {
            if(IsValidUrl(url))
            {
                return $"Browsing ... {url}";
            }
            else
            {
                return InvalidUrlErrorMessage;
            }
        }

        private bool IsValidUrl(string url)
        {
            foreach (char ch in url)
            {
                if(char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
