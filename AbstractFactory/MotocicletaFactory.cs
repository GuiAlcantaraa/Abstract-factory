using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MotocicletaFactory : IVeiculoFactory
    {
        public Motocicleta CriarMotocicleta()
        {
            return new Motocicleta();
        }

        public Carro CriarCarro()
        {
            throw new NotSupportedException("Não é possível criar carro em uma fábrica de motocicletas.");
        }

        public Caminhao CriarCaminhao()
        {
            throw new NotSupportedException("Não é possível criar caminhão em uma fábrica de motocicletas.");
        }
    }
}
