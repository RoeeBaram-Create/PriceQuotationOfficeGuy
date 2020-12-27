using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceQuotationOfficeGuy.Models
{
    public class PriceQuotationResponseDto
    {
        
        public string DownLoadPdfPriceQuotation { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsValidResponse { get; set; }

    }
}
