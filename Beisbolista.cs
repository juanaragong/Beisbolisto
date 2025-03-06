using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp41
{
    internal class Beisbolista
    {
        //Atributos
        public string nombre;
        public int numeroJugador;
        public string posicion;
        public int numHits;
        public int numVecesBat;


        //Funciones 
        public double promedioBateo()
        {
            return (double)numHits / numVecesBat;
        }

        public string GanaBono()
        {
            string mensaje = "";
            if (promedioBateo() >= .500)
            {
                mensaje = "Gana bono";
            }
            else
            {
                mensaje = "No gana bono";
            }
            return mensaje;

        }

    }
}
