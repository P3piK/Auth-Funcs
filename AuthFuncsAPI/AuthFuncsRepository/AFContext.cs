using AuthFuncsRepository.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthFuncsRepository
{
    public class AFContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
