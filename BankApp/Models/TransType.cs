using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankApp.Models
{
    public class TransType
    {
        [Key]
        public int TranstypeId { get; set; }
        public string TransName { get; set; }
        [Required]
        public int TransactionId { get; set; }

        [Required]
        public int CustomerId { get; set; }
    }
}