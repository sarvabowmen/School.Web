using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory 
    {
        SchoolDbContext schoolContext;

        public SchoolDbContext Init()
        {
            return schoolContext ?? (schoolContext = new SchoolDbContext());
        }
        protected override void DisposeCore()
        {
            if (schoolContext != null)
                schoolContext.Dispose();
        }
    }
}
