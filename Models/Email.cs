using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Email
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public Contacts Sender { get; set; }
        public Contacts Recive { get; set; }
        public override string ToString()
        {
            return $"{nameof(ID)}: {ID},\n" +
                   $"{nameof(Subject)}: {Subject},\n" +
                   $"{nameof(Sender)}: {Sender},\n" +
                   $"{nameof(Recive)}: {Recive}";
        }
    }
}
