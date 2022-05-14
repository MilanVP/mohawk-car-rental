using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignment1.Models
{
    public class PurchaseDateValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var purchaseDate = Convert.ToDateTime(value);
            return purchaseDate <= DateTime.Now;
        }
    }
}
