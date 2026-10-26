using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Passport
    {
        public long id {  get; set; }
        public string Name { get; set {
                if (Name != null) Name = value;
                else { throw new ArgumentException("Invalid value");  }
            } 
        }
        public DateTime Date { get; set; } 
    }

}
