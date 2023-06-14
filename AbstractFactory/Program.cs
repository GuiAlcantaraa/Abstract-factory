using System;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVeiculoFactory fabricaCarro = new CarroFactory();
            Veiculo carro = fabricaCarro.CriarCarro();
            carro.Dirigir();

            IVeiculoFactory fabricaMotocicleta = new MotocicletaFactory();
            Veiculo motocicleta = fabricaMotocicleta.CriarMotocicleta();
            motocicleta.Dirigir();

            IVeiculoFactory fabricaCaminhao = new CaminhaoFactory();
            Veiculo caminhao = fabricaCaminhao.CriarCaminhao();
            caminhao.Dirigir();
        }
    }
}
