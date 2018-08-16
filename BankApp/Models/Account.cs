using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace BankApp.Models
{
    public class Account
    {
        
        [Key]
        public int AccountId { get; set; }
        [Required]
        [Display(Name = "Customer ID")]
   
        public int CustomerId{ get; set; }
        [Display(Name = "AccountType")]
        public string accounttype1 { get; set; }
        [Required]
        [Display(Name = "Account Number")]
        public int AccountNum { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        public decimal Balance { get; set; }
        public bool Status { get; set; }

        public virtual AccountType1 accounttype{ get; set; }

     
    }

}
