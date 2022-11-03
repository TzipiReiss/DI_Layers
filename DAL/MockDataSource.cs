using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MockDataSource : IDataSource
    {
        List<Contacts> contacts;
        List<Email> emails;
        void init()
        {
            emails = new List<Email>();
            emails.Add(new Email()
            {
                ID = 1,
                Subject = "123",
                Sender = new Contacts() { ID = 12, name = "Avi", email = "123@gmail.com" },
                Recive = new Contacts() { ID = 456, name = "Beni", email = "222@gmail.com" }
            });
            emails.Add(new Email()
            {
                ID = 2,
                Subject = "456",
                Sender = new Contacts() { ID = 456, name = "Beni", email = "222@gmail.com" },
                Recive = new Contacts() { ID = 12, name = "Avi", email = "123@gmail.com" }
            });
            emails.Add(new Email()
            {
                ID = 3,
                Subject = "789",
                Sender = new Contacts() { ID = 89, name = "Gadi", email = "555@gmail.com" },
                Recive = new Contacts() { ID = 12, name = "Avi", email = "123@gmail.com" }
            });
        }
        public List<Email> GetAll()
        {
            if (emails == null) init();
            return emails;
        }
        public Email GetEmailById(int id)
        {
            foreach (var item in emails)
            {
                if (item.ID == id)
                    return item;
            }
            return null;
        }
        public void InsertEmail(Email email)
        {
            emails.Add(email);
        }
        public void UpdateEmail(int IdEmail)
        {

        }
        public void DeleteEmail(int IdEmail)
        {
            Email currEmail = null;
            foreach (var item in emails)
            {
                if (item.ID == IdEmail)
                    currEmail = item;
            }
            emails.Remove(currEmail);
        }

    }
}
