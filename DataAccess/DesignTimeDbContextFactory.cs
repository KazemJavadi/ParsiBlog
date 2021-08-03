using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        AppDbContext IDesignTimeDbContextFactory<AppDbContext>.CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder optionBuilder = new DbContextOptionsBuilder();
            optionBuilder.UseSqlServer($@"server=.\mssqlserver20191;database=kazemjavadi.ir;user id=sa;password=2019");
            return new AppDbContext(optionBuilder.Options);
        }
    }
}
