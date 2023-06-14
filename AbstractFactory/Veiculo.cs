using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Veiculo
    {
        public abstract void Dirigir();
    }

    public class Carro : Veiculo
    {
        public override void Dirigir()
        {
            Console.WriteLine("Dirigindo um carro.");
        }
    }

    public class Motocicleta : Veiculo
    {
        public override void Dirigir()
        {
            Console.WriteLine("Pilotando uma motocicleta.");
        }
    }

    public class Caminhao : Veiculo
    {
        public override void Dirigir()
        {
            Console.WriteLine("Dirigindo um caminhão.");
        }
    }

}
