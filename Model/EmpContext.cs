using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace employeemanagement.aspnetcorewebapi.Model
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions options):base (options)
        {


        }
        DbSet<Employee> Employees { get; set; }

        internal void Delete(object item)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }

        internal Task FirstOrDefaultAsync(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
