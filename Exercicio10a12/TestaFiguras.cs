namespace Exercicio10a12
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TestaFiguras
    {
        public static void Executar()
        {
            Circulo circulo = new Circulo(3.0);
            double areaCirculo = circulo.CalcularArea();
            Console.WriteLine($"\nÁrea do Círculo (raio 3.0): {areaCirculo:F2}");

            Esfera esfera = new Esfera(5.0);
            double volumeEsfera = esfera.CalcularVolume();
            Console.WriteLine($"Volume da Esfera (raio 5.0): {volumeEsfera:F2}");
        }
    }
}