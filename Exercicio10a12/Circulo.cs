namespace Exercicio10a12
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Circulo
    {
        public double Raio;
        //O raio é a medida principal para definir uma esfera,
        //pois todas as suas propriedades geométricas derivam dele.
        //No Círculo o raio é usado para calcular a área.

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public double CalcularArea()
        {
            return Math.PI * (Raio * Raio);
        }
    }
}