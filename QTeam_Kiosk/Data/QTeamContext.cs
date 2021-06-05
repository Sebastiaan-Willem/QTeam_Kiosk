using Microsoft.EntityFrameworkCore;
using QTeam_Kiosk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QTeam_Kiosk.Data
{
    public class QTeamContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public QTeamContext(DbContextOptions options):base(options)
        {

        }
    }
}
