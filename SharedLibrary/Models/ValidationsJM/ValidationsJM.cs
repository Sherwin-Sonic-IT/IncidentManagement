using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models.ValidationsJM
{
    public class IsZeroValidationAttribute : ValidationAttribute
    {
        public IsZeroValidationAttribute(string mess = "Please select an item in the list.")
        {
            ErrorMessage = mess;
        }

        public override bool IsValid(object value)
        {
            if (value is int port)
            {
                if (port <= 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
