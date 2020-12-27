using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PriceQuotationOfficeGuy.Models
{
    public class PriceQuotationCreationDto
    {
        [Display(Name = "Customer Name")]
        [Required (ErrorMessage = "Customer Name is mandatory")]
        public string CustomerName { get; set; }

        [Display(Name = "Amount")]
        [Required(ErrorMessage = "Amount is mandatory")]
        public decimal? Amount { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Product Name is mandatory")]
        public string ProductName { get; set; }

    }
}
