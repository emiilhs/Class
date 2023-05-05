using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    public class Class1
    {
        public string ad;
        public string soyad;
        public int yas;
        
        public void fullname()
        {
            Console.WriteLine($"{ad} {soyad} registered");

        }
        public int age()
        {
            return yas;
        }
    }
}
