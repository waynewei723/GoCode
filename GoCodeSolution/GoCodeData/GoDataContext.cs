using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoCodeData.Model;

namespace GoCodeData
{
    public class GoDataContext : DbContext
    {
        public DbSet<GoUser> GoUsers { get; set; }
    }
}
