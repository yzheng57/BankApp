using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankApp.Models
{
    public class TermDeposit
    {
        [Key]
        public int DepositId { get; set; }
        public int CustomerId { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double Amount { get; set; }
        [Required]
        public int Months { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public double Interest { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Total Amount")]
        public double total_amt { get; set; }

    }
}