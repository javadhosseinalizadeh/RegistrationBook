using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BussinessEntity;

namespace DataAccessLayer
{
    public class Database : DbContext
    {
        public Database() : base("rt"){ }

        public DbSet<CRUD_Cstmr> CRUD_Cstmrs { get; set; }
    }
}
