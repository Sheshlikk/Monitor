using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР1
{
    internal class Program
    {
        public class Receipt
        {
           public int Number { get; set; }
            public string Date { get; set; }
            public float Summa { get; set; }

            public Receipt(int number, string date, float summa) { 
                Number = number;
                Date = date;
                Summa = summa;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
