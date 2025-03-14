namespace Exercicio10a12
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Esfera
    {
        public double Raio;
        //O raio é a medida principal para definir uma esfera,
        //pois todas as suas propriedades geométricas derivam dele.
        //Na Esfera o raio define o volume da esfera.

        public Esfera(double raio)
        {
            Raio = raio;
        }

        public double CalcularVolume()
        {
            return (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio);
        }
    }
}