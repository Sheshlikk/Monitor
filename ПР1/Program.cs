using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР1
{
    internal class Program
    {
        public class Monitor
        {
           public string Firm { get; set; }
            public string Type { get; set; }
            public float Diagonal { get; set; }

            public Monitor(string firm, string type, float diagonal)
            {
                Firm = firm;
                Type = type;
                Diagonal = diagonal;

            }

        }
        static void Main(string[] args)
        {

            Monitor monitor = new Monitor("Samsung", "IPS", 27);
            Console.WriteLine($"{monitor.Firm} {monitor.Type} {monitor.Diagonal}");//комментарий


        }
    }
}
