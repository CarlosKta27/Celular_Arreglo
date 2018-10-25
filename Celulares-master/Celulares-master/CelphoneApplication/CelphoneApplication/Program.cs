using System;
using CelularProteccion;
using System.Collections;

namespace CelphoneApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Arreglo de objetos (declaracion)
            Celular [] IphoneX = new Celular[3];

            //reservar memoria de los objetos
            for (int i = 0; i < IphoneX.Length; i++)
            {
                IphoneX[i] = new Celular();
            }  
            
            
            
            char menu;
            int num;
            
            Console.WriteLine("Que celular deseas utilizar");
            num = int.Parse(Console.ReadLine());
            
            
            Console.WriteLine("Selecciona una opcion");
            
            
            do
            {
                Console.WriteLine("1 >> Llamar.");
                Console.WriteLine("2 >> Mensajear.");
                Console.WriteLine("3 >> Ingresar Saldo.");
                Console.WriteLine("4 >> Checar Saldo.");
                Console.WriteLine("0 >> Apagar.");
                menu = char.Parse(Console.ReadLine());
                switch (menu)
                {
                     case '1':
                         IphoneX[num-1].LLamar();
                         break;
                     case '2':
                         IphoneX[num-1].Mensajear();
                         break;
                     case '3':
                         IphoneX[num-1].Ingresar_saldo();
                         break;
                     case '4':
                         IphoneX[num-1].Checar_saldo();
                         break;
                     case '0':
                         IphoneX[num-1].Apagar();
                         break;
                     default:
                         Console.WriteLine("Ingresa una opcion viable");
                         break;
                }
            } while (menu != '0');
        }
    }
}