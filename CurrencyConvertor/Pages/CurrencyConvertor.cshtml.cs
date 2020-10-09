using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace CurrencyConvertor.Pages
{
    public class CurrencyConvertorModel : PageModel
    {
        public Double amount;
        public Double money;
        public String selectionOne;
        public String selectionTwo;

        static Double eurToGbp(Double eur)
        {
          return eur * 0.91;
        }

        static Double gbpToEur(Double gbp)
        {
            return gbp * 1.10;
        }


        public void OnGet()
        {

        }
        public void OnPost()
        {
            this.amount = Convert.ToDouble(Request.Form["amount"]);
            this.selectionOne = Request.Form["Select1"];
            this.selectionTwo = Request.Form["Select2"];

            if (selectionOne == "EUR" && selectionTwo == "GBP")
            {
                this.money = eurToGbp(this.amount);
            }
        }
    }
}
