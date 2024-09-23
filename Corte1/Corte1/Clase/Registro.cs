using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1.models
{
    internal class Registro
    {
        private Persona[] personas = new Persona[30];
        private int Contador= 0;

        public void AgregarPersona(Persona persona)
        {
            if (Contador < 30)
            {
                personas[Contador] = persona;
                Contador++;
            }
            else
            {
                Console.WriteLine("El arreglo está lleno. No se puede agregar más personas.");
            }
        }

        public void MostrarPersonas()
        {
            for (int i = 0; i < Contador; i++)
            {
                MessageBox.Show($"Persona {i + 1}: {personas[i].Nombre} {personas[i].Apellido}");
            }
        }
    }
}
