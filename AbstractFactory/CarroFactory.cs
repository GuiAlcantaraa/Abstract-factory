using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CarroFactory : IVeiculoFactory
    {
        public Carro CriarCarro()
        {
            return new Carro();
        }

        public Motocicleta CriarMotocicleta()
        {
            throw new NotSupportedException("Não é possível criar motocicleta em uma fábrica de carros.");
        }

        public Caminhao CriarCaminhao()
        {
            throw new NotSupportedException("Não é possível criar caminhão em uma fábrica de carros.");
        }
    }
}
