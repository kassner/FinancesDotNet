using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinancesDotNet.Models;

namespace FinancesDotNet.Models
{
    public class FinancesDotNetContext : DbContext
    {
        public FinancesDotNetContext (DbContextOptions<FinancesDotNetContext> options)
            : base(options)
        {
        }

        public DbSet<FinancesDotNet.Models.Account> Account { get; set; }

        public DbSet<FinancesDotNet.Models.Payee> Payee { get; set; }
    }
}
