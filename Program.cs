using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            DateTime today = DateTime.Today;
            Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));
            Console.WriteLine(dateTime.ToString("d"));
            Console.WriteLine(today.ToString("dd-MM-yyyy"));
            Console.ReadLine();

        }
    }
}
