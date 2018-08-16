using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BankApp.Models
{
    public class Customer
    {
        [Required]
        [StringLength(256)]
        public string UserName { get; set; }
        [Key]
        public int CustomerId { get; set; }

        

        [Required]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "Account Number must be between 6 and 10 digits.")]
        [Column(TypeName = "varchar")]
        [Display(Name = "Account #")]
        public string AccountNumber { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        public string Country { get; set; }
        [Required]
        public string Phone { get; set; }

        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}