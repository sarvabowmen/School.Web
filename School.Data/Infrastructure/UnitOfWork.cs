using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private SchoolDbContext schoolContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public SchoolDbContext SchoolDbContext
        {
            get
            {
                return schoolContext ?? (schoolContext = dbFactory.Init());
            }
        }

        public void Commit() {

            SchoolDbContext.Commit();
        }
    }
}
