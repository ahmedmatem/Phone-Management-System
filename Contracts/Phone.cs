using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Management_System.Contracts
{
    public abstract class Phone : ICallable
    {
        private const string InvalidPhoneNumberErrorMessage = "Invalid number!";
        private const int SmartphoneNumberLength = 10;
        private const int StationaryPhoneNumberLength = 7;

        public virtual string Call(string phoneNumber)
        {
            if(IsValidPhoneNumber(phoneNumber))
            {
                return GiveACall(phoneNumber);
            }
            else
            {
                return InvalidPhoneNumberErrorMessage;
            }
        }

        protected bool IsValidPhoneNumber(string phoneNumber)
        {
            foreach (char ch in phoneNumber)
            {
                if (!char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        private string GiveACall(string phoneNumber)
        {
            if(phoneNumber.Length == SmartphoneNumberLength)
            {
                return $"Calling... {phoneNumber}";
            }
            else
            {
                // In case of Stationary phone number
                return $"Dialing... {phoneNumber}";
            }
        }
    }
}
