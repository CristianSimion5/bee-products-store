using Polifloris.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Polifloris.CustomAttributes
{
    public class PhoneNumberAttribute : ValidationAttribute
    {
        public string GetErrorMessage() =>
            $"Numărul de telefon poate începe cu '+', " +
            $"însă în rest este format numai din cifre.";

        protected override ValidationResult IsValid(object value, 
            ValidationContext validationContext)
        {

            var order = (Order) validationContext.ObjectInstance;
            var nrTel = order.PhoneNumber;

            if (nrTel == null)
            {
                return new ValidationResult(GetErrorMessage());
            }

            var m = Regex.Match(nrTel, @"^[+]{0,1}\d{10,12}");

            if (m.Success)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(GetErrorMessage());
        }
    }
}
