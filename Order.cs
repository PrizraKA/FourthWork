using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthWork
{
    internal class Order
    {
        public string PayerIBAN = "UA53 2012 1111 2356 7891 21";
        public string PayerName = "Gromov Oleksandr Sergeevich";

        public string RecipientIBAN = "UA23 6521 8901 7386 9010 53";
        public string RecipientName = "Bing Oleg Olegovich";

        public void InfoOfPeople()
        {
            Console.WriteLine($"\t\t\t\t\tPayer:\nIBAN: {PayerIBAN}\nName: {PayerName}\n\t\t\t\t\tRecipient:\nIBAN: {RecipientIBAN}\nName: {RecipientName}");    
        }

       
    }
    
}
