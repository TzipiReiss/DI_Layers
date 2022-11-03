using Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class Utilities
    {
        public static EmailService ConfigEmailDependencies(string v)
        {
            switch (v)
            {
                case "Mock": return new EmailService(new Repositories.MockDataSource());
                case "SQL":
                default:
                    return new EmailService(new Repositories.SQLDataSorce());
            }
        }
    }
}
