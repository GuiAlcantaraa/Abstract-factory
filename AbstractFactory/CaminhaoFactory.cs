using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CaminhaoFactory : IVeiculoFactory
    {
        public Caminhao CriarCaminhao()
        {
            return new Caminhao();
        }
        
        public Carro CriarCarro()
        {
            throw new NotSupportedException("Não é possível criar carro em uma fábrica de caminhão.");
        }

        public Motocicleta CriarMotocicleta()
        {
            throw new NotSupportedException("Não é possível criar motocicleta em uma fábrica de caminhão.");
        }
    }
}
