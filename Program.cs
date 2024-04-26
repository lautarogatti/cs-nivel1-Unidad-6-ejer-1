using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.*//

            int n, resto, conRes = 0, conPri = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                conRes = 0;
                for(int x = 1; x <= n; x++){

                    resto = n % x;
                    if(resto == 0){
                        conRes++;
                    }
                }
                if(conRes == 2){
                    conPri++;
                }
            }
            Console.WriteLine("La cantidad de primos ingresados es: " + conPri);
        }
    }
}
