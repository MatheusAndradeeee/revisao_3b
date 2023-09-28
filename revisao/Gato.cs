using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao
{
    internal class Gato: Animal
    {
      
        public string Raca { get; set; }

        public Gato(double peso, double altura, string raca) 
            :base(peso, altura)
        {
            Raca = raca;
            
        }

        public override void Barulho()
        {
            Console.WriteLine("miauu!");
        }

    }
}
