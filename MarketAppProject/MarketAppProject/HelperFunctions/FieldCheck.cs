using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MarketAppProject.HelperFunctions
{
    public static class FieldCheck
    {
        public static bool checkDateTimeField(DateTime date)
        {
            if (date.Year<1900 || date.Year>3000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        public static bool checkDateTimeField(DateTime? date)
        {
            if (date.Value.Year<1900 || date.Value.Year>3000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool checkEmailField(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, emailPattern))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool checkPhoneField(string phoneNumber)
        {
            string phoneNumberPattern = @"^\d{10,15}$";
            if (string.IsNullOrWhiteSpace(phoneNumber) || !Regex.IsMatch(phoneNumber, phoneNumberPattern))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool checkGenderField(string gender) 
        {
            string genderPattern = @"^[FMN]$";
            if (string.IsNullOrWhiteSpace(gender) || !Regex.IsMatch(gender, genderPattern))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool checkAddressField(string address)
        {
            if(address.Length>0 || address.Length<255)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
