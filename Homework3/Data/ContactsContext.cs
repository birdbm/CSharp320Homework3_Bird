using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Homework3.Models;

namespace Homework3.Data
{
    public class ContactsContext : DbContext
    {
        public ContactsContext (DbContextOptions<ContactsContext> options)
            : base(options)
        {

        }

        public DbSet<Homework3.Models.Contact>? Contact { get; set; }
    }
}
