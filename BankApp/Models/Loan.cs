using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankApp.Models
{
    public class Loan
    {
        
        public int LoanId { get; set; }
        public int CustomerId { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double Amount { get; set; }

        [Required]
        public int Year { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreatedOn { get; set; }

    }
}