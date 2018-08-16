using System.ComponentModel.DataAnnotations;

namespace BankApp.Models
{
    public class AccountType1
    {

        [Key]
        public int AccountTypeId { get; set; }


        [Required]
        public string AccountName { get; set; }
    }
}