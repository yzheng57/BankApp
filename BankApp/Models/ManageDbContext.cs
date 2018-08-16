using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BankApp.Models
{
    public class ManageDbContext : DbContext
    {
        public ManageDbContext()
            : base("name=DefaultConnection")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<TransType> TransTypes { get; set; }
        public DbSet<TermDeposit> TermDeposits { get; set; }
        public DbSet<AccountType1> AccountTypes { get; set; }

        //public System.Data.Entity.DbSet<BankApp.Models.Transaction> Transactions { get; set; }
    }
}