using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cambiador
{
    class Program
    {
        static int cant = 0;
        static void Aferiar()
        {
            Console.WriteLine("Ingresa la cantidad a feriar: ");
            cant = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Aferiar();

            int[] feria = new int[] { 5, 2, 1 }; //cantidades a manejar

            int Resultado = 0; //variabre de resultado
            Console.WriteLine("Feria en:");
            for (int i = 0; i < feria.Length; i++) //hasta cuando detener el for
            {
                Resultado = cant / feria[i]; //dividir la cantidad a feriar, para obtener billetes y monedas
                Console.WriteLine(Resultado + " x " + feria[i]);
                cant -= Resultado * feria[i]; //verificar para descontar a la siguiente vuelta
            }
            Console.ReadKey();
        }
    }
}