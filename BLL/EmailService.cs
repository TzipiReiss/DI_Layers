using Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmailService
    {
        IDataSource ds;
        public EmailService(IDataSource ds)
        {
            this.ds = ds;
        }
        public List<Email> GetAll()
        {
            var list = ds.GetAll();
            return list;
        }
    }
}
